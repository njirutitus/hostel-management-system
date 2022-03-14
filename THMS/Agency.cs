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
    public partial class Agency : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
        public Agency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int allocated = 0;
            if (cboAgentid.Text.Trim() != "" && numericUpDown1.Value > 2014 && cboSemester.Text != "" && cboHostelid.Text != "")
            {
                //check if hostel is already allocated to another agent
                try
                {
                    conn = new MySqlConnection(constring);
                    conn.Open();
                    string queryhstid = "SELECT hostelid FROM tbhostelagency WHERE hostelid='" + this.cboHostelid.Text.Trim() + "' and year= '"+this.numericUpDown1.Value+"' and semester='"+this.cboSemester.Text+"';";
                    MySqlCommand cmmd = new MySqlCommand(queryhstid, conn);
                    if (cmmd.ExecuteScalar() is DBNull || (Convert.ToInt32(cmmd.ExecuteScalar()))>0)
                    {
                        allocated = 1;
                        cboHostelid.Text = "";
                    }
                    if (allocated == 1)
                    {
                        MessageBox.Show("This hostel has already been allocated to another agent");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (allocated == 0)
                {
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT * FROM tbhostelagency";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dr = dt.NewRow();
                        dr["agentid"] = cboAgentid.Text.Trim();
                        dr["year"] = numericUpDown1.Value;
                        dr["semester"] = cboSemester.SelectedItem;
                        dr["hostelid"] = cboHostelid.Text.Trim();
                        dr["amountpayable"] = txtAmountpayable.Text.Trim();


                        dt.Rows.Add(dr);
                        adapter.Update(dt);
                        MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //reset controls
                        cboAgentid.SelectedIndex = -1;
                        cboHostelid.SelectedIndex = -1;
                        txtAmountpayable.Text = string.Empty;
                        cboSemester.SelectedIndex = -1;
                        numericUpDown1.Value = numericUpDown1.Minimum;

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT * FROM tbhostelagency";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView5.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("All the Fields must be Correctly Filled First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgsearch_Click(object sender, EventArgs e)
        {
            if (cmbAgsearchby.SelectedItem.ToString() == "AGENT ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostelagency WHERE  agentid='" + this.cboAgentid.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView5.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbAgsearchby.SelectedItem.ToString() == "HOSTEL ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostelagency WHERE hostelid='" + this.cboHostelid.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView5.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Selection", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAgsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAgsearchby.SelectedItem.ToString() == "AGENT ID")
            {
                wmtxtAgsearch.Text = "";
                wmtxtAgsearch.WaterMarkText = "Select from drop down list labelled 'AGENT ID'";
                wmtxtAgsearch.Enabled = false;
            }
            else if (cmbAgsearchby.SelectedItem.ToString() == "HOSTEL ID")
            {
                wmtxtAgsearch.Text = "";
                wmtxtAgsearch.WaterMarkText = "Select from drop down list labelled 'HOSTEL ID'";
                wmtxtAgsearch.Enabled = false;
            }
        }

        private void btnAeviewsaveddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbhostelagency";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView5.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgcancel_Click(object sender, EventArgs e)
        {
            //Resetting controls
            cboAgentid.SelectedIndex = -1;
            cboHostelid.Text = "";
            txtAmountpayable.Text = string.Empty;
            cboSemester.SelectedIndex = -1;
            numericUpDown1.Value = numericUpDown1.Minimum;
        }

        private void cboAgentid_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM agents";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                cboAgentid.DataSource = dt;
                cboAgentid.FormattingEnabled = true;
                cboAgentid.DisplayMember = "agentid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboHostelid_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbhostels";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                cboHostelid.DataSource = dt;
                cboHostelid.DisplayMember = "hostelid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboHostelid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHostelid.Text != "")
            {
                int rent;
                int capacity;
                try
                {
                    conn = new MySqlConnection(constring);
                    conn.Open();
                    string query = "SELECT rent FROM tbhostels WHERE hostelid='" + this.cboHostelid.Text.Trim() + "';";
                    string query1 = "SELECT capacity FROM tbhostels WHERE hostelid='" + this.cboHostelid.Text.Trim() + "';";
                    MySqlCommand cmmd = new MySqlCommand(query, conn);
                    MySqlCommand cmd = new MySqlCommand(query1, conn);
                    rent = (Int32)cmmd.ExecuteScalar();
                    capacity = (Int32)cmd.ExecuteScalar();
                    int totalrent = capacity * rent;
                    txtAmountpayable.Text = (0.01 * totalrent).ToString();
                    txtAmountpayable.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cboHostelid_Leave(object sender, EventArgs e)
        {
            
        }

        }
    }

