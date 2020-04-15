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
            this.Size = new System.Drawing.Size(767, 390);
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
                    lblForgottenPass.Visible = false;
                    lblLoggedIn.Visible = true;
                    pLogin.Visible = false;
                    this.Size = new System.Drawing.Size(1022, 552);
                    UpdateLabels();                    
                    
                }
                else
                {
                    lblLoggedIn.Visible = true;
                    lblForgottenPass.Visible = true;                   
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
            lblLoggedIn.Visible = false;
            this.Size = new System.Drawing.Size(767, 390);
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

        private void btnEmployee_MouseHover(object sender, EventArgs e)
        {
            pEmpInfo.Visible = true;
            btnEmployee.BackColor = System.Drawing.Color.Firebrick;
        }

        private void btnStocks_MouseHover(object sender, EventArgs e)
        {        
            pStocksInfo.Visible = true;
            btnStocks.BackColor = System.Drawing.Color.Firebrick;
        }

        private void btnSchedule_MouseHover(object sender, EventArgs e)
        {
            PScheduleInfo.Visible = true;
            btnSchedule.BackColor = System.Drawing.Color.Firebrick;
        }

        private void btnStatistics_MouseHover(object sender, EventArgs e)
        {
            pStatsInfo.Visible = true;
            btnStatistics.BackColor = System.Drawing.Color.Firebrick;
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            pEmpInfo.Visible = false;
            btnEmployee.BackColor = System.Drawing.Color.Maroon;
        }

        private void btnStocks_MouseLeave(object sender, EventArgs e)
        {
            pStocksInfo.Visible = false;
            btnStocks.BackColor = System.Drawing.Color.Maroon;
        }

        private void btnSchedule_MouseLeave(object sender, EventArgs e)
        {
            PScheduleInfo.Visible = false;
            btnSchedule.BackColor = System.Drawing.Color.Maroon;
        }

        private void btnStatistics_MouseLeave(object sender, EventArgs e)
        {
            pStatsInfo.Visible = false;
            btnStatistics.BackColor = System.Drawing.Color.Maroon;
        }

        #endregion

        #region ForgottenPass
        private void lblForgottenPass_Click(object sender, EventArgs e)
        {
            pForgottenPass.Visible = true;
            lblForgottenPass.Visible = false;
        }

        private void btRetrievePass_Click(object sender, EventArgs e)
        {
            string email = tbEmailRetrievePass.Text;
            string name = tbNameRetrievePass.Text;
            if(tbEmailRetrievePass.Text == ""|| tbNameRetrievePass.Text == "")
            {
                MessageBox.Show("Please fill in all the textboxes!");
            }
            else
            {
                if (uc.CheckEmail(email))
                {
                    if(uc.GetForgottenPass(email, name))
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

        private void btBackRetrievePass_Click(object sender, EventArgs e)
        {
            tbEmailRetrievePass.Text = "";
            tbNameRetrievePass.Text = "";
            pForgottenPass.Visible = false;
            lblForgottenPass.Visible = true;
        }
        #endregion

    }
}
