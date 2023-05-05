using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_DB_to_VS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //OleDbConnection conn = new OleDbConnection();
            //conn.ConnectionString = "Provider = Mincrosoft.ace.Oledb.12.0; Data Source = infodb.accdb";
            //conn.Open();
            //MessageBox.Show("ok");

            Form2 frmAdd = new Form2();
            frmAdd.ShowDialog();



        }
    }
}
