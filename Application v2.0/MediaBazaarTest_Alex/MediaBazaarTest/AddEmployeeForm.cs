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
        private DepartmentControl dc;
        public AddEmployeeForm(UserControl ucMain, DepartmentControl dcMain)
        {
            InitializeComponent();           
            uc = ucMain;
            dc = dcMain;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            //cmbDepartment.DataSource = Enum.GetValues(typeof(Department));
            foreach(DepartmentClass d in dc.GetDepartments())
            {
                cmbDepartment.Items.Add(d);
                cmbDepartmentChange.Items.Add(d);
            }
            cmbPosition.DataSource = Enum.GetValues(typeof(Position));

            //cmbDepartmentChange.DataSource = Enum.GetValues(typeof(Department));
            cmbPositionChange.DataSource = Enum.GetValues(typeof(Position));

            cmbDepartment.SelectedItem = null;
            cmbPosition.SelectedItem = null;

            cmbDepartmentChange.SelectedItem = null;
            cmbPositionChange.SelectedItem = null;

            //GridView
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.RowHeadersVisible = false;
            dgvEmployee.MultiSelect = false;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmployee.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvEmployee.RowTemplate.MinimumHeight = 54;
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.ScrollBars = ScrollBars.Vertical;
            FillUpDgv("");

            //Panel control 
            pAddUser.Visible = false;
            pAllEmployees.Visible = false;
            pPromoteEmployee.Visible = false;

        }

        #region CREATE_USER
        private void btSendEmail_Click(object sender, EventArgs e)
        {
            string fName = tbFName.Text;
            string lName = tbSName.Text;
            DepartmentClass dep;
            Position pos;
            DateTime date = dtpBday.Value.Date;
            string email = tbEmail.Text;
            string phone = tbPhoneNumber.Text;
            string address = tbAddress.Text;
            string city = tbCity.Text;
            string zipcode = tbZipcode.Text;

            //GetGender
            string gender = "";
            if (cbMale.Checked)
            {
                gender = "Male";
            }
            else if (cbFemale.Checked)
            {
                gender = "Female";
            }
            else if (cbOtherGender.Checked)
            {
                gender = tbOtherGender.Text;
            }

            if (fName == "" || lName == "" || phone == "" || address == "" || gender == "" || zipcode == "" || city == "")
            {
                MessageBox.Show("All textboxes must be filled up! ");
            }
            else
            {
                if (cmbDepartment.SelectedItem == null || cmbPosition.SelectedItem == null)
                {
                    MessageBox.Show("Department/Position is not selected!");
                }
                else
                {
                    //Enum.TryParse<Department>(cmbDepartment.SelectedValue.ToString(), out dep);
                    dep = dc.GetDepartmentByName(cmbDepartment.SelectedItem.ToString());

                    Enum.TryParse<Position>(cmbPosition.SelectedValue.ToString(), out pos);
                    if (uc.CheckEmail(email))
                    {
                        uc.AddUser(fName, lName, dep, pos, email, phone, city, zipcode, address, date, gender);
                        MessageBox.Show("User added successfully");
                        ClearInfoAddUser();
                        FillUpDgv("");
                    }
                    else
                    {
                        MessageBox.Show("Email should be in format 'user@email.com'");
                        tbEmail.Text = "";
                    }
                }
            }
        }
        #endregion

        #region PANEL_CONTROL
        private void btCreateUserPanel_Click(object sender, EventArgs e)
        {
            if (!pAddUser.Visible)
            {
                pAddUser.Visible = true;
                pAllEmployees.Visible = false;
            }
            else
            {
                pAddUser.Visible = false;
            }
        }

        private void btPromoteFire_Click(object sender, EventArgs e)
        {
            if (!pAllEmployees.Visible)
            {
                pAddUser.Visible = false;
                pAllEmployees.Visible = true;
                dgvEmployee.ClearSelection();
            }
            else
            {
                pAllEmployees.Visible = false;
                btPromoteSelected.Enabled = false;
                dgvEmployee.Refresh();
            }
        }
        private int id;
        private void btPromoteSelected_Click(object sender, EventArgs e)
        {
            if (!pPromoteEmployee.Visible && dgvEmployee.SelectedRows.Count > 0)
            {
                pPromoteEmployee.Visible = true;
                tbSearch.Text = "";
                id = Convert.ToInt32(dgvEmployee.SelectedCells[0].Value.ToString());
                UpdateEmployeeInfoLabel();
            }
            else
            {
                MessageBox.Show("Please select an Employee first!");
            }
        }

        #endregion

        #region FIRE/PROMOTE
        private void tbFireSelected_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmployee.SelectedCells[0].Value.ToString());
            uc.FireUser(id);
            FillUpDgv("");
            MessageBox.Show("Employee fired successfully");
        }

        private void btChangeDep_Click(object sender, EventArgs e)
        {
            if (cmbDepartmentChange.SelectedItem != null)
            {
                DepartmentClass dep = null;
                //Enum.TryParse<Department>(cmbDepartmentChange.SelectedValue.ToString(), out dep);
                dep = dc.GetDepartmentByName(cmbDepartmentChange.SelectedValue.ToString());
                if (uc.ChangeDepartment(id, dep) == false)
                {
                    MessageBox.Show("Selected employee is a part of this department already!");
                }
                else
                {
                    MessageBox.Show("Department changed successfully!");
                    UpdateEmployeeInfoLabel();
                    cmbDepartmentChange.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Select a value from the comboBox!");
            }

        }

        private void btChangePosition_Click(object sender, EventArgs e)
        {
            if (cmbPositionChange.SelectedItem != null)
            {
                Position pos;
                Enum.TryParse<Position>(cmbPositionChange.SelectedValue.ToString(), out pos);
                if (uc.ChangePosition(id, pos) == false)
                {
                    MessageBox.Show($"Selected employee is a {pos} already!");
                }
                else
                {
                    MessageBox.Show("Position changed successfully!");
                    UpdateEmployeeInfoLabel();
                    cmbPositionChange.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Select a value from the comboBox!");
            }
        }

        private void btChangeRank_Click(object sender, EventArgs e)
        {
            if (cmbRankChange.SelectedItem != null)
            {
                int rank = Convert.ToInt32(cmbRankChange.SelectedItem);
                if (uc.ChangeRank(id, rank) == false)
                {
                    MessageBox.Show($"Selected employee is rank {rank} already!");
                }
                else
                {
                    MessageBox.Show("Rank changed successfully!");
                    UpdateEmployeeInfoLabel();
                    cmbRankChange.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Select a value from the comboBox!");
            }
        }

        private void btChangeSalary_Click(object sender, EventArgs e)
        {
            if (tbSalary.Text != "")
            {
                double salary = Convert.ToDouble(tbSalary.Text);
                if (uc.ChangeSalary(id, salary) == false)
                {
                    MessageBox.Show($"Enter a different amount than the current salary!");
                }
                else
                {
                    MessageBox.Show("Salary changed successfully!");
                    UpdateEmployeeInfoLabel();
                    tbSalary.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill in the salary tb with a double value!");
            }
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            pPromoteEmployee.Visible = false;
            pAllEmployees.Visible = true;

            id = 0;
            lblSelectedEmployeeInfo.Text = "";
            dgvEmployee.ClearSelection();

            tbSalary.Text = "";
            cmbRankChange.SelectedItem = null;
            cmbPositionChange.SelectedItem = null;
            cmbDepartmentChange.SelectedItem = null;            
            FillUpDgv("");            
        }
        #endregion

        #region UPDATE_CONTROLS
        private void UpdateEmployeeInfoLabel()
        {
            lblSelectedEmployeeInfo.Text = uc.GetUserByID(id).GetInfo();
        }

        private void FillUpDgv(string demo)
        {
            dgvEmployee.Rows.Clear();
            List<User> users = uc.GetUsers();
            foreach (User u in users)
            {
                if(demo == "")
                {
                    dgvEmployee.Rows.Add(new string[]
                    {
                    u.Id.ToString(),
                    u.FName,
                    u.LName,
                    u.Position.ToString(),
                    u.Department.Name,
                    u.Rank.ToString(),
                    u.Salary.ToString()
                    });
                }
                else
                {
                    if($"{u.FName} {u.LName}".ToLower().Contains(demo.ToLower()) || u.LName.ToLower().Contains(demo.ToLower()))
                    {
                        dgvEmployee.Rows.Add(new string[]
                    {
                    u.Id.ToString(),
                    u.FName,
                    u.LName,
                    u.Position.ToString(),
                    u.Department.Name,
                    u.Rank.ToString(),
                    u.Salary.ToString()
                    });
                    }
                }
                
            }
        }

        #endregion

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

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
       
        private void tbOtherGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void cbOtherGender_CheckedChanged(object sender, EventArgs e)
        {
            if(tbOtherGender.Visible == false)
            {
                tbOtherGender.Visible = true;
            }
            else
            {
                tbOtherGender.Visible = false;
            }
           
        }

        private void ClearInfoAddUser()
        {
            tbFName.Text = "";
            tbSName.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            tbAddress.Text = "";
            tbOtherGender.Text = "";
            tbCity.Text = "";
            tbZipcode.Text = "";
            cmbDepartment.SelectedItem = null;
            cmbPosition.SelectedItem = null;
        }
        

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {            
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);      
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FillUpDgv(tbSearch.Text);
        }


        #endregion

       
    }
}
