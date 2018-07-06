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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register.reg program1 = new Register.reg();
            program1.regis(textBox1.Text.ToString(),textBox11.Text.ToString(), textBox2.Text.ToString(), textBox5.Text.ToString(), textBox4.Text.ToString(), textBox6.Text.ToString(), textBox7.Text.ToString(), textBox8.Text.ToString(), textBox9.Text.ToString(), textBox10.Text.ToString());
            if (program1.regis(textBox1.Text.ToString(), textBox11.Text.ToString(), textBox2.Text.ToString(), textBox5.Text.ToString(), textBox4.Text.ToString(), textBox6.Text.ToString(), textBox7.Text.ToString(), textBox8.Text.ToString(), textBox9.Text.ToString(), textBox10.Text.ToString()))
            {
                MessageBox.Show("注册成功！");
                client c = new client();
                this.Hide();
                c.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client c = new client();
            c.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
