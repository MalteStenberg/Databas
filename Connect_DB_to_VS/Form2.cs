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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.Oledb.12.0; Data Source = Info.accdb";
            conn.Open();
            //MessageBox.Show("ok");


            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "insert into Tabel1(FName, LName) values('Maryam', 'Rezaee')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data successfully saved");
        }
    }
}
