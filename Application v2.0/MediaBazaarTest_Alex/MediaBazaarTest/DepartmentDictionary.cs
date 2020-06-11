using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MediaBazaarTest
{
    public class DepartmentDictionary
    {
        private Dictionary<string, int> deps;
        //For DB
        private string connstr;
        private MySqlConnection conn;

        public DepartmentDictionary()
        {
            deps = new Dictionary<string, int>();
            //for db
            this.connstr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            this.conn = new MySqlConnection(connstr);
            GetAllDepartmentsFromDB();
        }

        private void GetAllDepartmentsFromDB()
        {
            this.deps.Clear();
            MySqlCommand cmd = new MySqlCommand($"SELECT department_id AS id, name FROM department", this.conn);
            this.conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = Convert.ToString(reader["name"]);
                this.deps.Add(name, id);
            }
            reader.Close();
            this.conn.Close();          
        }

        public Dictionary<string, int> GetAllDepartments()
        {
            return this.deps;
        }

        public int GetIdByName(string demo)
        {
            foreach(KeyValuePair<string, int> e in this.deps)
            {
                if(e.Key == demo)
                {
                    return e.Value;
                }
            }
            return 0;
        }

        public void AddDepartment(string name)
        {
            MySqlCommand AddDep = new MySqlCommand($"INSERT INTO department (name) VALUES(@name)", this.conn);
            AddDep.Parameters.AddWithValue("@name", name);
            this.conn.Open();
            AddDep.ExecuteNonQuery();
            this.conn.Close();
            GetAllDepartmentsFromDB();

        }

        public void ChangeName(int id, string s)
        {
            MySqlCommand ChangeName = new MySqlCommand($"UPDATE department SET name = @name WHERE department_id = @id", this.conn);
            ChangeName.Parameters.AddWithValue("@name", s);
            ChangeName.Parameters.AddWithValue("@id", id);
            this.conn.Open();
            ChangeName.ExecuteNonQuery();
            this.conn.Close();
            GetAllDepartmentsFromDB();
        }

        public void DeleteDepartment(int id)
        {
            MySqlCommand DeleteDep = new MySqlCommand($"DELETE FROM department WHERE department_id = @id", this.conn);
            DeleteDep.Parameters.AddWithValue("@id", id);
            this.conn.Open();
            DeleteDep.ExecuteNonQuery();
            this.conn.Close();
            GetAllDepartmentsFromDB();

        }
    }
}
