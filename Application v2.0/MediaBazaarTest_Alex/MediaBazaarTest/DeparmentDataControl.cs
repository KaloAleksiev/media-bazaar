using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    public class DeparmentDataControl
    {
        private string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";

        public List<DepartmentClass> GetAllDepartments()
        {
            List<DepartmentClass> deps = new List<DepartmentClass>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"department_id AS id, name FROM department", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = Convert.ToString(reader["name"]);
                deps.Add(new DepartmentClass(id, name));
            }
           
            reader.Close();
            conn.Close();
            return deps;
        }

        public void AddDepartment(DepartmentClass dep)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO department (department_id, name) VALUES (@id, @name)", conn);
            cmd.Parameters.AddWithValue("@id", dep.Id);
            cmd.Parameters.AddWithValue("@name", dep.Name);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int GetMaxId()
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT MAX(department_id) AS max FROM department", conn);
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
    }
}
