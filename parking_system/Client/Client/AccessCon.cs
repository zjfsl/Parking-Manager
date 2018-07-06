using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;

namespace AccessCon
    { 

public class Access
{
       
        OleDbConnection oleDb = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Parking.mdb");
    public void Closecon()//关闭连接
        {
            oleDb.Close();
        }

    public Access() //构造函数
    {
        oleDb.Open();
    }

    public void Get()//获取全部内容
    {
        string sql = "select * from t_user";
        //获取表1的内容
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
        DataTable dt = new DataTable(); //新建表对象
        dbDataAdapter.Fill(dt); //用适配对象填充表对象
        foreach (DataRow item in dt.Rows)
        {
            //Console.WriteLine(item[0] + " | " + item[1]);
            MessageBox.Show(item[0] + " , " + item[1]);
        }
    }

        public DataTable Find(string phone)//通过电话找用户，返回一条数据
        {
            string temp = Convert.ToString(phone);
            string sql = "select * from t_user WHERE 联系电话='" + phone + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("电话不存在!");
                return null;
            }
            return dt;
        }

        public bool Find(string user, string password)
    {
        string temp1 = Convert.ToString(user);
        string temp2 = Convert.ToString(password);
        string sql = "select * from t_user WHERE User='"+user+"'";
        //获取表1中昵称为LanQ的内容
        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
        DataTable dt = new DataTable(); //新建表对象
        dbDataAdapter.Fill(dt); //用适配对象填充表对象
        if (dt.Rows.Count == 0)
        {
            MessageBox.Show("用户名不存在!");
            return false;
        }
                
        foreach (DataRow item in dt.Rows)
        {
            if(Convert.ToString(item[1])== password)
                return true;
            else
                MessageBox.Show("密码错误");
                return false;
        }
        return false;
        }


        public DataTable Find(bool boo, string number)//寻找车牌号
        {
            string temp = Convert.ToString(number);
            string sql = "select * from t_park WHERE 车牌 like '%" + number + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("车牌不存在!");
                return null;
            }

            return dt;
        }


        public bool FindAdmin(string user, string password)//在管理员表中寻找
        {
            string temp1 = Convert.ToString(user);
            string temp2 = Convert.ToString(password);
            string sql = "select * from t_admin WHERE User='" + user + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            if (dt.Rows.Count == 0)
            {
                return false;
            }

            foreach (DataRow item in dt.Rows)
            {
                if (Convert.ToString(item[1]) == password)
                    return true;
                else
                    MessageBox.Show("密码错误");
                return false;
            }
            return false;
        }


        public DataTable FindUser(string user, string password)//用用户名和密码查询，返回一条信息
        {
            string temp1 = Convert.ToString(user);
            string temp2 = Convert.ToString(password);
            string sql = "select * from t_user WHERE User='" + user + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            return dt;
        }

        public DataTable FindPark(int ID)//寻找流水号返回停车记录
        {
            string temp = Convert.ToString(ID);
            string sql = "select * from t_park WHERE ID = " + temp;
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            return dt;
        }

        public DataTable FindPark(string pla)//寻找车牌号返回停车记录
        {
            string temp = Convert.ToString(pla);
            string sql = "select * from t_park WHERE 车牌 like '%" + pla + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("车牌不存在!");
                return null;
            }

            return dt;
        }

        public DataTable FindPark(DateTime date)//时间返回停车记录
        {
            //sql = "select * from 客户信息管理 where 修改时间 BETWEEN #" + dateTimePicker1.Text.ToString() + "# AND #" + dateTimePicker2.Text.ToString() + "#";
            //其中 修改时间 字段为 date/ time            
            //string temp = Convert.ToString(pla);
            string sql = "select * from t_park WHERE 进场时间 BETWEEN #" + date.Date.ToString("yyyy-MM-dd") + "# AND #" + date.Date.AddDays(1).ToString("yyyy-MM-dd") + "#";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            return dt;
        }


        public bool Add(string[] arr)//添加注册用户
    {
            //INSERT INTO [雇员] ([雇员号],[姓名],[性别],[出生日期],[部门]) VALUES ('001','李丽婷,'女’,#1992-02-04#,'人力资源部’)
            //"update t_user set 姓名 ='"+temp1+"',性别 ='"+temp2+"',联系电话 ='"+temp3+"',账户余额 ='"+temp4+"',车1 ='"+temp5+"',车2 ='"+temp6+"',车3 ='"+temp7+"',车4 ='"+temp8+"',车5 ='"+temp9+"' where 联系电话 ='"+temp+"'"
            string sql = "INSERT INTO t_user ([User], [Password], [姓名], [性别], [联系电话], [账户余额], [车1],[车2],[车3],[车4],[车5]) values ('"+arr[0]+"','"+arr[1]+"','"+arr[2]+ "','" + arr[3] + "','" + arr[4] + "','" + 0 + "','" + arr[5] + "','" + arr[6] + "','" + arr[7] + "','" + arr[8] + "','" + arr[9] + "')";
            OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
        int i = oleDbCommand.ExecuteNonQuery(); //返回被修改的数目
        return i > 0;
    }

    public bool Del()
    {
        string sql = "delete from 表1 where 昵称='LANQ'";
        //删除昵称为LanQ的记录
        OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
        int i = oleDbCommand.ExecuteNonQuery();
        return i > 0;
    }

    public bool Change(string phone,string t1,string t2,string t3,string t4,string t5,string t6,string t7,string t8,string t9)
    {
            string temp = Convert.ToString(phone);
            string sql = "select * from t_user WHERE 联系电话='" + temp + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("电话不存在!");
                return false;
            }
            string temp1 = Convert.ToString(t1);
            string temp2 = Convert.ToString(t2);
            string temp3 = Convert.ToString(t3);
            string temp4 = Convert.ToString(t4);
            string temp5 = Convert.ToString(t5);
            string temp6 = Convert.ToString(t6);
            string temp7 = Convert.ToString(t7);
            string temp8 = Convert.ToString(t8);
            string temp9 = Convert.ToString(t9);
            sql = "update t_user set 姓名 ='"+temp1+"',性别 ='"+temp2+"',联系电话 ='"+temp3+"',账户余额 ='"+temp4+"',车1 ='"+temp5+"',车2 ='"+temp6+"',车3 ='"+temp7+"',车4 ='"+temp8+"',车5 ='"+temp9+"' where 联系电话 ='"+temp+"'";
        //将表1中昵称为东熊的账号修改成233333
        OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
        int i = oleDbCommand.ExecuteNonQuery();
        return i > 0;
    }

        public bool charge(string phone,int money)
        {
            string sql = "select * from t_user WHERE 联系电话='" + phone + "'";
            //获取表1中昵称为LanQ的内容
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, oleDb); //创建适配对象
            DataTable dt = new DataTable(); //新建表对象
            dbDataAdapter.Fill(dt); //用适配对象填充表对象
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("电话不存在!");
                return false;
            }
            foreach(DataRow item in dt.Rows)
            {
                money += Convert.ToInt32(item[6].ToString());
            }
            Form1Form2.mm.caculator = money;
            sql = "update t_user set 账户余额 ='" + money.ToString() + "'";
            OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDb);
            int i = oleDbCommand.ExecuteNonQuery();
            return i > 0;
        }

    }

}