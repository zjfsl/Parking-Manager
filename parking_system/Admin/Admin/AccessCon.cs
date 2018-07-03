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

class Access
{
       
        OleDbConnection oleDb = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hcx\Desktop\parking_system\Admin\Admin\obj\Debug\accessData\Parking.mdb");
    public void Closecon()//关闭连接
        {
            oleDb.Close();
        }

    public Access() //构造函数
    {
        oleDb.Open();
    }

    public void Get()
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

    public DataTable Find(string phone)
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
    public bool Add()
    {
        string sql = "insert into 表1 (昵称,账号) values ('LanQ','2545493686')";
        //往表1添加一条记录，昵称是LanQ，账号是2545493686
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
}

}