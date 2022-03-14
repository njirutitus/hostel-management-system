namespace THMS
{
    partial class EmployStaff
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
            this.txtStaffid = new System.Windows.Forms.ComboBox();
            this.btnSesearch = new System.Windows.Forms.Button();
            this.cmbSesearchby = new System.Windows.Forms.ComboBox();
            this.nudSeyear = new System.Windows.Forms.NumericUpDown();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.txtSsalary = new System.Windows.Forms.TextBox();
            this.cboSsemester = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.wmtxtSesearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStaffid
            // 
            this.txtStaffid.FormattingEnabled = true;
            this.txtStaffid.Location = new System.Drawing.Point(143, 124);
            this.txtStaffid.Name = "txtStaffid";
            this.txtStaffid.Size = new System.Drawing.Size(121, 21);
            this.txtStaffid.TabIndex = 57;
            this.txtStaffid.Click += new System.EventHandler(this.txtStaffid_Click);
            // 
            // btnSesearch
            // 
            this.btnSesearch.Location = new System.Drawing.Point(848, 44);
            this.btnSesearch.Name = "btnSesearch";
            this.btnSesearch.Size = new System.Drawing.Size(75, 23);
            this.btnSesearch.TabIndex = 55;
            this.btnSesearch.Text = "Search";
            this.btnSesearch.UseVisualStyleBackColor = true;
            this.btnSesearch.Click += new System.EventHandler(this.btnSesearch_Click);
            // 
            // cmbSesearchby
            // 
            this.cmbSesearchby.FormattingEnabled = true;
            this.cmbSesearchby.Items.AddRange(new object[] {
            "STAFF ID",
            "SEMESTER",
            "YEAR"});
            this.cmbSesearchby.Location = new System.Drawing.Point(478, 29);
            this.cmbSesearchby.Name = "cmbSesearchby";
            this.cmbSesearchby.Size = new System.Drawing.Size(364, 21);
            this.cmbSesearchby.TabIndex = 54;
            this.cmbSesearchby.Text = "search by";
            this.cmbSesearchby.SelectedIndexChanged += new System.EventHandler(this.cmbSesearchby_SelectedIndexChanged);
            // 
            // nudSeyear
            // 
            this.nudSeyear.Location = new System.Drawing.Point(143, 161);
            this.nudSeyear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudSeyear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.nudSeyear.Name = "nudSeyear";
            this.nudSeyear.Size = new System.Drawing.Size(112, 20);
            this.nudSeyear.TabIndex = 53;
            this.nudSeyear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(352, 44);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 23);
            this.btnView.TabIndex = 52;
            this.btnView.Text = "View Saved Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(287, 95);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(677, 375);
            this.dataGridView7.TabIndex = 51;
            // 
            // txtSsalary
            // 
            this.txtSsalary.Location = new System.Drawing.Point(143, 220);
            this.txtSsalary.Name = "txtSsalary";
            this.txtSsalary.Size = new System.Drawing.Size(135, 20);
            this.txtSsalary.TabIndex = 50;
            this.txtSsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSsalary_KeyPress);
            // 
            // cboSsemester
            // 
            this.cboSsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSsemester.FormattingEnabled = true;
            this.cboSsemester.Items.AddRange(new object[] {
            "January-April",
            "May-August",
            "September-December"});
            this.cboSsemester.Location = new System.Drawing.Point(140, 193);
            this.cboSsemester.Name = "cboSsemester";
            this.cboSsemester.Size = new System.Drawing.Size(138, 21);
            this.cboSsemester.TabIndex = 49;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(163, 266);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 35);
            this.cmdCancel.TabIndex = 48;
            this.cmdCancel.Text = "CANCEL";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(23, 266);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(87, 35);
            this.cmdSave.TabIndex = 47;
            this.cmdSave.Text = "SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 227);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "SALARY";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 197);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "SEMESTER";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 168);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "YEAR";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 132);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 43;
            this.label27.Text = "STAFF ID";
            // 
            // wmtxtSesearch
            // 
            this.wmtxtSesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtSesearch.Location = new System.Drawing.Point(478, 56);
            this.wmtxtSesearch.Name = "wmtxtSesearch";
            this.wmtxtSesearch.Size = new System.Drawing.Size(364, 20);
            this.wmtxtSesearch.TabIndex = 56;
            this.wmtxtSesearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtSesearch.WaterMarkText = "";
            // 
            // EmployStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 498);
            this.Controls.Add(this.txtStaffid);
            this.Controls.Add(this.btnSesearch);
            this.Controls.Add(this.cmbSesearchby);
            this.Controls.Add(this.nudSeyear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.txtSsalary);
            this.Controls.Add(this.cboSsemester);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.wmtxtSesearch);
            this.Name = "EmployStaff";
            this.Text = "STAFF EMPLOYMENT";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtStaffid;
        private System.Windows.Forms.Button btnSesearch;
        private System.Windows.Forms.ComboBox cmbSesearchby;
        private System.Windows.Forms.NumericUpDown nudSeyear;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.TextBox txtSsalary;
        private System.Windows.Forms.ComboBox cboSsemester;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private PROJE.WaterMarkTextBox wmtxtSesearch;

    }
}