using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CashierApp;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    public class UserDataControl
    {
        private string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        private DepartmentDictionary dd;
        private Dictionary<string, int> deps;
        public UserDataControl()
        {
            dd = new DepartmentDictionary();
            deps = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> entry in dd.GetAllDepartments())
            {
                deps.Add(entry.Key, entry.Value);
            }
        }

        public User CheckCredentials(string password, string email)
        {
            User u;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT id, firstName, lastName, start_date, end_date, birth_date, position, department_id, phone_number, salary, rank, city, zipcode, address, gender FROM User WHERE email = '{email}' AND password = '{password}' AND end_date IS NULL OR end_date = '';", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                int id = Convert.ToInt32(reader["id"]);
                string fNname = Convert.ToString(reader["firstName"]);
                string lName = Convert.ToString(reader["lastName"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime bDate = Convert.ToDateTime(reader["birth_date"]);
                int depId = Convert.ToInt32(reader["department_id"]);
                string pos = Convert.ToString(reader["position"]);
                string city = Convert.ToString(reader["city"]);
                string zipcode = Convert.ToString(reader["zipcode"]);
                string gender = Convert.ToString(reader["gender"]);
                string address = Convert.ToString(reader["address"]);
                string phonenumber = Convert.ToString(reader["phone_number"]);
                double salary = Convert.ToDouble(reader["salary"]);
                int rank = Convert.ToInt32(reader["rank"]);
                reader.Close();
                conn.Close();
                foreach (KeyValuePair<string, int> e in this.deps)
                {
                    if (e.Value == depId)
                    {
                        string dep = e.Key;
                        u = new User(id, fNname, lName, dep, pos, email, city, zipcode, address, phonenumber, rank, salary, password, startDate, bDate, gender);
                        return u;
                    }
                }
            }
            reader.Close();
            conn.Close();
            return null;
        }

        public int GetMaxId()
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT MAX(id) AS max FROM user", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.IsDBNull(0))
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(reader["max"]);
                id++;
            }
            reader.Close();
            conn.Close();
            return id;
        }

        public void AddUserToDB(User u)
        {
            int dep = 0;
            //Get the appropriate department
            foreach (KeyValuePair<string, int> e in this.deps)
            {
                if (e.Key == u.Department)
                {
                    dep = e.Value;
                }
            }
            MySqlConnection conn = new MySqlConnection(connectionString);
            string addUser = $"INSERT into user( id, firstName, lastName, address, email, password, position, department_id, phone_number, salary, rank, start_date, birth_date, city, zipcode, gender)" +
                $"VALUES (@id, @firstName, @lastName, @address, @email, @password, @position, @department_id, @phone_number, @salary, @rank, @start_date, @birth_date, @city, @zipcode, @gender)";
            MySqlCommand cmd = new MySqlCommand(addUser, conn);
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@firstName", u.FName);
            cmd.Parameters.AddWithValue("@lastName", u.LName);
            cmd.Parameters.AddWithValue("@address", u.Address);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@position", u.Position.ToString());
            cmd.Parameters.AddWithValue("@department_id", dep);
            cmd.Parameters.AddWithValue("@phone_number", u.Phone);
            cmd.Parameters.AddWithValue("@salary", u.Salary);
            cmd.Parameters.AddWithValue("@rank", u.Rank);
            cmd.Parameters.AddWithValue("@start_date", u.StartDate);
            //cmd.Parameters.AddWithValue("@end_date", u.EndDate);
            cmd.Parameters.AddWithValue("@birth_date", u.BDay);
            cmd.Parameters.AddWithValue("@city", u.City);
            cmd.Parameters.AddWithValue("@zipcode", u.Zipcode);
            cmd.Parameters.AddWithValue("@gender", u.Gender);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            string getInfo = $"SELECT id, firstName, lastName, address, email, password, city, zipcode, gender, position, department_id, phone_number, salary, rank, start_date, birth_date FROM user WHERE end_date IS NULL OR end_date = '';";
            MySqlCommand cmd = new MySqlCommand(getInfo, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string fNname = Convert.ToString(reader["firstName"]);
                string lName = Convert.ToString(reader["lastName"]);
                string address = Convert.ToString(reader["address"]);
                string city = Convert.ToString(reader["city"]);
                string zipcode = Convert.ToString(reader["zipcode"]);
                string email = Convert.ToString(reader["email"]);
                string password = Convert.ToString(reader["password"]);
                string pos = Convert.ToString(reader["position"]);
                int depId = Convert.ToInt32(reader["department_id"]);
                string phonenumber = Convert.ToString(reader["phone_number"]);
                double salary = Convert.ToDouble(reader["salary"]);
                int rank = Convert.ToInt32(reader["rank"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime bDate = Convert.ToDateTime(reader["birth_date"]);
                string gender = Convert.ToString(reader["gender"]);
                string dep = "";
                foreach (KeyValuePair<string, int> e in this.deps)
                {
                    if (e.Value == depId)
                    {
                        dep = e.Key;
                    }
                }
                users.Add(new User(id, fNname, lName, dep, pos, email, city, zipcode, address, phonenumber, rank, salary, password, startDate, bDate, gender));
            }
            reader.Close();
            conn.Close();
            return users;
        }

        public void FireEmployeeDB(int id, DateTime date)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string AddEndDate = $"UPDATE user SET end_date = @end_date WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(AddEndDate, conn);
            cmd.Parameters.AddWithValue("@end_date", date);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ChangeEmployeeDepartment(int id, string dep)
        {
            int depId = 0;
            foreach (KeyValuePair<string, int> e in this.deps)
            {
                if (e.Key == dep)
                {
                    depId = e.Value;
                }
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            string ChangeDep = $"UPDATE user SET department_id = @department_id WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(ChangeDep, conn);
            cmd.Parameters.AddWithValue("@department_id", depId);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ChangeEmployeePosition(int id, Position pos)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string ChangePos = $"UPDATE user SET position = @position WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(ChangePos, conn);
            cmd.Parameters.AddWithValue("@position", pos.ToString());
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ChangeEmployeeRank(int id, int rank)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string ChangeRank = $"UPDATE user SET rank = @rank WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(ChangeRank, conn);
            cmd.Parameters.AddWithValue("@rank", rank);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ChangeEmployeeSalary(int id, double salary)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string ChangeSalary = $"UPDATE user SET salary = @salary WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(ChangeSalary, conn);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public string GetForgottenPassword(string email, string Fname)
        {
            string pass = "";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string GetPass = $"SELECT password FROM user WHERE email = '{email}' AND firstName = '{Fname}'";
            MySqlCommand cmd = new MySqlCommand(GetPass, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                pass = Convert.ToString(reader["password"]);
                reader.Close();
                conn.Close();
                return pass;

            }
            reader.Close();
            conn.Close();
            return pass;
        }

        public void AcceptLeaveRequest(LeaveRequest request)
        {
            int id = request.Id;
            MySqlConnection conn = new MySqlConnection(connectionString);
            string acceptRequest = $"UPDATE leaverequest SET accepted = 1 WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(acceptRequest, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DenyLeaveRequest(LeaveRequest request)
        {
            int id = request.Id;
            MySqlConnection conn = new MySqlConnection(connectionString);
            string denyRequest = $"UPDATE leaverequest SET accepted = 0 WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(denyRequest, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<LeaveRequest> GetLeaveRequestsFromDB()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            List<LeaveRequest> requests = new List<LeaveRequest>();
            MySqlCommand GetAllRequests = new MySqlCommand("SELECT id, user_id, start_date, end_date, accepted FROM leaverequest", conn);
            conn.Open();
            MySqlDataReader reader = GetAllRequests.ExecuteReader();
            while (reader.Read())
            {
                int requestId = Convert.ToInt32(reader["id"]);
                int userId = Convert.ToInt32(reader["user_id"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime endDate = Convert.ToDateTime(reader["end_date"]);
                bool accepted = Convert.ToBoolean(reader["accepted"]);
                requests.Add(new LeaveRequest(requestId, userId, startDate, endDate, accepted));
            }
            reader.Close();
            conn.Close();
            return requests;
        }
    }
}
