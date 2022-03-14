namespace THMS
{
    partial class Booking
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
            this.cmbStudentgender = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.cmbOccupancy = new System.Windows.Forms.ComboBox();
            this.txtAmounttobepaid = new System.Windows.Forms.Label();
            this.txtBtransactionno = new System.Windows.Forms.TextBox();
            this.cmdPaymentmode = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.btnBsearch = new System.Windows.Forms.Button();
            this.cmbBsearchby = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.numericUpDownByear = new System.Windows.Forms.NumericUpDown();
            this.btnBviewsaveddata = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label55 = new System.Windows.Forms.Label();
            this.btnHbcancel = new System.Windows.Forms.Button();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.cboBsempaidfor = new System.Windows.Forms.ComboBox();
            this.cboBhostelid = new System.Windows.Forms.ComboBox();
            this.cboBfaculty = new System.Windows.Forms.ComboBox();
            this.txtBregno = new System.Windows.Forms.TextBox();
            this.txtBstudentname = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.wmtxtBsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudentgender
            // 
            this.cmbStudentgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentgender.FormattingEnabled = true;
            this.cmbStudentgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbStudentgender.Location = new System.Drawing.Point(163, 273);
            this.cmbStudentgender.Name = "cmbStudentgender";
            this.cmbStudentgender.Size = new System.Drawing.Size(183, 21);
            this.cmbStudentgender.TabIndex = 76;
            this.cmbStudentgender.SelectedIndexChanged += new System.EventHandler(this.cmbStudentgender_SelectedIndexChanged);
            this.cmbStudentgender.Leave += new System.EventHandler(this.cmbStudentgender_Leave);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(22, 281);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(108, 13);
            this.label74.TabIndex = 75;
            this.label74.Text = "STUDENT GENDER";
            // 
            // cmbOccupancy
            // 
            this.cmbOccupancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccupancy.FormattingEnabled = true;
            this.cmbOccupancy.Items.AddRange(new object[] {
            "ALONE",
            "WITH ROOMMATES"});
            this.cmbOccupancy.Location = new System.Drawing.Point(163, 309);
            this.cmbOccupancy.Name = "cmbOccupancy";
            this.cmbOccupancy.Size = new System.Drawing.Size(183, 21);
            this.cmbOccupancy.TabIndex = 74;
            this.cmbOccupancy.SelectedIndexChanged += new System.EventHandler(this.cmbOccupancy_SelectedIndexChanged);
            // 
            // txtAmounttobepaid
            // 
            this.txtAmounttobepaid.AutoSize = true;
            this.txtAmounttobepaid.Location = new System.Drawing.Point(170, 345);
            this.txtAmounttobepaid.Name = "txtAmounttobepaid";
            this.txtAmounttobepaid.Size = new System.Drawing.Size(0, 13);
            this.txtAmounttobepaid.TabIndex = 73;
            // 
            // txtBtransactionno
            // 
            this.txtBtransactionno.Location = new System.Drawing.Point(163, 408);
            this.txtBtransactionno.Name = "txtBtransactionno";
            this.txtBtransactionno.Size = new System.Drawing.Size(173, 20);
            this.txtBtransactionno.TabIndex = 72;
            this.txtBtransactionno.TextChanged += new System.EventHandler(this.txtBtransactionno_TextChanged);
            // 
            // cmdPaymentmode
            // 
            this.cmdPaymentmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdPaymentmode.FormattingEnabled = true;
            this.cmdPaymentmode.Items.AddRange(new object[] {
            "MPESA",
            "BANK"});
            this.cmdPaymentmode.Location = new System.Drawing.Point(163, 369);
            this.cmdPaymentmode.Name = "cmdPaymentmode";
            this.cmdPaymentmode.Size = new System.Drawing.Size(183, 21);
            this.cmdPaymentmode.TabIndex = 71;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(30, 411);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(106, 13);
            this.label56.TabIndex = 70;
            this.label56.Text = "TRANSACTION NO.";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(30, 377);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(111, 13);
            this.label65.TabIndex = 69;
            this.label65.Text = "MODE OF PAYMENT";
            // 
            // btnBsearch
            // 
            this.btnBsearch.Location = new System.Drawing.Point(864, 68);
            this.btnBsearch.Name = "btnBsearch";
            this.btnBsearch.Size = new System.Drawing.Size(75, 23);
            this.btnBsearch.TabIndex = 68;
            this.btnBsearch.Text = "Search";
            this.btnBsearch.UseVisualStyleBackColor = true;
            this.btnBsearch.Click += new System.EventHandler(this.btnBsearch_Click);
            // 
            // cmbBsearchby
            // 
            this.cmbBsearchby.FormattingEnabled = true;
            this.cmbBsearchby.Items.AddRange(new object[] {
            "STUDENT NAME",
            "STUDENT\'S REGISTRATION NUMBER",
            "HOSTEL ID"});
            this.cmbBsearchby.Location = new System.Drawing.Point(554, 60);
            this.cmbBsearchby.Name = "cmbBsearchby";
            this.cmbBsearchby.Size = new System.Drawing.Size(285, 21);
            this.cmbBsearchby.TabIndex = 67;
            this.cmbBsearchby.Text = "search by";
            this.cmbBsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbBsearchby_SelectedIndexChanged);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(26, 345);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(117, 16);
            this.label64.TabIndex = 66;
            this.label64.Text = "Amount to be Paid";
            // 
            // numericUpDownByear
            // 
            this.numericUpDownByear.Location = new System.Drawing.Point(165, 212);
            this.numericUpDownByear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownByear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numericUpDownByear.Name = "numericUpDownByear";
            this.numericUpDownByear.Size = new System.Drawing.Size(124, 20);
            this.numericUpDownByear.TabIndex = 65;
            this.numericUpDownByear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // btnBviewsaveddata
            // 
            this.btnBviewsaveddata.Location = new System.Drawing.Point(381, 68);
            this.btnBviewsaveddata.Name = "btnBviewsaveddata";
            this.btnBviewsaveddata.Size = new System.Drawing.Size(104, 23);
            this.btnBviewsaveddata.TabIndex = 64;
            this.btnBviewsaveddata.Text = "&View Saved Data";
            this.btnBviewsaveddata.UseVisualStyleBackColor = true;
            this.btnBviewsaveddata.Click += new System.EventHandler(this.btnBviewsaveddata_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(381, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(605, 382);
            this.dataGridView2.TabIndex = 63;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(22, 141);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 13);
            this.label55.TabIndex = 62;
            this.label55.Text = "FACULTY";
            // 
            // btnHbcancel
            // 
            this.btnHbcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHbcancel.Location = new System.Drawing.Point(241, 455);
            this.btnHbcancel.Name = "btnHbcancel";
            this.btnHbcancel.Size = new System.Drawing.Size(118, 34);
            this.btnHbcancel.TabIndex = 61;
            this.btnHbcancel.Text = "CANCEL";
            this.btnHbcancel.UseVisualStyleBackColor = true;
            this.btnHbcancel.Click += new System.EventHandler(this.btnHbcancel_Click);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubmit.Location = new System.Drawing.Point(65, 456);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(114, 33);
            this.cmdSubmit.TabIndex = 60;
            this.cmdSubmit.Text = "SUBMIT";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click_1);
            // 
            // cboBsempaidfor
            // 
            this.cboBsempaidfor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBsempaidfor.FormattingEnabled = true;
            this.cboBsempaidfor.Items.AddRange(new object[] {
            "January-April",
            "May-August",
            "September-December"});
            this.cboBsempaidfor.Location = new System.Drawing.Point(163, 177);
            this.cboBsempaidfor.Name = "cboBsempaidfor";
            this.cboBsempaidfor.Size = new System.Drawing.Size(186, 21);
            this.cboBsempaidfor.TabIndex = 59;
            // 
            // cboBhostelid
            // 
            this.cboBhostelid.FormattingEnabled = true;
            this.cboBhostelid.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cboBhostelid.Location = new System.Drawing.Point(163, 238);
            this.cboBhostelid.Name = "cboBhostelid";
            this.cboBhostelid.Size = new System.Drawing.Size(183, 21);
            this.cboBhostelid.TabIndex = 58;
            this.cboBhostelid.SelectedIndexChanged += new System.EventHandler(this.cboBhostelid_SelectedIndexChanged);
            this.cboBhostelid.Click += new System.EventHandler(this.cboBhostelid_Click);
            this.cboBhostelid.Leave += new System.EventHandler(this.cboBhostelid_Leave);
            // 
            // cboBfaculty
            // 
            this.cboBfaculty.FormattingEnabled = true;
            this.cboBfaculty.Items.AddRange(new object[] {
            "scince, engineering and technology",
            "Business Studies",
            "Arts and Humanities",
            "Education and Resources Development",
            "Agriculture and Environment Studies"});
            this.cboBfaculty.Location = new System.Drawing.Point(163, 138);
            this.cboBfaculty.Name = "cboBfaculty";
            this.cboBfaculty.Size = new System.Drawing.Size(183, 21);
            this.cboBfaculty.TabIndex = 57;
            // 
            // txtBregno
            // 
            this.txtBregno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBregno.Location = new System.Drawing.Point(163, 107);
            this.txtBregno.Name = "txtBregno";
            this.txtBregno.Size = new System.Drawing.Size(183, 20);
            this.txtBregno.TabIndex = 56;
            // 
            // txtBstudentname
            // 
            this.txtBstudentname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBstudentname.Location = new System.Drawing.Point(163, 78);
            this.txtBstudentname.Name = "txtBstudentname";
            this.txtBstudentname.Size = new System.Drawing.Size(182, 20);
            this.txtBstudentname.TabIndex = 55;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(22, 317);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 13);
            this.label49.TabIndex = 54;
            this.label49.Text = "OCCUPANCY";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(22, 180);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(83, 13);
            this.label51.TabIndex = 53;
            this.label51.Text = "SEM PAID FOR";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(25, 246);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(64, 13);
            this.label52.TabIndex = 52;
            this.label52.Text = "HOSTEL ID";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(22, 113);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 13);
            this.label53.TabIndex = 51;
            this.label53.Text = "REG. NO.";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(22, 78);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(93, 13);
            this.label54.TabIndex = 50;
            this.label54.Text = "STUDENT NAME";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(22, 214);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(36, 13);
            this.label50.TabIndex = 78;
            this.label50.Text = "YEAR";
            // 
            // wmtxtBsearch
            // 
            this.wmtxtBsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtBsearch.Location = new System.Drawing.Point(554, 87);
            this.wmtxtBsearch.Name = "wmtxtBsearch";
            this.wmtxtBsearch.Size = new System.Drawing.Size(285, 20);
            this.wmtxtBsearch.TabIndex = 77;
            this.wmtxtBsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtBsearch.WaterMarkText = "";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 542);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.wmtxtBsearch);
            this.Controls.Add(this.cmbStudentgender);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.cmbOccupancy);
            this.Controls.Add(this.txtAmounttobepaid);
            this.Controls.Add(this.txtBtransactionno);
            this.Controls.Add(this.cmdPaymentmode);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.btnBsearch);
            this.Controls.Add(this.cmbBsearchby);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.numericUpDownByear);
            this.Controls.Add(this.btnBviewsaveddata);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.btnHbcancel);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.cboBsempaidfor);
            this.Controls.Add(this.cboBhostelid);
            this.Controls.Add(this.cboBfaculty);
            this.Controls.Add(this.txtBregno);
            this.Controls.Add(this.txtBstudentname);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Name = "Booking";
            this.Text = "HOSTEL BOOKING";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentgender;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox cmbOccupancy;
        private System.Windows.Forms.Label txtAmounttobepaid;
        private System.Windows.Forms.TextBox txtBtransactionno;
        private System.Windows.Forms.ComboBox cmdPaymentmode;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button btnBsearch;
        private System.Windows.Forms.ComboBox cmbBsearchby;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown numericUpDownByear;
        private System.Windows.Forms.Button btnBviewsaveddata;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnHbcancel;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.ComboBox cboBsempaidfor;
        private System.Windows.Forms.ComboBox cboBhostelid;
        private System.Windows.Forms.ComboBox cboBfaculty;
        private System.Windows.Forms.TextBox txtBregno;
        private System.Windows.Forms.TextBox txtBstudentname;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private PROJE.WaterMarkTextBox wmtxtBsearch;
        private System.Windows.Forms.Label label50;

    }
}