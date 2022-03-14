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
    public partial class Add_Hostels : Form
    {
        
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
       // int occupancy;
        
        public Add_Hostels()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
             try
            {

                conn = new MySqlConnection(constring);
                conn.Open();
                string query = "SELECT * FROM tbhostels";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dr = dt.NewRow();
                dr["Name"] = txtHostelname.Text.Trim();
                dr["Ownerid"] = cboOwnerid.Text.Trim();
                dr["Capacity"] = txtCapacity.Text.Trim();
                dr["Category"] = cboCategory.SelectedItem;
                dr["Allowed_gender"] = cmbHgender.SelectedItem;
                dr["Distance"] = txtDistance.Text.Trim();
                dr["AdditionaIitems"] = txtAdditionalitems.Text.Trim();
                dr["Rent"] = txtRent.Text.Trim();
                dr["maxoccupants"] = numericUpDown3.Value;


                dt.Rows.Add(dr);
                adapter.Update(dt);
                string query1 = "UPDATE `tbhostels` SET `totaloccupancy`=`maxoccupants`*`Capacity` ";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //reset controls
                txtHostelname.Text = string.Empty;
                txtCapacity.Text = string.Empty;
                txtDistance.Text = string.Empty;
                txtAdditionalitems.Text = string.Empty;
                txtRent.Text = string.Empty;
                cboOwnerid.SelectedIndex = -1;
                cboCategory.SelectedIndex = -1;
                numericUpDown3.Value = numericUpDown3.Minimum;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbhostels ORDER BY name ";
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
        

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void cboHgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdditionalitems_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            if (txtHostelname.Text.Trim() != "" && cboOwnerid.Text.Trim() != "" && txtCapacity.Text.Trim() != "" && cboCategory.Text != "" && cmbHgender.Text != "" && txtDistance.Text.Trim() != "" && txtRent.Text.Trim() != "")
            {
                try
                {

                    conn = new MySqlConnection(constring);
                    conn.Open();
                    string query = "SELECT * FROM tbhostels";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dr = dt.NewRow();
                    dr["Name"] = txtHostelname.Text.Trim();
                    dr["Ownerid"] = cboOwnerid.Text.Trim();
                    dr["Capacity"] = txtCapacity.Text.Trim();
                    dr["Category"] = cboCategory.SelectedItem;
                    dr["allowedgender"] = cmbHgender.Text;
                    dr["Distance"] = txtDistance.Text.Trim();
                    dr["AdditionaIitems"] = txtAdditionalitems.Text.Trim();
                    dr["Rent"] = txtRent.Text.Trim();
                    dr["maxoccupants"] = numericUpDown3.Value;


                    dt.Rows.Add(dr);
                    adapter.Update(dt);
                    string query1 = "UPDATE `tbhostels` SET `totaloccupancy`=`maxoccupants`*`Capacity` ";
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset controls
                    txtHostelname.Text = string.Empty;
                    txtCapacity.Text = string.Empty;
                    txtDistance.Text = string.Empty;
                    txtAdditionalitems.Text = string.Empty;
                    txtRent.Text = string.Empty;
                    cboOwnerid.SelectedIndex = -1;
                    cboCategory.SelectedIndex = -1;
                    numericUpDown3.Value = numericUpDown3.Minimum;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostels ORDER BY name ";
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
            else
            {
                MessageBox.Show("All the Fields must be Correctly Filled First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmdHupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnHacancel_Click(object sender, EventArgs e)
        {
            //reset controls
            txtHostelname.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            txtDistance.Text = string.Empty;
            txtAdditionalitems.Text = string.Empty;
            txtRent.Text = string.Empty;
            cboOwnerid.SelectedIndex = -1;
            cboCategory.SelectedIndex = -1;
            numericUpDown3.Value = numericUpDown3.Minimum;
        }

        private void cmdRemoveitem_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            string hostelid = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
            if (hostelid == "")
            {
                MessageBox.Show("You Must Select an Hostelid from the Table to delete it", "Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM  tbhostels WHERE hostelid='" + hostelid + "';";
                    MySqlCommand cmmd = new MySqlCommand(query, conn);
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        try
                        {
                            conn = new MySqlConnection(constring);
                            string query1 = "SELECT * FROM tbhostels order by name";
                            adapter = new MySqlDataAdapter(query1, conn);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAhviewsaveddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbhostels ORDER BY Name";
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

        private void cmbHsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHsearchby.Text == "OWNER ID")
            {
                wmtxtHsearch.Text = "";
                wmtxtHsearch.WaterMarkText = "select from the drop down list labelled Ownner Id";
                wmtxtHsearch.Enabled = false;
            }
            else if (cmbHsearchby.Text == "HOSTEL NAME")
            {
                wmtxtHsearch.Text = "";
                wmtxtHsearch.WaterMarkText = "Type Hostel Name Here";
                wmtxtHsearch.Enabled = true;
            }
            else if (cmbHsearchby.Text == "MAXIMUM DISTANCE")
            {
                wmtxtHsearch.Text = "";
                wmtxtHsearch.WaterMarkText = "Type The Maximum Distance Here";
                wmtxtHsearch.Enabled = true;
            }
            else if (cmbHsearchby.Text == "HOSTEL ID")
            {
                wmtxtHsearch.Text = "";
                wmtxtHsearch.WaterMarkText = "Type The Hostel Id Here";
                wmtxtHsearch.Enabled = true;
            }
        }

        private void btnHsearch_Click(object sender, EventArgs e)
        {
            if (cmbHsearchby.SelectedItem.ToString() == "OWNER ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostels WHERE ownerid='" + this.cboOwnerid.Text.Trim() + "';";
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
                cmbHsearchby.Text = "Search by";
                wmtxtHsearch.WaterMarkText = string.Empty;
            }
            else if (cmbHsearchby.SelectedItem.ToString() == "HOSTEL NAME")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostels WHERE name LIKE '%" + this.wmtxtHsearch.Text.Trim() + "%'";
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
                cmbHsearchby.Text = "Search by";
                wmtxtHsearch.WaterMarkText = string.Empty; 
            }
            else if (cmbHsearchby.SelectedItem.ToString() == "MAXIMUM DISTANCE")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostels WHERE distance<='" + this.wmtxtHsearch.Text.Trim() + "';";
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
                cmbHsearchby.Text = "Search by";
                wmtxtHsearch.WaterMarkText = string.Empty;
            }
            else if (cmbHsearchby.SelectedItem.ToString() == "HOSTEL ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbhostels WHERE hostelid='" + this.wmtxtHsearch.Text.Trim() + "';";
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
                cmbHsearchby.Text = "Search by";
                wmtxtHsearch.WaterMarkText = string.Empty;
            }
        }

        private void cboOwnerid_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tblandlords";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                cboOwnerid.DataSource = dt;
                cboOwnerid.FormattingEnabled = true;
                cboOwnerid.DisplayMember = "landlordid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem.ToString() == "Single")
            {
                txtRent.WaterMarkText = "rent should be between 8000 & 20000";
            }
            else if (cboCategory.SelectedItem.ToString() == "Double")
            {

                txtRent.WaterMarkText = "rent should be between 10000 & 24000";
            }
            else if (cboCategory.SelectedItem.ToString() == "Bedsitter")
            {
                txtRent.WaterMarkText = "rent should be between 10000 & 24000";
            }
            else if (cboCategory.SelectedItem.ToString() == "Selfcontained")
            {
                txtRent.WaterMarkText = "rent should be between 17000 & 51000";
            }
        }

        private void txtRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
