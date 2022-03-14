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
    public partial class expenses : Form
    {
         string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
       // int occupancy;
        public expenses()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtOfficeequipment.Text.Trim() != "" && txtMaintenance.Text.Trim() != "" && txtStaffexpenses.Text.Trim() != "" && txtMiscellaneous.Text.Trim() != "" && cboExsemester.Text != "" && numericUpDownEyear.Value > 2014)
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbexpenses";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dr = dt.NewRow();
                    dr["officeequipment"] = txtOfficeequipment.Text.Trim();
                    dr["maintenance"] = txtMaintenance.Text.Trim();
                    dr["staffexpenses"] = txtStaffexpenses.Text.Trim();
                    dr["miscellaneous"] = txtMiscellaneous.Text.Trim();
                    dr["semester"] = cboExsemester.SelectedItem;
                    dr["year"] = numericUpDownEyear.Value;

                    dt.Rows.Add(dr);
                    adapter.Update(dt);
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset controls
                    txtOfficeequipment.Text = string.Empty;
                    txtMaintenance.Text = string.Empty;
                    txtStaffexpenses.Text = string.Empty;
                    txtMiscellaneous.Text = string.Empty;
                    cboExsemester.SelectedIndex = -1;
                    numericUpDownEyear.Value = numericUpDownEyear.Minimum;



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbexpenses";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView4.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("All the Fields must be Correctly Filled First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEsearchby.SelectedItem.ToString() == "YEAR")
            {
                wmtxtEsearch.Text = "";
                wmtxtEsearch.WaterMarkText = "Type the year you want to search here";
                wmtxtEsearch.Enabled = true;
            }
            else if (cmbEsearchby.SelectedItem.ToString() == "SEMESTER")
            {
                wmtxtEsearch.Text = "";
                wmtxtEsearch.WaterMarkText = "Select 1 From drop down list labelled semester";
                wmtxtEsearch.Enabled = false;
            }
        }

        private void btnEsearch_Click(object sender, EventArgs e)
        {
            if (cmbEsearchby.SelectedItem.ToString() == "YEAR")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbexpenses WHERE year='" + this.wmtxtEsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView4.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else if (cmbEsearchby.SelectedItem.ToString() == "SEMESTER")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbexpenses WHERE semester='" + this.cboExsemester.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView4.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEviewsaveddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbexpenses";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEupdate_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView4.CurrentCell.RowIndex;
            int columnindex = dataGridView4.CurrentCell.ColumnIndex;
            string value = dataGridView4.Rows[rowindex].Cells[columnindex].Value.ToString();
            if (txtOfficeequipment.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbexpenses SET officeequipment='" + this.txtOfficeequipment.Text.Trim() + "',date=NOW() where recordid='" + value + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (numericUpDownEyear.Value != numericUpDownEyear.Minimum)
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbexpenses SET year='" + this.numericUpDownEyear.Value + "',date=NOW() where recordid='" + value + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (txtMaintenance.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbexpenses SET maintenance='" + this.txtMaintenance.Text.Trim() + "',date=NOW() where recordid='" + value + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (txtStaffexpenses.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbexpenses SET staffexpenses='" + this.txtStaffexpenses.Text.Trim() + "',date=NOW() where recordid='" + value + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (txtMiscellaneous.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbexpenses SET miscellaneous='" + this.txtMiscellaneous.Text.Trim() + "',date=NOW() where recordid='" + value + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    MessageBox.Show("Data Upadated");
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cboExsemester.SelectedIndex != -1)
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbexpenses SET semester='" + this.cboExsemester.Text.Trim() + "',date=NOW() where recordid='" + value + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            MessageBox.Show("Data Upadated", "Information");


            try
            {
                conn = new MySqlConnection(constring);
                string query1 = "SELECT * FROM tbexpenses";
                adapter = new MySqlDataAdapter(query1, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //reset controls
            txtOfficeequipment.Text = string.Empty;
            txtMaintenance.Text = string.Empty;
            txtStaffexpenses.Text = string.Empty;
            txtMiscellaneous.Text = string.Empty;
            cboExsemester.SelectedIndex = -1;
            numericUpDownEyear.Value = numericUpDownEyear.Minimum;
        }

        private void txtOfficeequipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaintenance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStaffexpenses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMiscellaneous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void label71_Click(object sender, EventArgs e)
        {

        }
        }
    }

