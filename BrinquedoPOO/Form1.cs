﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brinquedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadBrinquedo frm = 
                new frmCadBrinquedo();
            frm.ShowDialog();
        }
    }
}
