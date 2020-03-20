using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Shift
    {
        string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        MySqlConnection conn;

        private int shiftId;
        private DateTime date;
        private ShiftType type;
        List<User> people;
        private Department department;

        public Shift(DateTime date, ShiftType type, Department department)
        {
            this.date = date;
            this.type = type;
            this.department = department;

            people = new List<User>();
        }

        public void AddPerson(User person)
        { people.Add(person); }

        public void AddShiftToDB()
        {
            MySqlCommand AddShiftToDB = new MySqlCommand("INSERT INTO shift (date, type, department) VALUES (@date, @type, @department)", conn);
            AddShiftToDB.Parameters.AddWithValue("@date", this.date.ToString("yyyy-MM-dd"));
            AddShiftToDB.Parameters.AddWithValue("@type", this.type);
            AddShiftToDB.Parameters.AddWithValue("@department", this.department);
            conn.Open();
            int i = AddShiftToDB.ExecuteNonQuery();
            conn.Close();
            MySqlCommand GetShiftID = new MySqlCommand("SELECT id FROM shift WHERE date = '" + this.date.ToString("yyyy=-MM-dd") + "' AND type = '" + this.type + "' AND department = '" + this.department + "'", conn);
            conn.Open();
            MySqlDataReader reader1 = GetShiftID.ExecuteReader();
            reader1.Read();
            this.shiftId = Convert.ToInt32(reader1["id"]);
            reader1.Close();
            conn.Close();
            string table = null;

            foreach (Employee user in people)
            {
                table = "shift_employee";
                MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@demployee_id, @shift_id)", conn);
           //     AddPersonToShiftDB.Parameters.AddWithValue("@demployee_id", user.Id);
                AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                conn.Open();
                int j = AddPersonToShiftDB.ExecuteNonQuery();
                conn.Close();
            }

            foreach (DepotWorker user in people)
            {
                table = "shift_depot";
                MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@demployee_id, @shift_id)", conn);
             //   AddPersonToShiftDB.Parameters.AddWithValue("@demployee_id", user.EmpNumber);
                AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                conn.Open();
                int j = AddPersonToShiftDB.ExecuteNonQuery();
                conn.Close();
            }

            foreach (Manager user in people)
            {
                table = "shift_manager";
                MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@demployee_id, @shift_id)", conn);
                //AddPersonToShiftDB.Parameters.AddWithValue("@employee_id", user.ManagerId);
                AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                conn.Open();
                int j = AddPersonToShiftDB.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
