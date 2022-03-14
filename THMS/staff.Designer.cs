namespace THMS
{
    partial class staff
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
            this.btnSCancel = new System.Windows.Forms.Button();
            this.cmbSsearchby = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.txtPaybillno = new System.Windows.Forms.TextBox();
            this.txtBankaccname = new System.Windows.Forms.TextBox();
            this.txtBankaccno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSsearch = new PROJE.WaterMarkTextBox();
            this.txtPassword = new PROJE.WaterMarkTextBox();
            this.btnSsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSCancel
            // 
            this.btnSCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCancel.Location = new System.Drawing.Point(53, 431);
            this.btnSCancel.Name = "btnSCancel";
            this.btnSCancel.Size = new System.Drawing.Size(92, 38);
            this.btnSCancel.TabIndex = 52;
            this.btnSCancel.Text = "&CANCEL";
            this.btnSCancel.UseVisualStyleBackColor = true;
            this.btnSCancel.Click += new System.EventHandler(this.btnSCancel_Click);
            // 
            // cmbSsearchby
            // 
            this.cmbSsearchby.FormattingEnabled = true;
            this.cmbSsearchby.Items.AddRange(new object[] {
            "NATIONAL ID NO.",
            "NAME",
            "PHONE NO."});
            this.cmbSsearchby.Location = new System.Drawing.Point(548, 26);
            this.cmbSsearchby.Name = "cmbSsearchby";
            this.cmbSsearchby.Size = new System.Drawing.Size(322, 21);
            this.cmbSsearchby.TabIndex = 51;
            this.cmbSsearchby.Text = "search by";
            this.cmbSsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbSsearchby_SelectedIndexChanged);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(363, 28);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(138, 24);
            this.button11.TabIndex = 50;
            this.button11.Text = "&VEW SAVED DATA";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(363, 81);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(635, 415);
            this.dataGridViewStaff.TabIndex = 49;
            this.dataGridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Password";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdno);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 87);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtIdno
            // 
            this.txtIdno.Location = new System.Drawing.Point(123, 47);
            this.txtIdno.MaxLength = 8;
            this.txtIdno.Name = "txtIdno";
            this.txtIdno.Size = new System.Drawing.Size(227, 20);
            this.txtIdno.TabIndex = 3;
            this.txtIdno.TextChanged += new System.EventHandler(this.txtIdno_TextChanged);
            this.txtIdno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdno_KeyPress);
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(123, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID NO.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtPhoneno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 77);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.Location = new System.Drawing.Point(123, 43);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(123, 16);
            this.txtPhoneno.MaxLength = 12;
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(217, 20);
            this.txtPhoneno.TabIndex = 2;
            this.txtPhoneno.TextChanged += new System.EventHandler(this.txtPhoneno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(223, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 36);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.Location = new System.Drawing.Point(224, 376);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(89, 34);
            this.cmdUpdate.TabIndex = 46;
            this.cmdUpdate.Text = "&UPDATE";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(53, 376);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(71, 34);
            this.cmdSave.TabIndex = 45;
            this.cmdSave.Text = "&SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboBank);
            this.groupBox3.Controls.Add(this.txtPaybillno);
            this.groupBox3.Controls.Add(this.txtBankaccname);
            this.groupBox3.Controls.Add(this.txtBankaccno);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(7, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 129);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cboBank
            // 
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Items.AddRange(new object[] {
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
            this.cboBank.Location = new System.Drawing.Point(123, 82);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(221, 21);
            this.cboBank.TabIndex = 8;
            this.cboBank.SelectedIndexChanged += new System.EventHandler(this.cboBank_SelectedIndexChanged);
            // 
            // txtPaybillno
            // 
            this.txtPaybillno.Location = new System.Drawing.Point(123, 106);
            this.txtPaybillno.Name = "txtPaybillno";
            this.txtPaybillno.Size = new System.Drawing.Size(183, 20);
            this.txtPaybillno.TabIndex = 7;
            this.txtPaybillno.TextChanged += new System.EventHandler(this.txtPaybillno_TextChanged);
            this.txtPaybillno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaybillno_KeyPress);
            // 
            // txtBankaccname
            // 
            this.txtBankaccname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBankaccname.Location = new System.Drawing.Point(123, 54);
            this.txtBankaccname.Name = "txtBankaccname";
            this.txtBankaccname.Size = new System.Drawing.Size(183, 20);
            this.txtBankaccname.TabIndex = 5;
            this.txtBankaccname.TextChanged += new System.EventHandler(this.txtBankaccname_TextChanged);
            // 
            // txtBankaccno
            // 
            this.txtBankaccno.Location = new System.Drawing.Point(123, 19);
            this.txtBankaccno.Name = "txtBankaccno";
            this.txtBankaccno.Size = new System.Drawing.Size(183, 20);
            this.txtBankaccno.TabIndex = 4;
            this.txtBankaccno.TextChanged += new System.EventHandler(this.txtBankaccno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Paybill No.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bank";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bank Acc. Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bank Acc. No.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSsearch
            // 
            this.txtSsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSsearch.Location = new System.Drawing.Point(548, 54);
            this.txtSsearch.Name = "txtSsearch";
            this.txtSsearch.Size = new System.Drawing.Size(322, 20);
            this.txtSsearch.TabIndex = 53;
            this.txtSsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSsearch.WaterMarkText = "";
            this.txtSsearch.TextChanged += new System.EventHandler(this.txtSsearch_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(130, 346);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 54;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPassword.WaterMarkText = "Set default password for this user";
            // 
            // btnSsearch
            // 
            this.btnSsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSsearch.Location = new System.Drawing.Point(892, 28);
            this.btnSsearch.Name = "btnSsearch";
            this.btnSsearch.Size = new System.Drawing.Size(86, 24);
            this.btnSsearch.TabIndex = 55;
            this.btnSsearch.Text = "SEARCH";
            this.btnSsearch.UseVisualStyleBackColor = true;
            this.btnSsearch.Click += new System.EventHandler(this.btnSsearch_Click);
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.btnSsearch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSsearch);
            this.Controls.Add(this.btnSCancel);
            this.Controls.Add(this.cmbSsearchby);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.groupBox3);
            this.Name = "staff";
            this.Text = "STAFF REGISTRATION";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.ComboBox cmbSsearchby;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboBank;
        private System.Windows.Forms.TextBox txtPaybillno;
        private System.Windows.Forms.TextBox txtBankaccname;
        private System.Windows.Forms.TextBox txtBankaccno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private PROJE.WaterMarkTextBox txtSsearch;
        private PROJE.WaterMarkTextBox txtPassword;
        private System.Windows.Forms.Button btnSsearch;
    }
}