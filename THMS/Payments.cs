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
    public partial class Payments : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
       // int occupancy;
        
        public Payments()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (cboClientemployeetype.Text.Trim() != "" && cboClientemployeeno.Text.Trim() != "" && txtAmountpaid.Text.Trim() != "" && cboModeofpayment.Text.Trim() != "" && txtTransactionno.Text.Trim() != "")
            {
                //save data to the database
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbpayment";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dr = dt.NewRow();
                    dr["clientemployeetype"] = cboClientemployeetype.Text.Trim();
                    dr["clientemployeeno"] = cboClientemployeeno.Text.Trim();
                    dr["amountpaid"] = txtAmountpaid.Text.Trim();
                    dr["modeofpayment"] = cboModeofpayment.Text.Trim();
                    dr["transactionid"] = txtTransactionno.Text.Trim();

                    dt.Rows.Add(dr);
                    adapter.Update(dt);
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //resetting controls
                    cboClientemployeetype.SelectedIndex = -1;
                    cboClientemployeeno.SelectedIndex = -1;
                    txtAmountpaid.Text = string.Empty;
                    cboModeofpayment.SelectedIndex = -1;
                    txtTransactionno.Text = string.Empty;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //refresh Datagrid
                if (Variables.usertype == "ADMINISTRATOR")
                {
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT * FROM tbpayment";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPayment.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (Variables.usertype == "STAFF")
                {
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT * FROM tbpayment WHERE clientemployeetype ='LANDLORD' OR  `clientemployeetype`='AGENT'";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPayment.DataSource = dt;

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

        private void btnPsearch_Click(object sender, EventArgs e)
        {
            if (cmbPsearchby.SelectedItem.ToString() == "TRANSACTION ID")
            {

                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbpayment WHERE transactionid='" + this.txtPsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayment.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbPsearchby.SelectedItem.ToString() == "CLIENT/EMPLOYEE ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbpayment WHERE clientemployeeno='" + this.cboClientemployeeno.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayment.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbPsearchby.SelectedItem.ToString() == "CLIENT/EMPLOYEE TYPE")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbpayment WHERE clientemployeetype='" + this.cboClientemployeetype.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayment.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPviwsaveddata_Click(object sender, EventArgs e)
        {
            if (Variables.usertype == "ADMINISTRATOR")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbpayment";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayment.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Variables.usertype == "STAFF")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbpayment WHERE clientemployeetype ='LANDLORD' OR  `clientemployeetype`='AGENT'";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayment.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnPcancel_Click(object sender, EventArgs e)
        {
            //Resetting controls
            cboClientemployeeno.SelectedIndex = -1;
            cboClientemployeetype.SelectedIndex = -1;
            txtAmountpaid.Text = string.Empty;
            cboModeofpayment.SelectedIndex = -1;
            txtTransactionno.Text = string.Empty;
        }

        private void cboClientemployeetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientemployeetype.Text.Trim() == "LANDLORD")
            {
                cboClientemployeeno.Enabled = true;
                txtAmountpaid.Enabled = true;
                cboModeofpayment.Enabled = true;
                txtTransactionno.Enabled = true;
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT DISTINCT ownerid FROM tbhostels";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    cboClientemployeeno.DataSource = dt;
                    cboClientemployeeno.FormattingEnabled = true;
                    cboClientemployeeno.DisplayMember = "ownerid";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cboClientemployeetype.Text.Trim() == "STAFF")
            {
                if (Variables.usertype == "STAFF")
                {
                    MessageBox.Show("You must be Logged in as an Administrator to pay a staff member", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboClientemployeetype.SelectedIndex = -1;

                }
                else
                {
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT DISTINCT staffid FROM tbstaffemployment";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        cboClientemployeeno.DataSource = dt;
                        cboClientemployeeno.FormattingEnabled = true;
                        cboClientemployeeno.DisplayMember = "staffid";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (cboClientemployeetype.Text.Trim() == "AGENT")
            {
                cboClientemployeeno.Enabled = true;
                txtAmountpaid.Enabled = true;
                cboModeofpayment.Enabled = true;
                txtTransactionno.Enabled = true;
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT DISTINCT agentid FROM tbhostelagency";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    cboClientemployeeno.DataSource = dt;
                    cboClientemployeeno.FormattingEnabled = true;
                    cboClientemployeeno.DisplayMember = "agentid";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cboClientemployeetype.Text.Trim() == null)
            {
                MessageBox.Show("select one to continue");
            }
        }

        private void cmbPsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPsearchby.SelectedItem.ToString() == "CLIENT/EMPLOYEE ID")
            {
                txtPsearch.Text = "";
                txtPsearch.WaterMarkText = "select from the first 2 combo boxes on the right";
                txtPsearch.Enabled = false;
            }
            else if (cmbPsearchby.SelectedItem.ToString() == "CLIENT/EMPLOYEE TYPE")
            {
                txtPsearch.Text = "";
                txtPsearch.WaterMarkText = "select from the first combo box on the right";
                txtPsearch.Enabled = false;
            }
            else if (cmbPsearchby.Text == "TRANSACTION NO.")
            {
                txtPsearch.Text = "";
                txtPsearch.WaterMarkText = "Type Transaction No. Here";
                txtPsearch.Enabled = true;
            }
        }

        private void txtAmountpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        }
    }

