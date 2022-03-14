namespace THMS
{
    partial class Payments
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
            this.btnPsearch = new System.Windows.Forms.Button();
            this.cmbPsearchby = new System.Windows.Forms.ComboBox();
            this.btnPviewsaveddata = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.btnPcancel = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.txtTransactionno = new System.Windows.Forms.TextBox();
            this.txtAmountpaid = new System.Windows.Forms.TextBox();
            this.cboModeofpayment = new System.Windows.Forms.ComboBox();
            this.cboClientemployeeno = new System.Windows.Forms.ComboBox();
            this.cboClientemployeetype = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.txtPsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPsearch
            // 
            this.btnPsearch.Location = new System.Drawing.Point(359, 40);
            this.btnPsearch.Name = "btnPsearch";
            this.btnPsearch.Size = new System.Drawing.Size(75, 23);
            this.btnPsearch.TabIndex = 56;
            this.btnPsearch.Text = "Search";
            this.btnPsearch.UseVisualStyleBackColor = true;
            this.btnPsearch.Click += new System.EventHandler(this.btnPsearch_Click);
            // 
            // cmbPsearchby
            // 
            this.cmbPsearchby.FormattingEnabled = true;
            this.cmbPsearchby.Items.AddRange(new object[] {
            "CLIENT/EMPLOYEE TYPE",
            "CLIENT/EMPLOYEE ID",
            "TRANSACTION NO."});
            this.cmbPsearchby.Location = new System.Drawing.Point(36, 32);
            this.cmbPsearchby.Name = "cmbPsearchby";
            this.cmbPsearchby.Size = new System.Drawing.Size(292, 21);
            this.cmbPsearchby.TabIndex = 55;
            this.cmbPsearchby.Text = "search by";
            this.cmbPsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbPsearchby_SelectedIndexChanged);
            // 
            // btnPviewsaveddata
            // 
            this.btnPviewsaveddata.Location = new System.Drawing.Point(470, 35);
            this.btnPviewsaveddata.Name = "btnPviewsaveddata";
            this.btnPviewsaveddata.Size = new System.Drawing.Size(106, 32);
            this.btnPviewsaveddata.TabIndex = 54;
            this.btnPviewsaveddata.Text = "View Saved Data";
            this.btnPviewsaveddata.UseVisualStyleBackColor = true;
            this.btnPviewsaveddata.Click += new System.EventHandler(this.btnPviwsaveddata_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(18, 106);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(612, 386);
            this.dgvPayment.TabIndex = 53;
            // 
            // btnPcancel
            // 
            this.btnPcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPcancel.Location = new System.Drawing.Point(816, 281);
            this.btnPcancel.Name = "btnPcancel";
            this.btnPcancel.Size = new System.Drawing.Size(99, 37);
            this.btnPcancel.TabIndex = 52;
            this.btnPcancel.Text = "&CANCEL";
            this.btnPcancel.UseVisualStyleBackColor = true;
            this.btnPcancel.Click += new System.EventHandler(this.btnPcancel_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(660, 281);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(98, 37);
            this.button18.TabIndex = 51;
            this.button18.Text = "&SAVE";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // txtTransactionno
            // 
            this.txtTransactionno.Location = new System.Drawing.Point(816, 234);
            this.txtTransactionno.Name = "txtTransactionno";
            this.txtTransactionno.Size = new System.Drawing.Size(151, 20);
            this.txtTransactionno.TabIndex = 50;
            // 
            // txtAmountpaid
            // 
            this.txtAmountpaid.Location = new System.Drawing.Point(816, 164);
            this.txtAmountpaid.Name = "txtAmountpaid";
            this.txtAmountpaid.Size = new System.Drawing.Size(151, 20);
            this.txtAmountpaid.TabIndex = 49;
            this.txtAmountpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountpaid_KeyPress);
            // 
            // cboModeofpayment
            // 
            this.cboModeofpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeofpayment.FormattingEnabled = true;
            this.cboModeofpayment.Items.AddRange(new object[] {
            "MPESA",
            "CHEQUE"});
            this.cboModeofpayment.Location = new System.Drawing.Point(816, 199);
            this.cboModeofpayment.Name = "cboModeofpayment";
            this.cboModeofpayment.Size = new System.Drawing.Size(151, 21);
            this.cboModeofpayment.TabIndex = 48;
            // 
            // cboClientemployeeno
            // 
            this.cboClientemployeeno.FormattingEnabled = true;
            this.cboClientemployeeno.Location = new System.Drawing.Point(816, 137);
            this.cboClientemployeeno.Name = "cboClientemployeeno";
            this.cboClientemployeeno.Size = new System.Drawing.Size(151, 21);
            this.cboClientemployeeno.TabIndex = 47;
            // 
            // cboClientemployeetype
            // 
            this.cboClientemployeetype.AutoCompleteCustomSource.AddRange(new string[] {
            "LANDLORD",
            "STAFF",
            "AGENT"});
            this.cboClientemployeetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientemployeetype.FormattingEnabled = true;
            this.cboClientemployeetype.Items.AddRange(new object[] {
            "LANDLORD",
            "STAFF",
            "AGENT"});
            this.cboClientemployeetype.Location = new System.Drawing.Point(816, 103);
            this.cboClientemployeetype.Name = "cboClientemployeetype";
            this.cboClientemployeetype.Size = new System.Drawing.Size(151, 21);
            this.cboClientemployeetype.TabIndex = 46;
            this.cboClientemployeetype.SelectedIndexChanged += new System.EventHandler(this.cboClientemployeetype_SelectedIndexChanged);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(636, 241);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(106, 13);
            this.label59.TabIndex = 45;
            this.label59.Text = "TRANSACTION NO.";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(636, 207);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(111, 13);
            this.label60.TabIndex = 44;
            this.label60.Text = "MODE OF PAYMENT";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(636, 171);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(82, 13);
            this.label61.TabIndex = 43;
            this.label61.Text = "AMOUNT PAID";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(636, 137);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(122, 13);
            this.label62.TabIndex = 42;
            this.label62.Text = "CLIENT/EMPLOYEE ID";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(636, 106);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(139, 13);
            this.label63.TabIndex = 41;
            this.label63.Text = "CLIENT/EMPLOYEE TYPE";
            // 
            // txtPsearch
            // 
            this.txtPsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPsearch.Location = new System.Drawing.Point(36, 59);
            this.txtPsearch.Name = "txtPsearch";
            this.txtPsearch.Size = new System.Drawing.Size(292, 20);
            this.txtPsearch.TabIndex = 57;
            this.txtPsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPsearch.WaterMarkText = "";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 525);
            this.Controls.Add(this.txtPsearch);
            this.Controls.Add(this.btnPsearch);
            this.Controls.Add(this.cmbPsearchby);
            this.Controls.Add(this.btnPviewsaveddata);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.btnPcancel);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.txtTransactionno);
            this.Controls.Add(this.txtAmountpaid);
            this.Controls.Add(this.cboModeofpayment);
            this.Controls.Add(this.cboClientemployeeno);
            this.Controls.Add(this.cboClientemployeetype);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label63);
            this.Name = "Payments";
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPsearch;
        private System.Windows.Forms.ComboBox cmbPsearchby;
        private System.Windows.Forms.Button btnPviewsaveddata;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Button btnPcancel;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox txtTransactionno;
        private System.Windows.Forms.TextBox txtAmountpaid;
        private System.Windows.Forms.ComboBox cboModeofpayment;
        private System.Windows.Forms.ComboBox cboClientemployeeno;
        private System.Windows.Forms.ComboBox cboClientemployeetype;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private PROJE.WaterMarkTextBox txtPsearch;
    }
}