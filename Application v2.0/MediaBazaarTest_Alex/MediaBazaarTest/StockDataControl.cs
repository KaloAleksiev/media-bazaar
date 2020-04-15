using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    class StockDataControl
    {
        string connStr;
        MySqlConnection conn;

        public StockDataControl()
        {
            connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            conn = new MySqlConnection(connStr);
        }

        public List<Item> GetStockFromDB()
        {
            List<Item> items = new List<Item>();
            MySqlCommand GetAllItems = new MySqlCommand("SELECT item_id, name, description, department_id, amount_in_stock, auto_restock, ar_limit FROM item", conn);
            conn.Open();
            MySqlDataReader reader = GetAllItems.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["item_id"]);
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();
                string department = ((Department)Convert.ToInt32(reader["department_id"])).ToString();
                int amnt = Convert.ToInt32(reader["amount_in_stock"]);
                bool auto = Convert.ToBoolean(reader["auto_restock"]);
                int arLimit = Convert.ToInt32(reader["ar_limit"]);
                items.Add(new Item(id, name, description, department, amnt, auto, arLimit));
            }
            reader.Close();
            conn.Close();
            return items;
        }

        public bool ChangeAutoRequest(Item i)
        {
            MySqlCommand UpdateAR = new MySqlCommand("UPDATE item SET auto_restock = @autoRestock, ar_limit = @arLimit WHERE item_id = @id", conn);
            UpdateAR.Parameters.AddWithValue("@auto_restock", i.AutoRestock);
            UpdateAR.Parameters.AddWithValue("@arLimit", i.ARLimit);
            UpdateAR.Parameters.AddWithValue("@id", i.Id);
            conn.Open();
            int k = UpdateAR.ExecuteNonQuery();
            conn.Close();
            if (k > 0)
            { return true; }
            else { return false; }
        }

        public bool CreateRestockRequest(RestockRequest rr, /*User user*/ int userId)
        {
            MySqlCommand CreateRequest = new MySqlCommand("INSERT INTO restockrequest (item_id, amount, emp_id, date) VALUES (@itemId, @amount, @emp_id, @date)", conn);
            CreateRequest.Parameters.AddWithValue("@itemId", rr.Item.Id);
            CreateRequest.Parameters.AddWithValue("@amount", rr.Amount);
            CreateRequest.Parameters.AddWithValue("@emp_id", userId);
            CreateRequest.Parameters.AddWithValue("@date", rr.Date.ToString("yyyy-MM-dd"));
            conn.Open();
            int k = CreateRequest.ExecuteNonQuery();
            conn.Close();
            if (k > 0)
            { return true; }
            else { return false; }
        }
    }
}
