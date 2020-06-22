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
                                          uc.GetUserByID(request.UserId).FName,
                                          request.StartDate,
                                          request.EndDate,
                                          request.Accepted
                                      });
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {

        }
    }
}
