﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rails4Trams
{
    public partial class BestuurderForm : Form
    {
        public BestuurderForm()
        {

            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnBestFormBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WagenparkBeheerderForm l = new WagenparkBeheerderForm();
            l.Show();
        }
    }
}
