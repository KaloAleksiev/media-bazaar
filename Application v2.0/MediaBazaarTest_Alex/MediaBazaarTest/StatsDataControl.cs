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
        private string connectionString ;
        private MySqlConnection conn;
        private Stock s;

        public StatsDataControl()
        {
            this.connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            this.conn = new MySqlConnection(connectionString);
            s = new Stock("hui");
        }

        public string GetItemStats(Item i)
        {
            string info = $"{i.Name}";            
            this.conn.Open();
            MySqlCommand GetRestockRequests = new MySqlCommand($"SELECT request_id AS id, amount AS amount FROM restockrequest WHERE item_id = {i.Id};", this.conn);
            MySqlDataReader reader = GetRestockRequests.ExecuteReader();

            while (reader.Read())
            {
                info += $"\n------------------------------------\n";
                info += $"Request ID: {Convert.ToString(reader["id"])}; Amount: {Convert.ToString(reader["amount"])}";
                info += $"\n------------------------------------\n";
            }
            this.conn.Close();
            return info;
        }

        public double GetAvgSalaryPerDepartment(int dep)
        {

            this.conn.Open();
            MySqlCommand GetAvarageSalary = new MySqlCommand($" SELECT AVG(salary) AS avarageSalary FROM user WHERE department_id = {dep};", this.conn);
            MySqlDataReader reader = GetAvarageSalary.ExecuteReader();
            reader.Read();
            double avgSalary = Convert.ToDouble(reader["avarageSalary"]);
            reader.Close();
            this.conn.Close();
            return avgSalary;
        }

        public double GetAvarageSalaryOverall()
        {
            this.conn.Open();            
            MySqlCommand GetAvarageSalary = new MySqlCommand($" SELECT AVG(salary) AS avarageSalary FROM user;", this.conn);
            MySqlDataReader reader = GetAvarageSalary.ExecuteReader();
            reader.Read();
            double avgSalary = Convert.ToDouble(reader["avarageSalary"]);
            reader.Close();
            this.conn.Close();
            return avgSalary;
        }

        public List<int> GetPostitionCountPerDep(int dep)
        {
            List<int> count = new List<int>();
            List<string> positions = new List<string>{"Administrator", "Manager","DepotWorker","Employee"};
            
            this.conn.Open();
            foreach(string s in positions)
            {
                MySqlCommand GetEmployeeCount = new MySqlCommand($"SELECT COUNT(id) AS c FROM user WHERE department_id = {dep} AND position = '{s}';", this.conn);
                MySqlDataReader reader = GetEmployeeCount.ExecuteReader();
                reader.Read();
                int empCount = Convert.ToInt32(reader["c"]);
                reader.Close();
                count.Add(empCount);
            }
            this.conn.Close();
            return count;
        }

        public List<int> GetItemsCountPerDepartment()
        {
            List<int> count = new List<int>();

            this.conn.Open();
            for(int i = 1; i <= 3; i++)
            {
                MySqlCommand GetItemsCount = new MySqlCommand($"SELECT COUNT(item_id) AS c FROM item WHERE department_id = {i};", this.conn);
                MySqlDataReader reader = GetItemsCount.ExecuteReader();
                reader.Read();
                int itemCount = Convert.ToInt32(reader["c"]);
                reader.Close();
                count.Add(itemCount);
            }
            this.conn.Close();
            return count;
        }

        public List<KeyValuePair<int,int>> GetBestSellingItems()
        {
            //the first int in the dictionary is the ITEM_ID, the 2nd one- the quantity.
            Dictionary<int, int> soldItems = new Dictionary<int, int>();            
            MySqlCommand GetSalesCount = new MySqlCommand($"SELECT item_id, SUM(quantity) AS c FROM sale_item GROUP BY item_id ;", this.conn);
            this.conn.Open();
            MySqlDataReader reader = GetSalesCount.ExecuteReader();
            while (reader.Read())
            {
                soldItems.Add(Convert.ToInt32(reader["item_id"]), Convert.ToInt32(reader["c"]));
            }
            this.conn.Close();         
            var list = soldItems.OrderByDescending(d=>d.Value).ToList();           
            return list;
        }

        public List<KeyValuePair<int, int>> GetBestEmployees()
        {
            Dictionary<int, int> emps = new Dictionary<int, int>();           
            MySqlCommand GetEmpsCount = new MySqlCommand($"SELECT employee_id, COUNT(sale_id) AS c FROM sale GROUP BY employee_id ;", this.conn);
            this.conn.Open();
            MySqlDataReader reader = GetEmpsCount.ExecuteReader();
            while (reader.Read())
            {
                emps.Add(Convert.ToInt32(reader["employee_id"]), Convert.ToInt32(reader["c"]));
            }
            this.conn.Close();
            var list = emps.OrderByDescending(d => d.Value).ToList();
            return list;
        }

        public double GetRevenuePerDep(int id)
        {
            Dictionary<Item, int> items = new Dictionary<Item, int>();
            double revenue = 0;

            MySqlCommand GetRevenue = new MySqlCommand($"SELECT item_id, quantity FROM sale_item WHERE item_id IN (SELECT item_id FROM item WHERE department_id = {id});", this.conn);
            this.conn.Open();
            MySqlDataReader reader = GetRevenue.ExecuteReader();
            while (reader.Read())
            {
                Item i = s.GetItemById(Convert.ToInt32(reader["item_id"]));
                int amount = Convert.ToInt32(reader["quantity"]);
                if (items.ContainsKey(i))
                {
                    items[i] += amount; 
                }
                else
                {
                    items.Add(i, amount);
                }                
            }
            this.conn.Close();
            
            foreach(KeyValuePair<Item, int> i in items)
            {
                revenue += i.Key.Price * i.Value;
            }

            return revenue;
        }
    }
}
