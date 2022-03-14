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
    public partial class EmployStaff : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
        public EmployStaff()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            int employed = 0;
            if (txtStaffid.Text.Trim() != "" && nudSeyear.Value > 2014 && cboSsemester.Text != "" && txtSsalary.Text.Trim() != "")
            {
                //check for duplicates
                try
                {
                    conn = new MySqlConnection(constring);
                    conn.Open();
                    string queryhstid = "SELECT staffid FROM tbstaffemployment WHERE staffid='" + this.txtStaffid.Text.Trim() + "' and year= '"+this.nudSeyear.Value+"' and semester='"+this.cboSsemester.Text+"';";
                    MySqlCommand cmmd = new MySqlCommand(queryhstid, conn);
                    if (cmmd.ExecuteScalar() is DBNull || (Convert.ToInt32(cmmd.ExecuteScalar()))>0)
                    {
                        employed = 1;
                        txtStaffid.Text = "";
                    }
                    if (employed == 1)
                    {
                        MessageBox.Show("This Staff Member is already employed");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (employed == 0)
                {
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT * FROM tbstaffemployment";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dr = dt.NewRow();
                        dr["staffid"] = txtStaffid.Text.Trim();
                        dr["year"] = nudSeyear.Value;
                        dr["semester"] = cboSsemester.SelectedItem;
                        dr["salary"] = txtSsalary.Text.Trim();


                        dt.Rows.Add(dr);
                        adapter.Update(dt);
                        MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //resetting controls
                        txtStaffid.Text = string.Empty;
                        nudSeyear.Value = nudSeyear.Minimum;
                        cboSsemester.SelectedIndex = -1;
                        txtSsalary.Text = string.Empty;



                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        conn = new MySqlConnection(constring);
                        string query = "SELECT * FROM tbstaffemployment";
                        adapter = new MySqlDataAdapter(query, conn);
                        cmd = new MySqlCommandBuilder(adapter);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView7.DataSource = dt;
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

        private void cmbSesearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSesearchby.SelectedItem.ToString() == "STAFF ID")
            {
                wmtxtSesearch.WaterMarkText = "Type the Staff's Unique Id Here";
                wmtxtSesearch.Enabled = true;
            }
            else if (cmbSesearchby.SelectedItem.ToString() == "SEMESTER")
            {
                wmtxtSesearch.WaterMarkText = "Select from drop down list labelled 'SEMESTER'";
                wmtxtSesearch.Enabled = false;
            }
            else if (cmbSesearchby.SelectedItem.ToString() == "YEAR")
            {
                wmtxtSesearch.WaterMarkText = "Select from Numeric Up Down box labelled 'YEAR'";
                wmtxtSesearch.Enabled = false;
            }
            else
            {
                wmtxtSesearch.WaterMarkText = "Select one from dropdown list above first";
                wmtxtSesearch.Enabled = false;
            }
        }

        private void txtStaffid_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbstaff";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                txtStaffid.DataSource = dt;
                txtStaffid.FormattingEnabled = true;
                txtStaffid.DisplayMember = "staffid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
             txtStaffid.Text = string.Empty;
             nudSeyear.Value = nudSeyear.Minimum;
             cboSsemester.SelectedIndex = -1;
             txtSsalary.Text = string.Empty;
        
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new MySqlConnection(constring);
            string query = "SELECT * FROM tbstaffemployment";
            adapter = new MySqlDataAdapter(query, conn);
            cmd = new MySqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView7.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnSesearch_Click(object sender, EventArgs e)
        {
            if (cmbSesearchby.SelectedItem.ToString() == "STAFF ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaffemployment WHERE staffid='" + this.wmtxtSesearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView7.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbSesearchby.SelectedItem.ToString() == "SEMESTER")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaffemployment WHERE semester='" + this.cboSsemester.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView7.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbSesearchby.SelectedItem.ToString() == "YEAR")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbstaffemployment WHERE year='" + nudSeyear.Value + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView7.DataSource = dt;
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
            wmtxtSesearch.Text = "";
        }
        
    }
}
