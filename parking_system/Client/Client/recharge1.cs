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
    public partial class recharge1 : Form
    {
        public recharge1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recharge2 form = new recharge2();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccessCon.Access access = new AccessCon.Access();
            DataTable dataTable = access.Find(textBox1.Text.ToString());
            foreach (DataRow item in dataTable.Rows)
            {
                textBox2.Text = item[3].ToString();
                textBox3.Text = item[6].ToString();
            }
        }
    }
}
