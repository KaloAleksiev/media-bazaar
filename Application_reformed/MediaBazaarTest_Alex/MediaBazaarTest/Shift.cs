using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    class Shift
    {
        //Variables
        private int shiftId;
        private DateTime date;
        List<User> users;

        //Propperties
        public Department Department { get; set; }
        public ShiftType Type { get; set; }
        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }

        //Constructors
        public Shift(int shiftId, DateTime date, ShiftType type, Department department)
        {
            ShiftId = shiftId;
            this.date = date;
            this.Type = type;
            this.Department = department;

            users = new List<User>();
        }

        //Methods
        public void AddUser(User person)
        { users.Add(person); }

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
                MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
                conn.Open();
                MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                reader1.Read();
                int n = Convert.ToInt32(reader1["EN"]);
                reader1.Close();
                conn.Close();
                List<int> indexe = new List<int>();
                MySqlCommand GetIDsOfPeopl = new MySqlCommand("SELECT employee_id FROM shift_user WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
                conn.Open();
                MySqlDataReader reader3 = GetIDsOfPeopl.ExecuteReader();
                for (int i = 0; i < n; i++)
                {
                    reader3.Read();
                    int empId = Convert.ToInt32(reader3["employee_id"]);
                    indexe.Add(empId);
                }
                reader3.Close();
                conn.Close();
                //List<int> toDelete = new List<int>();
                if (n > users.Count)
                {
                    for (int i = 0; i < indexe.Count; i++)
                    {
                        bool flag = true;
                        for (int j = 0; j < users.Count; j++)
                        {
                            if (users[j].Id == indexe[i])
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            MySqlCommand DeleteShift = new MySqlCommand("DELETE FROM shift_user WHERE employee_id = '" + indexe[i].ToString() + "'", conn);
                            conn.Open();
                            int j = DeleteShift.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        bool flag = true;
                        for (int j = 0; j < indexe.Count; j++)
                        {
                            if (users[i].Id == indexe[j])
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO shift_user (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                            AddPersonToShiftDB.Parameters.AddWithValue("@employee_id", users[i].Id.ToString());
                            AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                            conn.Open();
                            int k = AddPersonToShiftDB.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
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
                foreach (User user in users)
                {
                    table = "shift_user";
                    MySqlCommand AddPersonToShiftDB3 = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                    AddPersonToShiftDB3.Parameters.AddWithValue("@employee_id", user.Id);
                    AddPersonToShiftDB3.Parameters.AddWithValue("@shift_id", this.shiftId);
                    conn.Open();
                    int h = AddPersonToShiftDB3.ExecuteNonQuery();
                    conn.Close();
                }
                
            }
        }

        public List<User> GetAllUsers()
        { return users; }

        public void RemoveUser(User u)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == u.Id)
                { users.Remove(users[i]); }
            }
        }
    }
}
