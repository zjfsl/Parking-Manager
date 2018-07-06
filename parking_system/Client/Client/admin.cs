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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            client client = new client();
            client.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.queryViaPho program1 = new Admin.queryViaPho();
            foreach(DataRow item in program1.query(textBox1.Text).Rows)
            {
                textBox2.Text = item[3].ToString();
                textBox5.Text = item[4].ToString();
                textBox4.Text = item[5].ToString();
                textBox3.Text = item[6].ToString();
                textBox6.Text = item[7].ToString();
                textBox7.Text = item[8].ToString();
                textBox8.Text = item[9].ToString();
                textBox9.Text = item[10].ToString();
                textBox10.Text = item[11].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DataRow item in Form1Form2.mm.temp.Rows)
            {
                item[3] = textBox2.Text.ToString();
                item[4] = textBox5.Text.ToString();
                item[5] = textBox4.Text.ToString();
                item[6] = textBox3.Text.ToString();
                item[7] = textBox6.Text.ToString();
                item[8] = textBox7.Text.ToString();
                item[9] = textBox8.Text.ToString();
                item[10] = textBox9.Text.ToString();
                item[11] = textBox10.Text.ToString();
            }
            Admin.queryViaPho program2 = new Admin.queryViaPho();
            program2.update(Form1Form2.mm.temp);
        }
    }
}
