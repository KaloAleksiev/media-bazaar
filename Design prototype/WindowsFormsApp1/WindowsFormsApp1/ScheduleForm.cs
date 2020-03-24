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

namespace WindowsFormsApp1
{
    public partial class ScheduleForm : Form
    {
        int b = 15;
        int posX = 15;
        int posY = 102;
        int allHeight = 26;
        int lbWidth = 35;
        int btnWidth = 50;
        List<Button> dynamicButtons;
        DateTime dt;
        string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        MySqlConnection conn;
        List<Shift> shifts;
        //Lists for types of workers (all in the db)
        List<Employee> AllEmps;
        List<DepotWorker> AllDW;
        List<Manager> AllMng;
        //Lists for types of workers (who are in the shifts)
        List<Employee> InShiftE;
        List<DepotWorker> InShiftD;
        Manager InShiftM;


        public ScheduleForm(DateTime dt)
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);
            this.dt = dt; //Date of the shift
            dynamicButtons = new List<Button>(); //List of all buttons
            lblMonth.Text = dt.ToString("dd.MM.yy");
            AlignAll();
            shifts = new List<Shift>();
            AllEmps = new List<Employee>();
            AllDW = new List<DepotWorker>();
            AllMng = new List<Manager>();
            InShiftE = new List<Employee>();
            InShiftD = new List<DepotWorker>();

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
                    Department dep = Department.Manager;
                    //Find all people in the shift (if there are any)
                    MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND department = '" + dep.ToString() + "')", conn);
                    conn.Open();
                    MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                    reader1.Read();
                    n = Convert.ToInt32(reader1["EN"]);
                    try
                    { shiftId = Convert.ToInt32(reader1["shift_id"]); }
                    catch { }
                    reader1.Close();
                    conn.Close();
                    //Button color depends on the amount of people found
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else { dynamicButton.BackColor = Color.Red; }
                    dynamicButton.Text = n + " / 1";
                    //New sihft is added
                    shifts.Add(new Shift(shiftId, dt, st, dep));
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
                    Department dep = Department.DepotWorker;
                    MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND department = '" + dep.ToString() + "')", conn);
                    conn.Open();
                    MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                    reader1.Read();
                    n = Convert.ToInt32(reader1["EN"]);
                    try
                    { shiftId = Convert.ToInt32(reader1["shift_id"]); }
                    catch { }
                    reader1.Close();
                    conn.Close();
                    dynamicButton.Text = n + " / 2";
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else if (n == 2)
                    { dynamicButton.BackColor = Color.Red; }
                    else { dynamicButton.BackColor = Color.Yellow; }
                    shifts.Add(new Shift(shiftId, dt, st, dep));
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
                    else if (j >= 15 && j < b)
                    { dep = Department.Phones; }
                    MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND department = '" + dep.ToString() + "')", conn);
                    conn.Open();
                    MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                    reader1.Read();
                    n = Convert.ToInt32(reader1["EN"]);
                    try
                    { shiftId = Convert.ToInt32(reader1["shift_id"]); }
                    catch { }
                    reader1.Close();
                    conn.Close();
                    dynamicButton.Text = n + " / 3";
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else if (n == 3)
                    { dynamicButton.BackColor = Color.Red; }
                    else { dynamicButton.BackColor = Color.Yellow; }
                    shifts.Add(new Shift(shiftId, dt, st, dep));
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
            AllEmps = new List<Employee>();
            AllDW = new List<DepotWorker>();
            AllMng = new List<Manager>();
            InShiftE = new List<Employee>();
            InShiftD = new List<DepotWorker>();
            lbAllPpl.Items.Clear();
            lbInShift.Items.Clear();
        }

        public void ShiftPicked(DateTime dt, int j, int n)
        {
            //Get shift info for label
            lbShiftInfo.Text = $"{shifts[j].Type} shift in the {shifts[j].Department} department. Date: {dt.ToString("dd.MM.yyyy")}";
            label21.Text = j.ToString(); //Store shift index in label
            pShift.Visible = true;

            AllEmps = ControlClass.GetAllEmployees(); //Get ALL the employees in the DB.
            AllMng = ControlClass.GetAllManagers();
            AllDW = ControlClass.GetAllDepotWorkers();
            CheckIfFull(n, shifts[j].Department, shifts[j].ShiftId); //Not really "check", deletes the people already selected for the shift from the AllEmps List.
            FillChosenShift(shifts[j].Department);
            FillFromDBByDept(shifts[j].Department);
        }

        public void CheckIfFull(int n, Department dep, int shiftId)
        {
            if (n > 0) //n is number of people found to be in the shift already.
            //If there are any people already in the shift:
            {
                string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand getEmpId = new MySqlCommand("SELECT employee_id FROM shift_user WHERE shift_id = '" + shiftId.ToString() + "'", conn);
                conn.Open();
                for (int i = 1; i <= n; i++)
                {
                    MySqlDataReader reader1 = getEmpId.ExecuteReader();
                    reader1.Read();
                    int empId = Convert.ToInt32(reader1["employee_id"]);
                    reader1.Close();
                    string sql = "SELECT u.firstname, u.lastname, u.email, u.password, u.address, u.start_date, u.phone_number, e.id, e.emp_number, e.department, e.salary FROM user AS u INNER JOIN employee AS e ON u.id = e.id WHERE u.id = '" + empId.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int id = Convert.ToInt32(reader["id"]);
                    int empid = Convert.ToInt32(reader["emp_number"]);
                    string firstname = Convert.ToString(reader["firstName"]);
                    string lastname = Convert.ToString(reader["lastName"]);
                    string email = Convert.ToString(reader["email"]);
                    string address = Convert.ToString(reader["address"]);
                    string phonenumber = Convert.ToString(reader["phone_number"]);
                    string department = Convert.ToString(reader["department"]);
                    double salary = Convert.ToDouble(reader["salary"]);
                    Employee e = new Employee(id, empid, firstname, lastname, email, address, phonenumber, department, salary);
                    InShiftE.Add(e); //Add found people to the list for people in shifts.
                    for (int j = 0; j < AllEmps.Count; j++)
                    {
                        if (AllEmps[j].EmpNumber == e.EmpNumber)
                        {
                            AllEmps.RemoveAt(j); //Remove the people already picked for the shift
                        }
                    }
                    //AllEmps.Remove(e);
                    reader.Close();
                }
                conn.Close();
            }
        }

        public void FillChosenShift(Department dep)
        {
            //Fill listbox with people selected for the shift.
            switch (dep)
            {
                case Department.Manager:
                    lbInShift.Items.Clear();

                    break;
                case Department.DepotWorker:
                    break;
                default:
                    lbInShift.Items.Clear();
                    foreach (Employee emp in InShiftE)
                    { lbInShift.Items.Add(emp.GetInfo()); }
                    break;
            }

        }

        public void FillFromDBByDept(Department dep)
        {
            //Fill listbox with all people with the department of the shift.
            switch (dep)
            {
                case (Department.Manager): //HELP
                    lbAllPpl.Items.Clear();
                    List<Manager> managers = new List<Manager>();
                    foreach (Manager m in AllMng)
                    {
                        if (m.Department == dep)
                        { managers.Add(m); }
                    }
                    foreach (Manager manager in managers)
                    { lbAllPpl.Items.Add(manager.GetInfo()); }
                    AllMng = managers;
                    break;
                case (Department.DepotWorker): //HELP
                    lbAllPpl.Items.Clear();
                    List<DepotWorker> depotWorkers = new List<DepotWorker>();
                    foreach (DepotWorker d in AllDW)
                    {
                        if (d.Department == dep)
                        { depotWorkers.Add(d); }
                    }
                    foreach (DepotWorker dw in depotWorkers)
                    { lbAllPpl.Items.Add(dw.GetInfo()); }
                    AllDW = depotWorkers;
                    break;
                default:
                    lbAllPpl.Items.Clear();
                    List<Employee> emps = new List<Employee>();
                    foreach (Employee emp in AllEmps)
                    {
                        if (emp.Department == dep)
                        { emps.Add(emp); }
                    }
                    foreach (Employee emp in emps)
                    { lbAllPpl.Items.Add(emp.GetInfo()); }
                    AllEmps = emps;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Department dep = shifts[Convert.ToInt32(label21.Text)].Department;
            switch (dep)
            {
                case (Department.Manager): //HELP
                    if (InShiftM == null)
                    {
                        try
                        {
                            //Add the selected person from the AllPpl listbox to the InShift listbox
                            InShiftM = (AllMng[lbAllPpl.SelectedIndex]);
                            AllMng.RemoveAt(lbAllPpl.SelectedIndex);
                            lbAllPpl.Items.Clear();
                            foreach (Manager m in AllMng)
                            { lbAllPpl.Items.Add(m.GetInfo()); } //Refresh the AllPpl listbox
                            shifts[Convert.ToInt32(label21.Text)].AddPerson(InShiftM);
                            FillChosenShift(dep); //Refresh the InShift listbox.
                        }
                        catch
                        { MessageBox.Show("Please select a person."); }
                    }
                    else
                    { MessageBox.Show("There can't be more than 3 people in an employee shift."); }
                    break;

                case (Department.DepotWorker): //HELP
                    if (InShiftD.Count != 2)
                    {
                        try
                        {
                            //Add the selected person from the AllPpl listbox to the InShift listbox
                            InShiftD.Add(AllDW[lbAllPpl.SelectedIndex]);
                            DepotWorker d = AllDW[lbAllPpl.SelectedIndex];
                            AllDW.RemoveAt(lbAllPpl.SelectedIndex);
                            lbAllPpl.Items.Clear();
                            foreach (DepotWorker dw in AllDW)
                            { lbAllPpl.Items.Add(dw.GetInfo()); } //Refresh the AllPpl listbox
                            shifts[Convert.ToInt32(label21.Text)].AddPerson(d);
                            FillChosenShift(dep); //Refresh the InShift listbox.
                        }
                        catch
                        { MessageBox.Show("Please select a person."); }
                    }
                    else
                    { MessageBox.Show("There can't be more than 3 people in an employee shift."); }

                    break;
                default:
                    if (InShiftE.Count != 3)
                    {
                        try
                        {
                            //Add the selected person from the AllPpl listbox to the InShift listbox
                            InShiftE.Add(AllEmps[lbAllPpl.SelectedIndex]);
                            Employee u = AllEmps[lbAllPpl.SelectedIndex];
                            AllEmps.RemoveAt(lbAllPpl.SelectedIndex);
                            lbAllPpl.Items.Clear();
                            foreach (Employee emp in AllEmps)
                            { lbAllPpl.Items.Add(emp.GetInfo()); } //Refresh the AllPpl listbox
                            shifts[Convert.ToInt32(label21.Text)].AddPerson(u);
                            FillChosenShift(dep); //Refresh the InShift listbox.
                        }
                        catch
                        { MessageBox.Show("Please select a person."); }
                    }
                    else
                    { MessageBox.Show("There can't be more than 3 people in an employee shift."); }
                    break;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Department dep = shifts[Convert.ToInt32(label21.Text)].Department;
            switch (dep)
            {
                case (Department.Manager): //HELP
                    try
                    {
                        //Remove selected person from the InShift listbox to the AllPpl listbox
                        AllMng.Add(InShiftM);
                        shifts[Convert.ToInt32(label21.Text)].RemovePerson(InShiftM);

                        lbAllPpl.Items.Clear();
                        foreach (Manager m in AllMng)
                        { lbAllPpl.Items.Add(m.GetInfo()); } //Refresh the AllPpl listbox.
                        FillChosenShift(dep); //Refresh the InShift listbox.
                    }
                    catch
                    { MessageBox.Show("Please select a person."); }
                    break;
                case (Department.DepotWorker): //HELP
                    try
                    {
                        //Remove selected person from the InShift listbox to the AllPpl listbox
                        AllDW.Add(InShiftD[lbInShift.SelectedIndex]);
                        shifts[Convert.ToInt32(label21.Text)].RemovePerson(InShiftD[lbInShift.SelectedIndex]);
                        InShiftD.RemoveAt(lbInShift.SelectedIndex);
                        lbAllPpl.Items.Clear();
                        foreach (DepotWorker d in AllDW)
                        { lbAllPpl.Items.Add(d.GetInfo()); } //Refresh the AllPpl listbox.
                        FillChosenShift(dep); //Refresh the InShift listbox.
                    }
                    catch
                    { MessageBox.Show("Please select a person."); }
                    break;
                default:
                    try
                    {
                        //Remove selected person from the InShift listbox to the AllPpl listbox
                        AllEmps.Add(InShiftE[lbInShift.SelectedIndex]);
                        shifts[Convert.ToInt32(label21.Text)].RemovePerson(InShiftE[lbInShift.SelectedIndex]);
                        InShiftE.RemoveAt(lbInShift.SelectedIndex);
                        lbAllPpl.Items.Clear();
                        foreach (Employee emp in AllEmps)
                        { lbAllPpl.Items.Add(emp.GetInfo()); } //Refresh the AllPpl listbox.
                        FillChosenShift(dep); //Refresh the InShift listbox.
                    }
                    catch
                    { MessageBox.Show("Please select a person."); }
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            shifts[Convert.ToInt32(label21.Text)].AddShiftToDB(); //Add the shift to the DB.
            switch (shifts[Convert.ToInt32(label21.Text)].Department)
            {
                case (Department.Manager): //HELP
                    dynamicButtons[Convert.ToInt32(label21.Text)].Text = shifts[Convert.ToInt32(label21.Text)].GetAllMng().Count + " / 1";
                    if (shifts[Convert.ToInt32(label21.Text)].GetAllMng().Count == 0)
                    { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Green; }
                    else if (shifts[Convert.ToInt32(label21.Text)].GetAllMng().Count == 1)
                    { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Red; }
                    break;
                case (Department.DepotWorker): //HELP
                    dynamicButtons[Convert.ToInt32(label21.Text)].Text = shifts[Convert.ToInt32(label21.Text)].GetAllDW().Count + " / 2";
                    if (shifts[Convert.ToInt32(label21.Text)].GetAllDW().Count == 0)
                    { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Green; }
                    else if (shifts[Convert.ToInt32(label21.Text)].GetAllDW().Count == 2)
                    { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Red; }
                    else { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Yellow; }
                    break;
                default:
                    dynamicButtons[Convert.ToInt32(label21.Text)].Text = shifts[Convert.ToInt32(label21.Text)].GetAllEmps().Count + " / 3";
                    if (shifts[Convert.ToInt32(label21.Text)].GetAllEmps().Count == 0)
                    { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Green; }
                    else if (shifts[Convert.ToInt32(label21.Text)].GetAllEmps().Count == 3)
                    { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Red; }
                    else { dynamicButtons[Convert.ToInt32(label21.Text)].BackColor = Color.Yellow; }
                    break; //Change the clicked button text and color in accordance to the new emp amount.
            }
            //If the shift has no people in it, delete it (!!!IMPORTANT!!!)
            if (shifts[Convert.ToInt32(label21.Text)].GetAllEmps().Count == 0)
            {
                MySqlCommand DeleteShift = new MySqlCommand("DELETE FROM shift WHERE shift_id = '" + shifts[Convert.ToInt32(label21.Text)].ShiftId + "'", conn);
                conn.Open();
                int j = DeleteShift.ExecuteNonQuery();
                conn.Close();
            }
            ResetAll();
            pShift.Visible = false;
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
        } //Unimportant

        private void btnNext_Click(object sender, EventArgs e)
        {
            dt = dt.AddDays(1);
            Form1.CreateScheduleForm(dt); ;
            this.Close();
        } //Unimportant

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dt = dt.AddDays(-1);
            Form1.CreateScheduleForm(dt); ;
            this.Close();
        } //Unimportant

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
    }
}
