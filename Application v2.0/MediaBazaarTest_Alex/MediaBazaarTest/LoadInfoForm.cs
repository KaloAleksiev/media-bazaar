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
    public partial class LoadInfoForm : Form
    {
        Position pos;
        KeyValuePair<string, int> dep;
        int year;
        Month month;
        ShiftType type;
        ShiftDataControl sdc;
        UserControl uc;
        Random rnd;
        Dictionary<int, int> shiftTokenDictionary;
        Dictionary<int, Shift[]> allShifts;

        public LoadInfoForm(ShiftDataControl sdc, UserControl uc, Month month, int year, string depText, int depId, ShiftType type, Position pos)
        {
            InitializeComponent();
            //pbStatus.Minimum = 1;
            //pbStatus.Maximum = 8;
            //pbStatus.Value = 1;
            //pbStatus.Step = 1;
            this.pos = pos;
            this.dep = new KeyValuePair<string, int>(depText, depId);
            this.year = year;
            this.month = month;
            this.type = type;
            this.sdc = sdc;
            this.uc = uc;

            shiftTokenDictionary = new Dictionary<int, int>();
            allShifts = new Dictionary<int, Shift[]>();
            rnd = new Random();
        }

        public void UpdateProgress(string statusMessage)
        {
            //lbStatus.Text = statusMessage;
            //pbStatus.PerformStep();
        }

        private void LoadInfoForm_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                _inputparameter.Proccess = 1200;
                backgroundWorker.RunWorkerAsync(_inputparameter);
            }
        }

        struct DataParameter 
        {
            public int Proccess;
        }

        private DataParameter _inputparameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
            BackgroundWorker bw = sender as BackgroundWorker;
            e.Result = CreateScheduleForMonth(bw);
            
            //}
            //catch(Exception ex)
            //{ MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK); }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done!", "Operation status", MessageBoxButtons.OK);
            this.Close();
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string statusMessage = "";
            switch (e.ProgressPercentage)
            {
                case 12: statusMessage = "Initializing process..."; break;
                case 25: statusMessage = "Clearing all shifts in chosen month..."; break;
                case 38: statusMessage = "Calculating shifts per person..."; break;
                case 50: statusMessage = "Creating empty shifts..."; break;
                case 63: statusMessage = "Initializing schedule creation..."; break;
                case 74: statusMessage = "Filling all shifts with employees..."; break;
                case 75: statusMessage = "Saving created shifts..."; break;
                case 100: statusMessage = "Finishing up..."; break;
            }
            if (e.ProgressPercentage <= 100)
            { pbStatus.Value = e.ProgressPercentage; }
            if (statusMessage != "")
            { lbStatus.Text = statusMessage; }
            pbStatus.Update();
        }

        public int CreateScheduleForMonth(BackgroundWorker bw)
        {
            bw.ReportProgress(12);

            //Clear all shifts in month.
            bw.ReportProgress(25);
            for (int i = 1; i <= DateTime.DaysInMonth(year, (int)month); i++)
            {
                DateTime dt = new DateTime(year, (int)month, i);

                //Get all shifts from the database
                List<int> indexes = sdc.GetAllShiftsOnDateByDep(dep.Value, pos, dt);
                DeleteShift(indexes);
            }

            //Calculate the amount of shifts an emplyee has to do in a month.
            bw.ReportProgress(38);
            int shiftsPerPerson = CalculateAmountOfShiftsPerPerson(new DateTime(year, (int)month, 1), pos, dep.Key);
            if (shiftsPerPerson == 0)
            {
                goto NoUsers;
            }

            //Create dictionary with the user ID as the key and amount of shift "tokens" left as the value.
            shiftTokenDictionary = CreateShiftTokenDictionary(pos, dep.Key, shiftsPerPerson);

            //Create empty shifts for each day of the month.
            bw.ReportProgress(50);
            allShifts = CreateAllShifts(pos, dep.Value);

            //Main repetition segment, where the assigment takes place.
            bw.ReportProgress(63);
            CreateSchedule(pos);

            bw.ReportProgress(100);
            return 1;

        NoUsers: return 0;
        }


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
            int userLimit = 1;
            if (pos == Position.Employee)
            { userLimit = 3; }
            else if (pos == Position.DepotWorker)
            { userLimit = 2; }
            else { userLimit = 1; }

            int totalShiftCount = DateTime.DaysInMonth(dt.Year, dt.Month) * 3 * userLimit;
            List<User> users = new List<User>();
            foreach (User u in uc.GetUsers())
            {
                if (u.Position == pos && u.Department == dep)
                { users.Add(u); }
            }
            int shiftsPerPerson = 0;
            if (users.Count != 0)
            {
                shiftsPerPerson = totalShiftCount / users.Count;
            }
            else
            {
                MessageBox.Show("There are no users in this department.");
                return 0;
            }
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
            for (int i = 1; i <= DateTime.DaysInMonth(year, (int)month); i++)
            {
                allShifts.Add(i, new Shift[3]);
                for (int j = 0; j <= 2; j++)
                {
                    //Maybe a morning shift is not created  at all ????????? //Alex
                    ShiftType type = ShiftType.Morning;
                    if (j == 1)
                    { type = ShiftType.Noon; }
                    else if (j == 2) { type = ShiftType.Evening; }
                    allShifts[i][j] = new Shift(new DateTime(year, (int)month, i), type, pos, dep);
                }
            }
            return allShifts;
        }

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
            backgroundWorker.ReportProgress(74);
            foreach (KeyValuePair<int, int> userToken in standInTokens)
            { allShifts = CycleThroughMonth(pos, pairityFlag, userLimit, userToken, 0); }

            //Add the new shifts to the data base.
            backgroundWorker.ReportProgress(75);
            AddAllShiftsToDB();
        }

        public Dictionary<int, Shift[]> CycleThroughMonth(Position pos, bool pairityFlag, int userLimit, KeyValuePair<int, int> userToken, int counter)
        {
            //If this is the third recursion, don't do anything.
            if (counter < 4)
            {
                //Call the needed method for each day of the month.
                for (int i = 1; i <= DateTime.DaysInMonth(year, (int)month); i++)
                {
                    int rndNum = rnd.Next(0, 3);
                    allShifts = AddUserToShiftRnd(pos, pairityFlag, userToken, i, rndNum, userLimit, 0);
                }

                //If the person has not been assigned to the max. allowed amount of shifts, repeat with different pairity flag.
                if (counter == 1)
                {
                    if (shiftTokenDictionary[userToken.Key] != 0)
                    { CycleThroughMonth(pos, !pairityFlag, userLimit, userToken, 2); }
                    return allShifts;
                }
                else if (counter == 2)
                {
                    if (shiftTokenDictionary[userToken.Key] != 0)
                    { CycleThroughMonth(pos, !pairityFlag, userLimit, userToken, 3); }
                    return allShifts;
                }
                else if (counter == 3)
                {
                    if (shiftTokenDictionary[userToken.Key] != 0)
                    { CycleThroughMonth(pos, !pairityFlag, userLimit, userToken, 4); }
                    return allShifts;
                }
                else
                {
                    if (shiftTokenDictionary[userToken.Key] != 0)
                    { CycleThroughMonth(pos, !pairityFlag, userLimit, userToken, 1); }
                    return allShifts;
                }
            }
            return allShifts;
        }

        public Dictionary<int, Shift[]> AddUserToShiftRnd(Position pos, bool pairityFlag, KeyValuePair<int, int> userToken, int i, int rndNum, int userLimit, int counter1)
        {
            counter1++;
            //If this is the fourth recursion, don't do anything.
            if (counter1 < 4)
            {
                //There might be a problem with the random ?? //Alex
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
                        else if (j == 2) { j = 0; }
                        allShifts = AddUserToShiftRnd(pos, pairityFlag, userToken, i, j, userLimit, counter1);
                    }
                }
                return allShifts;
            }
            return allShifts;
        }

        public void AddAllShiftsToDB()
        {
            int progress = 75;
            //Add all the shifts to the database.
            foreach (KeyValuePair<int, Shift[]> shifts in allShifts)
            {
                progress += 1;
                if (progress == 100)
                { progress--; }
                for (int i = 0; i < 3; i++)
                { shifts.Value[i].AddShiftToDB(); }
                backgroundWorker.ReportProgress(progress);
            }
        }

    }
}
