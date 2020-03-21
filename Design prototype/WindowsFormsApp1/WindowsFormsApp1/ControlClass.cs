﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class ControlClass
    {
        string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";

        
        
        public string AssignToDepotTW(string name)
        {
            int id = ReturnWorkerID(name);
            int emp_id = DepotWorker.depoNumber;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string insertData = "INSERT INTO workers(id, function) VALUES(@id, 'depotworker'); INSERT INTO depotworker( id, salary) VALUES ( @id,'2500')";
                    MySqlCommand command = new MySqlCommand(insertData, connection);

                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return "Depot Worker Added Succesfully!";

                }
                catch (Exception ex)
                {
                    return "Failed to connect to database due to" + ex.ToString();
                }
            }

        }
        public string AssignToEmployee(string name, Department department)
        {

            int id = ReturnWorkerID(name);
            string dep = department.ToString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string insertData = "INSERT INTO workers(id, function) VALUES(@id, 'employee'); INSERT INTO employee(id,department, salary) VALUES (@id, @department,'3000')";
                    MySqlCommand command = new MySqlCommand(insertData, connection);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@department", dep);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return "Employee Added Succesfully!";

                }
                catch (Exception ex)
                {
                    return "Failed to connect to database due to" + ex.ToString();
                }
            }

        }
        public string AssignToManager(string name)
        {
            int id = ReturnWorkerID(name);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string insertData = "INSERT INTO workers(id, function) VALUES(@id, 'manager');INSERT INTO manager(id, salary) VALUES(@id, '4000');";
                    MySqlCommand command = new MySqlCommand(insertData, connection);

                    command.Parameters.AddWithValue("@id", id);
                    // command1.Parameters.AddWithValue("@id", id);
                    // command.Parameters.AddWithValue("@manager_id", manager_id);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    // int result1 = command1.ExecuteNonQuery();
                    return "yey";

                }
                catch (Exception ex)
                {
                    return "Failed to connect to database due to" + ex.ToString();
                }
            }
        }
        public void ShowAllUsers(IList<string> names)
        {
            string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            string sqlStatement = "SELECT concat(firstName,' ', lastName) as name FROM user";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader = null;
            try
            {
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string name = (string)reader["name"];
                    names.Add(name);
                }
            }
            finally
            {
                connection.Close();
            }

        }
        public int ReturnWorkerIDbyEmail(string email)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string sql = "SELECT id FROM user where email = @email;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            conn.Open();
            Object result = cmd.ExecuteScalar();
            int id = -1;
            if (result != null)
            {
                id = Convert.ToInt32(result);
            }
            conn.Close();
            return id;
        }
        public int ReturnWorkerID(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string sql = "SELECT id FROM user where concat(firstName,' ', lastName) = @name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            conn.Open();
            Object result = cmd.ExecuteScalar();
            int id = -1;
            if (result != null)
            {
                id = Convert.ToInt32(result);
            }
            conn.Close();
            return id;
        }
        public string ReturnWorkerInfo(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT u.id as id, u.firstName as firstName, u.lastName as lastName, w.function as function FROM user u INNER JOIN workers w on u.id = w.id where concat(firstName,' ', lastName) = @name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["id"]);
            string firstname = Convert.ToString(reader["firstName"]);
            string lastname = Convert.ToString(reader["lastName"]);
            string function = Convert.ToString(reader["function"]);
            return $"{id }  {firstname }  {lastname }  {function }";
            conn.Close();
        }

        public User ReturnUser(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT u.id as id, u.firstName as firstName, u.lastName as lastName, u.email as email ,u.address as address,u.phone_number as phonenumber,w.function as function FROM user u INNER JOIN workers w on u.id = w.id where concat(firstName,' ', lastName) = @name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["id"]);
            string firstname = Convert.ToString(reader["firstName"]);
            string lastname = Convert.ToString(reader["lastName"]);
            string function = Convert.ToString(reader["function"]);
            string email = Convert.ToString(reader["email"]);
            string address = Convert.ToString(reader["address"]);
            string phonenumber = Convert.ToString(reader["phonenumber"]);
            User u = new User(firstname, lastname, email, address, phonenumber);
            return u;
            conn.Close();
        }
        public string CheckFunction(int id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataReader myReader = null;
            MySqlCommand myCommand = new MySqlCommand("SELECT id FROM `employee`", conn);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["id"].ToString() == id.ToString())
                {
                    conn.Close();
                    return "Employee";
                }
            }
            myCommand = new MySqlCommand("SELECT id FROM `manager`", conn);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["id"].ToString() == id.ToString())
                {
                    conn.Close();
                    return "Manager";
                }
            }
            myCommand = new MySqlCommand("SELECT id FROM `depotworker`", conn);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["id"].ToString() == id.ToString())
                {
                    conn.Close();
                    return "DepotWorker";
                }
            }
            myCommand = new MySqlCommand("SELECT id FROM `administrator`", conn);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["id"].ToString() == id.ToString())
                {
                    conn.Close();
                    return "Administrator";
                }
            }
            conn.Close();
            return "NA";
        }

    }
       
    
}

