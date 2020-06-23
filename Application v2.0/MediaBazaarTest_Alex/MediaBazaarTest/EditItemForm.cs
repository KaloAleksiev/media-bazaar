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
        DepartmentDictionary dd;

        public EditItemForm(Item i, Stock s, User u)
        {
            InitializeComponent();
            this.item = i;
            this.s = s;
            currentUser = u;
            sdc = new StockDataControl();
            dd = new DepartmentDictionary();
            //Set the departments in the comboBox
            foreach(KeyValuePair<string, int> p in dd.GetAllDepartments())
            {
                cbDep.Items.Add(p.Key);
            }

            //determine where u update the item of create a new one
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
                tbSellingPrice.Text = this.item.Sprice.ToString();
                tbRestockPrice.Text = this.item.Rprice.ToString();
            }
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbItemName.Text != "" && rtbItemDesc.Text != "" && cbDep.SelectedIndex > -1)
                {
                    Item newItem = sdc.AddItemToDB(tbItemName.Text, rtbItemDesc.Text, cbDep.SelectedIndex + 1, Convert.ToDouble(tbSellingPrice.Text), Convert.ToDouble(tbRestockPrice.Text));
                    if (newItem != null)
                    {
                        MessageBox.Show("Item successfully saved!");
                        s.AddItem(newItem);
                        this.Close();
                    }
                    else { MessageBox.Show("Something went wrong!"); }
                }
                else { MessageBox.Show("Please fill out all the fields!"); }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("The prices should be numeric values!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbItemName.Text != "" && rtbItemDesc.Text != "" && cbDep.SelectedIndex > -1)
                {
                    if (sdc.EditItem(item.Id, tbItemName.Text, rtbItemDesc.Text, cbDep.SelectedIndex + 1, Convert.ToDouble(tbSellingPrice.Text), Convert.ToDouble(tbRestockPrice.Text)))
                    {
                        item.UpdateItem(tbItemName.Text, rtbItemDesc.Text, cbDep.SelectedItem.ToString());
                        MessageBox.Show("Changes successfully saved!");
                        this.Close();
                    }
                    else { MessageBox.Show("Something went wrong!"); }
                }
                else { MessageBox.Show("Please fill out all the fields!"); }
            }            
            catch (FormatException ex)
            {
                MessageBox.Show("The prices should be numeric values!");
            }
        }
    }
}
