using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessCon;
using System.Data.OleDb;
using System.Data;

namespace Form1Form2
{
    public struct mm
    {
        public static string m = null;
        public static string n = null;
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