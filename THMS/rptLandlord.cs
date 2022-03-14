using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THMS
{
    public partial class rptLandlord : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
        public rptLandlord()
        {
            InitializeComponent();
        }

        private void rptLandlord_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tblandlords";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
