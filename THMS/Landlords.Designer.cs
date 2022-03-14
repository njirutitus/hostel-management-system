namespace THMS
{
    partial class Landlords
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
            this.btnLcancel = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.btnLdelete = new System.Windows.Forms.Button();
            this.btnLsearch = new System.Windows.Forms.Button();
            this.cmbLsearchby = new System.Windows.Forms.ComboBox();
            this.btnLviewsaveddata = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtLaddress = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtLphoneno = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtLnid = new System.Windows.Forms.TextBox();
            this.cmdLsaveprint = new System.Windows.Forms.Button();
            this.cmdLupdate = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtLbankaccname = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtLbankaccno = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cboLbank = new System.Windows.Forms.ComboBox();
            this.txtLpaybillno = new System.Windows.Forms.TextBox();
            this.txtLsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLcancel
            // 
            this.btnLcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLcancel.Location = new System.Drawing.Point(103, 506);
            this.btnLcancel.Name = "btnLcancel";
            this.btnLcancel.Size = new System.Drawing.Size(81, 33);
            this.btnLcancel.TabIndex = 62;
            this.btnLcancel.Text = "&CANCEL";
            this.btnLcancel.UseVisualStyleBackColor = true;
            this.btnLcancel.Click += new System.EventHandler(this.btnLcancel_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(63, 33);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(359, 15);
            this.label69.TabIndex = 61;
            this.label69.Text = "NB: To Delete or Update a Landlord the National Id No field must be filled";
            // 
            // btnLdelete
            // 
            this.btnLdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLdelete.Location = new System.Drawing.Point(231, 501);
            this.btnLdelete.Name = "btnLdelete";
            this.btnLdelete.Size = new System.Drawing.Size(103, 38);
            this.btnLdelete.TabIndex = 60;
            this.btnLdelete.Text = "&DELETE";
            this.btnLdelete.UseVisualStyleBackColor = true;
            this.btnLdelete.Click += new System.EventHandler(this.btnLdelete_Click);
            // 
            // btnLsearch
            // 
            this.btnLsearch.Location = new System.Drawing.Point(865, 51);
            this.btnLsearch.Name = "btnLsearch";
            this.btnLsearch.Size = new System.Drawing.Size(75, 23);
            this.btnLsearch.TabIndex = 59;
            this.btnLsearch.Text = "Search";
            this.btnLsearch.UseVisualStyleBackColor = true;
            this.btnLsearch.Click += new System.EventHandler(this.btnLsearch_Click);
            // 
            // cmbLsearchby
            // 
            this.cmbLsearchby.FormattingEnabled = true;
            this.cmbLsearchby.Items.AddRange(new object[] {
            "NATIONAL ID NO.",
            "NAME",
            "PHONE NO."});
            this.cmbLsearchby.Location = new System.Drawing.Point(568, 42);
            this.cmbLsearchby.Name = "cmbLsearchby";
            this.cmbLsearchby.Size = new System.Drawing.Size(278, 21);
            this.cmbLsearchby.TabIndex = 58;
            this.cmbLsearchby.Text = "search by";
            this.cmbLsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbLsearchby_SelectedIndexChanged);
            // 
            // btnLviewsaveddata
            // 
            this.btnLviewsaveddata.Location = new System.Drawing.Point(439, 53);
            this.btnLviewsaveddata.Name = "btnLviewsaveddata";
            this.btnLviewsaveddata.Size = new System.Drawing.Size(100, 23);
            this.btnLviewsaveddata.TabIndex = 57;
            this.btnLviewsaveddata.Text = "View Saved Data";
            this.btnLviewsaveddata.UseVisualStyleBackColor = true;
            this.btnLviewsaveddata.Click += new System.EventHandler(this.btnLviewsaveddata_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(408, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(587, 408);
            this.dataGridView3.TabIndex = 56;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.txtLaddress);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.txtLphoneno);
            this.groupBox7.Location = new System.Drawing.Point(41, 153);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(347, 100);
            this.groupBox7.TabIndex = 54;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Contact Details";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 26);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 13);
            this.label36.TabIndex = 10;
            this.label36.Text = "PHONE NO.";
            // 
            // txtLaddress
            // 
            this.txtLaddress.Location = new System.Drawing.Point(123, 55);
            this.txtLaddress.Name = "txtLaddress";
            this.txtLaddress.Size = new System.Drawing.Size(109, 20);
            this.txtLaddress.TabIndex = 2;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 58);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 13);
            this.label37.TabIndex = 19;
            this.label37.Text = "ADDRESS";
            // 
            // txtLphoneno
            // 
            this.txtLphoneno.Location = new System.Drawing.Point(123, 26);
            this.txtLphoneno.Name = "txtLphoneno";
            this.txtLphoneno.Size = new System.Drawing.Size(153, 20);
            this.txtLphoneno.TabIndex = 12;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtLname);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label35);
            this.groupBox8.Controls.Add(this.txtLnid);
            this.groupBox8.Location = new System.Drawing.Point(39, 53);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(343, 94);
            this.groupBox8.TabIndex = 53;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Personal Details";
            // 
            // txtLname
            // 
            this.txtLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLname.Location = new System.Drawing.Point(125, 19);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(188, 20);
            this.txtLname.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(38, 13);
            this.label39.TabIndex = 6;
            this.label39.Text = "NAME";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "NATIONAL ID";
            // 
            // txtLnid
            // 
            this.txtLnid.Location = new System.Drawing.Point(125, 45);
            this.txtLnid.MaxLength = 8;
            this.txtLnid.Name = "txtLnid";
            this.txtLnid.Size = new System.Drawing.Size(128, 20);
            this.txtLnid.TabIndex = 1;
            this.txtLnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLnid_KeyPress);
            // 
            // cmdLsaveprint
            // 
            this.cmdLsaveprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLsaveprint.Location = new System.Drawing.Point(103, 456);
            this.cmdLsaveprint.Name = "cmdLsaveprint";
            this.cmdLsaveprint.Size = new System.Drawing.Size(81, 24);
            this.cmdLsaveprint.TabIndex = 51;
            this.cmdLsaveprint.Text = "&SAVE";
            this.cmdLsaveprint.UseVisualStyleBackColor = true;
            this.cmdLsaveprint.Click += new System.EventHandler(this.cmdLsaveprint_Click);
            // 
            // cmdLupdate
            // 
            this.cmdLupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLupdate.Location = new System.Drawing.Point(231, 456);
            this.cmdLupdate.Name = "cmdLupdate";
            this.cmdLupdate.Size = new System.Drawing.Size(103, 27);
            this.cmdLupdate.TabIndex = 52;
            this.cmdLupdate.Text = "&UPDATE";
            this.cmdLupdate.UseVisualStyleBackColor = true;
            this.cmdLupdate.Click += new System.EventHandler(this.cmdLupdate_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.txtLbankaccname);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.Controls.Add(this.txtLbankaccno);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.cboLbank);
            this.groupBox9.Controls.Add(this.txtLpaybillno);
            this.groupBox9.Location = new System.Drawing.Point(39, 259);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(363, 191);
            this.groupBox9.TabIndex = 55;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Payment Details";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(4, 50);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(94, 13);
            this.label41.TabIndex = 9;
            this.label41.Text = "BANK ACC NAME";
            // 
            // txtLbankaccname
            // 
            this.txtLbankaccname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLbankaccname.Location = new System.Drawing.Point(125, 43);
            this.txtLbankaccname.Name = "txtLbankaccname";
            this.txtLbankaccname.Size = new System.Drawing.Size(218, 20);
            this.txtLbankaccname.TabIndex = 3;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(4, 91);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 13);
            this.label42.TabIndex = 8;
            this.label42.Text = "BANK ACC NO.";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 171);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(72, 13);
            this.label40.TabIndex = 20;
            this.label40.Text = "PAYBILL NO.";
            // 
            // txtLbankaccno
            // 
            this.txtLbankaccno.Location = new System.Drawing.Point(125, 91);
            this.txtLbankaccno.Name = "txtLbankaccno";
            this.txtLbankaccno.Size = new System.Drawing.Size(190, 20);
            this.txtLbankaccno.TabIndex = 4;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 131);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(36, 13);
            this.label38.TabIndex = 11;
            this.label38.Text = "BANK";
            // 
            // cboLbank
            // 
            this.cboLbank.FormattingEnabled = true;
            this.cboLbank.Items.AddRange(new object[] {
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
            this.cboLbank.Location = new System.Drawing.Point(125, 128);
            this.cboLbank.Name = "cboLbank";
            this.cboLbank.Size = new System.Drawing.Size(224, 21);
            this.cboLbank.TabIndex = 5;
            this.cboLbank.Text = "select your from the list";
            // 
            // txtLpaybillno
            // 
            this.txtLpaybillno.Location = new System.Drawing.Point(125, 168);
            this.txtLpaybillno.Name = "txtLpaybillno";
            this.txtLpaybillno.Size = new System.Drawing.Size(160, 20);
            this.txtLpaybillno.TabIndex = 13;
            this.txtLpaybillno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLpaybillno_KeyPress);
            // 
            // txtLsearch
            // 
            this.txtLsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLsearch.Location = new System.Drawing.Point(568, 66);
            this.txtLsearch.Name = "txtLsearch";
            this.txtLsearch.Size = new System.Drawing.Size(278, 20);
            this.txtLsearch.TabIndex = 63;
            this.txtLsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLsearch.WaterMarkText = "";
            // 
            // Landlords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 542);
            this.Controls.Add(this.txtLsearch);
            this.Controls.Add(this.btnLcancel);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.btnLdelete);
            this.Controls.Add(this.btnLsearch);
            this.Controls.Add(this.cmbLsearchby);
            this.Controls.Add(this.btnLviewsaveddata);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.cmdLsaveprint);
            this.Controls.Add(this.cmdLupdate);
            this.Controls.Add(this.groupBox9);
            this.Name = "Landlords";
            this.Text = "Landlords";
            this.Load += new System.EventHandler(this.Landlords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLcancel;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Button btnLdelete;
        private System.Windows.Forms.Button btnLsearch;
        private System.Windows.Forms.ComboBox cmbLsearchby;
        private System.Windows.Forms.Button btnLviewsaveddata;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtLaddress;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtLphoneno;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtLnid;
        private System.Windows.Forms.Button cmdLsaveprint;
        private System.Windows.Forms.Button cmdLupdate;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtLbankaccname;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtLbankaccno;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cboLbank;
        private System.Windows.Forms.TextBox txtLpaybillno;
        private PROJE.WaterMarkTextBox txtLsearch;
    }
}