using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RestockRequestForm : Form
    {
        private int ItemId;
        public RestockRequestForm(int id)
        {
            InitializeComponent();
            this.ItemId = id;
            tbItemIDRestockForm.Text = ItemId.ToString();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
