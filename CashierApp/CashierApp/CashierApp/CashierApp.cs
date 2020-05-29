using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp
{
    public partial class CashierApp : Form
    {
        private Stock s;
        private CashierControl cc;
        //departments
        private DepartmentDictionary dd;
        private Dictionary<string, int> deps;

        public CashierApp()
        {
            InitializeComponent(); 
            //initialize objects, get the departments
            s = new Stock();
            cc = new CashierControl();
            

        }
        
        private void CashierApp_Load(object sender, EventArgs e)
        {
            //Departments
            dd = new DepartmentDictionary();
            this.deps = dd.GetAllDepartmentsFromDB();
            cbDepartment.Items.Add("All");
            foreach (KeyValuePair<string, int> entry in deps)
            {
                cbDepartment.Items.Add(entry.Key);
            }

            //appropiate size
            this.Size = new System.Drawing.Size(764, 390);

            //For the dgv
            dgvStock.AutoGenerateColumns = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.MultiSelect = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStock.RowTemplate.MinimumHeight = 54;
            FillUpDgv("", "All");
            dgvStock.ClearSelection();

        }

        #region LOGIN
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Login credential/s missing! Fill in both of the textboxes!");
            }
            else
            {
                if (cc.Login(tbPassword.Text, tbEmail.Text) == true)
                {

                    //Clear tbs
                    tbEmail.Text = "";
                    tbPassword.Text = "";
                    lblForgottenPass.Visible = false;
                    lblLoggedIn.Visible = true;
                    pLogin.Visible = false;
                    Cashier c = cc.GetLoggedIn();
                    lbGreetings.Text = $"Hello, {c.Name} {c.Surname}";
                    this.Size = new System.Drawing.Size(1342, 650);
                }
                else
                {
                    lblLoggedIn.Visible = true;
                    lblForgottenPass.Visible = true;
                }
            }
        }

        private void lblForgottenPass_Click(object sender, EventArgs e)
        {
            pForgottenPass.Visible = true;
        }

        private void btBackRetrievePass_Click(object sender, EventArgs e)
        {
            pForgottenPass.Visible = false;
        }

        private void btRetrievePass_Click(object sender, EventArgs e)
        {
            string email = tbEmailRetrievePass.Text;
            string name = tbNameRetrievePass.Text;
            if (tbEmailRetrievePass.Text == "" || tbNameRetrievePass.Text == "")
            {
                MessageBox.Show("Please fill in all the textboxes!");
            }
            else
            {
                if (cc.CheckEmail(email))
                {
                    if (cc.GetForgottenPass(email, name))
                    {
                        MessageBox.Show($"Your password has been sent to {email} email!");
                        tbEmailRetrievePass.Text = "";
                        tbNameRetrievePass.Text = "";
                        pForgottenPass.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show($"No account has been found with the supplied credentials");
                    }
                }
                else
                {
                    MessageBox.Show("Email should be in this format: user@gmail.com");
                }

            }
        }
        #endregion

        #region DGV UPDATE
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FillUpDgv(tbSearch.Text,cbDepartment.Text);
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUpDgv(tbSearch.Text, cbDepartment.Text);
        }

        private void FillUpDgv(string demo, string dep)
        {
            dgvStock.Rows.Clear();
            List<Item> items = s.GetAllItems();
            foreach(Item i in items)
            {
                if(demo == "" && dep=="All")
                {
                    dgvStock.Rows.Add(new object[]
                    {   i.Id,
                        i.Name,
                        i.Description.Replace(",", ",\n"),
                        i.Department,
                        i.AmountInStock
                    });
                }

                if (demo == "" && i.Department == dep)
                {
                    dgvStock.Rows.Add(new object[]
                    {   i.Id,
                        i.Name,
                        i.Description.Replace(",", ",\n"),
                        i.Department,
                        i.AmountInStock
                    });
                }

                if (demo != "" && i.Name.ToLower().Contains(demo) && dep == "All")
                {
                    dgvStock.Rows.Add(new object[]
                    {   
                       i.Id,
                       i.Name,
                       i.Description.Replace(",", ",\n"),
                       i.Department,
                       i.AmountInStock
                    });
                }

                if(demo != "" && i.Name.ToLower().Contains(demo) && i.Department == dep)
                {
                    dgvStock.Rows.Add(new object[]
                    {
                       i.Id,
                       i.Name,
                       i.Description.Replace(",", ",\n"),
                       i.Department,
                       i.AmountInStock
                    });
                }
                
            }
        }

        #endregion

        #region SALE CONTROL
        private Item GetItemById(int id)
        {
            foreach (Item i in s.GetAllItems())
            {
                if(i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }
        private void btAddItemToSale_Click(object sender, EventArgs e)
        {
            if(dgvStock.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select an item from the list!");
            }
            else
            {
                Item i = GetItemById(Convert.ToInt32(dgvStock.SelectedCells[0].Value));
                int amount = Convert.ToInt32(nudAmount.Value);
                if (amount < 1)
                {
                    MessageBox.Show("Select a bigger amount than 0!");
                }
                else
                {
                    if(i.AmountInStock < amount)
                    {
                        MessageBox.Show($"Currently in stock: {i.AmountInStock} units of the item!");
                    }
                    else
                    {
                        bool hui = cc.AddItemToSale(i, amount);
                        if (hui == false)
                        {
                            MessageBox.Show($"This item is already in the order");
                        }
                        else
                        {
                            UpdateLB();
                            dgvStock.ClearSelection();
                            nudAmount.Value = 0;
                        }                       
                    }
                }                
            }           
        }

        private void UpdateLB()
        {
            lbCurrentlyInOrder.Items.Clear();
            foreach(KeyValuePair<Item, int> i in cc.GetCurrentItems())
            {
                lbCurrentlyInOrder.Items.Add($"{i.Key.Name} X {i.Value} - {(i.Key.Price*i.Value).ToString("C")}");
            }
        }

        private void btRemoveItemFromSale_Click(object sender, EventArgs e)
        {
            if(lbCurrentlyInOrder.SelectedItems.Count > 0)
            {
                string s = lbCurrentlyInOrder.SelectedItem.ToString();
                cc.RemoveItemFromSale(s);
                UpdateLB();
            }
            else
            {
                MessageBox.Show("Select an Item first!");
            }
            
        }

        private void btCompleteSale_Click(object sender, EventArgs e)
        {
            if(cc.GetCurrentItems().Count > 0)
            {
                string s = cc.CompleteSale();
                MessageBox.Show(s);
                UpdateLB();
                FillUpDgv("", "All");
            }
            else
            {
                MessageBox.Show("There are no items to be sold!");
            }
           
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
           
            if(dgvStock.SelectedRows.Count < 1)
            {
                lblSelected.Text = "No item selected";
            }
            else
            {
                lblSelected.Text = dgvStock.SelectedCells[1].Value.ToString();
            }
        }

        #endregion

        
    }
}
