using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace CashierApp
{
    public class DepartmentDictionary
    {
        private Dictionary<string, int> deps;

        public DepartmentDictionary()
        {
            deps = new Dictionary<string, int>();            
        }

        public Dictionary<string, int> GetAllDepartmentsFromDB()
        {
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand($"SELECT department_id AS id, name FROM department", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = Convert.ToString(reader["name"]);
                this.deps.Add(name, id);
            }

            reader.Close();
            conn.Close();
            return this.deps;
        }
    }
}
