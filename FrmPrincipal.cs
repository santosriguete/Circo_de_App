﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeAPP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxCEP_Click(object sender, EventArgs e)
        {
            FrmBuscaCEP busca = new FrmBuscaCEP();
            busca.Show();
        }
    }
}
