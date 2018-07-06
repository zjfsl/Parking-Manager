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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)//按车牌号查询键
        {
            DataTable fill = null;
            User.queryViaPlt program2 = new User.queryViaPlt();
            fill = program2.query(textBox30.Text);
            dataGridView1.DataSource = fill;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)//初始读取
        {
            User.downloadInfo program1 = new User.downloadInfo();
            DataTable fill = program1.download();
            foreach (DataRow item in fill.Rows)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1Form2.cacheclean.clean();
            this.Close();
            client client = new client();
            client.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
