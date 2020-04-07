using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    public class UserDataControl
    {
        private string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
      
        public User CheckCredentials(string password, string email)
        {
            User u;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT id, fName, lName, start_date, end_date, birth_date, position, department, phone_number, salary, rank, address FROM User WHERE password LIKE {password} AND email LIKE = {email}",conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                int id = Convert.ToInt32(reader["id"]);
                string fNname = Convert.ToString(reader["fName"]);
                string lName = Convert.ToString(reader["lName"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime endDate = Convert.ToDateTime(reader["end_date"]);
                DateTime bDate = Convert.ToDateTime(reader["birth_date"]);
                int dep = Convert.ToInt32(reader["department"]);
                string pos = Convert.ToString(reader["position"]);
                string address = Convert.ToString(reader["address"]);
                string phonenumber = Convert.ToString(reader["phone_number"]);
                double salary = Convert.ToDouble(reader["salary"]);
                int rank = Convert.ToInt32(reader["rank"]);
                reader.Close();
                conn.Close();
                u = new User(id, fNname, lName, dep, pos, email, address, phonenumber, rank, salary, password, startDate, endDate, bDate);
                return u;
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
            Department dep = u.Department;
            MySqlConnection conn = new MySqlConnection(connectionString);
            string addUser = $"INSERT into user( id, firstName, lastName, address, email, password, position, department_id, phone_number, salary, rank, start_date, end_date, birth_date)" +
                $"VALUES (@id, @firstName, @lastName, @address, @email, @password, @position, @department_id, @phone_number, @salary, @rank, @start_date, @end_date, @birth_date)";
            MySqlCommand cmd = new MySqlCommand(addUser, conn);
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@firstName", u.FName);
            cmd.Parameters.AddWithValue("@lastName", u.LName);
            cmd.Parameters.AddWithValue("@address", u.Address);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@position", u.Position.ToString());
            cmd.Parameters.AddWithValue("@department_id",(int)dep);
            cmd.Parameters.AddWithValue("@phone_number", u.Phone);
            cmd.Parameters.AddWithValue("@salary", u.Salary);
            cmd.Parameters.AddWithValue("@rank", u.Rank);
            cmd.Parameters.AddWithValue("@start_date", u.StartDate);
            cmd.Parameters.AddWithValue("@end_date", u.EndDate);
            cmd.Parameters.AddWithValue("@birth_date", u.BDay);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            string getInfo = $"SELECT id, firstName, lastName, address, email, password, position, department_id, phone_number, salary, rank, start_date, end_date, birth_date FROM user";
            MySqlCommand cmd = new MySqlCommand(getInfo, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string fNname = Convert.ToString(reader["firstName"]);
                string lName = Convert.ToString(reader["lastName"]);
                string address = Convert.ToString(reader["address"]);
                string email = Convert.ToString(reader["email"]);
                string password = Convert.ToString(reader["password"]);
                string pos = Convert.ToString(reader["position"]);
                int dep = Convert.ToInt32(reader["department_id"]);
                string phonenumber = Convert.ToString(reader["phone_number"]);
                double salary = Convert.ToDouble(reader["salary"]);
                int rank = Convert.ToInt32(reader["rank"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime endDate = Convert.ToDateTime(reader["end_date"]);
                DateTime bDate = Convert.ToDateTime(reader["birth_date"]);         
                
                users.Add(new User(id, fNname, lName, dep, pos, email, address, phonenumber, rank, salary, password, startDate, endDate, bDate));
            }
            reader.Close();
            conn.Close();
            return users;
        }
    }
}
