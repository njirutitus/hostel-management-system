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
    public partial class staff : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
       // int occupancy;
        public staff()
        {
            InitializeComponent();
        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            //resetting the controls
            txtName.Text = string.Empty;
            txtIdno.Text = string.Empty;
            txtPhoneno.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBankaccno.Text = string.Empty;
            txtBankaccname.Text = string.Empty;
            cboBank.SelectedIndex = -1;
            txtPaybillno.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void cmbSsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSsearchby.SelectedIndex == -1)
            {
                txtSsearch.WaterMarkText = "select one from the drop down list above first";
                txtSsearch.Enabled = false;
            }
            else if (cmbSsearchby.Text.Trim() == "NATIONAL ID NO.")
            {
                txtSsearch.WaterMarkText = "Type Staff's National Id Number Here";
                txtSsearch.Enabled = true;
            }
            else if (cmbSsearchby.Text.Trim() == "NAME")
            {
                txtSsearch.WaterMarkText = "Type Staff's Name Here";
                txtSsearch.Enabled = true;
            }
            else if (cmbSsearchby.Text.Trim() == "PHONE NO.")
            {
                txtSsearch.WaterMarkText = "Type Staff's Phone Number Here";
                txtSsearch.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbstaff";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewStaff.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim() != "" && txtIdno.Text.Trim() != "" && txtPhoneno.Text.Trim() != "" && txtAddress.Text.Trim() != "" && txtBankaccno.Text.Trim() != "" && txtBankaccname.Text.Trim() != "" && cboBank.Text != "" && txtPaybillno.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaff";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dr = dt.NewRow();
                    dr["staffname"] = txtName.Text.Trim();
                    dr["nid"] = txtIdno.Text.Trim();
                    dr["phoneno"] = txtPhoneno.Text.Trim();
                    dr["address"] = txtAddress.Text.Trim();
                    dr["bankaccno"] = txtBankaccno.Text.Trim();
                    dr["bankaccname"] = txtBankaccname.Text.Trim();
                    dr["bank"] = cboBank.Text.Trim();
                    dr["paybillno"] = txtPaybillno.Text.Trim();
                    dr["password"] = txtPassword.Text.Trim();


                    dt.Rows.Add(dr);
                    adapter.Update(dt);
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //resetting the controls
                    txtName.Text = string.Empty;
                    txtIdno.Text = string.Empty;
                    txtPhoneno.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    txtBankaccno.Text = string.Empty;
                    txtBankaccname.Text = string.Empty;
                    cboBank.SelectedIndex = -1;
                    txtPaybillno.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    {
                        try
                        {
                            conn = new MySqlConnection(constring);
                            string query1 = "SELECT * FROM tbstaff order by staffname";
                            adapter = new MySqlDataAdapter(query1, conn);
                            cmd = new MySqlCommandBuilder(adapter);
                            dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewStaff.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdno.Text == "")
            {
                MessageBox.Show("You Must Enter National Id No. to Delete a Staff", "Information");
            }
            else
            {

                try
                {
                    conn.Open();
                    string query = "DELETE FROM  tbstaff WHERE nid='" + this.txtIdno.Text.Trim() + "';";
                    MySqlCommand cmmd = new MySqlCommand(query, conn);
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        try
                        {
                            conn = new MySqlConnection(constring);
                            string query1 = "SELECT * FROM tbstaff order by staffname";
                            adapter = new MySqlDataAdapter(query1, conn);
                            cmd = new MySqlCommandBuilder(adapter);
                            dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewStaff.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdno.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tbstaff SET staffname='" + this.txtName.Text.Trim() + "',date=NOW(),bankaccno='" + this.txtBankaccno.Text.Trim() + "',bankaccname='" + this.txtBankaccname.Text.Trim() + "',bank='" + this.cboBank.Text.Trim() + "',address='" + this.txtAddress.Text.Trim() + "',phoneno='" + this.txtPhoneno.Text.Trim() + "',paybillno='" + this.txtPaybillno.Text.Trim() + "' where nid='" + this.txtIdno.Text.Trim() + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    MySqlDataReader myreader;
                    conn.Open();
                    myreader = cmd1.ExecuteReader();
                    MessageBox.Show("Data Upadated");
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query1 = "SELECT * FROM tbstaff order by staffname";
                        adapter = new MySqlDataAdapter(query1, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewStaff.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You Must Enter Id No to Update");
            }
        }

        private void txtIdno_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPaybillno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBankaccname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBankaccno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSsearch_Click(object sender, EventArgs e)
        {
            if (cmbSsearchby.SelectedItem.ToString() == "NATIONAL ID NO.")
            {

                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaff WHERE nid='" + this.txtSsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewStaff.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbSsearchby.SelectedItem.ToString() == "NAME")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaff WHERE staffname LIKE '%" + this.txtSsearch.Text.Trim() + "%'";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewStaff.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbSsearchby.SelectedItem.ToString() == "PHONE NO.")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaff WHERE phoneno='" + this.txtSsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewStaff.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtIdno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPaybillno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
