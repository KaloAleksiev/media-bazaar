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
        }

        private void btSendEmail_Click(object sender, EventArgs e)
        {
            string fName = tbFName.Text;
            string lName = tbSName.Text;
            Department dep;
            Enum.TryParse<Department>(cmbDepartment.SelectedValue.ToString(), out dep);
            Position pos;
            Enum.TryParse<Position>(cmbPosition.SelectedValue.ToString(), out pos);
            DateTime date = dtpBday.Value.Date;
            string email = tbEmail.Text;
            string phone = tbPhoneNumber.Text;
            string address = tbAddress.Text;           
            
             if (uc.CheckEmail(email))
             {
                uc.AddUser(fName, lName, dep, pos, email, phone, address, date);
                MessageBox.Show("User added successfully");
             }
             else
             {
                 MessageBox.Show("Email should be in format 'user@email.com'");
                 tbEmail.Text = "";
             }
            
        }
    }
}
