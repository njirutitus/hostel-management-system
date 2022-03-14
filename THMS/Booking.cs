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
    public partial class Booking : Form
    {

        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        MySqlDataAdapter adapter = null;
        MySqlCommandBuilder cmd;
        DataTable dt;
        DataRow dr;
        int occupancy;
        public Booking()
        {
            InitializeComponent();
        }

        private void btnBviewsaveddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbbooking";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBsearchby.SelectedItem.ToString() == "STUDENT'S NAME")
            {
                wmtxtBsearch.Text = "";
                wmtxtBsearch.WaterMarkText = "Type The Student's Name Here";
                wmtxtBsearch.Enabled = true;
            }
            if (cmbBsearchby.SelectedItem.ToString() == "STUDENT REGISTRATION NUMBER")
            {
                wmtxtBsearch.Text = "";
                wmtxtBsearch.WaterMarkText = "Type the student's registration number Here";
            }
            if (cmbBsearchby.SelectedItem.ToString() == "HOSTEL ID")
            {
                wmtxtBsearch.Text = "";
                wmtxtBsearch.WaterMarkText = "Select from drop down list labelled Hostel Id";
                wmtxtBsearch.Enabled = false;
            }
        }

        private void btnBsearch_Click(object sender, EventArgs e)
        {
            if (cmbBsearchby.SelectedItem.ToString() == "STUDENT NAME")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbbooking WHERE studentname like '%" + this.wmtxtBsearch.Text.Trim() + "%'";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbBsearchby.SelectedItem.ToString() == "STUDENT'S REGISTRATION NUMBER")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbbooking WHERE regno='" + this.wmtxtBsearch.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmbBsearchby.SelectedItem.ToString() == "HOSTEL ID")
            {
                try
                {
                    conn = new MySqlConnection(constring);
                    string query = "SELECT * FROM tbbooking WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "';";
                    adapter = new MySqlDataAdapter(query, conn);
                    cmd = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cboBhostelid_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbOccupancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rent;
            int max;
            try
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                string query = "SELECT rent FROM tbhostels WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "';";
                string query1 = "SELECT maxoccupants FROM tbhostels WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "';";
                MySqlCommand cmmd = new MySqlCommand(query, conn);
                MySqlCommand cmd = new MySqlCommand(query1, conn);
                rent = (Int32)cmmd.ExecuteScalar();
                max = (Int32)cmd.ExecuteScalar();
                if (cmbOccupancy.Text == "WITH ROOMMATES")
                {
                    occupancy = 1;
                    double renttobepaid = rent / max;
                    txtAmounttobepaid.Text = renttobepaid.ToString();
                }
                else if (cmbOccupancy.Text == "ALONE")
                {
                    occupancy = max;
                    txtAmounttobepaid.Text = rent.ToString();
                }
                else if (cmbOccupancy.Text == "")
                {
                    txtAmounttobepaid.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSubmit_Click_1(object sender, EventArgs e)
        {
            int occstatus = 1; //vacancy status variable.  1 for yes and 0 for no
            int genderverified = 1;
            int roomno = 1;
            if (txtBstudentname.Text.Trim() != "" && txtBregno.Text.Trim() != "" && cmbStudentgender.Text.Trim() != "" && cboBfaculty.Text.Trim() != "" && cboBhostelid.Text.Trim() != "" && cboBsempaidfor.Text != "" && numericUpDownByear.Value != numericUpDownByear.Minimum && cmdPaymentmode.Text != "" && txtBtransactionno.Text.Trim() != "")
            {
                //Check if there is vacant room in the selected hostel
                int occupied;
                int max;
                try
                {
                    conn = new MySqlConnection(constring);
                    conn.Open();
                    string queryoccupied = "SELECT sum(occupancy) FROM tbbooking WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "' and sempaidfor='" + this.cboBsempaidfor.Text + "' and year='" + this.numericUpDownByear.Value + "'";
                    string querymax = "SELECT totaloccupancy FROM tbhostels WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "';";
                    MySqlCommand cmmd = new MySqlCommand(queryoccupied, conn);
                    MySqlCommand cmd = new MySqlCommand(querymax, conn);
                    if (cmmd.ExecuteScalar() is DBNull)
                    {
                    }
                    else
                    {
                        occupied = Convert.ToInt32(cmmd.ExecuteScalar());
                        max = Convert.ToInt32(cmd.ExecuteScalar());
                        if (occupied >= max)
                        {
                            MessageBox.Show("This hostel is fully occupied");
                            cboBhostelid.SelectedIndex = -1;
                            cmbOccupancy.SelectedIndex = -1;
                            occstatus = 0;
                        }
                        else if (occupied < max)
                        {
                            if ((max - occupied) < occupancy)
                            {
                                MessageBox.Show("You can not stay in your own room in this hostel");
                                cmbOccupancy.SelectedIndex = -1;
                                occstatus = 0;


                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //verify Gender
                try
                {
                    string gender = null;
                    string gndr = null;
                    conn.Close();
                    conn = new MySqlConnection(constring);
                    string querygender = "select allowedgender from tbhostels where hostelid='" + this.cboBhostelid.Text + "'";
                    MySqlCommand cmdgender = new MySqlCommand(querygender, conn);
                    conn.Open();
                    gender = Convert.ToString(cmdgender.ExecuteScalar());
                    if (cmbStudentgender.Text != gender)
                    {
                        genderverified = 0;
                        if (gender == "FEMALE")
                        {
                            gndr = "Lady";
                            MessageBox.Show("you must be a " + gndr + " To occupy this hostel");
                            cmbStudentgender.SelectedIndex = -1;
                            cmbOccupancy.SelectedIndex = -1;
                        }
                        else if (gender == "MALE")
                        {
                            gndr = "Gentleman";
                            MessageBox.Show("you must be a " + gndr + " To occupy this hostel");
                            cmbStudentgender.SelectedIndex = -1;
                            cmbOccupancy.SelectedIndex = -1;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (occstatus == 1 && genderverified ==1)
                {

                    try
                    {
                        // check for duplicate transactions
                        string query1 = "SELECT transactionno FROM tbbooking WHERE transactionno='" + this.txtBtransactionno.Text + "' and modeofpayment='" + this.cmdPaymentmode.Text + "'";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        string transactionno = (string)cmd1.ExecuteScalar();

                        if (transactionno == txtBtransactionno.Text)
                        {
                            MessageBox.Show("Duplicate Transaction detected", "Error");
                            cmbOccupancy.SelectedIndex = -1;
                        }
                        else
                        {
                            //Allocate room
                            int maximum;
                            string queryroomno = "select max(roomno) from tbbooking where hostelid='" + this.cboBhostelid.Text.Trim() + "' and sempaidfor='" + this.cboBsempaidfor.Text + "' and year='" + this.numericUpDownByear.Value + "'";
                            MySqlCommand cmdr = new MySqlCommand(queryroomno, conn);
                            if (cmdr.ExecuteScalar() is  DBNull)
                            {
                                maximum = 0;
                                roomno = maximum + 1;
                            }
                            else
                            {
                                maximum = Convert.ToInt32(cmdr.ExecuteScalar());
                                roomno = maximum + 1;
                                if (cmbOccupancy.Text == "WITH ROOMMATES")
                                {
                                    do
                                    {
                                        string queryocc = "select sum(occupancy) from tbbooking where roomno='" + maximum + "' and hostelid='" + this.cboBhostelid.Text.Trim() + "' and sempaidfor='" + this.cboBsempaidfor.Text + "' and year='" + this.numericUpDownByear.Value + "'";
                                        string querymaxocc = "SELECT maxoccupants FROM tbhostels WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "';";
                                        string querygndr = "select studentgender from tbbooking where roomno='" + maximum + "' and hostelid='" + this.cboBhostelid.Text.Trim() + "' and sempaidfor='" + this.cboBsempaidfor.Text + "' and year='" + this.numericUpDownByear.Value + "'";
                                        MySqlCommand cmdocc = new MySqlCommand(queryocc, conn);
                                        MySqlCommand cmdmaxocc = new MySqlCommand(querymaxocc, conn);
                                        MySqlCommand cmdgndr = new MySqlCommand(querygndr, conn);

                                        int occ = Convert.ToInt32(cmdocc.ExecuteScalar());
                                        int maxocc = Convert.ToInt32(cmdmaxocc.ExecuteScalar());
                                        string gndr = Convert.ToString(cmdgndr.ExecuteScalar());
                                        if (occ < maxocc)
                                        {
                                            if (gndr == cmbStudentgender.Text.Trim())
                                            {
                                                roomno = maximum;
                                            }

                                        }
                                        maximum--;
                                    }
                                    while (maximum > 0);
                                
                                }
                            }
                            //save the record to the database
                            try
                            {
                                conn = new MySqlConnection(constring);
                                string query = "SELECT * FROM tbbooking";
                                adapter = new MySqlDataAdapter(query, conn);
                                cmd = new MySqlCommandBuilder(adapter);
                                dt = new DataTable();
                                adapter.Fill(dt);
                                dr = dt.NewRow();
                                dr["studentname"] = txtBstudentname.Text.Trim();
                                dr["regno"] = txtBregno.Text.Trim();
                                dr["roomno"] = roomno;
                                dr["studentgender"] = cmbStudentgender.Text;
                                dr["faculty"] = cboBfaculty.Text.Trim();
                                dr["hostelid"] = cboBhostelid.Text.Trim();
                                dr["sempaidfor"] = cboBsempaidfor.SelectedItem;
                                dr["year"] = numericUpDownByear.Value;
                                dr["occupancy"] = occupancy;
                                dr["modeofpayment"] = cmdPaymentmode.SelectedItem;
                                dr["transactionno"] = txtBtransactionno.Text.Trim();

                                dt.Rows.Add(dr);
                                adapter.Update(dt);
                                MessageBox.Show("Submitted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            //refresh the data table
                            try
                            {
                                conn = new MySqlConnection(constring);
                                string query = "SELECT * FROM tbbooking";
                                adapter = new MySqlDataAdapter(query, conn);
                                cmd = new MySqlCommandBuilder(adapter);
                                dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView2.DataSource = dt;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                            //printing receipt
                            {

                                try
                                {
                                    receipt rct = new receipt();
                                    conn = new MySqlConnection(constring);
                                    string query = "SELECT name FROM tbhostels WHERE hostelid='" + this.cboBhostelid.Text.Trim() + "';";
                                    conn.Open();
                                    MySqlCommand cmmd = new MySqlCommand(query, conn);
                                    string hostelname = (string)cmmd.ExecuteScalar();


                                    if (Variables.usertype == "STAFF")
                                    {
                                        string query3 = "SELECT staffname FROM tbstaff WHERE nid='" + Variables.userid + "';";
                                        MySqlCommand cmd2 = new MySqlCommand(query3, conn);
                                        string staffname = (string)cmd2.ExecuteScalar();
                                        rct.drawnBy = staffname;
                                    }
                                    else if (Variables.usertype == "ADMINISTRATOR")
                                    {
                                        rct.drawnBy = "ADMINISTRATOR";
                                    }
                                    try
                                    {
                                        string query5 = "SELECT receiptno FROM tbbooking WHERE transactionno='" + this.txtBtransactionno.Text + "';";
                                        MySqlCommand cmd5 = new MySqlCommand(query5, conn);
                                        int receiptno = (Int32)cmd5.ExecuteScalar();


                                        rct.Studentname = txtBstudentname.Text;
                                        rct.Regno = txtBregno.Text.Trim();
                                        rct.Hostelid = int.Parse(cboBhostelid.Text.Trim());
                                        rct.Hostelname = hostelname;
                                        rct.Receiptno = receiptno;
                                        rct.Roomno = roomno;
                                        rct.Occupancy = cmbOccupancy.Text;
                                        rct.amount = float.Parse(txtAmounttobepaid.Text);
                                        rct.ReceiptDate = DateTime.Now;


                                        rct.print();
                                        MessageBox.Show("Receipt Printed Successfully");
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //reset controls
                    txtBstudentname.Text = string.Empty;
                    txtBregno.Text = string.Empty;
                    cboBfaculty.Text = "";
                    cboBhostelid.Text = string.Empty;
                    cboBsempaidfor.SelectedIndex = -1;
                    numericUpDownByear.Value = numericUpDownByear.Minimum;
                    cmbOccupancy.SelectedIndex = -1;
                    cmbStudentgender.SelectedIndex = -1;
                    cmdPaymentmode.SelectedIndex = -1;
                    txtBtransactionno.Text = string.Empty;
                    txtAmounttobepaid.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("All the Fields must be Filled First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHbcancel_Click(object sender, EventArgs e)
        {
            //reset controls
            txtBstudentname.Text = string.Empty;
            txtBregno.Text = string.Empty;
            cboBfaculty.SelectedIndex = -1;
            cboBhostelid.SelectedIndex = -1;
            cboBsempaidfor.SelectedIndex = -1;
            numericUpDownByear.Value = numericUpDownByear.Minimum;
            cmbOccupancy.SelectedIndex = -1;
            cmdPaymentmode.SelectedIndex = -1;
            txtBtransactionno.Text = string.Empty;
        }

        private void cboBhostelid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboBhostelid_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(constring);
                string query = "SELECT * FROM tbhostels";
                adapter = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(adapter);
                dt = new DataTable();
                adapter.Fill(dt);
                cboBhostelid.DataSource = dt;
                cboBhostelid.FormattingEnabled = true;
                cboBhostelid.DisplayMember = "hostelid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStudentgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbStudentgender_Leave(object sender, EventArgs e)
        {
            
            if (cboBhostelid.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("the hostel id must be selected first");

            }
        }

        private void txtBtransactionno_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
