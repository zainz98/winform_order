using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace project1
{
    
    public partial class Form4 : Form
    {
        SqlConnection co = new SqlConnection(@"");
        public Form4()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1 F1 = new form1();
            F1.ShowDialog();
            F1 = null;
            this.Show();
            
        }

      

        private void t_ItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mdashDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mdashDataSet.t_Orders' table. You can move, or remove it, as needed.
            this.t_OrdersTableAdapter.Fill(this.mdashDataSet.t_Orders);
            // TODO: This line of code loads data into the 'mdashDataSet.t_Items' table. You can move, or remove it, as needed.
            this.t_ItemsTableAdapter.Fill(this.mdashDataSet.t_Items);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mdashDataSet);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from t_Orders where OrderNumber = '{0}' and OrderDate = '{1}' and CustomerName = '{2}'and CustomerAddress = '{3}'and CustomerPhone= '{4}'and TotalAmount= '{5}' and RefaundAmount= '{6}' and CustomerCity= '{7}'and item= '{8}' and item_m_u= '{9}'", textBox1.Text, textBox3.Text, textBox2.Text, textBox6.Text, textBox4.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("INSERT INTO t_Orders (OrderNumber,CustomerName,CustomerAddress,CustomerPhone,TotalAmount,RefaundAmount,CustomerCity,item,item_m_u)VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", textBox1.Text, textBox6.Text, textBox8.Text, textBox4.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("add order");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("DELETE from t_Orders  where OrderNumber = '{0}' and OrderDate = '{1}' and CustomerName = '{2}'and CustomerAddress = '{3}'and CustomerPhone= '{4}'and TotalAmount= '{5}' and RefaundAmount= '{6}' and CustomerCity= '{7}'and item= '{8}' and item_m_u= '{9}'", textBox1.Text, textBox3.Text, textBox2.Text, textBox6.Text, textBox4.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("delet order");

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
          string sql = string.Format("UPDATE t_Orders  SET OrderNumber = '{0}', OrderDate = '{1}',CustomerName = '{2}',CustomerAddress = '{3}',CustomerPhone= '{4}',TotalAmount= '{5}' ,RefaundAmount= '{6}' ,CustomerCity= '{7}',item= '{8}',item_m_u= '{9}' where OrderNumber = '{0}' and OrderDate = '{1}' and CustomerName = '{2}'and CustomerAddress = '{3}'and CustomerPhone= '{4}'and TotalAmount= '{5}' and RefaundAmount= '{6}' and CustomerCity= '{7}'and item= '{8}' and item_m_u= '{9}' ", textBox1.Text, textBox3.Text, textBox2.Text, textBox6.Text, textBox4.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("UPDATE order");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sql = string.Format("select * from t_Orders where OrderNumber = '{0}' and OrderDate = '{1}' and CustomerName = '{2}'and CustomerAddress = '{3}'and CustomerPhone= '{4}'and TotalAmount= '{5}' and RefaundAmount= '{6}' and CustomerCity= '{7}'and item= '{8}' and item_m_u= '{9}'", textBox1.Text, textBox3.Text, textBox2.Text, textBox6.Text, textBox4.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        
    

      



       

        

      
        
    }
}
