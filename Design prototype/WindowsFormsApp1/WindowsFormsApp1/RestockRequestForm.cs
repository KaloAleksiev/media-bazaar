using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class RestockRequestForm : Form
    {
        int ItemId;
        DepotWorker depotWorker;


        string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        MySqlConnection conn;
        Stock stock = new Stock("Restock");

        public RestockRequestForm()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand GetAllItems = new MySqlCommand("SELECT item_id AS id, name AS name, description AS descr, amount_in_stock AS inStock, auto_restock AS ar, ar_limit AS arl FROM item;", conn);
            MySqlDataReader reader = GetAllItems.ExecuteReader();
            while (reader.Read())
            {
                int itemId = Convert.ToInt32(reader["id"]);
                string name = Convert.ToString(reader["name"]);
                string desc = Convert.ToString(reader["descr"]);
                int inStock = Convert.ToInt32(reader["inStock"]);
                bool ar = Convert.ToBoolean(reader["ar"]);
                int arl = Convert.ToInt32(reader["arl"]);
                Item item = new Item(itemId, name, desc, inStock, ar, arl);
                stock.AddItem(item);
            }
            conn.Close();
            for (int i = 0; i < stock.GetAllItems().Count; i++)
            {
                lbItems.Items.Add(stock.GetAllItems()[i].GetInfo());
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tbAmountRestockForm.Text);
            String date = DateTime.Now.ToString("yyyyMMdd");
            MySqlCommand CreateRequest = new MySqlCommand($"INSERT INTO restockrequest(item_id, amount, date) VALUES ({this.ItemId}, {amount}, {date})", conn);
            conn.Open();
            int succ = CreateRequest.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Request sent!");
        }
    }
}
