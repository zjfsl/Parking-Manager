using System;
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
    public partial class pwErr : Form
    {
        public pwErr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login form = new login();
            this.Hide();
            form.Show();
        }
    }
}
