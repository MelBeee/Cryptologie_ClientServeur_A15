﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptologie
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
