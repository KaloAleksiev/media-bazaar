﻿using System;
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
    public partial class ScheduleForm : Form
    {
        private UserControl uc;
        public ScheduleForm(UserControl userControl)
        {           
            InitializeComponent();
            this.uc = userControl;
        }
    }
}
