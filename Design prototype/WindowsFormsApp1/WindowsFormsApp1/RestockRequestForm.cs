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
        private int ItemId;
        string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        MySqlConnection conn;
        public RestockRequestForm()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr);
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
