﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TOP.Screen
{
    public partial class frmTest1 : TOP.Parent.PForm
    {
        public frmTest1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource asynchronously

            GridView = gridView1;
            GridControl = gridControl1;
        }

        private void frmTest1_Shown(object sender, EventArgs e)
        {
         
        }
    }
}
