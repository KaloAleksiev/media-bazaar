using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    public partial class ScheduleForm : Form
    {
        private UserControl uc;
        ShiftDataControl sdc;
        int b = 15;
        int posX = 15;
        int posY = 102;
        int allHeight = 26;
        int lbWidth = 35;
        int btnWidth = 50;
        int userLimit = 0;
        List<Button> dynamicButtons;
        DateTime dt;
        string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        
        List<Shift> shifts;
        //Lists for types of workers (all in the db)
        List<User> AllEmps;
        //Lists for types of workers (who are in the shifts)
        List<User> InShift;

        public ScheduleForm(UserControl userControl, DateTime dt)
        {           
            InitializeComponent();
            this.uc = userControl;
            sdc = new ShiftDataControl();
            
            this.dt = dt; //Date of the shift
            dynamicButtons = new List<Button>(); //List of all buttons
            lblMonth.Text = dt.ToString("dd.MM.yy");
            AlignAll();
            shifts = new List<Shift>();
            AllEmps = new List<User>();
            InShift = new List<User>();
            createSchedule(dt);
        }


        public void createSchedule(DateTime dt)
        {
            //All buttons are created
            posX += lbWidth;
            for (int j = 0; j < b; j++)
            {
                Button dynamicButton = new Button();
                dynamicButton.Location = new Point(posX, posY);
                dynamicButton.Height = allHeight;
                dynamicButton.Width = btnWidth;
                dynamicButton.BackColor = Color.White;
                dynamicButton.ForeColor = Color.Black;
                dynamicButton.FlatStyle = FlatStyle.Flat;

                int n = 1;
                int shiftId = 0;

                if (j >= 0 && j < 3)
                {
                    //Find the type of shift
                    ShiftType st = ShiftType.Morning;
                    if (j % 3 == 0)
                    { st = ShiftType.Morning; }
                    else if (j % 3 == 1)
                    { st = ShiftType.Noon; }
                    else if (j % 3 == 2)
                    { st = ShiftType.Evening; }
                    Position pos = Position.Manager;
                    //Find all people in the shift (if there are any)
                    //int[] amntOfUsers = sdc.GetAmntOfUsersInShift(dt, st, pos);
                    //n = amntOfUsers[0];
                    //try
                   // { shiftId = amntOfUsers[1]; }
                   // catch { }
                    //Button color depends on the amount of people found
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else { dynamicButton.BackColor = Color.Red; }
                    dynamicButton.Text = n + " / 1";
                    //New sihft is added
                    shifts.Add(new Shift(shiftId, dt, st, pos));
                }
                else if (j >= 3 && j < 6)
                {
                    ShiftType st = ShiftType.Morning;
                    if (j % 3 == 0)
                    { st = ShiftType.Morning; }
                    else if (j % 3 == 1)
                    { st = ShiftType.Noon; }
                    else if (j % 3 == 2)
                    { st = ShiftType.Evening; }
                    Position pos = Position.DepotWorker;
                    //int[] amntOfUsers = sdc.GetAmntOfUsersInShift(dt, st, pos);
                    //n = amntOfUsers[0];
                    //try
                    //{ //shiftId = amntOfUsers[1]; }
                    //catch { }
                    dynamicButton.Text = n + " / 2";
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else if (n == 2)
                    { dynamicButton.BackColor = Color.Red; }
                    else { dynamicButton.BackColor = Color.Yellow; }
                    shifts.Add(new Shift(shiftId, dt, st, pos));
                }
                else if (j >= 6 && j < b)
                {
                    ShiftType st = ShiftType.Morning;
                    if (j % 3 == 0)
                    { st = ShiftType.Morning; }
                    else if (j % 3 == 1)
                    { st = ShiftType.Noon; }
                    else if (j % 3 == 2)
                    { st = ShiftType.Evening; }
                    //Find shift department
                    Department dep = Department.Phones;
                    if (j >= 6 && j < 9)
                    { dep = Department.Phones; }
                    else if (j >= 9 && j < 12)
                    { dep = Department.Computers; }
                    else if (j >= 12 && j < b)
                    { dep = Department.TVs; }
                    Position pos = Position.Employee;
                    //int[] amntOfUsers = sdc.GetAmntOfUsersInShift(dt, st, pos, (int)dep);
                    //n = amntOfUsers[0];
                    //try
                    //{ shiftId = amntOfUsers[1]; }
                    //catch { }
                    //dynamicButton.Text = n + " / 3";
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else if (n == 3)
                    { dynamicButton.BackColor = Color.Red; }
                    else { dynamicButton.BackColor = Color.Yellow; }
                    shifts.Add(new Shift(shiftId, dt, st, pos, (int)dep));
                }
                dynamicButton.Name = "j" + j;
                dynamicButton.Font = new Font("Microsoft Sans Serif", 8);
                dynamicButton.Click += new EventHandler(DynamicButton_Click);
                dynamicButtons.Add(dynamicButton);
                Controls.Add(dynamicButton);
                posX += btnWidth;
            }
            posX = 15;
            posY += allHeight;

            posX = 15;
            posY = 102;
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            //What happens when button is clicked
            Button clickedButton = (Button)sender; //Get the button clicked as object
            char[] arBtnName = clickedButton.Name.ToCharArray();
            char[] arBtnText = clickedButton.Text.ToCharArray();
            int n = Convert.ToInt32(arBtnText[0].ToString());
            ResetAll(); //Reset all user type collections and listboxes
            ShiftPicked(dt, GetIdOutOfBtn(arBtnName), n); 
        }

        public void ResetAll()
        {
            AllEmps = new List<User>();
            InShift = new List<User>();
            lbAllPpl.Items.Clear();
            lbInShift.Items.Clear();
            foreach (Shift s in shifts)
            {
                s.DeleteAllUsers();
            }
        }

        public void ShiftPicked(DateTime dt, int j, int n)
        {
            ResetAll();
            //Get shift info for label
            if (shifts[j].Position != Position.Employee)
            { lbShiftInfo.Text = $"{shifts[j].Type} shift in the {shifts[j].Position} department. Date: {dt.ToString("dd.MM.yyyy")}"; }
            else { lbShiftInfo.Text = $"{shifts[j].Type} shift in the {(Department)shifts[j].Department} department. Date: {dt.ToString("dd.MM.yyyy")}"; }
            label21.Text = j.ToString(); //Store shift index in label
            pShift.Visible = true;

            if (j >= 0 && j < 3)
            { userLimit = 1; }
            else if (j >= 3 && j < 6)
            { userLimit = 2; }
            else if (j >= 6 && j < b)
            { userLimit = 3; }

            AllEmps.Clear();
            foreach (User user in uc.GetUsers())
            { AllEmps.Add(user); }
            CheckIfFull(n, shifts[j].ShiftId, j); //Not really "check", deletes the people already selected for the shift from the AllEmps List.
            FillChosenShift();
            FillFromDBByDept((Department)shifts[j].Department, shifts[j].Position);
        }

        public void CheckIfFull(int n, int shiftId, int l)
        {
            if (n > 0) //n is number of people found to be in the shift already.
            //If there are any people already in the shift:
            {
                List<int> indexes = new List<int>();
                indexes = sdc.GetIdOfUsersInShift(shiftId, n);
                for (int i = 0; i < indexes.Count; i++)
                {
                    //string sql = "SELECT id, firstName, lastName, email, password, address, position, department_id, salary, rank, start_date, birth_date, phone_number, city, zipcode, gender FROM user WHERE id = '" + indexes[i].ToString() + "'";
                    //MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    //reader.Read();
                    //int id = Convert.ToInt32(reader["id"]);
                    //string firstname = Convert.ToString(reader["firstName"]);
                    //string lastname = Convert.ToString(reader["lastName"]);
                    //string email = Convert.ToString(reader["email"]);
                    //string address = Convert.ToString(reader["address"]);
                    //string phonenumber = Convert.ToString(reader["phone_number"]);
                    //string position = Convert.ToString(reader["position"]);
                    //string password = Convert.ToString(reader["password"]);
                    //int department = Convert.ToInt32(reader["department_id"]);
                    //int rank = Convert.ToInt32(reader["rank"]);
                    //DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                    //DateTime bday = Convert.ToDateTime(reader["birth_date"]);
                    //double salary = Convert.ToDouble(reader["salary"]);
                    //string city = Convert.ToString(reader["city"]);
                    //string zipcode = Convert.ToString(reader["zipcode"]);
                    //string gender = Convert.ToString(reader["gender"]);
                    ////User u = new User(id, firstname, lastname, department, position, email, city, zipcode, address, phonenumber, rank, salary, password, startDate, bday, gender);
                    //reader.Close();
                    User u = uc.GetUserByID(indexes[i]);
                    InShift.Add(u); //Add found people to the list for people in shifts.
                    shifts[l].AddUser(u);
                    for (int j = 0; j < AllEmps.Count; j++)
                    {
                        if (AllEmps[j].Id == u.Id)
                        {
                            AllEmps.RemoveAt(j); //Remove the people already picked for the shift
                        }
                    }
                }
            }
        }

        public void FillChosenShift()
        {
            //Fill listbox with people selected for the shift. 
            lbInShift.Items.Clear();
            foreach (User u in InShift)
            {
                lbInShift.Items.Add(u.GetInfo());
            }
        }

        public void FillFromDBByDept(Department dep, Position pos)
        {
            //Fill listbox with all people with the department of the shift.
            lbAllPpl.Items.Clear();
            List<User> emps = new List<User>();
            foreach (User emp in AllEmps)
            {
                if (pos == Position.Employee)
                {
                    //if (emp.Department == dep && emp.Position == pos)
                    { emps.Add(emp); }
                }
                else
                {
                    if (emp.Position == pos)
                    { emps.Add(emp); }
                }
            }
            foreach (User emp in emps)
            { lbAllPpl.Items.Add(emp.GetInfo()); }
            AllEmps = emps;
        }

        #region Unimportant
        public int GetIdOutOfBtn(char[] arBtnName)
        {
            int first = 0;
            for (int i = 0; i < arBtnName.Length; i++)
            {
                if (arBtnName[i] == 'j')
                {
                    string l = null;
                    int j = i + 1;
                    while (j < arBtnName.Length)
                    {
                        l += arBtnName[j].ToString();
                        j++;
                    }
                    first = Convert.ToInt32(l);
                }
            }
            return first;
        } 

        private void btnNext_Click(object sender, EventArgs e)
        {
            dt = dt.AddDays(1);
            MainForm.CreateScheduleForm(uc, dt); ;
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dt = dt.AddDays(-1);
            MainForm.CreateScheduleForm(uc, dt); ;
            this.Close();
        }

        public Month GetMonth(DateTime dt)
        {
            Month month = Month.January;
            switch (dt.Month)
            {
                case (1): month = Month.January; break;
                case (2): month = Month.February; break;
                case (3): month = Month.March; break;
                case (4): month = Month.April; break;
                case (5): month = Month.May; break;
                case (6): month = Month.June; break;
                case (7): month = Month.July; break;
                case (8): month = Month.August; break;
                case (9): month = Month.September; break;
                case (10): month = Month.October; break;
                case (11): month = Month.November; break;
                case (12): month = Month.December; break;
            }
            return month;
        } //Unimportant

        public void AlignAll()
        {
            this.Width = 870;
            this.Height = 500;
            btnNext.Width = 150;
            btnNext.Height = 27;
            btnNext.Location = new Point(500, 9);
            btnPrevious.Width = 150;
            btnPrevious.Height = 27;
            btnPrevious.Location = new Point(200, 9);
            lblMonth.Width = 150;
            lblMonth.Height = 27;
            lblMonth.Location = new Point(350, 9);

            int posYfixed = 50;

            List<Label> labels = new List<Label>();
            foreach (Control obj in Controls)
            {
                if (obj is Label)
                {
                    if (obj.Name != "lblMonth")
                    { labels.Add((Label)obj); }
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                labels[i].Location = new Point(150 + ((i - 1) * 150), posYfixed + 26);
                labels[i].Height = 26;
                labels[i].Width = 50;
            }
            for (int i = 6; i <= 10; i++)
            {
                labels[i].Location = new Point(100 + ((i - 6) * 150), posYfixed + 26);
                labels[i].Height = 26;
                labels[i].Width = 50;
            }
            for (int i = 11; i <= 15; i++)
            {
                labels[i].Location = new Point(50 + ((i - 11) * 150), posYfixed + 26);
                labels[i].Height = 26;
                labels[i].Width = 50;
            }
            for (int i = 16; i < 21; i++)
            {
                labels[i].Location = new Point(50 + ((i - 16) * 150), posYfixed);
                labels[i].Height = 26;
                labels[i].Width = 150;
            }

            pShift.Size = new Size(751, 272);
            pShift.Location = new Point(50, 169);

            lbShiftInfo.Location = new Point(20, 14);

            lbAllPpl.Size = new Size(230, 188);
            lbAllPpl.Location = new Point(20, 75);

            lbInShift.Size = new Size(230, 188);
            lbInShift.Location = new Point(500, 75);

            btnAdd.Size = new Size(150, 27);
            btnAdd.Location = new Point(300, 129);

            btnCancel.Size = new Size(150, 27);
            btnCancel.Location = new Point(300, 228);

            btnConfirm.Size = new Size(150, 27);
            btnConfirm.Location = new Point(300, 195);

            btnRemove.Size = new Size(150, 27);
            btnRemove.Location = new Point(300, 162);

            label22.Location = new Point(17, 55);
            label23.Location = new Point(497, 55);
        } //Unimportant
        #endregion

        #region Panel Buttons
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
                    { lbAllPpl.Items.Add(emp.GetInfo()); } //Refresh the AllPpl listbox
                    
                    shifts[Convert.ToInt32(label21.Text)].AddUser(u);
                    
                    FillChosenShift(); //Refresh the InShift listbox.
                    
                }
                catch
                { MessageBox.Show("Please select a person."); }
            }
            else
            { MessageBox.Show($"There can't be more than {userLimit} people in a(n) {AllEmps[lbAllPpl.SelectedIndex].Position} shift."); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //Remove selected person from the InShift listbox to the AllPpl listbox
                
                AllEmps.Add(InShift[lbInShift.SelectedIndex]);
                shifts[Convert.ToInt32(label21.Text)].RemoveUser(InShift[lbInShift.SelectedIndex]);
                
                InShift.RemoveAt(lbInShift.SelectedIndex);
                lbAllPpl.Items.Clear();
                foreach (User emp in AllEmps)
                { 
                    lbAllPpl.Items.Add(emp.GetInfo()); } //Refresh the AllPpl listbox.
                FillChosenShift(); //Refresh the InShift listbox.
            }
            catch
            { MessageBox.Show("Please select a person."); }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            shifts[Convert.ToInt32(label21.Text)].AddShiftToDB(); //Add the shift to the DB.
            
            dynamicButtons[Convert.ToInt32(label21.Text)].Text = shifts[Convert.ToInt32(label21.Text)].GetAllUsers().Count + $" / {userLimit}";
            if (shifts[Convert.ToInt32(label21.Text)].GetAllUsers().Count == 0)
            { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Green; }
            else if (shifts[Convert.ToInt32(label21.Text)].GetAllUsers().Count == userLimit)
            { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Red; }
            else { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Yellow; }
            int oo = 0;
            List<User> ooo = shifts[Convert.ToInt32(label21.Text)].GetAllUsers();
            oo = ooo.Count;

            //If the shift has no people in it, delete it (!!!IMPORTANT!!!)
            if (oo == 0)
            { sdc.DeleteShift(shifts[Convert.ToInt32(label21.Text)].ShiftId); }

            ResetAll();
            pShift.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAll();
            pShift.Visible = false;
        }

        #endregion

    }
}
