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
    public partial class Landlords : Form
    {
         string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
       // int occupancy;
        public Landlords()
        {
            InitializeComponent();
        }

        private void cmdLsaveprint_Click(object sender, EventArgs e)
        {
            if (txtLname.Text.Trim() != "" && txtLnid.Text.Trim() != "" && txtLphoneno.Text.Trim() != "" && txtLaddress.Text.Trim() != "" && txtLbankaccno.Text.Trim() != "" && txtLbankaccname.Text.Trim() != "" && cboLbank.Text != "" && txtLpaybillno.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tblandlords";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dr = dt.NewRow();
                    dr["Landlordname"] = txtLname.Text.Trim();
                    dr["nid"] = txtLnid.Text.Trim();
                    dr["phoneno"] = txtLphoneno.Text.Trim();
                    dr["address"] = txtLaddress.Text.Trim();
                    dr["bankaccno"] = txtLbankaccno.Text.Trim();
                    dr["bankaccname"] = txtLbankaccname.Text.Trim();
                    dr["bank"] = cboLbank.SelectedItem;
                    dr["paybillno"] = txtLpaybillno.Text.Trim();

                    dt.Rows.Add(dr);
                    adapter.Update(dt);
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset controls
                    txtLname.Text = string.Empty;
                    txtLnid.Text = string.Empty;
                    txtLphoneno.Text = string.Empty;
                    txtLaddress.Text = string.Empty;
                    txtLbankaccno.Text = string.Empty;
                    txtLbankaccname.Text = string.Empty;
                    cboLbank.SelectedIndex = -1;
                    txtLpaybillno.Text = string.Empty;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tblandlords";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView3.DataSource = dt;
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

        private void Landlords_Load(object sender, EventArgs e)
        {

        }

        private void btnLviewsaveddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tblandlords";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbLsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLsearchby.SelectedItem.ToString() == "NATIONAL ID NO.")
            {
                txtLsearch.Text = "";
                txtLsearch.WaterMarkText = "Type National ID no. Here";
            }
            else if (cmbLsearchby.SelectedItem.ToString() == "NAME")
            {
                txtLsearch.Text = "";
                txtLsearch.WaterMarkText = "Type Landlord Name Here";
            }
            else if (cmbLsearchby.SelectedItem.ToString() == "PHONE NO.")
            {
                txtLsearch.Text = "";
                txtLsearch.WaterMarkText = "Type Landlord's Phone No. Here";
            }
        }

        private void btnLsearch_Click(object sender, EventArgs e)
        {
            if (cmbLsearchby.SelectedItem.ToString() == "NATIONAL ID NO.")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tblandlords WHERE nid='" + this.txtLsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbLsearchby.SelectedItem.ToString() == "NAME")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tblandlords WHERE landlordname LIKE '%" + this.txtLsearch.Text.Trim() + "%'";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbLsearchby.SelectedItem.ToString() == "PHONE NO.")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tblandlords WHERE phoneno='" + this.txtLsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLcancel_Click(object sender, EventArgs e)
        {
            //reset controls
            txtLname.Text = string.Empty;
            txtLnid.Text = string.Empty;
            txtLphoneno.Text = string.Empty;
            txtLaddress.Text = string.Empty;
            txtLbankaccno.Text = string.Empty;
            txtLbankaccname.Text = string.Empty;
            cboLbank.SelectedIndex = -1;
            txtLpaybillno.Text = string.Empty;
        }

        private void cmdLupdate_Click(object sender, EventArgs e)
        {
            if (txtLnid.Text.Trim() != "")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "UPDATE tblandlords SET landlordname='" + this.txtLname.Text.Trim() + "',date=NOW(),bankaccno='" + this.txtLbankaccno.Text.Trim() + "',bankaccname='" + this.txtLbankaccname.Text.Trim() + "',bank='" + this.cboLbank.Text.Trim() + "',address='" + this.txtLaddress.Text.Trim() + "',phoneno='" + this.txtLphoneno.Text.Trim() + "',paybillno='" + this.txtLpaybillno.Text.Trim() + "' where nid='" + this.txtLnid.Text.Trim() + "'; ";
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
                        string query1 = "SELECT * FROM tblandlords order by landlordname";
                        adapter = new MySqlDataAdapter(query1, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView3.DataSource = dt;
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

        private void btnLdelete_Click(object sender, EventArgs e)
        {
            if (txtLnid.Text == "")
            {
                MessageBox.Show("You Must Enter National Id No. to Delete a Landlord", "Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM  tblandlords WHERE nid='" + this.txtLnid.Text.Trim() + "';";
                    MySqlCommand cmmd = new MySqlCommand(query, conn);
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        try
                        {
                            conn = new MySqlConnection(constring);
                            string query1 = "SELECT * FROM tblandlords order by landlordname";
                            adapter = new MySqlDataAdapter(query1, conn);
                            cmd = new MySqlCommandBuilder(adapter);
                            dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView3.DataSource = dt;
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

        private void txtLnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLpaybillno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        }
    }

