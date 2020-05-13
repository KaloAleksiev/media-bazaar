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
        UserControl uc;
        AnnoucemntDataControl dc = new AnnoucemntDataControl();
        List<Annoucement> list = new List<Annoucement>();
        Annoucement toedit;
        public Annoucemnts(UserControl uc)
        {
            InitializeComponent();
            this.uc = uc; 
            list = dc.ReturnAllAnnoucemntFromDB();
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
                Annoucement annoucement = new Annoucement(dtpstart_date.Value, dtpend_picker.Value, tbTitle.Text, rtbAnnoucemntText.Text, uc.GetLoggedIn());
                dc.AddAnnoucemntToDB(annoucement);
                list = dc.ReturnAllAnnoucemntFromDB();
                UpdateList();
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
                dc.DeleteAnnoucement(title);
                dgvANnoucemnts.Rows.RemoveAt(this.dgvANnoucemnts.SelectedRows[0].Index);
                MessageBox.Show($"The annoucement {toedit.Title} was edited succesfully!");
            }
            else
            {
                MessageBox.Show($"Make sure you choose the annoucement from the list!");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            toedit.ChangeTitle(tbTitle.Text);
            toedit.ChangeText(rtbAnnoucemntText.Text);
            toedit.ChangeStartDate(dtpstart_date.Value);
            toedit.ChangeEndDate(dtpend_picker.Value);
            dc.UpdateAnnoucemnt(toedit);

            MessageBox.Show($"The annoucement '{toedit.Title}' was edited succesfully!");
            list = dc.ReturnAllAnnoucemntFromDB();
            UpdateList();
        }

        private void btAnnoucemntToBeUpdated_Click(object sender, EventArgs e)
        {
            string title = dgvANnoucemnts.SelectedCells[0].Value.ToString();
            toedit = dc.ReturnAnnoucemntFromDB(title);
            tbTitle.Text = toedit.Title;
            rtbAnnoucemntText.Text = toedit.Text;
            dtpstart_date.Value = toedit.StartDate;
            dtpend_picker.Value = toedit.EndDate;
        }
    }
}
