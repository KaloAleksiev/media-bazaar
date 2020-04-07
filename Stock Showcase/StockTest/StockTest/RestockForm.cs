using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTest
{
    public partial class RestockForm : Form
    {
        Item item;
        public RestockForm(Item i)
        {
            InitializeComponent();
            this.item = i;
            lbInfo.Text += item.Name;
        }
    }
}
