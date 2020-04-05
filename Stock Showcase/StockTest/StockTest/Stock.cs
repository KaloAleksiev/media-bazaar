using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StockTest
{
    class Stock
    {
        private string name;
        public static List<Item> items;

        public Stock(string name)
        {
            items = new List<Item>();
            this.name = name;
            GetStockFromDB();
        }

        public void AddItem(Item item)
        { items.Add(item); }

        public List<Item> GetAllItems()
        { return items; }

        public Item GetItemById(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == id)
                { return items[i]; }
            }
            return null;
        }

        public Item GetItemByName(string name)
        {
            foreach (Item i in items)
            {
                if (i.Name == name)
                { return i; }
            }
            return null;
        }

        public string GetStockInfo()
        {
            string returnStr = "";
            foreach (Item i in items)
            { returnStr += $"{i.GetInfo()} \n"; }
            return returnStr;
        }

        public void GetStockFromDB()
        {
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand GetAllItems = new MySqlCommand("SELECT item_id, name, description, department_id, amount_in_stock FROM item", conn);
            conn.Open();
            MySqlDataReader reader = GetAllItems.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["item_id"]);
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();
                string department = ((Department)Convert.ToInt32(reader["department_id"])).ToString();
                int amnt = Convert.ToInt32(reader["amount_in_stock"]);
                AddItem(new Item(id, name, description, department, amnt));
            }
            reader.Close();
            conn.Close();
        }
    }
}
