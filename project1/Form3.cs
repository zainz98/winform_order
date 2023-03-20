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
    public partial class Form3 : Form
    {
        SqlConnection co = new SqlConnection(@"");
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mdashDataSet.t_Items' table. You can move, or remove it, as needed.
            this.t_ItemsTableAdapter.Fill(this.mdashDataSet.t_Items);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE t_Items  SET ItemDescription = '{0}', OrderID = '{1}',ItemAmount = '{2}',ItemU_M = '{3}',ItemPrice= '{4}'where ItemDescription = '{0}' and OrderID = '{1}' and ItemAmount = '{2}' and ItemU_M = '{3}' and ItemPrice= '{4}'", textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("UPDATE item");
  

        }

       private void button3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from t_Items where ItemDescription = '{0}' and OrderID = '{1}' and ItemAmount = '{2}' and ItemU_M = '{3}' and ItemPrice= '{4}'", textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql,co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       private void button1_Click(object sender, EventArgs e)
       {
           string sql = string.Format("INSERT INTO t_Items (ItemDescription,OrderID,ItemAmount,ItemU_M,ItemPrice)VALUES ('{0}','{1}','{2}','{3}','{4}')", textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
           SqlDataAdapter da = new SqlDataAdapter(sql, co);
           DataTable dt = new DataTable();
           da.Fill(dt);
           dataGridView1.DataSource = dt;
           MessageBox.Show("add item");
       }

       private void button2_Click(object sender, EventArgs e)
       {
           string sql = string.Format("DELETE from t_Items where ItemDescription = '{0}' and OrderID = '{1}' and ItemAmount = '{2}' and ItemU_M = '{3}' and ItemPrice= '{4}'", textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
           SqlDataAdapter da = new SqlDataAdapter(sql, co);
           DataTable dt = new DataTable();
           da.Fill(dt);
           dataGridView1.DataSource = dt;
           MessageBox.Show("delet item");

       }

      

       

      

       
    }
}
