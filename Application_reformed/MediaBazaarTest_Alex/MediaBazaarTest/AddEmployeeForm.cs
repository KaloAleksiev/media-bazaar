using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using S22.Imap;


namespace MediaBazaarTest
{
    public partial class AddEmployeeForm : Form
    {
        private UserControl uc;
        public AddEmployeeForm()
        {
            InitializeComponent();
            uc = new UserControl();
            cmbDepartment.DataSource = Enum.GetValues(typeof(Department));
            cmbPosition.DataSource = Enum.GetValues(typeof(Position));
            cmbDepartment.SelectedItem = null;
            cmbPosition.SelectedItem = null;

            //GridView
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.RowHeadersVisible = false;
            dgvEmployee.MultiSelect = false;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmployee.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvEmployee.RowTemplate.MinimumHeight = 54;
            FillUpDgv();
        }

        private void btSendEmail_Click(object sender, EventArgs e)
        {
            string fName = tbFName.Text;
            string lName = tbSName.Text;
            Department dep;            
            Position pos;            
            DateTime date = dtpBday.Value.Date;
            string email = tbEmail.Text;
            string phone = tbPhoneNumber.Text;
            string address = tbAddress.Text;

            if (fName == "" || lName == "" || phone == "" || address == "" )
            {
                MessageBox.Show("All textboxes must be filled up! ");
            }
            else
            {
                if(cmbDepartment.SelectedItem == null || cmbPosition.SelectedItem == null)
                {
                    MessageBox.Show("Department/Position is not selected!");
                }
                else
                {
                    Enum.TryParse<Department>(cmbDepartment.SelectedValue.ToString(), out dep);
                    Enum.TryParse<Position>(cmbPosition.SelectedValue.ToString(), out pos);
                    if (uc.CheckEmail(email))
                    {
                        uc.AddUser(fName, lName, dep, pos, email, phone, address, date);
                        MessageBox.Show("User added successfully");
                        ClearInfoAddUser();
                    }
                    else
                    {
                        MessageBox.Show("Email should be in format 'user@email.com'");
                        tbEmail.Text = "";
                    }
                }                
            }                        
        }
        private void FillUpDgv()
        {
            List<User> users = uc.GetUsers(); 
            foreach(User u in users)
            {
                dgvEmployee.Rows.Add(new string[]
                {   u.FName,
                    u.LName,
                    u.Position.ToString(),
                    u.Department.ToString(),
                    u.Rank.ToString(),
                    u.Salary.ToString()
                });
            }
            
        }

        #region INPUT_CONTROL
        private void tbFName_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }       
        private void tbSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        } 
        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ClearInfoAddUser()
        {
            tbFName.Text = "";
            tbSName.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            tbAddress.Text = "";
            cmbDepartment.SelectedItem = null;
            cmbPosition.SelectedItem = null;
        }



        #endregion
      
    }
}
