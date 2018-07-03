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
            //String name = this.textBox2.Text; 
            //String password = this.textBox1.Text;
            //if (name.Equals("member") && password.Equals("123456")) 
            //{
            //    recharge1 form = new recharge1();
            //    this.Hide();
            //    form.Show();
            //}
            //else
            //{
            //    pwErr form = new pwErr();
            //    this.Hide();
            //    form.Show();
            //}
            Access test = new Access();
            //test.Get();
            bool result = false;
            result = test.Find(textBox1.Text, textBox2.Text);
            if (result == true)
            {
                payment2 payment2 = new payment2();
                this.Hide();
                payment2.Show();
            }
            test.Closecon();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
