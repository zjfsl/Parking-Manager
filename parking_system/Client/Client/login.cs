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
using AccessCon;


namespace Client
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag;
            Login.login program1 = new Login.login();
            flag = program1.LoginWindow(textBox1.Text,textBox2.Text);
            switch(flag)
            {
                case 1:admin admin = new admin();
                    admin.Show();
                    this.Hide();
                    break;
                case 2:user user = new user();
                    user.Show();
                    this.Hide();
                    break;
                case 3:MessageBox.Show("用户名或密码错误！");
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client form = new client();
            this.Hide();
            form.Show();
        }
    }
}
