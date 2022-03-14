namespace THMS
{
    partial class Agency
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
            this.btnAgsearch = new System.Windows.Forms.Button();
            this.cmbAgsearchby = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAeviewsaveddata = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.txtAmountpayable = new System.Windows.Forms.TextBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.cboHostelid = new System.Windows.Forms.ComboBox();
            this.cboAgentid = new System.Windows.Forms.ComboBox();
            this.btnAgcancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.wmtxtAgsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgsearch
            // 
            this.btnAgsearch.Location = new System.Drawing.Point(410, 11);
            this.btnAgsearch.Name = "btnAgsearch";
            this.btnAgsearch.Size = new System.Drawing.Size(75, 23);
            this.btnAgsearch.TabIndex = 56;
            this.btnAgsearch.Text = "Search";
            this.btnAgsearch.UseVisualStyleBackColor = true;
            this.btnAgsearch.Click += new System.EventHandler(this.btnAgsearch_Click);
            // 
            // cmbAgsearchby
            // 
            this.cmbAgsearchby.FormattingEnabled = true;
            this.cmbAgsearchby.Items.AddRange(new object[] {
            "AGENT ID",
            "HOSTEL ID"});
            this.cmbAgsearchby.Location = new System.Drawing.Point(89, 3);
            this.cmbAgsearchby.Name = "cmbAgsearchby";
            this.cmbAgsearchby.Size = new System.Drawing.Size(270, 21);
            this.cmbAgsearchby.TabIndex = 55;
            this.cmbAgsearchby.Text = "search by";
            this.cmbAgsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbAgsearchby_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(826, 201);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 54;
            this.numericUpDown1.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // btnAeviewsaveddata
            // 
            this.btnAeviewsaveddata.Location = new System.Drawing.Point(503, 11);
            this.btnAeviewsaveddata.Name = "btnAeviewsaveddata";
            this.btnAeviewsaveddata.Size = new System.Drawing.Size(100, 23);
            this.btnAeviewsaveddata.TabIndex = 53;
            this.btnAeviewsaveddata.Text = "View Saved Data";
            this.btnAeviewsaveddata.UseVisualStyleBackColor = true;
            this.btnAeviewsaveddata.Click += new System.EventHandler(this.btnAeviewsaveddata_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(78, 72);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(588, 389);
            this.dataGridView5.TabIndex = 52;
            // 
            // txtAmountpayable
            // 
            this.txtAmountpayable.Location = new System.Drawing.Point(828, 250);
            this.txtAmountpayable.Name = "txtAmountpayable";
            this.txtAmountpayable.Size = new System.Drawing.Size(138, 20);
            this.txtAmountpayable.TabIndex = 51;
            // 
            // cboSemester
            // 
            this.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "January-April",
            "May-August",
            "September-December"});
            this.cboSemester.Location = new System.Drawing.Point(826, 166);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(138, 21);
            this.cboSemester.TabIndex = 50;
            // 
            // cboHostelid
            // 
            this.cboHostelid.FormattingEnabled = true;
            this.cboHostelid.Location = new System.Drawing.Point(828, 226);
            this.cboHostelid.Name = "cboHostelid";
            this.cboHostelid.Size = new System.Drawing.Size(138, 21);
            this.cboHostelid.TabIndex = 49;
            this.cboHostelid.SelectedIndexChanged += new System.EventHandler(this.cboHostelid_SelectedIndexChanged);
            this.cboHostelid.Click += new System.EventHandler(this.cboHostelid_Click);
            this.cboHostelid.Leave += new System.EventHandler(this.cboHostelid_Leave);
            // 
            // cboAgentid
            // 
            this.cboAgentid.FormattingEnabled = true;
            this.cboAgentid.Location = new System.Drawing.Point(826, 138);
            this.cboAgentid.Name = "cboAgentid";
            this.cboAgentid.Size = new System.Drawing.Size(138, 21);
            this.cboAgentid.TabIndex = 48;
            this.cboAgentid.Click += new System.EventHandler(this.cboAgentid_Click);
            // 
            // btnAgcancel
            // 
            this.btnAgcancel.Location = new System.Drawing.Point(826, 319);
            this.btnAgcancel.Name = "btnAgcancel";
            this.btnAgcancel.Size = new System.Drawing.Size(101, 30);
            this.btnAgcancel.TabIndex = 47;
            this.btnAgcancel.Text = "CANCEL";
            this.btnAgcancel.UseVisualStyleBackColor = true;
            this.btnAgcancel.Click += new System.EventHandler(this.btnAgcancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 46;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(675, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "YEAR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(675, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "SEMESTER";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(677, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "AMOUNT PAYABLE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(677, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "HOSTEL ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(675, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "AGENT ID";
            // 
            // wmtxtAgsearch
            // 
            this.wmtxtAgsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtAgsearch.Location = new System.Drawing.Point(89, 30);
            this.wmtxtAgsearch.Name = "wmtxtAgsearch";
            this.wmtxtAgsearch.Size = new System.Drawing.Size(270, 20);
            this.wmtxtAgsearch.TabIndex = 57;
            this.wmtxtAgsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtAgsearch.WaterMarkText = "";
            // 
            // Agency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 465);
            this.Controls.Add(this.wmtxtAgsearch);
            this.Controls.Add(this.btnAgsearch);
            this.Controls.Add(this.cmbAgsearchby);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAeviewsaveddata);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.txtAmountpayable);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.cboHostelid);
            this.Controls.Add(this.cboAgentid);
            this.Controls.Add(this.btnAgcancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Name = "Agency";
            this.Text = "Agency";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgsearch;
        private System.Windows.Forms.ComboBox cmbAgsearchby;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAeviewsaveddata;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TextBox txtAmountpayable;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.ComboBox cboHostelid;
        private System.Windows.Forms.ComboBox cboAgentid;
        private System.Windows.Forms.Button btnAgcancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private PROJE.WaterMarkTextBox wmtxtAgsearch;
    }
}