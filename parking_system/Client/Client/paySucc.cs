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
    public partial class paySucc : Form
    {
        public paySucc()
        {
            InitializeComponent();
            this.label1.Text="请在以下时间之前驾车离开停车场，谢谢！";
            DateTime dt = new DateTime();
            dt=DateTime.Now;
            dt=dt.AddMinutes(30);
            this.label3.Text=dt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client form =new client();
            this.Hide();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
