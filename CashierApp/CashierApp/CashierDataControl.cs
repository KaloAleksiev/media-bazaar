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
    public class CashierDataControl
    {
        private string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";

        public Cashier CheckCredentials(string password, string email)
        {
            Cashier c;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT id, firstName, lastName FROM User WHERE email = '{email}' AND password = '{password}' AND end_date IS NULL OR end_date = '';", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                int id = Convert.ToInt32(reader["id"]);
                string fNname = Convert.ToString(reader["firstName"]);
                string lName = Convert.ToString(reader["lastName"]);           
                reader.Close();
                conn.Close();
   
                c = new Cashier(id, fNname, lName, email, password);
                return c;
                
            }
            reader.Close();
            conn.Close();
            return null;
        }

        public string GetForgottenPassword(string email, string Fname)
        {
            string pass = "";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string GetPass = $"SELECT password FROM user WHERE email = '{email}' AND firstName = '{Fname}'";
            MySqlCommand cmd = new MySqlCommand(GetPass, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                pass = Convert.ToString(reader["password"]);
                reader.Close();
                conn.Close();
                return pass;

            }
            reader.Close();
            conn.Close();
            return pass;
        }

        public int GetMaxSaleId()
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT MAX(sale_id) AS max FROM sale", conn);
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

        public void AddSaleToDB(Sale s)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string addSale = $"INSERT into sale( sale_id, total_price, employee_id, sale_date)" +
                $"VALUES (@sid, @price, @cId, @date)";
            MySqlCommand cmd = new MySqlCommand(addSale, conn);
            cmd.Parameters.AddWithValue("@sid", s.Id);
            cmd.Parameters.AddWithValue("@price", s.Price);
            cmd.Parameters.AddWithValue("@cId", s.UserId);
            cmd.Parameters.AddWithValue("@date",s.Date);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            foreach(KeyValuePair<Item, int> i in s.GetItems())
            {
                string addSaleItem = $"INSERT into sale_item( sale_id, item_id, quantity)" +
                $"VALUES (@sid, @iID, @qua)";
                MySqlCommand cmd1 = new MySqlCommand(addSaleItem, conn);
                cmd1.Parameters.AddWithValue("@sid", s.Id);
                cmd1.Parameters.AddWithValue("@iID", i.Key.Id);
                cmd1.Parameters.AddWithValue("@qua", i.Value);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                string reduceQuantity = $"UPDATE item SET amount_in_stock = @quantity WHERE item_id = @id";
                MySqlCommand cmd2 = new MySqlCommand(reduceQuantity, conn);
                cmd2.Parameters.AddWithValue("@quantity", i.Key.AmountInStock);
                cmd2.Parameters.AddWithValue("@id", i.Key.Id);                
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
