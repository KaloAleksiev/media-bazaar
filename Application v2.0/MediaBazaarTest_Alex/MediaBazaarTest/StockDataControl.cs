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
            conn.Open();
            MySqlCommand UpdateAR = new MySqlCommand("UPDATE item SET auto_restock = @autoRestock WHERE item_id = @id", conn);
            UpdateAR.Parameters.AddWithValue("@autoRestock", i.AutoRestock);
            UpdateAR.Parameters.AddWithValue("@id", i.Id);
            int k = UpdateAR.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            MySqlCommand UpdateARL = new MySqlCommand("UPDATE item SET ar_limit = @arLimit WHERE item_id = @id", conn);
            UpdateARL.Parameters.AddWithValue("@arLimit", i.ARLimit);
            k += UpdateAR.ExecuteNonQuery();
            conn.Close();
            return Convert.ToBoolean(k - 1);
        }

        public bool CreateRestockRequest(RestockRequest rr, User user)
        {
            MySqlCommand CreateRequest = new MySqlCommand("INSERT INTO restockrequest (item_id, amount, emp_id, date) VALUES (@itemId, @amount, @emp_id, @date)", conn);
            CreateRequest.Parameters.AddWithValue("@itemId", rr.Item.Id);
            CreateRequest.Parameters.AddWithValue("@amount", rr.Amount);
            CreateRequest.Parameters.AddWithValue("@emp_id", user.Id);
            CreateRequest.Parameters.AddWithValue("@date", rr.Date.ToString("yyyy-MM-dd"));
            conn.Open();
            int k = CreateRequest.ExecuteNonQuery();
            conn.Close();
            if (k > 0)
            { return true; }
            else { return false; }
        }

        public Item AddItemToDB(string name, string desc, int depId)
        {
            MySqlCommand CreateItem = new MySqlCommand("INSERT INTO item (name, description, department_id, amount_in_stock, auto_restock, ar_limit) VALUES (@name, @description, @depId, 0, 0, 3)", conn);
            CreateItem.Parameters.AddWithValue("@name", name);
            CreateItem.Parameters.AddWithValue("@description", desc);
            CreateItem.Parameters.AddWithValue("@depId", depId);
            conn.Open();
            int k = CreateItem.ExecuteNonQuery();

            if (k > 0)
            {
                Item newItem;
                MySqlCommand GetAllItems = new MySqlCommand("SELECT item_id, name, description, department_id, amount_in_stock, auto_restock, ar_limit FROM item WHERE item_id = (SELECT MAX(item_id) FROM item)", conn);
                MySqlDataReader reader = GetAllItems.ExecuteReader();
                reader.Read();
                int id = Convert.ToInt32(reader["item_id"]);
                string name1 = reader["name"].ToString();
                string description = reader["description"].ToString();
                string department = ((Department)Convert.ToInt32(reader["department_id"])).ToString();
                int amnt = Convert.ToInt32(reader["amount_in_stock"]);
                bool auto = Convert.ToBoolean(reader["auto_restock"]);
                int arLimit = Convert.ToInt32(reader["ar_limit"]);
                newItem = new Item(id, name1, description, department, amnt, auto, arLimit);
                conn.Close();
                return newItem;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public bool EditItem(int id, string name, string desc, int depId)
        {
            conn.Open();
            MySqlCommand CreateItem = new MySqlCommand("UPDATE item SET name = @name, description = @description, department_id = @deptId WHERE item_id = @itemid", conn);
            CreateItem.Parameters.AddWithValue("@name", name);
            CreateItem.Parameters.AddWithValue("@description", desc);
            CreateItem.Parameters.AddWithValue("@deptId", depId);
            CreateItem.Parameters.AddWithValue("@itemid", id);
            int k = CreateItem.ExecuteNonQuery();
            conn.Close();
            return Convert.ToBoolean(k);
        }

        public bool DeleteItem(Item i)
        {
            MySqlCommand DeleteItem = new MySqlCommand("DELETE FROM item WHERE item_id = '" + i.Id + "'", conn);
            conn.Open();
            int j = DeleteItem.ExecuteNonQuery();
            conn.Close();
            return Convert.ToBoolean(j);
        }
    }
}
