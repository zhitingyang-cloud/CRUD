using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            
        }


        int id = 30;
        private void button1_Click(object sender, EventArgs e)
        {

            //新增
            
            var name = T_NAME.Text;
            var number = T_NUMBER.Text;
            var address = T_ADDRESS.Text;
            var remark = T_REMARK.Text;

            TEST100_TB test100 = new TEST100_TB();
            test100.NAME = name;
            test100.NUMBER = number;
            test100.ADDRESS = address;
            test100.REMARK = remark;
            test100.ID = id;
            id++;
            db.TEST100_TB.InsertOnSubmit(test100);
            db.SubmitChanges();
            MessageBox.Show("資料已新增");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //查詢
            var name = T_NAME.Text;
            var number = T_NUMBER.Text;
            var address = T_ADDRESS.Text;
            var remark = T_REMARK.Text;

            var db2 = db.TEST100_TB.Where(p => p.NAME == name || p.NUMBER == number || p.ADDRESS == address || p.REMARK == remark);
           // var db2 = db.TEST100_TB.Where(p => p.NAME.Contains("in"));
            dataGridView1.DataSource = db2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //修改
            var name = T_NAME.Text;
            var number = T_NUMBER.Text;
            var address = T_ADDRESS.Text;
            var remark = T_REMARK.Text;
            var usersToUpdate = from user in db.TEST100_TB
                                where user.NAME == name
                                select user;
            var list = usersToUpdate.ToList();

            foreach (var user in usersToUpdate)
            {
                user.NUMBER = number;
                user.ADDRESS = address;
                user.REMARK = remark;

            }
            db.SubmitChanges();
            MessageBox.Show("資料已修改");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //刪除
            var name = T_NAME.Text;
            var number = T_NUMBER.Text;
            var address = T_ADDRESS.Text;
            var remark = T_REMARK.Text;
            var db2 = db.TEST100_TB.Where(p => p.NAME == name|| p.NUMBER==number|| p.ADDRESS==address||p.REMARK==remark);

            foreach (var item in db2)
            {
                db.TEST100_TB.DeleteOnSubmit(item);
            }

            db.SubmitChanges();
            MessageBox.Show("資料已刪除");
        }

       
    }
}
