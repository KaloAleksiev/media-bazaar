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
    public partial class Annoucemnts : Form
    {
        AnnoucementControl ac;
        UserControl uc;
        List<Annoucement> list;

        public Annoucemnts(UserControl uc)
        {
            ac = new AnnoucementControl();
            InitializeComponent();
            this.uc = uc; 
            dgvANnoucemnts.AutoGenerateColumns = false;
            dgvANnoucemnts.RowHeadersVisible = false;
            dgvANnoucemnts.MultiSelect = false;
            dgvANnoucemnts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvANnoucemnts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvANnoucemnts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvANnoucemnts.RowTemplate.MinimumHeight = 54;
            UpdateList();
          
        }
        private void UpdateList()
        {
            List<Annoucement> list = ac.GetAllAnnoucemnts();
            dgvANnoucemnts.Rows.Clear();
            foreach (var item in list)
            {
                dgvANnoucemnts.Rows.Add(new string[] { item.Title, item.StartDate.ToString("dd MMMM yyyy"), item.EndDate.ToString("dd MMMM yyyy") });
            }
            
        }
        private void btnAddAnnoucemnt_Click(object sender, EventArgs e)
        {
            if (tbTitle.TextLength != 0 || rtbAnnoucemntText.Text != String.Empty)
            {
                if (cmDepartment.SelectedIndex > -1)
                {
                    int department = cmDepartment.SelectedIndex + 1;
                    ac.NewAnnoucement(dtpstart_date.Value, dtpend_picker.Value, tbTitle.Text, rtbAnnoucemntText.Text, uc.GetLoggedIn(), department);
                    UpdateList();
                }
                else
                {
                    int department = 0;
                    ac.NewAnnoucement(dtpstart_date.Value, dtpend_picker.Value, tbTitle.Text, rtbAnnoucemntText.Text, uc.GetLoggedIn(), department);
                    UpdateList();
                }
            }
            else
            {
                MessageBox.Show("Make sure you add the title and descrioption of the annoucemnt!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvANnoucemnts.SelectedRows.Count > 0)
            {
                string title = dgvANnoucemnts.SelectedCells[0].Value.ToString();
                ac.DeleteAnnoucemnt(title);
                dgvANnoucemnts.Rows.RemoveAt(this.dgvANnoucemnts.SelectedRows[0].Index);
                MessageBox.Show($"The annoucement {ac.GetToEditTitle()} was edited succesfully!");
            }
            else
            {
                MessageBox.Show($"Make sure you choose the annoucement from the list!");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ac.EditAnnoucement(tbTitle.Text, rtbAnnoucemntText.Text, dtpstart_date.Value, dtpend_picker.Value, cmDepartment.SelectedIndex + 1);
            MessageBox.Show($"The annoucement '{ac.GetToEditTitle()}' was edited succesfully!");
            UpdateList();
        }

        private void btAnnoucemntToBeUpdated_Click(object sender, EventArgs e)
        {
            string title = dgvANnoucemnts.SelectedCells[0].Value.ToString();
            Annoucement toedit = ac.GetToBeEditedAnnoucemnt(title);
            tbTitle.Text = toedit.Title;
            rtbAnnoucemntText.Text = toedit.Text;
            dtpstart_date.Value = toedit.StartDate;
            dtpend_picker.Value = toedit.EndDate;
            cmDepartment.Text = "";
            int department = toedit.DepartmentId;
            if (department == 1)
            {
                cmDepartment.Text = "Phones";
                UpdateList();
            }
            else if (department == 2)
            {
                cmDepartment.Text = "Computers";
                UpdateList();
            }
            else if (department == 3)
            {
                cmDepartment.Text = "TVs";
                UpdateList();
            }
        }
    }
}
