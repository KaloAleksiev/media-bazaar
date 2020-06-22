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
    public partial class ShiftAssignmentForm : Form
    {
        private UserControl uc;
        ShiftDataControl sdc;
        int userLimit = 0;
        Shift shift;
        int nrOfPeople;
        Position pos;
        public DateTime dt;
        KeyValuePair<string, int> dep;
        int currentShiftId = 0;
        //Lists for types of workers (all in the db)
        List<User> AllEmps;
        //Lists for types of workers (who are in the shifts)
        List<User> InShift;

        public ShiftAssignmentForm(UserControl userControl, DateTime dt, KeyValuePair<string, int> dep, Position pos, ShiftType type, int nrOfPeople, int shiftId = -1)
        {
            InitializeComponent();
            this.uc = userControl;
            sdc = new ShiftDataControl();
            this.pos = pos;
            this.dt = dt;
            this.dep = dep;
            if (shiftId == -1)
            { shift = new Shift(dt, type, pos, dep.Value); }
            else { shift = new Shift(shiftId, dt, type, pos, dep.Value); }
            AllEmps = new List<User>();
            InShift = new List<User>();
            this.nrOfPeople = nrOfPeople;
            if (nrOfPeople > 0)
            { currentShiftId = sdc.GetAmntOfUsersInShift(dt, type, pos, dep.Value).Key; }
            SetUpForm();
            lbShiftInfo.Text = $"Schedule for {dt.ToString()} for {pos.ToString()}s of {dep.Key} department, {type.ToString()} shifts.";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (InShift.Count < userLimit)
            {
                try
                {
                    //Add the selected person from the AllPpl listbox to the InShift listbox
                    InShift.Add(AllEmps[lbAllPpl.SelectedIndex]);
                    User u = AllEmps[lbAllPpl.SelectedIndex];
                    AllEmps.RemoveAt(lbAllPpl.SelectedIndex);
                    lbAllPpl.Items.Clear();
                    foreach (User emp in AllEmps)
                    { 
                        lbAllPpl.Items.Add(emp.GetInfo()); } //Refresh the AllPpl listbox

                    shift.AddUser(u);
                    MessageBox.Show(shift.GetAllUsers().Count.ToString());
                    FillChosenShift(); //Refresh the InShift listbox.
                }
                catch
                { MessageBox.Show("Please select a person."); }
            }
            else
            { MessageBox.Show($"There can't be more than {userLimit} people in a(n) {pos} shift."); }
        }

        public void FillChosenShift()
        {
            //Fill listbox with people selected for the shift. 
            lbInShift.Items.Clear();
            foreach (User u in InShift)
            { 
                lbInShift.Items.Add(u.GetInfo()); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //Remove selected person from the InShift listbox to the AllPpl listbox

                AllEmps.Add(InShift[lbInShift.SelectedIndex]);
                shift.RemoveUser(InShift[lbInShift.SelectedIndex]);

                InShift.RemoveAt(lbInShift.SelectedIndex);
                lbAllPpl.Items.Clear();
                MessageBox.Show(shift.GetAllUsers().Count.ToString());
                foreach (User emp in AllEmps)
                {
                    lbAllPpl.Items.Add(emp.GetInfo());
                } //Refresh the AllPpl listbox.
                FillChosenShift(); //Refresh the InShift listbox.
            }
            catch
            { MessageBox.Show("Please select a person."); }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            shift.AddShiftToDB(); //Add the shift to the DB.

            int oo = 0;
            List<User> ooo = shift.GetAllUsers();
            oo = ooo.Count;

            //If the shift has no people in it, delete it (!!!IMPORTANT!!!)
            if (oo == 0)
            { sdc.DeleteShift(shift.ShiftId); }

            ResetAll();
            this.Close();
        }

        public void ResetAll()
        {
            AllEmps = new List<User>();
            InShift = new List<User>();
            lbAllPpl.Items.Clear();
            lbInShift.Items.Clear();
            shift.DeleteAllUsers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAll();
            this.Close();
        }

        public void FillUpListBoxes()
        {
            if (nrOfPeople > 0)
            {
                List<int> indexes = sdc.GetIdOfUsersInShift(currentShiftId, nrOfPeople);
                List<int> foundIndexes = new List<int>();
                for (int i = 0; i < AllEmps.Count; i++)
                {
                    if (indexes.Contains(AllEmps[i].Id))
                    { foundIndexes.Add(i); }
                }
                foreach (int i in foundIndexes)
                { InShift.Add(AllEmps[i]); }
                foreach (User u in InShift)
                {
                    try
                    {
                        AllEmps.Remove(u);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            foreach (User u in AllEmps)
            { lbAllPpl.Items.Add(u.GetInfo()); }
            foreach (User u in InShift)
            { 
                lbInShift.Items.Add(u.GetInfo());
                shift.AddUser(u);
            }
        }

        public void SetUpForm()
        {
            if (pos == Position.Employee)
            { userLimit = 3; }
            else if (pos == Position.DepotWorker)
            { userLimit = 2; }
            else { userLimit = 1; }
            AllEmps.Clear();
            foreach (User u in uc.GetUsers())
            {
                if (u.Department == dep.Key && u.Position == pos)
                { AllEmps.Add(u); }
            }
            FillUpListBoxes();
        }
    }
}
