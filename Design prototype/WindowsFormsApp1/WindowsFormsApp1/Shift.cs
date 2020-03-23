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
        private int shiftId;
        private DateTime date;
        List<User> people;

        public Shift(DateTime date, ShiftType type, Department department)
        {
            this.date = date;
            this.Type = type;
            this.Department = department;
            
            people = new List<User>();
        }

        public Shift(int shiftId, DateTime date, ShiftType type, Department department)
        {
            ShiftId = shiftId;
            this.date = date;
            this.Type = type;
            this.Department = department;

            people = new List<User>();
        }

        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }

        public Department Department
        { get; set; }

        public ShiftType Type
        { get; set; }

        public void AddPerson(User person)
        { people.Add(person); }

        public void AddShiftToDB()
        {
            //See if a shift with the ID already exists.
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand CheckForShift = new MySqlCommand("SELECT COUNT(*) AS cnt FROM shift WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
            conn.Open();
            MySqlDataReader reader = CheckForShift.ExecuteReader();
            reader.Read();
            int o = Convert.ToInt32(reader["cnt"]);
            reader.Close();
            conn.Close();
            //If it exists, just add people to the shift_user table with the correct shift ID. Might have to delete all the rows for the shift first, because they could repeat.
            if (o > 0)
            {
                //HELP
            }
            else
            {
                //If the shift doesn't exist, create it.
                MySqlCommand AddShiftToDB = new MySqlCommand("INSERT INTO shift (date, type, department) VALUES (@date, @type, @department)", conn);
                AddShiftToDB.Parameters.AddWithValue("@date", this.date.ToString("yyyy-MM-dd"));
                AddShiftToDB.Parameters.AddWithValue("@type", this.Type);
                AddShiftToDB.Parameters.AddWithValue("@department", this.Department.ToString());
                conn.Open();
                int i = AddShiftToDB.ExecuteNonQuery();
                conn.Close();
                //Get the shifts ID. (Redundant, since I added shiftID as an input parameter, but I'm scared that removing this might mess up the code.)
                MySqlCommand GetShiftID = new MySqlCommand("SELECT shift_id FROM shift WHERE date = '" + this.date.ToString("yyyy=-MM-dd") + "' AND type = '" + this.Type.ToString() + "' AND department = '" + this.Department.ToString() + "'", conn);
                conn.Open();
                MySqlDataReader reader1 = GetShiftID.ExecuteReader();
                reader1.Read();
                this.shiftId = Convert.ToInt32(reader1["shift_id"]);
                reader1.Close();
                conn.Close();
                string table = null;
                //Add each user from the people list into the shift_user table.
                foreach (User user in people)
                {
                    table = "shift_user";
                    MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                    AddPersonToShiftDB.Parameters.AddWithValue("@employee_id", user.GetGottenID());
                    AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                    conn.Open();
                    int k = AddPersonToShiftDB.ExecuteNonQuery();
                    conn.Close();
                }
            }       
        }

        public List<Employee> GetAllEmps()
        {
            List<Employee> emps = new List<Employee>();
            foreach (Employee emp in people)
            { emps.Add(emp); }
            return emps;
        }

        public void RemovePerson(User u)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].GetGottenID() == u.GetGottenID())
                { people.Remove(people[i]); }
            }
        }
    }
}
