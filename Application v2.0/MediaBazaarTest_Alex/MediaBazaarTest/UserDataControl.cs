﻿using System;
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
            MySqlCommand cmd = new MySqlCommand($"SELECT id, firstName, lastName, start_date, end_date, birth_date, position, department_id, phone_number, salary, rank, address FROM User WHERE email = '{email}' AND password = '{password}' AND end_date IS NULL OR end_date = '';", conn);
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
                int dep = Convert.ToInt32(reader["department_id"]);
                string pos = Convert.ToString(reader["position"]);
                string address = Convert.ToString(reader["address"]);
                string phonenumber = Convert.ToString(reader["phone_number"]);
                double salary = Convert.ToDouble(reader["salary"]);
                int rank = Convert.ToInt32(reader["rank"]);
                reader.Close();
                conn.Close();
                u = new User(id, fNname, lName, dep, pos, email, address, phonenumber, rank, salary, password, startDate, bDate);
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
            string addUser = $"INSERT into user( id, firstName, lastName, address, email, password, position, department_id, phone_number, salary, rank, start_date, birth_date)" +
                $"VALUES (@id, @firstName, @lastName, @address, @email, @password, @position, @department_id, @phone_number, @salary, @rank, @start_date, @birth_date)";
            MySqlCommand cmd = new MySqlCommand(addUser, conn);
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@firstName", u.FName);
            cmd.Parameters.AddWithValue("@lastName", u.LName);
            cmd.Parameters.AddWithValue("@address", u.Address);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@position", u.Position.ToString());
            cmd.Parameters.AddWithValue("@department_id", (int)dep);
            cmd.Parameters.AddWithValue("@phone_number", u.Phone);
            cmd.Parameters.AddWithValue("@salary", u.Salary);
            cmd.Parameters.AddWithValue("@rank", u.Rank);
            cmd.Parameters.AddWithValue("@start_date", u.StartDate);
            //cmd.Parameters.AddWithValue("@end_date", u.EndDate);
            cmd.Parameters.AddWithValue("@birth_date", u.BDay);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            string getInfo = $"SELECT id, firstName, lastName, address, email, password, position, department_id, phone_number, salary, rank, start_date, birth_date FROM user WHERE end_date IS NULL OR end_date = '';";
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
                DateTime bDate = Convert.ToDateTime(reader["birth_date"]);

                users.Add(new User(id, fNname, lName, dep, pos, email, address, phonenumber, rank, salary, password, startDate, bDate));
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

        public void ChangeEmployeeDepartment(int id, Department dep)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string ChangeDep = $"UPDATE user SET department_id = @department_id WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(ChangeDep, conn);
            cmd.Parameters.AddWithValue("@department_id", (int)dep);
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


    }
}