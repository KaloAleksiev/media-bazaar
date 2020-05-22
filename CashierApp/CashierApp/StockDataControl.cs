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
    class StockDataControl
    {
        private readonly string connStr;
        private readonly MySqlConnection conn;
        private readonly DepartmentDictionary dd;

        public StockDataControl()
        {
            connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            conn = new MySqlConnection(connStr);
            dd = new DepartmentDictionary();
        }

        public List<Item> GetStockFromDB()
        {
            Dictionary<string, int> deps = dd.GetAllDepartmentsFromDB();
            List<Item> items = new List<Item>();
            MySqlCommand GetAllItems = new MySqlCommand("SELECT item_id, name, description, department_id, amount_in_stock, auto_restock,selling_price, ar_limit FROM item", conn);
            conn.Open();
            MySqlDataReader reader = GetAllItems.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["item_id"]);
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();
                
                string department = null;
                foreach (KeyValuePair<string, int> entry in deps)
                {
                    if (entry.Value == Convert.ToInt32(reader["department_id"]))
                    {
                        department = entry.Key;
                    }
                }

                int amnt = Convert.ToInt32(reader["amount_in_stock"]);
                bool auto = Convert.ToBoolean(reader["auto_restock"]);
                int arLimit = Convert.ToInt32(reader["ar_limit"]);
                double price = Convert.ToDouble(reader["selling_price"]);
                items.Add(new Item(id, name, description, department, amnt, auto, arLimit, price));
            }
            reader.Close();
            conn.Close();
            return items;
        }  

    }
}

