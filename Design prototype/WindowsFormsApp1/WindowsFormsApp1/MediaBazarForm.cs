using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Stock stock;
        ControlClass cc = new ControlClass();
        User currentUser;
        public Form1()
        {
            InitializeComponent();
            FillComboBox_Names();
            //Navigation Bar buttons Bounds
            btEmployee.SetBounds(140, 7, 200, 40);
            btSchedule.SetBounds(340, 7, 200, 40);
            btStatistics.SetBounds(540, 7, 200, 40);
            btStock.SetBounds(740, 7, 300, 40);
            btlogout.SetBounds(1040, 7, 200, 40);

            pLogin.Visible = true;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            //pLogin.Bounds = Screen.GetWorkingArea(this);

            //Bounds of Login form and its controls
            pLogin.SetBounds(0, 0, 1280, 800);
            tbUsername.SetBounds(745, 320, 200, 100);
            tbPassword.SetBounds(745, 373, 200, 100);
            btLogin.SetBounds(745, 405, 200, 30);

            //variable initialization
            stock = new Stock("Stock");
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand GetAllItems = new MySqlCommand("SELECT item_id AS id, name AS name, description AS descr, amount_in_stock AS inStock, auto_restock AS ar, ar_limit AS arl FROM item;", conn);
            MySqlDataReader reader2 = GetAllItems.ExecuteReader();
            while (reader2.Read())
            {
                int itemId = Convert.ToInt32(reader2["id"]);
                string name = Convert.ToString(reader2["name"]);
                string desc = Convert.ToString(reader2["descr"]);
                int inStock = Convert.ToInt32(reader2["inStock"]);
                bool ar = Convert.ToBoolean(reader2["ar"]);
                int arl = Convert.ToInt32(reader2["arl"]);
                Item item = new Item(itemId, name, desc, inStock, ar, arl);
                stock.AddItem(item);
            }
            conn.Close();

            for (int i = 0; i < stock.GetAllItems().Count; i++)
            {
                lbItems.Items.Add(stock.GetAllItems()[i].GetInfo());
            }
        }
        void FillComboBox_Names()
        {
            cmbNameAssign.Items.Clear();
            cmbNamePromote.Items.Clear();
            List<string> name = new List<string>();
            cc.ShowAllUsers(name);
            for (int i = 0; i < name.Count(); i++)
            {
                cmbNameAssign.Items.Add(name[i]);
                cmbNamePromote.Items.Add(name[i]);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";         
            MySqlConnection conn = new MySqlConnection(connStr);            
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) AS succ, id AS id FROM user WHERE email='" + tbUsername.Text + "' and password='" + tbPassword.Text + "'", conn);           
            MySqlDataReader reader2 = command.ExecuteReader();
            reader2.Read();
            int infoRead = Convert.ToInt32(reader2["succ"]);
            if (infoRead == 1)
            {
                int id = Convert.ToInt32(reader2["id"]);
                string function = cc.CheckFunction(id);
                reader2.Close();
                
                if (function == "employee")
                {
                    btSchedule.SetBounds(540, 7, 200, 40);                    
                    btStock.SetBounds(740, 7, 300, 40);
                    btlogout.SetBounds(1040, 7, 200, 40);
                    //pEmplyee.Visible = true;
                    EmployeePanel();
                    pLogin.Visible = false;
                    btEmployee.Visible = false;
                    btSchedule.Visible = false;
                    btStatistics.Visible = false;

                    MySqlConnection pullInfo = new MySqlConnection(connStr);
                    pullInfo.Open();
                    string sql = "SELECT u.firstname, u.lastname, u.email, u.password, u.address, u.start_date, u.phone_number, e.id, e.emp_number, e.department, e.salary FROM user AS u INNER JOIN employee AS e ON u.id = e.id WHERE u.id = '" + id.ToString() + "'";
                    MySqlCommand pullAll = new MySqlCommand(sql, pullInfo);
                    MySqlDataReader readerAll = pullAll.ExecuteReader();
                    readerAll.Read();
                    int empid = Convert.ToInt32(readerAll["emp_number"]);
                    string firstname = Convert.ToString(readerAll["firstName"]);
                    string lastname = Convert.ToString(readerAll["lastName"]);
                    string email = Convert.ToString(readerAll["email"]);
                    string address = Convert.ToString(readerAll["address"]);
                    string phonenumber = Convert.ToString(readerAll["phone_number"]);
                    string department = Convert.ToString(readerAll["department"]);
                    double salary = Convert.ToDouble(readerAll["salary"]);
                    currentUser = new Employee(id, empid, firstname, lastname, email, address, phonenumber, department, salary);
                    readerAll.Close();
                    pullInfo.Close();
                }
                else if (function == "manager")
                {
                    btSchedule.SetBounds(340, 7, 200, 40);
                    btStatistics.SetBounds(540, 7, 200, 40);
                    btStock.SetBounds(740, 7, 300, 40);
                    btlogout.SetBounds(1040, 7, 200, 40);
                    pEmplyee.Visible = true;
                    EmployeePanel();
                    pLogin.Visible = false;

                    MySqlConnection pullInfo = new MySqlConnection(connStr);
                    pullInfo.Open();
                    string sql = "SELECT u.firstname, u.lastname, u.email, u.password, u.address, u.start_date, u.phone_number, e.id, e.manager_id, e.salary FROM user AS u INNER JOIN manager AS e ON u.id = e.id WHERE u.id = '" + id.ToString() + "'";
                    MySqlCommand pullAll = new MySqlCommand(sql, pullInfo);
                    MySqlDataReader readerAll = pullAll.ExecuteReader();
                    readerAll.Read();
                    string firstname = Convert.ToString(readerAll["firstName"]);
                    string lastname = Convert.ToString(readerAll["lastName"]);
                    string email = Convert.ToString(readerAll["email"]);
                    string address = Convert.ToString(readerAll["address"]);
                    string phonenumber = Convert.ToString(readerAll["phone_number"]);
                    currentUser = new Manager(id, firstname, lastname, email, address, phonenumber);
                    readerAll.Close();
                    pullInfo.Close();
                }
                else if (function == "depotworker")
                {
                    btSchedule.SetBounds(540, 7, 200, 40);
                    btStock.SetBounds(740, 7, 300, 40);
                    btlogout.SetBounds(1040, 7, 200, 40);
                    //pEmplyee.Visible = true;
                    EmployeePanel();
                    pLogin.Visible = false;
                    btEmployee.Visible = false;
                    btSchedule.Visible = false;

                    MySqlConnection pullInfo = new MySqlConnection(connStr);
                    pullInfo.Open();
                    string sql = "SELECT u.firstname, u.lastname, u.email, u.password, u.address, u.start_date, u.phone_number, e.id, e.emp_number, e.salary FROM user AS u INNER JOIN depotworker AS e ON u.id = e.id WHERE u.id = '" + id.ToString() + "'";
                    MySqlCommand pullAll = new MySqlCommand(sql, pullInfo);
                    MySqlDataReader readerAll = pullAll.ExecuteReader();
                    readerAll.Read();
                    string firstname = Convert.ToString(readerAll["firstName"]);
                    string lastname = Convert.ToString(readerAll["lastName"]);
                    string email = Convert.ToString(readerAll["email"]);
                    string address = Convert.ToString(readerAll["address"]);
                    string phonenumber = Convert.ToString(readerAll["phone_number"]);
                    currentUser = new DepotWorker(id, firstname, lastname, email, address, phonenumber);
                    readerAll.Close();
                    pullInfo.Close();
                }
                else if (function == "administrator")
                {
                    pEmplyee.Visible = true;
                    EmployeePanel();
                    pLogin.Visible = false;

                    btEmployee.SetBounds(130, 7, 200, 40);
                    btSchedule.SetBounds(340, 7, 200, 40);
                    btStatistics.SetBounds(540, 7, 200, 40);
                    btStock.SetBounds(740, 7, 300, 40);
                    btlogout.SetBounds(1040, 7, 200, 40);

                    MySqlConnection pullInfo = new MySqlConnection(connStr);
                    pullInfo.Open();
                    string sql = "SELECT u.firstname, u.lastname, u.email, u.password, u.address, u.start_date, u.phone_number, e.id, e.admin_number FROM user AS u INNER JOIN administrator AS e ON u.id = e.id WHERE u.id = '" + id.ToString() + "'";
                    MySqlCommand pullAll = new MySqlCommand(sql, pullInfo);
                    MySqlDataReader readerAll = pullAll.ExecuteReader();
                    readerAll.Read();
                    string firstname = Convert.ToString(readerAll["firstName"]);
                    string lastname = Convert.ToString(readerAll["lastName"]);
                    string email = Convert.ToString(readerAll["email"]);
                    string address = Convert.ToString(readerAll["address"]);
                    string phonenumber = Convert.ToString(readerAll["phone_number"]);
                    currentUser = new Administrator(id, firstname, lastname, email, address, phonenumber);
                    readerAll.Close();
                    pullInfo.Close();
                }

            }
            else
            {
                MessageBox.Show("The credentials do not match");

                
                EmployeePanel();
                
            }
        }




        public void EmployeePanel()
        {
            //Bounds of Employee form and its controls
            pEmplyee.SetBounds(0, 60, 1280, 740);

            label2.SetBounds(180, 70, 80, 60);
            tbName.SetBounds(132, 90, 150, 100);
            label8.SetBounds(170, 120, 150, 100);
            tbAddress.SetBounds(132, 140, 150, 100);
            label9.SetBounds(165, 170, 150, 100);
            cmbDepartment.SetBounds(132, 190, 150, 100);

            label12.SetBounds(430, 70, 150, 100);
            tbLastName.SetBounds(420, 90, 150, 100);
            label16.SetBounds(430, 120, 150, 100);
            tbEmailAddress.SetBounds(420, 140, 150, 100);
            label13.SetBounds(430, 170, 230, 100);
            tbPhoneNumber.SetBounds(420, 190, 150, 100);

            btAddEmployee.SetBounds(150, 220, 400, 40);

            label4.SetBounds(200, 280, 400, 40);
            cmbNameAssign.SetBounds(160, 300, 200, 100);
            label1.SetBounds(430, 280, 150, 100);
            cmbDepartemntAssign.SetBounds(410, 300, 150, 100);
            btAssignToDepartment.SetBounds(150, 340, 400, 40);

            label10.SetBounds(200, 390, 100, 40);
            cmbNamePromote.SetBounds(160, 410, 200, 40);
            label11.SetBounds(430, 390, 150, 100);
            tbPromoteDepartment.SetBounds(410, 410, 150, 100);

            btnCheckInfoPromot.SetBounds(150, 440, 200, 40);
            btPromote.SetBounds(360, 440, 200, 40);

            lbEmployee.SetBounds(700, 50, 400, 550);

        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            //Hides all panels and dispaly the only the employee panel
            EmployeePanel();
            pLogin.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            pEmplyee.Visible = true;
        }


        private void btStatistics_Click(object sender, EventArgs e)
        {
            //Hides all panels and displays the only the Statistic panel
            pLogin.Visible = false;
            pEmplyee.Visible = false;
            pStatistics.Visible = true;
            pStock.Visible = false;
            pStatistics.SetBounds(0, 50, 1280, 750);

            //Bounds of Statistics form and its controls
            label5.SetBounds(320, 20, 200, 100);

            lbStatistics.SetBounds(150, 50, 400, 500);
           

            label6.SetBounds(600, 190, 300, 50);
            cmbDepartmentStats.SetBounds(720, 190, 180, 50);
            
            btViewItemStats.SetBounds(600, 230, 300, 50);
            btViewStatsOverall.SetBounds(600, 290, 300, 50);
            btViewDepartmentStats.SetBounds(600, 350, 300, 50);
            
            //fill the cmb with all the items 
            foreach (Item i in stock.GetAllItems())
            {
                lbStatistics.Items.Add(i.Name);
            }
        }

        private void btStock_Click(object sender, EventArgs e)
        {
            //Hides all panels and displays only the Stock Control panel
            pLogin.Visible = false;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = true;
            pStock.SetBounds(0, 50, 1280, 750);
            lbItems.SetBounds(150, 70, 400, 500);
            btSendRestockRequest.SetBounds(600, 310, 200, 40);


        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            //Hides all panels and takes you back to Login panel
            pLogin.Visible = true;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            pLogin.SetBounds(0, 0, 1280, 800);
            lbItems.SetBounds(50, 70, 500, 600);
            btSendRestockRequest.SetBounds(550, 680, 100, 40);
        }

        #region Stock




        private void btSendRestockRequest_Click(object sender, EventArgs e)
        {
            RestockRequestForm r = new RestockRequestForm(currentUser);
            r.Show(this);
        }
        #endregion

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            cc.CreateUser(tbName.Text, tbLastName.Text, tbEmailAddress.Text, tbAddress.Text, date, tbPhoneNumber.Text, cmbDepartment.SelectedItem.ToString());


            //int id = User.id;
            //DateTime start_date = DateTime.Now;

            //string password = tbLastName.Text + Convert.ToString(id);
            //string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        string insertData = "insert into user(id, firstname,lastname,email,password,address,start_date,phone_number)  VALUES (@id, @firstname,@lastname,@email,@password,@address,@start_date,@phone_number)";
            //        MySqlCommand command = new MySqlCommand(insertData, connection);
            //        command.Parameters.AddWithValue("@id", id);
            //        command.Parameters.AddWithValue("@firstname", tbName.Text);
            //        command.Parameters.AddWithValue("@lastname", tbLastName.Text);
            //        command.Parameters.AddWithValue("@email", tbEmailAddress.Text);
            //        command.Parameters.AddWithValue("@password", password);
            //        command.Parameters.AddWithValue("@address", tbAddress.Text);
            //        command.Parameters.AddWithValue("@start_date", start_date);
            //        command.Parameters.AddWithValue("@phone_number", tbPhoneNumber.Text);
            //        connection.Open();
            //        int result = command.ExecuteNonQuery();
            //        MessageBox.Show("Connected to database");
            //        MessageBox.Show("Data inserted successfully");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Failed to connect to database due to" + ex.ToString());
            //        MessageBox.Show("Failed to insert data due to" + ex.ToString());
            //    }

            //}

            //User newUser = new User(tbName.Text, tbLastName.Text, tbEmailAddress.Text, tbAddress.Text, tbPhoneNumber.Text);
            //string name = tbName.Text + " " + tbLastName.Text;
            //FillComboBox_Names();
        }


        private void btSchedule_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            CreateScheduleForm(dt);
        }

        public static void CreateScheduleForm(DateTime dt)
        {
            ScheduleForm frm = new ScheduleForm(dt);
            frm.Show();
        }

        private void btAssignToDepartment_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string department = cmbDepartemntAssign.SelectedItem.ToString();
            string name = cmbNameAssign.SelectedItem.ToString();
            User u;
            u = cc.ReturnUser(name);
            string m = cc.DeleteWorker(u.GetGottenID());
            MessageBox.Show(m);
            MessageBox.Show("Assigned succ");
        }

        private void btPromote_Click(object sender, EventArgs e)
        {

            string a = tbPromoteDepartment.Text;
            string name = cmbNamePromote.Text;
            if (a == "Manager")
            {
                MySqlConnection conn = new MySqlConnection(@"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234");
                string sql = "DELETE FROM employee WHERE where concat(firstName,' ', lastName) = @name;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                string message = cc.AssignToManager(cmbNamePromote.Text);
                MessageBox.Show(message);
            }
            else if (a == "Employee.TV")
            {
                string message = cc.AssignToEmployee(cmbNamePromote.Text, Department.TVs);

                MessageBox.Show(message);
            }
            else if (a == "Employee.Computer")
            {
                string message = cc.AssignToEmployee(cmbNamePromote.Text, Department.Computers);

                MessageBox.Show(message);
            }
            else if (a == "Employee.Phones")
            {
                string message = cc.AssignToEmployee(cmbNamePromote.Text, Department.Phones);

                MessageBox.Show(message);
            }
            else if (a == "Depo Workers")
            {
                string message = cc.AssignToDepotTW(cmbNamePromote.Text);

                MessageBox.Show(message);
            }

        }

        private void btnCheckInfoPromot_Click(object sender, EventArgs e)
        {
            string info = cc.ReturnWorkerInfo(cmbNamePromote.Text);
            MessageBox.Show(info);
        }

        #region Statistics
        private void btViewStatsOverall_Click(object sender, EventArgs e)
        {

            MessageBox.Show(cc.GetStatsOverall());
        }

        private void btViewItemStats_Click(object sender, EventArgs e)
        {
            try
            {

                Item selected = stock.GetItemByName(lbStatistics.SelectedItem.ToString());

                MessageBox.Show(cc.GetItemStats(selected));
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You have to select an item first!");
            }

            lbStatistics.SelectedItem = null;

        }

        private void btViewDepartmentStats_Click(object sender, EventArgs e)
        {
            string department = "";
            try
            {

                department = cmbDepartmentStats.SelectedItem.ToString();
                MessageBox.Show(cc.GetStatsPerDepartment(department));

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You have to select a department first!");
            }
            cmbDepartmentStats.SelectedItem = null;
        }
        #endregion
    }
}


