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
            Recharge1.Recharge program1 = new Recharge1.Recharge();
            if (program1.charge(Convert.ToInt32(textBox4.Text),textBox1.Text.ToString()) && textBox4.Text!="")
            {
                MessageBox.Show("充值成功，账户余额为"+Form1Form2.mm.caculator+"元");
                Form1Form2.cacheclean.cleancache();
                client c = new client();
                c.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recharge1.query program2 = new Recharge1.query();
            foreach (DataRow item in program2.queryInfo(textBox1.Text.ToString()).Rows)
            {
                textBox2.Text = item[3].ToString();
                textBox3.Text = item[6].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client c = new client();
            c.Show();
            this.Close();
        }
    }
}
