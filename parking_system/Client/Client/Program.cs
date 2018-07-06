using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessCon;
using System.Data.OleDb;
using System.Data;
using Client;

namespace Form1Form2
{
    static class cacheclean
    {
        public static void clean()
        {
             mm.m = null;
             mm.n = null;
        }
    }
    public struct mm
    {
        public static string m = null;
        public static string n = null;
        public static DataTable temp = null;
    };
}
namespace Client
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new client());
        }
    }
}

namespace Login
{
    public class login
    {
        bool result;
        public login()
        {
            result = false;
        }
        
        public int LoginWindow(string name, string password)
        {
            Access test = new Access();
            //从管理员表中查询

            result = test.FindAdmin(name,password);
            if (result == true)
            {
                test.Closecon();
                return 1;
            }
            //从用户表中查询
            result = test.Find(name, password);
            if (result == true)
            {
                Form1Form2.mm.m = name;
                Form1Form2.mm.n = password;
                test.Closecon();
                return 2;
            }
            test.Closecon();
            return 3;
        }
    }
}


namespace User
{
    public class downloadInfo
    {
        public DataTable download()
        {
            DataTable ReCl;
            Access test = new Access();
            ReCl = test.FindUser(Form1Form2.mm.m, Form1Form2.mm.n);
            test.Closecon();
            return ReCl;
        }
    }

    public class queryViaPlt
    {
        public DataTable query(string pla)
        {
            DataTable dt;
            Access test = new Access();
            dt = test.FindPark(pla);
            return dt;
        }
    }

}

namespace Admin
{
    public class queryViaPho
    {
        public DataTable query(string phone)
        {
            DataTable ReCl = null;
            Access test = new Access();
            ReCl = null;
            ReCl = test.Find(phone);
            test.Closecon();
            Form1Form2.mm.temp = ReCl;
            return ReCl;
        }
        public void update(DataTable toUpdate)
        {
            foreach(DataRow item in toUpdate.Rows)
            {
                Access test = new Access();
                if(test.Change(item[5].ToString(),item[3].ToString(),item[4].ToString(),item[5].ToString(),item[6].ToString(),item[7].ToString(),item[8].ToString(),item[9].ToString(),item[10].ToString(),item[11].ToString()))
                {
                    MessageBox.Show("修改成功!");
                }
            }
            
        } 

    }

}