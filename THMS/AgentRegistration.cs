using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace THMS
{
    public partial class AgentRegistration : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
        // int occupancy;
        public AgentRegistration()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtAname.Text.Trim()!="" && txtAnid.Text.Trim()!= "" && txtAphoneno.Text.Trim()!="" && txtAaddress.Text.Trim()!= "" && txtAbankaccno.Text.Trim()!= "" && txtAbankaccname.Text.Trim()!= "" && cboAbank.Text != "" && txtApaybillno.Text.Trim()!= "")
            {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM agents";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dr = dt.NewRow();
                dr["agentname"] = txtAname.Text.Trim();
                dr["nid"] = txtAnid.Text.Trim();
                dr["phoneno"] = txtAphoneno.Text.Trim();
                dr["address"] = txtAaddress.Text.Trim();
                dr["bankaccno"] = txtAbankaccno.Text.Trim();
                dr["bankaccname"] = txtAbankaccname.Text.Trim();
                dr["bank"] = cboAbank.SelectedItem;
                dr["paybillno"] = txtApaybillno.Text.Trim();

                dt.Rows.Add(dr);
                adapter.Update(dt);
                MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //resetting the controls
                txtAname.Text = string.Empty;
                txtAnid.Text = string.Empty;
                txtAphoneno.Text = string.Empty;
                txtAaddress.Text = string.Empty;
                txtAbankaccno.Text = string.Empty;
                txtAbankaccname.Text = string.Empty;
                cboAbank.SelectedIndex = -1;
                txtApaybillno.Text = string.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM agents";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView6.DataSource = dt;
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

        private void btnAgcancel_Click(object sender, EventArgs e)
        {
            //resetting the controls
            txtAname.Text = string.Empty;
            txtAnid.Text = string.Empty;
            txtAphoneno.Text = string.Empty;
            txtAaddress.Text = string.Empty;
            txtAbankaccno.Text = string.Empty;
            txtAbankaccname.Text = string.Empty;
            cboAbank.SelectedIndex = -1;
            txtApaybillno.Text = string.Empty;

        }

        private void btnAgviewsaveddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM agents";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView6.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbAsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAsearchby.Text == "NATIONAL ID NO.")
            {
                wmtxtAnsearch.Text = "";
                wmtxtAnsearch.WaterMarkText = "Type the Agent's National Id Here";
            }
            else if (cmbAsearchby.Text == "NAme")
            {
                wmtxtAnsearch.Text = "";
                wmtxtAnsearch.WaterMarkText = "Type the Agent's Name or Part of it Here";

            }
            else if (cmbAsearchby.Text == "PHONE NO.")
            {
                wmtxtAnsearch.Text = "";
                wmtxtAnsearch.WaterMarkText = "Type the Agent's Phone Number Here";
            }
        }

        private void btnAsearch_Click(object sender, EventArgs e)
        {
            if (cmbAsearchby.SelectedItem.ToString() == "NATIONAL ID NO.")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM agents WHERE nid='" + this.wmtxtAnsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView6.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbAsearchby.SelectedItem.ToString() == "NAME")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM agents WHERE agentname LIKE'%" + this.wmtxtAnsearch.Text.Trim() + "%'";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView6.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbAsearchby.SelectedItem.ToString() == "PHONE NO.")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM agents WHERE phoneno='" + this.wmtxtAnsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView6.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Search by Selection", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtAnid.Text == "")
            {
                MessageBox.Show("You Must Enter National Id NO. to Delete an Agent", "Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM  agents WHERE nid='" + this.txtAnid.Text.Trim() + "';";
                    MySqlCommand cmmd = new MySqlCommand(query, conn);
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        try
                        {
                            conn = new MySqlConnection(constring);
                            string query1 = "SELECT * FROM agents order by agentname";
                            adapter = new MySqlDataAdapter(query1, conn);
                            cmd = new MySqlCommandBuilder(adapter);
                            dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView6.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    //reset national id control
                    txtAnid.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgupdate_Click(object sender, EventArgs e)
        {
            if(txtAnid.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE agents SET agentname='" + this.txtAname.Text.Trim() + "',date=NOW(),bankaccno='" + this.txtAbankaccno.Text.Trim() + "',bankaccname='" + this.txtAbankaccname.Text.Trim() + "',bank='" + this.cboAbank.Text.Trim() + "',address='" + this.txtAaddress.Text.Trim() + "',phoneno='" + this.txtAphoneno.Text.Trim() + "',paybillno='" + this.txtApaybillno.Text.Trim() + "' where nid='" + this.txtAnid.Text.Trim() + "'; ";
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
                        string query1 = "SELECT * FROM agents order by agentname";
                        adapter = new MySqlDataAdapter(query1, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView6.DataSource = dt;
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

        private void AgentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtAnid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
