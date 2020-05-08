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
    public partial class StockForm : Form
    {
        Stock s;
        StockDataControl sdc;
        int j = 0;
        UserControl uc;
        List<Item> foundItems;

        public StockForm(UserControl userControl)
        {
            InitializeComponent();
            sdc = new StockDataControl();
            foundItems = new List<Item>();
            s = new Stock("this");
            uc = userControl;
            s.AddAllStock(sdc.GetStockFromDB());
            dgvStock.AutoGenerateColumns = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.MultiSelect = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStock.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStock.RowTemplate.MinimumHeight = 54;
            ShowStock(s.GetAllItems());
        }

        public void ShowStock(List<Item> items)
        {
            dgvStock.Rows.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                dgvStock.Rows.Add(new object[]
                                      {   item.Id,
                                          item.Name,
                                          item.Description.Replace(",", ",\n"),
                                          item.Department,
                                          item.AmountInStock.ToString()
                                      });
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Item selectedItem = GetSelectedItem();
            RestockForm frm = new RestockForm(selectedItem, s, uc.GetLoggedIn());
            frm.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            foundItems.Clear();

            foreach (Item item in s.GetAllItems())
            {
                if (item.Name.ToLower().Contains(tbSearch.Text.ToLower()))
                { foundItems.Add(item); }
            }

            ShowStock(foundItems);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            Item selectedItem = GetSelectedItem();
            EditItemForm frm = new EditItemForm(selectedItem, s, uc.GetLoggedIn());
            frm.FormClosed += new FormClosedEventHandler(UpdateGUIOnClose);
            frm.Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            Item selectedItem = GetSelectedItem();
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {selectedItem.Name}?", "Sure", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (sdc.DeleteItem(GetSelectedItem()))
                {
                    MessageBox.Show("Item successfully deleted.");
                    s.DeleteItem(selectedItem);
                    UpdateGUI();
                }
                else { MessageBox.Show("Something went wrong!"); }
            }
            else if (dialogResult == DialogResult.No) { MessageBox.Show("Item has not been deleted."); }
        }

        public Item GetSelectedItem()
        {
            foreach (Item i in s.GetAllItems())
            {
                if (i.Id == Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value))
                { return i; }
            }
            return null;
        }

        public void UpdateGUIOnClose(object sender, EventArgs e)
        {
            ShowStock(s.GetAllItems());
            tbSearch.Text = null;
        }

        public void UpdateGUI()
        {
            ShowStock(s.GetAllItems());
            tbSearch.Text = null;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            EditItemForm frm = new EditItemForm(null, s, uc.GetLoggedIn());
            frm.FormClosed += new FormClosedEventHandler(UpdateGUIOnClose);
            frm.Show();
        }
    }
}
