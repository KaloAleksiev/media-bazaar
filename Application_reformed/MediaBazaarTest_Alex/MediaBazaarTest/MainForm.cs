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
    public partial class MainForm : Form
    {
        UserControl uc;
        public MainForm()
        {
            InitializeComponent();
            uc = new UserControl();        
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == ""|| tbPassword.Text == "")
            {
                MessageBox.Show("Login credential/s missing! Fill in both of the textboxes!");
            }
            else
            {
                if(uc.Login(tbPassword.Text, tbEmail.Text) == true)
                {
                    //lblLoggedIn.ForeColor = System.Drawing.Color.Green;
                    //lblLoggedIn.Text = "Login successfull!";
                    switch (uc.GetLoggedIn().Position)
                    {
                        case Position.Administrator:
                            ButtonsForAdmin();
                            break;
                        case Position.Manager:
                            ButtonsForManager();
                            break;
                        default:
                            ButtonsForEmpDepWorker();
                            break;
                    }

                    //Clear tbs
                    tbEmail.Text = "";
                    tbPassword.Text = "";
                    pLogin.Visible = false;
                    UpdateLabels();                    
                    
                }
                else
                {
                    lblLoggedIn.Text = "Login failed!";
                    lblLoggedIn.ForeColor = System.Drawing.Color.Red;                    
                }
            }
        }

        #region NavigationControl

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm f = new AddEmployeeForm(uc);
            f.Show();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            StockForm s = new StockForm(uc);
            s.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm s = new ScheduleForm(uc);
            s.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm s = new StatisticsForm();
            s.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            uc.Logout();
            pLogin.Visible = true;           
        }

        #endregion

        #region UpdateControls
        private void UpdateLabels()
        {
            User u = uc.GetLoggedIn();
            lblDate.Text = DateTime.Now.Date.ToShortDateString();
            lblRole.Text = $"Logged in as {u.Position}";
            lblWelcome.Text = $"Welcome, {u.FName} {u.LName}";
        }

        private void ButtonsForAdmin()
        {
            btnEmployee.Visible = true;
            btnSchedule.Visible = true;
            btnStatistics.Visible = true;
            btnStocks.Visible = true;
        }

        private void ButtonsForManager()
        {
            btnEmployee.Visible = true;
            btnSchedule.Visible = true;
            btnStatistics.Visible = false;
            btnStocks.Visible = true;
        }

        private void ButtonsForEmpDepWorker()
        {
            btnEmployee.Visible = false;
            btnSchedule.Visible = true;
            btnStatistics.Visible = false;
            btnStocks.Visible = true;
        }
        #endregion

    }
}
