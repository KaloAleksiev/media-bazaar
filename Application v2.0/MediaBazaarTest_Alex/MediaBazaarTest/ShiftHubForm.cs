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

        Dictionary<int, int> shiftTokenDictionary;
        Dictionary<int, Shift[]> allShifts;

        public ShiftHubForm(UserControl uc)
        {
            InitializeComponent();
            this.uc = uc;
            dd = new DepartmentDictionary();
            shiftTokenDictionary = new Dictionary<int, int>();
            allShifts = new Dictionary<int, Shift[]>();
            sdc = new ShiftDataControl();
            deps = dd.GetAllDepartments();
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
            shiftTokenDictionary = CreateShiftTokenDictionary(pos, dep.Key, shiftsPerPerson);

            //Create empty shifts for each day of the month.
            allShifts = CreateAllShifts(pos, dep.Value);

            //Main repetition segment, where the assigment takes place.
            CreateSchedule(pos);

            //Show the shchedule.
            btnViewSchedule_Click(sender, e);
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

        public Dictionary<int, Shift[]> CreateAllShifts(Position pos, int dep)
        {
            Dictionary<int, Shift[]> allShifts = new Dictionary<int, Shift[]>();
            for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1); i++)
            {
                allShifts.Add(i, new Shift[3]);
                for (int j = 0; j <= 2; j++)
                {
                    ShiftType type = ShiftType.Morning;
                    if (j == 1)
                    { type = ShiftType.Noon; }
                    else if (j == 2) { type = ShiftType.Evening; }
                    allShifts[i][j] = new Shift(new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, i), type, pos, dep);
                }
            }
            return allShifts;
        }
        #endregion

        public void CreateSchedule(Position pos)
        {
            //Flag that determines on which days the people will be added.
            bool pairityFlag = false;

            Dictionary<int, int> standInTokens = new Dictionary<int, int>();

            foreach (KeyValuePair<int, int> kvp in shiftTokenDictionary)
            { standInTokens.Add(kvp.Key, kvp.Value); }

            int userLimit = 1;
            if (pos == Position.Employee)
            { userLimit = 3; }
            else if (pos == Position.DepotWorker)
            { userLimit = 2; }
            else { userLimit = 1; }

            //For each user, add them to every other day of the month.
            foreach (KeyValuePair<int, int> userToken in standInTokens)
            { allShifts = CycleThroughMonth(pos, pairityFlag, userLimit, userToken, 0); }

            //Add the new shifts to the data base.
            AddAllShiftsToDB();
        }

        public Dictionary<int, Shift[]> CycleThroughMonth(Position pos, bool pairityFlag, int userLimit, KeyValuePair<int, int> userToken, int counter)
        {
            //If this is the third recursion, don't do anything.
            if (counter < 2)
            {
                //Call the needed method for each day of the month.
                for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1); i++)
                {
                    Random rnd = new Random();
                    int rndNum = rnd.Next(0, 3);
                    allShifts = AddUserToShiftRnd(pos, pairityFlag, userToken, i, rndNum, userLimit, 0);
                }

                //If the person has not been assigned to the max. allowed amount of shifts, repeat with different pairity flag.
                if (shiftTokenDictionary[userToken.Key] != 0)
                { CycleThroughMonth(pos, !pairityFlag, userLimit, userToken, counter++); }
                return allShifts;
            }
            return allShifts;
        }

        public Dictionary<int, Shift[]> AddUserToShiftRnd( Position pos, bool pairityFlag, KeyValuePair<int, int> userToken, int i, int rndNum, int userLimit, int counter)
        {
            counter++;
            //If this is the fourth recursion, don't do anything.
            if (counter < 4)
            {
                int j = rndNum;
                //If the number of the day appeals to the flag condition, attempt to add the user to this shift.
                if (i % 2 == Convert.ToInt32(pairityFlag))
                {
                    //If the shift isn't full, add to it. If it is, try the next one.
                    if (allShifts[i][j].GetAllUsers().Count < userLimit)
                    {
                        allShifts[i][j].AddUser(uc.GetUserByID(userToken.Key));
                        shiftTokenDictionary[userToken.Key]--;
                    }
                    else
                    {
                        //Go to the next shift on the day and call the method again.
                        if (j == 0) { j = 1; }
                        else if (j == 1) { j = 2; }
                        else if (j == 2) { j = 3; }
                        allShifts = AddUserToShiftRnd(pos, pairityFlag, userToken, i, j, userLimit, counter);
                    }
                }
                return allShifts;
            }
            return allShifts;
        }

        public void AddAllShiftsToDB()
        {
            //Add all the shifts to the database.
            foreach (KeyValuePair<int, Shift[]> shifts in allShifts)
            {
                for (int i = 0; i < 3; i++)
                { shifts.Value[i].AddShiftToDB(); }
            }
        }

        #endregion
    }
}
