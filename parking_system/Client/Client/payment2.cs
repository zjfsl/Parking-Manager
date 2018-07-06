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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment2_Load(object sender, EventArgs e)
        {
            textBox4.Text = Form1Form2.mm.caculator.ToString();
            Form1Form2.cacheclean.cleancache();
        }
    }
}
