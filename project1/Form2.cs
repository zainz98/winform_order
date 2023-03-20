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
    public partial class Form2 : Form
    {
        SqlConnection co = new SqlConnection(@"");
        public Form2()
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

        private void t_ItemU_MBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ItemU_MBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mdashDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mdashDataSet.t_ItemU_M' table. You can move, or remove it, as needed.
            this.t_ItemU_MTableAdapter.Fill(this.mdashDataSet.t_ItemU_M);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("INSERT INTO t_ItemU_M (ItemU_M)VALUES ('{0}')", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("add ItemU");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from t_ItemU_M where ItemU_M = '{0}' ", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("DELETE from t_ItemU_M where ItemU_M = '{0}' ", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("delet ItemU");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE t_ItemU_M  SET ItemU_M = '{0}'where ItemU_M = '{0}'", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql, co);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("UPDATE ItemU");
        }

       

       

      

       

       
    }
}
