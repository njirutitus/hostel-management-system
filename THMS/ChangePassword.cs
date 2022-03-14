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
    public partial class ChangePassword : Form
    {
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Home secondform;
            secondform = new Home();
            string passwd;
            string newpass;
            string reenter;
            string adminpass;
            try
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                string query = "SELECT password FROM tbstaff WHERE nid='" + this.txtCuserid.Text.Trim() + "';";
                string query1 = "SELECT adminpassword FROM admin WHERE id=1";
                MySqlCommand cmmd = new MySqlCommand(query, conn);
                MySqlCommand cmd = new MySqlCommand(query1, conn);
                passwd = (string)cmmd.ExecuteScalar();
                adminpass = (string)cmd.ExecuteScalar();
                Variables.usertype = cmbCusertype.SelectedItem.ToString();
                string old = txtOld.Text.Trim();
                newpass = txtNew.Text.Trim();
                reenter = txtReenter.Text.Trim();
                conn.Close();
                if (Variables.usertype == "ADMINISTRATOR")
                {
                    if (old == adminpass && newpass == reenter || Variables.usertype == "STAFF" && old == passwd && newpass == reenter)
                    {
                        try
                        {
                            string query3 = "UPDATE admin SET adminpassword='" + newpass + "' WHERE id=1";
                            conn = new MySqlConnection(constring);
                            MySqlCommand cmd2 = new MySqlCommand(query3, conn);
                            conn.Open();
                            MySqlDataReader myreader3;
                            myreader3 = cmd2.ExecuteReader();
                            MessageBox.Show("password successfully changed");
                            while (myreader3.Read())
                            {
                            }
                            secondform.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("passwords do not match", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Variables.usertype == "STAFF")
                {
                    if (old == passwd && newpass == reenter)
                    {
                        try
                        {

                            string query2 = "UPDATE tbstaff SET password='" + newpass + "' WHERE nid='" + this.txtCuserid.Text.Trim() + "';";
                            conn = new MySqlConnection(constring);
                            MySqlCommand cmd1 = new MySqlCommand(query2, conn);
                            conn.Open();
                            MySqlDataReader myreader2;
                            myreader2 = cmd1.ExecuteReader();
                            MessageBox.Show("password successfully changed");
                            while (myreader2.Read())
                            {
                            }
                            secondform.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("passwords do not match", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Forgot_Password_Load(object sender, EventArgs e)
        {
            cmbCusertype.SelectedItem = "ADMINISTRATOR";
        }

        private void cmbCusertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCusertype.SelectedItem.ToString() == "ADMINISTRATOR")
            {
                txtCuserid.Hide();
                label2.Hide();
            }

            else if (cmbCusertype.SelectedItem.ToString() == "STAFF")
            {
                txtCuserid.Show();
                label2.Show();
                txtCuserid.WaterMarkText = "Type Your National Id Number Here";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Close();
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            login Login = new login();
            Login.Show();

        }

        private void txtCuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }

