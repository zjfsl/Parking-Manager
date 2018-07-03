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
    public partial class payment1 : Form
    {
        public payment1()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment2 form = new payment2();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client form = new client();
            this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessCon.Access access = new AccessCon.Access();
            DataTable dataTable = access.Find(true,Convert.ToString(textBox1.Text));
            if(dataTable==null)
                return;
            foreach(DataRow item in dataTable.Rows)
            {
                textBox11.Text=Convert.ToString(item[0]);
                textBox12.Text = Convert.ToString(item[2]);
                textBox13.Text = Convert.ToString(item[1]);
                TimeSpan timeSpan = Convert.ToDateTime(item[3])-Convert.ToDateTime(item[2]);
                textBox14.Text = Convert.ToString(timeSpan.Hours)+"小时"+Convert.ToString(timeSpan.Minutes)+"分钟";
                textBox16.Text = Convert.ToString(timeSpan.TotalMinutes*2)+"（每分钟两元）";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
