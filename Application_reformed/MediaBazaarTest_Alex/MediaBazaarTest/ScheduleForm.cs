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
        List<User> AllEmps;
        //Lists for types of workers (who are in the shifts)
        List<User> InShift;

        public ScheduleForm(UserControl userControl)
        {           
            InitializeComponent();
            this.uc = userControl;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

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
                    Position dep = Position.Manager;
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
                    //shifts.Add(new Shift(shiftId, dt, st, dep));
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
                    Position dep = Position.DepotWorker;
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
                    //shifts.Add(new Shift(shiftId, dt, st, dep));
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
            //ShiftPicked(dt, GetIdOutOfBtn(arBtnName), n);
        }

        public void ResetAll()
        {
            AllEmps = new List<User>();
            InShift = new List<User>();
            lbAllPpl.Items.Clear();
            lbInShift.Items.Clear();
        }

        public void ShiftPicked(DateTime dt, int j, int n)
        {
            //Get shift info for label
            lbShiftInfo.Text = $"{shifts[j].Type} shift in the {shifts[j].Department} department. Date: {dt.ToString("dd.MM.yyyy")}";
            label21.Text = j.ToString(); //Store shift index in label
            pShift.Visible = true;

            AllEmps = uc.GetUsers(); //Get ALL the employees in the DB.
            CheckIfFull(n, shifts[j].Department, shifts[j].ShiftId, j); //Not really "check", deletes the people already selected for the shift from the AllEmps List.
            FillChosenShift(shifts[j].Department);
            FillFromDBByDept(shifts[j].Department);
        }

        public void CheckIfFull(int n, Department dep, int shiftId, int l)
        {
            if (n > 0) //n is number of people found to be in the shift already.
            //If there are any people already in the shift:
            {
                List<int> indexes = new List<int>();
                string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand getEmpId = new MySqlCommand("SELECT employee_id FROM shift_user WHERE shift_id = '" + shiftId.ToString() + "'", conn);
                conn.Open();
                MySqlDataReader reader1 = getEmpId.ExecuteReader();
                for (int i = 1; i <= n; i++)
                {
                    reader1.Read();
                    int empId = Convert.ToInt32(reader1["employee_id"]);
                    indexes.Add(empId);
                }
                reader1.Close();
                for (int i = 0; i < indexes.Count; i++)
                {
                    string sql = "SELECT id, firstName, lastName, email, password, address, position, department_id, salary, rank, start_date, birth_date, phone_number FROM user WHERE id = '" + indexes[i].ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int id = Convert.ToInt32(reader["id"]);
                    string firstname = Convert.ToString(reader["firstName"]);
                    string lastname = Convert.ToString(reader["lastName"]);
                    string email = Convert.ToString(reader["email"]);
                    string address = Convert.ToString(reader["address"]);
                    string phonenumber = Convert.ToString(reader["phone_number"]);
                    string position = Convert.ToString(reader["position"]);
                    string password = Convert.ToString(reader["password"]);
                    int department = Convert.ToInt32(reader["department_id"]);
                    int rank = Convert.ToInt32(reader["rank"]);
                    DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                    DateTime bday = Convert.ToDateTime(reader["birth_date"]);
                    double salary = Convert.ToDouble(reader["salary"]);

                    User u = new User(id, firstname, lastname, department, position, email, address, phonenumber, rank, salary, password, startDate, bday);
                    reader.Close();
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
            conn.Close();
        }

        public void FillChosenShift(Department dep)
        {
            //Fill listbox with people selected for the shift. 
            lbInShift.Items.Clear();
            foreach (User u in InShift)
            {
                lbInShift.Items.Add(u.GetInfo());
            }
        }

        public void FillFromDBByDept(Department dep)
        {
            //Fill listbox with all people with the department of the shift.
            lbAllPpl.Items.Clear();
            List<User> emps = new List<User>();
            foreach (User emp in AllEmps)
            {
                if (emp.Department == dep)
                { emps.Add(emp); }
            }
            foreach (User emp in emps)
            { lbAllPpl.Items.Add(emp.GetInfo()); }
            AllEmps = emps;
        }
    }
}
