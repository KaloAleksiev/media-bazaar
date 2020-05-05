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
            Annoucement annoucement = new Annoucement(dtpstart_date.Value, dtpend_picker.Value, tbTitle.Text, rtbAnnoucemntText.Text, uc.GetLoggedIn());
            dc.AddAnnoucemntToDB(annoucement);
            list.Add(annoucement);
            UpdateList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
