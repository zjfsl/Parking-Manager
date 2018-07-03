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
    public partial class payment2 : Form
    {
        public payment2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paySucc form = new paySucc();
            this.Hide();
            form.Show();
        }
    }
}
