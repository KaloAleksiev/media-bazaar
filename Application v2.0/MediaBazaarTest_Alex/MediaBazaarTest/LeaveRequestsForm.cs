using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    public partial class LeaveRequestsForm : Form
    {
        UserControl uc;
        UserDataControl udc;
        List<LeaveRequest> requests;

        public LeaveRequestsForm(UserControl userControl)
        {
            InitializeComponent();
            uc = userControl;
            udc = new UserDataControl();
            requests = new List<LeaveRequest>();
            requests = udc.GetLeaveRequestsFromDB();
            dgvLeaveRequests.AutoGenerateColumns = false;
            dgvLeaveRequests.RowHeadersVisible = false;
            dgvLeaveRequests.MultiSelect = false;
            dgvLeaveRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaveRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLeaveRequests.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ShowRequests(requests);
        }

        public void ShowRequests(List<LeaveRequest> requests)
        {
            dgvLeaveRequests.Rows.Clear();
            for (int i = 0; i < requests.Count; i++)
            {
                LeaveRequest request = requests[i];
                dgvLeaveRequests.Rows.Add(new object[]
                                      {   request.Id,
                                          uc.GetUserByID(request.UserId).FName + "\n" + uc.GetUserByID(request.UserId).LName,
                                          request.StartDate,
                                          request.EndDate,
                                          request.Accepted
                                      });
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            LeaveRequest r = GetSelectedRequest();
            if (r != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to ACCEPT this request?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (uc.AcceptLeaveRequest(r))
                    {
                        MessageBox.Show("Request accepted!");
                        ShowRequests(udc.GetLeaveRequestsFromDB());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request first.");
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            LeaveRequest r = GetSelectedRequest();
            if (r != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to DENY this request?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (uc.DenyLeaveRequest(r))
                    {
                        MessageBox.Show("Request denied!");
                        ShowRequests(udc.GetLeaveRequestsFromDB());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request first.");
            }
        }

        public LeaveRequest GetSelectedRequest()
        {
            foreach (LeaveRequest r in requests)
            {
                if (r.Id == Convert.ToInt32(dgvLeaveRequests.SelectedRows[0].Cells[0].Value))
                { return r; }
            }
            return null;
        }
    }
}
