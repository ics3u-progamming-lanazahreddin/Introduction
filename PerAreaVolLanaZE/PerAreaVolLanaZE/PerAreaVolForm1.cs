﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolLanaZE
{
    public partial class frmPerAreaVolForm1 : Form
    {
        public frmPerAreaVolForm1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.lblAVolume.Text = Convert.ToString( (double)4 / (double)3 * Math.PI * Math.Pow(3,3) ) + "cm³";
        }

        private void BtnQPerimeter_Click(object sender, EventArgs e)
        {
            this.lblAPerimeter.Text = Convert.ToString(2 * (5 + 8)) + "cm";
        }

        private void BtnQArea_Click(object sender, EventArgs e)
        {
            this.lblAArea.Text = Convert.ToString(Math.PI * Math.Pow(7, 2)) + " cm²";
        }
    }
}
