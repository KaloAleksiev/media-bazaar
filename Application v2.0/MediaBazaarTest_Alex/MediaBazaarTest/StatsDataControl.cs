using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    public class StatsDataControl
    {
        private string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";   

        public string GetItemStats(Item i)
        {
            string info = $"{i.Name}";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand GetRestockRequests = new MySqlCommand($"SELECT request_id AS id, amount AS amount FROM restockrequest WHERE item_id = {i.Id};", conn);
            MySqlDataReader reader = GetRestockRequests.ExecuteReader();

            while (reader.Read())
            {
                info += $"\n------------------------------------\n";
                info += $"Request ID: {Convert.ToString(reader["id"])}; Amount: {Convert.ToString(reader["amount"])}";
                info += $"\n------------------------------------\n";
            }
            conn.Close();
            return info;
        }

        public double GetAvgSalaryPerDepartment(int dep)
        {                        
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand GetAvarageSalary = new MySqlCommand($" SELECT AVG(salary) AS avarageSalary FROM user WHERE department_id = {dep};", conn);
            MySqlDataReader reader = GetAvarageSalary.ExecuteReader();
            reader.Read();
            double avgSalary = Convert.ToDouble(reader["avarageSalary"]);
            reader.Close();
            conn.Close();
            return avgSalary;
        }

        public double GetAvarageSalaryOverall()
        {                                   
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();            
            MySqlCommand GetAvarageSalary = new MySqlCommand($" SELECT AVG(salary) AS avarageSalary FROM user;", conn);
            MySqlDataReader reader = GetAvarageSalary.ExecuteReader();
            reader.Read();
            double avgSalary = Convert.ToDouble(reader["avarageSalary"]);
            reader.Close();                       
            conn.Close();
            return avgSalary;
        }

        public List<int> GetPostitionCountPerDep(int dep)
        {
            List<int> count = new List<int>();
            List<string> positions = new List<string>{"Administrator", "Manager","DepotWorker","Employee"};
            MySqlConnection conn = new MySqlConnection(connectionString);            
            conn.Open();
            foreach(string s in positions)
            {
                MySqlCommand GetEmployeeCount = new MySqlCommand($"SELECT COUNT(id) AS c FROM user WHERE department_id = {dep} AND position = '{s}';", conn);
                MySqlDataReader reader = GetEmployeeCount.ExecuteReader();
                reader.Read();
                int empCount = Convert.ToInt32(reader["c"]);
                reader.Close();
                count.Add(empCount);
            }
            conn.Close();
            return count;
        }

        public List<int> GetItemsCountPerDepartment()
        {
            List<int> count = new List<int>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            for(int i = 1; i <= 3; i++)
            {
                MySqlCommand GetItemsCount = new MySqlCommand($"SELECT COUNT(item_id) AS c FROM item WHERE department_id = {i};", conn);
                MySqlDataReader reader = GetItemsCount.ExecuteReader();
                reader.Read();
                int itemCount = Convert.ToInt32(reader["c"]);
                reader.Close();
                count.Add(itemCount);
            }
            conn.Close();
            return count;
        }

        public List<KeyValuePair<int,int>> GetBestSellingItems()
        {
            //the first int in the dictionary is the ITEM_ID, the 2nd one- the quantity.
            Dictionary<int, int> soldItems = new Dictionary<int, int>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand GetSalesCount = new MySqlCommand($"SELECT item_id, SUM(quantity) AS c FROM sale_item GROUP BY item_id ;", conn);
            conn.Open();
            MySqlDataReader reader = GetSalesCount.ExecuteReader();
            while (reader.Read())
            {
                soldItems.Add(Convert.ToInt32(reader["item_id"]), Convert.ToInt32(reader["c"]));
            }
            conn.Close();         
            var list = soldItems.OrderByDescending(d=>d.Value).ToList();           
            return list;
        }

        public List<KeyValuePair<int, int>> GetBestEmployees()
        {
            Dictionary<int, int> emps = new Dictionary<int, int>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand GetEmpsCount = new MySqlCommand($"SELECT employee_id, COUNT(sale_id) AS c FROM sale GROUP BY employee_id ;", conn);
            conn.Open();
            MySqlDataReader reader = GetEmpsCount.ExecuteReader();
            while (reader.Read())
            {
                emps.Add(Convert.ToInt32(reader["employee_id"]), Convert.ToInt32(reader["c"]));
            }
            conn.Close();
            var list = emps.OrderByDescending(d => d.Value).ToList();
            return list;
        }
    }
}
