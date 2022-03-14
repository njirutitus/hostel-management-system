namespace THMS
{
    partial class AgentRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgcancel = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.btnAsearch = new System.Windows.Forms.Button();
            this.cmbAsearchby = new System.Windows.Forms.ComboBox();
            this.btnAgviewsaveddata = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboAbank = new System.Windows.Forms.ComboBox();
            this.txtApaybillno = new System.Windows.Forms.TextBox();
            this.txtAbankaccname = new System.Windows.Forms.TextBox();
            this.txtAbankaccno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAgupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAphoneno = new System.Windows.Forms.TextBox();
            this.txtAaddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAnid = new System.Windows.Forms.TextBox();
            this.txtAname = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.wmtxtAnsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgcancel
            // 
            this.btnAgcancel.Location = new System.Drawing.Point(122, 486);
            this.btnAgcancel.Name = "btnAgcancel";
            this.btnAgcancel.Size = new System.Drawing.Size(72, 29);
            this.btnAgcancel.TabIndex = 55;
            this.btnAgcancel.Text = "&CANCEL";
            this.btnAgcancel.UseVisualStyleBackColor = true;
            this.btnAgcancel.Click += new System.EventHandler(this.btnAgcancel_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(87, 79);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(336, 14);
            this.label70.TabIndex = 54;
            this.label70.Text = "NB: To Delete or Update an Agent the National Id No field must be filled";
            // 
            // btnAsearch
            // 
            this.btnAsearch.Location = new System.Drawing.Point(914, 75);
            this.btnAsearch.Name = "btnAsearch";
            this.btnAsearch.Size = new System.Drawing.Size(75, 23);
            this.btnAsearch.TabIndex = 53;
            this.btnAsearch.Text = "Search";
            this.btnAsearch.UseVisualStyleBackColor = true;
            this.btnAsearch.Click += new System.EventHandler(this.btnAsearch_Click);
            // 
            // cmbAsearchby
            // 
            this.cmbAsearchby.FormattingEnabled = true;
            this.cmbAsearchby.Items.AddRange(new object[] {
            "NATIONAL ID NO.",
            "NAME",
            "PHONE NO."});
            this.cmbAsearchby.Location = new System.Drawing.Point(571, 77);
            this.cmbAsearchby.Name = "cmbAsearchby";
            this.cmbAsearchby.Size = new System.Drawing.Size(325, 21);
            this.cmbAsearchby.TabIndex = 52;
            this.cmbAsearchby.Text = "search by";
            this.cmbAsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbAsearchby_SelectedIndexChanged);
            // 
            // btnAgviewsaveddata
            // 
            this.btnAgviewsaveddata.Location = new System.Drawing.Point(439, 90);
            this.btnAgviewsaveddata.Name = "btnAgviewsaveddata";
            this.btnAgviewsaveddata.Size = new System.Drawing.Size(103, 23);
            this.btnAgviewsaveddata.TabIndex = 51;
            this.btnAgviewsaveddata.Text = "View Saved Data";
            this.btnAgviewsaveddata.UseVisualStyleBackColor = true;
            this.btnAgviewsaveddata.Click += new System.EventHandler(this.btnAgviewsaveddata_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(426, 119);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(575, 409);
            this.dataGridView6.TabIndex = 50;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(254, 489);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(68, 26);
            this.cmdDelete.TabIndex = 49;
            this.cmdDelete.Text = "&DELETE";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboAbank);
            this.groupBox4.Controls.Add(this.txtApaybillno);
            this.groupBox4.Controls.Add(this.txtAbankaccname);
            this.groupBox4.Controls.Add(this.txtAbankaccno);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(42, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 129);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PAYMENT DETAILS";
            // 
            // cboAbank
            // 
            this.cboAbank.FormattingEnabled = true;
            this.cboAbank.Items.AddRange(new object[] {
            "EQUITY BANK",
            "KCB",
            "COOPERATIVE",
            "FAMILY",
            "DIAMOND TRUST",
            "K-REP",
            "FAULU",
            "BANK OF AFRICA",
            "ABC BANK",
            "BANK OF INDIA",
            "BANK OF BARODA",
            "BARCLAYS BANK KENYA",
            "CFC STANBIC HOLDINGS",
            "CHASE BANK KENYA",
            "CITIBANK",
            "CBK",
            "CONSOLODITATED BANK OF KENYA",
            "CREDIT BANK",
            "DEVELOPMENT BANK OF KENYA",
            "FIDELITY COMMERCIAL BANK LIMITED",
            "FIRST COMMUNITY BANK",
            "GIRO COMMERCIAL BANK",
            "GUARANTY TRUST BANK OF KENYA",
            "GUARDIAN BANK",
            "GULF AFRICAN BANK",
            "HABIB BANK",
            "HABIB BANK AG ZURICH",
            "HOUSING FINANCE COMPANY OF KENYA",
            "I&M BANK",
            "IMPERIAL BANK OF KENYA",
            "JAMII BORA BANK",
            "K-REP BANK",
            "MIDDLE EAST BANK KENYA",
            "NATIONAL BANK OF KENYA",
            "NIC BANK",
            "ORIENTAL COMMERCIAL BANK",
            "PARAMOUNT UNIVERSAL BANK",
            "PRIME BANK(KENYA)",
            "STARDARD CHARTERED BANK",
            "TRANS NATIONAL BANK KENYA",
            "UNITED BANK FOR AFRICA",
            "VICTORIA COMMERCIAL BANK"});
            this.cboAbank.Location = new System.Drawing.Point(133, 74);
            this.cboAbank.Name = "cboAbank";
            this.cboAbank.Size = new System.Drawing.Size(215, 21);
            this.cboAbank.TabIndex = 11;
            // 
            // txtApaybillno
            // 
            this.txtApaybillno.Location = new System.Drawing.Point(134, 103);
            this.txtApaybillno.Name = "txtApaybillno";
            this.txtApaybillno.Size = new System.Drawing.Size(146, 20);
            this.txtApaybillno.TabIndex = 10;
            // 
            // txtAbankaccname
            // 
            this.txtAbankaccname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbankaccname.Location = new System.Drawing.Point(134, 48);
            this.txtAbankaccname.Name = "txtAbankaccname";
            this.txtAbankaccname.Size = new System.Drawing.Size(214, 20);
            this.txtAbankaccname.TabIndex = 9;
            // 
            // txtAbankaccno
            // 
            this.txtAbankaccno.Location = new System.Drawing.Point(135, 23);
            this.txtAbankaccno.Name = "txtAbankaccno";
            this.txtAbankaccno.Size = new System.Drawing.Size(213, 20);
            this.txtAbankaccno.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "PAYBILL NO.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "BANK ACC. NO.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "BANK ACC. NAME";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "BANK";
            // 
            // btnAgupdate
            // 
            this.btnAgupdate.Location = new System.Drawing.Point(248, 444);
            this.btnAgupdate.Name = "btnAgupdate";
            this.btnAgupdate.Size = new System.Drawing.Size(74, 28);
            this.btnAgupdate.TabIndex = 48;
            this.btnAgupdate.Text = "&UPDATE";
            this.btnAgupdate.UseVisualStyleBackColor = true;
            this.btnAgupdate.Click += new System.EventHandler(this.btnAgupdate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 28);
            this.button4.TabIndex = 47;
            this.button4.Text = "&SAVE PRINT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAphoneno);
            this.groupBox5.Controls.Add(this.txtAaddress);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(42, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 85);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CONTACT DETAILS";
            // 
            // txtAphoneno
            // 
            this.txtAphoneno.Location = new System.Drawing.Point(133, 45);
            this.txtAphoneno.MaxLength = 12;
            this.txtAphoneno.Name = "txtAphoneno";
            this.txtAphoneno.Size = new System.Drawing.Size(165, 20);
            this.txtAphoneno.TabIndex = 5;
            // 
            // txtAaddress
            // 
            this.txtAaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAaddress.Location = new System.Drawing.Point(133, 19);
            this.txtAaddress.Name = "txtAaddress";
            this.txtAaddress.Size = new System.Drawing.Size(166, 20);
            this.txtAaddress.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "ADDRESS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "PHONE NUMBER";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAnid);
            this.groupBox6.Controls.Add(this.txtAname);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(42, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(378, 82);
            this.groupBox6.TabIndex = 44;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PERSONAL DETAILS";
            // 
            // txtAnid
            // 
            this.txtAnid.Location = new System.Drawing.Point(140, 54);
            this.txtAnid.MaxLength = 8;
            this.txtAnid.Name = "txtAnid";
            this.txtAnid.Size = new System.Drawing.Size(153, 20);
            this.txtAnid.TabIndex = 3;
            this.txtAnid.TextChanged += new System.EventHandler(this.txtAnid_TextChanged);
            this.txtAnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnid_KeyPress);
            // 
            // txtAname
            // 
            this.txtAname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAname.Location = new System.Drawing.Point(142, 19);
            this.txtAname.Name = "txtAname";
            this.txtAname.Size = new System.Drawing.Size(180, 20);
            this.txtAname.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "NAME";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "NATIONAL ID NO";
            // 
            // wmtxtAnsearch
            // 
            this.wmtxtAnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtAnsearch.Location = new System.Drawing.Point(571, 104);
            this.wmtxtAnsearch.Name = "wmtxtAnsearch";
            this.wmtxtAnsearch.Size = new System.Drawing.Size(325, 20);
            this.wmtxtAnsearch.TabIndex = 56;
            this.wmtxtAnsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtAnsearch.WaterMarkText = "";
            // 
            // AgentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 525);
            this.Controls.Add(this.wmtxtAnsearch);
            this.Controls.Add(this.btnAgcancel);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.btnAsearch);
            this.Controls.Add(this.cmbAsearchby);
            this.Controls.Add(this.btnAgviewsaveddata);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAgupdate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "AgentRegistration";
            this.Text = "AGENT REGISTRATION";
            this.Load += new System.EventHandler(this.AgentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgcancel;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button btnAsearch;
        private System.Windows.Forms.ComboBox cmbAsearchby;
        private System.Windows.Forms.Button btnAgviewsaveddata;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboAbank;
        private System.Windows.Forms.TextBox txtApaybillno;
        private System.Windows.Forms.TextBox txtAbankaccname;
        private System.Windows.Forms.TextBox txtAbankaccno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAgupdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAphoneno;
        private System.Windows.Forms.TextBox txtAaddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtAnid;
        private System.Windows.Forms.TextBox txtAname;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private PROJE.WaterMarkTextBox wmtxtAnsearch;
    }
}