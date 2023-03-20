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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mdashDataSet.t_ItemU_M' table. You can move, or remove it, as needed.
            this.t_ItemU_MTableAdapter.Fill(this.mdashDataSet.t_ItemU_M);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
            F2 = null;
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form3 F3 = new Form3();
            F3.ShowDialog();
            F3 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.ShowDialog();
            F4 = null;
            this.Show();
          
           
            
        }

        private void t_ItemU_MBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ItemU_MBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mdashDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
