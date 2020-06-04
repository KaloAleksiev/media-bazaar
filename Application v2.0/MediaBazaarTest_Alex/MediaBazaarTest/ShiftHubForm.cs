using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarTest
{
    public partial class ShiftHubForm : Form
    {
        DepartmentDictionary dd;
        Dictionary<string, int> deps;
        Month month;
        UserControl uc;
        ShiftDataControl sdc;

        public ShiftHubForm(UserControl uc)
        {
            InitializeComponent();
            this.uc = uc;
            dd = new DepartmentDictionary();
            sdc = new ShiftDataControl();
            deps = dd.GetAllDepartmentsFromDB();
            FillOutDepCB();
            AppendEvents();
        }

        public void FillOutDepCB()
        {
            foreach (KeyValuePair<string, int> dep in deps)
            { cbDepartment.Items.Add(dep.Key); }
        }

        public void UpdateInfoLabel(object sender, EventArgs e)
        {
            if (tbYear.Text == "" || cbDepartment.SelectedIndex == -1 || cbMonth.SelectedIndex == -1 || cbPosition.SelectedIndex == -1)
            { 
                lblFinalInfo.Text = "";
                btnViewSchedule.Enabled = false;
            }
            else {
                string type;
                if (rbMorning.Checked)
                { type = "Morning"; }
                else if (rbNoon.Checked)
                { type = "Noon"; }
                else { type = "Evening"; }
                lblFinalInfo.Text = $"View schedule for {(Month)(cbMonth.SelectedIndex + 1)} {tbYear.Text} " +
                                    $" for {(Position)(cbPosition.SelectedIndex + 1)}s " +
                                    $"\n of {cbDepartment.SelectedItem} department," +
                                    $" {type} shifts.";
                btnViewSchedule.Enabled = true;
            }
        }

        public void AppendEvents()
        {
            cbMonth.SelectedIndexChanged += new EventHandler(UpdateInfoLabel);
            cbDepartment.SelectedIndexChanged += new EventHandler(UpdateInfoLabel);
            cbPosition.SelectedIndexChanged += new EventHandler(UpdateInfoLabel);
            tbYear.TextChanged += new EventHandler(UpdateInfoLabel);
            rbMorning.CheckedChanged += new EventHandler(UpdateInfoLabel);
            rbNoon.CheckedChanged += new EventHandler(UpdateInfoLabel);
            rbEvening.CheckedChanged += new EventHandler(UpdateInfoLabel);
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            ShiftType type;
            if (rbEvening.Checked)
            { type = ShiftType.Evening; }
            else if (rbNoon.Checked)
            { type = ShiftType.Noon; }
            else { type = ShiftType.Morning; }
            DateTime dt = new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, 1);
            KeyValuePair<string, int> dep = new KeyValuePair<string, int>((string)cbDepartment.SelectedItem, cbDepartment.SelectedIndex + 1);
            ShiftForm frm = new ShiftForm(dt, dep, (Position)(cbPosition.SelectedIndex + 1), type, uc);
            frm.Show();
        }


        #region Shift Automatic Creation Algorithm 

        private void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            Position pos = (Position)(cbPosition.SelectedIndex + 1);
            KeyValuePair<string, int> dep = new KeyValuePair<string, int>((string)cbDepartment.SelectedItem, cbDepartment.SelectedIndex + 1);

            //Clear all shifts in month.
            for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1); i++)
            {
                DateTime dt = new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, i);
                
                //Get all shifts from the database
                List<int> indexes = sdc.GetAllShiftsOnDateByDep(dep.Value, pos, dt);
                DeleteShift(indexes);
            }

            //Calculate the amount of shifts an emplyee has to do in a month.
            int shiftsPerPerson = CalculateAmountOfShiftsPerPerson(new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, 1), pos, dep.Key);

            //Create dictionary with the user ID as the key and amount of shift "tokens" left as the value.
            Dictionary<int, int> shiftTokenDictionary = CreateShiftTokenDictionary(pos, dep.Key, shiftsPerPerson);

            //Create empty shifts for each day of the month.
            Dictionary<int, Shift> allShifts = CreateAllShifts(pos, dep.Value);

            //Main repetition segment, where the assigment takes place.

        }

        #region Preparation code for algorithm
        public void DeleteShift(List<int> indexes)
        {
            if (indexes != null)
            {
                foreach (int j in indexes)
                {
                    //Delete all people from the shift and then delete the shift itself.
                    sdc.DeleteAllPeopleFromShift(j);
                    sdc.DeleteShift(j);
                }
            }
        }

        public int CalculateAmountOfShiftsPerPerson(DateTime dt, Position pos, string dep)
        {
            int totalShiftCount = DateTime.DaysInMonth(dt.Year, dt.Month) * 3;
            List<User> users = new List<User>();
            foreach (User u in uc.GetUsers())
            {
                if (u.Position == pos && u.Department == dep)
                { users.Add(u); }
            }
            int shiftsPerPerson = totalShiftCount / users.Count;
            return shiftsPerPerson;
        }

        public Dictionary<int, int> CreateShiftTokenDictionary(Position pos, string dep, int shiftsPerPerson)
        {
            Dictionary<int, int> shiftTokenDictionary = new Dictionary<int, int>();
            foreach (User u in uc.GetUsers())
            {
                if (u.Position == pos && u.Department == dep)
                { shiftTokenDictionary.Add(u.Id, shiftsPerPerson); }
            }
            return shiftTokenDictionary;
        }

        public Dictionary<int, Shift> CreateAllShifts(Position pos, int dep)
        {
            Dictionary<int, Shift> allShifts = new Dictionary<int, Shift>();
            for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ShiftType type = ShiftType.Morning;
                    if (j == 1)
                    { type = ShiftType.Noon; }
                    else { type = ShiftType.Evening; }
                    allShifts.Add(i, new Shift(new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, i), type, pos, dep));
                }
            }
            return allShifts;
        }
        #endregion

        public void CreateSchedule(Dictionary<int, int> shiftTokenDictionary, Dictionary<int, Shift> allShifts)
        {
            bool pairityFlag = false;
            Dictionary<int, int> standInTokens = shiftTokenDictionary;
            
            foreach (KeyValuePair<int, int> userToken in standInTokens)
            {
                for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1); i++)
                {
                    if (i % 2 == Convert.ToInt32(pairityFlag))
                    {
                        allShifts[i].AddUser(uc.GetUserByID(userToken.Key));
                        shiftTokenDictionary[userToken.Key]--;
                    }
                }
            }
        }

        #endregion
    }
}
