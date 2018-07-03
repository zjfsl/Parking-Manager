using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using AccessCon;

namespace Admin
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessCon.Access access = new AccessCon.Access();
            DataTable result = access.Find(textBox1.Text);
            if(result!=null)
            {
                 MessageBox.Show("查询成功");
                foreach (DataRow item in result.Rows)
                {
                    textBox2.Text = Convert.ToString(item[3]);
                    textBox5.Text = Convert.ToString(item[4]);
                    textBox4.Text = Convert.ToString(item[5]);
                    textBox3.Text = Convert.ToString(item[6]);
                    textBox6.Text = Convert.ToString(item[7]);
                    textBox7.Text = Convert.ToString(item[8]);
                    textBox8.Text = Convert.ToString(item[9]);
                    textBox9.Text = Convert.ToString(item[10]);
                    textBox10.Text = Convert.ToString(item[11]);

                }
            }
            else
                MessageBox.Show("查询失败");
            access.Closecon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccessCon.Access access = new AccessCon.Access();
            bool result = access.Change(textBox1.Text, textBox2.Text, textBox5.Text, textBox4.Text, textBox3.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            if(result==true)
                MessageBox.Show("修改成功");
            else
                MessageBox.Show("修改失败");
            access.Closecon();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminLogin login = new adminLogin();
            this.Close();
            login.Show();
        }
    }

}
