﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pwSet form = new pwSet();
            this.Hide();
            form.Show();
        }
    }
}
