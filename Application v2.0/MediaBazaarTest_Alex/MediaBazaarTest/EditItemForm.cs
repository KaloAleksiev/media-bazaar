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
    public partial class EditItemForm : Form
    {
        Item item;
        Stock s;
        StockDataControl sdc;
        User currentUser;

        public EditItemForm(Item i, Stock s, User u)
        {
            InitializeComponent();
            this.item = i;
            this.s = s;
            currentUser = u;
            sdc = new StockDataControl();

            if (item == null)
            {
                lbTitle.Text = $"Adding a new item...";
                btnSaveChanges.Enabled = false;
                btnSaveChanges.Visible = false;
                btnSaveItem.Height *= 2;
            }
            else
            {
                lbTitle.Text = $"Now editing item {item.Name}, with ID {item.Id}";
                btnSaveItem.Enabled = false;
                btnSaveItem.Visible = false;
                tbItemName.Text = item.Name;
                rtbItemDesc.Text = item.Description;
                cbDep.SelectedItem = item.Department;
            }
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            Item newItem = sdc.AddItemToDB(tbItemName.Text, rtbItemDesc.Text, cbDep.SelectedIndex + 1);
            if (newItem != null)
            {
                MessageBox.Show("Item successfully saved!");
                s.AddItem(newItem);
                this.Close();
            }
            else { MessageBox.Show("Something went wrong!"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (sdc.EditItem(item.Id, tbItemName.Text, rtbItemDesc.Text, cbDep.SelectedIndex + 1))
            {
                item.UpdateItem(tbItemName.Text, rtbItemDesc.Text, ((Department)cbDep.SelectedIndex + 1).ToString());
                MessageBox.Show("Changes successfully saved!");
                this.Close();
            }
            else { MessageBox.Show("Something went wrong!"); }
        }
    }
}
