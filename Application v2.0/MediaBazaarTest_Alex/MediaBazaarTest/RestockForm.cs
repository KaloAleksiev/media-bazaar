using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarTest
{
    public partial class RestockForm : Form
    {
        Item item;
        Stock s;
        StockDataControl sdc;
        User currentUser;
        bool auto;
        public RestockForm(Item i, Stock s, User u)
        {
            InitializeComponent();
            this.item = i;
            this.s = s;
            auto = item.AutoRestock;
            currentUser = u;
            sdc = new StockDataControl();
            lbInfo.Text += item.Name;
            lbAutoRequest.Text = $"Auto Request: {item.AutoRestock.ToString()}.";
            if (item.AutoRestock)
            { btnAutoRequest.Text = "Turn off"; }
            else { btnAutoRequest.Text = "Turn on"; }
            nudLimit.Value = item.ARLimit;
            lbInfo.Left = 10;
            lbInfo.Width = this.Width - 10;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (sdc.CreateRestockRequest(s.CreateRequest(item, Convert.ToInt32(nudAmount.Value), currentUser.Id), currentUser))
            {
                MessageBox.Show("Restock Request sent.");
                this.Close();
            }
            else { MessageBox.Show("Something went wrong."); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            while (item.AutoRestock != auto)
            { item.ToggleAutoRequest(); }
            this.Close();
        }

        private void btnAutoRequest_Click(object sender, EventArgs e)
        {
            item.ToggleAutoRequest();
            lbAutoRequest.Text = $"Auto Request: {item.AutoRestock.ToString()}.";
            if (item.AutoRestock)
            { btnAutoRequest.Text = "Turn off"; }
            else { btnAutoRequest.Text = "Turn on"; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            auto = item.AutoRestock;
            item.ChangeARLimit(Convert.ToInt32(nudAmount.Value));
            if (sdc.ChangeAutoRequest(item))
            { MessageBox.Show("Auto Request updated."); }
            else { MessageBox.Show("Something went wrong."); }
        }
    }
}
