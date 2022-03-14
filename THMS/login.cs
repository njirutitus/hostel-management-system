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
    public partial class login : Form
    {
        
        string constring = "DataSource=localhost; user=root; password=''; database=chms";
        MySqlConnection conn;
        //MySqlDataAdapter adapter;
        //MySqlCommandBuilder cmd;
        //DataTable dt;
        //DataRow dr;
        public login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Home secondform;
            secondform = new Home();
            string passwd;
            string pwd;
            string adminpass;
            try
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                string query = "SELECT password FROM tbstaff WHERE nid='" + this.txtUserid.Text.Trim() + "';";
                string query1 = "SELECT adminpassword FROM admin WHERE id=1";
                MySqlCommand cmmd = new MySqlCommand(query, conn);
                MySqlCommand cmd = new MySqlCommand(query1, conn);
                passwd = (string)cmmd.ExecuteScalar();
                adminpass = (string)cmd.ExecuteScalar();
                Variables.usertype = cboUsertype.SelectedItem.ToString();
                string password = msktxtPassword.Text.ToString();
                pwd = msktxtPassword.Text.ToString();
                
                if (Variables.usertype == "ADMINISTRATOR" && password == adminpass || Variables.usertype == "STAFF" && pwd == passwd)
                {
                    if (Variables.usertype == "STAFF")
                    {
                        MessageBox.Show("you logged in as a staff. some controls will not be accessible","Information");
                        Variables.userid = int.Parse(txtUserid.Text.Trim());
                    }
                    secondform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorrect login credetials", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ChangePassword change = new ChangePassword();
            change.Show();
            this.Hide();
        }

        private void cboUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsertype.SelectedItem.ToString() == "ADMINISTRATOR")
            {
                txtUserid.Enabled = false;
                txtUserid.Hide();
                label4.Hide();
            }
            else if (cboUsertype.SelectedItem.ToString() == "STAFF")
            {
                txtUserid.Enabled = true;
                txtUserid.WaterMarkText = "Type Your National Id Number";
                txtUserid.Show();
                label4.Show();
            }

        }

        private void txtUserid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            cboUsertype.SelectedItem = "ADMINISTRATOR";
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        }
    }

