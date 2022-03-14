namespace THMS
{
    partial class expenses
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
            this.label71 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.btnEupdate = new System.Windows.Forms.Button();
            this.btnEsearch = new System.Windows.Forms.Button();
            this.cmbEsearchby = new System.Windows.Forms.ComboBox();
            this.numericUpDownEyear = new System.Windows.Forms.NumericUpDown();
            this.btnEviewsaveddata = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtOfficeequipment = new System.Windows.Forms.TextBox();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.txtMiscellaneous = new System.Windows.Forms.TextBox();
            this.txtStaffexpenses = new System.Windows.Forms.TextBox();
            this.cboExsemester = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.wmtxtEsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(34, 105);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(155, 15);
            this.label71.TabIndex = 65;
            this.label71.Text = "Must be Selected From the Table";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(9, 88);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(247, 15);
            this.label68.TabIndex = 64;
            this.label68.Text = "NB: To Update a record its Corresponding recordid ";
            // 
            // btnEupdate
            // 
            this.btnEupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEupdate.Location = new System.Drawing.Point(200, 378);
            this.btnEupdate.Name = "btnEupdate";
            this.btnEupdate.Size = new System.Drawing.Size(107, 36);
            this.btnEupdate.TabIndex = 63;
            this.btnEupdate.Text = "&UPDATE";
            this.btnEupdate.UseVisualStyleBackColor = true;
            this.btnEupdate.Click += new System.EventHandler(this.btnEupdate_Click);
            // 
            // btnEsearch
            // 
            this.btnEsearch.Location = new System.Drawing.Point(850, 32);
            this.btnEsearch.Name = "btnEsearch";
            this.btnEsearch.Size = new System.Drawing.Size(75, 23);
            this.btnEsearch.TabIndex = 62;
            this.btnEsearch.Text = "Search";
            this.btnEsearch.UseVisualStyleBackColor = true;
            this.btnEsearch.Click += new System.EventHandler(this.btnEsearch_Click);
            // 
            // cmbEsearchby
            // 
            this.cmbEsearchby.FormattingEnabled = true;
            this.cmbEsearchby.Items.AddRange(new object[] {
            "YEAR",
            "SEMESTER"});
            this.cmbEsearchby.Location = new System.Drawing.Point(521, 24);
            this.cmbEsearchby.Name = "cmbEsearchby";
            this.cmbEsearchby.Size = new System.Drawing.Size(308, 21);
            this.cmbEsearchby.TabIndex = 61;
            this.cmbEsearchby.Text = "search by";
            this.cmbEsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbEsearchby_SelectedIndexChanged);
            // 
            // numericUpDownEyear
            // 
            this.numericUpDownEyear.Location = new System.Drawing.Point(170, 318);
            this.numericUpDownEyear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownEyear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.numericUpDownEyear.Name = "numericUpDownEyear";
            this.numericUpDownEyear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEyear.TabIndex = 60;
            this.numericUpDownEyear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // btnEviewsaveddata
            // 
            this.btnEviewsaveddata.Location = new System.Drawing.Point(374, 32);
            this.btnEviewsaveddata.Name = "btnEviewsaveddata";
            this.btnEviewsaveddata.Size = new System.Drawing.Size(100, 29);
            this.btnEviewsaveddata.TabIndex = 59;
            this.btnEviewsaveddata.Text = "View Saved Data";
            this.btnEviewsaveddata.UseVisualStyleBackColor = true;
            this.btnEviewsaveddata.Click += new System.EventHandler(this.btnEviewsaveddata_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(350, 88);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(601, 426);
            this.dataGridView4.TabIndex = 58;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(78, 430);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 35);
            this.button9.TabIndex = 57;
            this.button9.Text = "&CANCEL";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(78, 378);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 36);
            this.button10.TabIndex = 56;
            this.button10.Text = "&SAVE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txtOfficeequipment
            // 
            this.txtOfficeequipment.Location = new System.Drawing.Point(170, 143);
            this.txtOfficeequipment.Name = "txtOfficeequipment";
            this.txtOfficeequipment.Size = new System.Drawing.Size(174, 20);
            this.txtOfficeequipment.TabIndex = 55;
            this.txtOfficeequipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOfficeequipment_KeyPress);
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Location = new System.Drawing.Point(170, 175);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(174, 20);
            this.txtMaintenance.TabIndex = 54;
            this.txtMaintenance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintenance_KeyPress);
            // 
            // txtMiscellaneous
            // 
            this.txtMiscellaneous.Location = new System.Drawing.Point(170, 257);
            this.txtMiscellaneous.Name = "txtMiscellaneous";
            this.txtMiscellaneous.Size = new System.Drawing.Size(174, 20);
            this.txtMiscellaneous.TabIndex = 53;
            this.txtMiscellaneous.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiscellaneous_KeyPress);
            // 
            // txtStaffexpenses
            // 
            this.txtStaffexpenses.Location = new System.Drawing.Point(170, 213);
            this.txtStaffexpenses.Name = "txtStaffexpenses";
            this.txtStaffexpenses.Size = new System.Drawing.Size(174, 20);
            this.txtStaffexpenses.TabIndex = 52;
            this.txtStaffexpenses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffexpenses_KeyPress);
            // 
            // cboExsemester
            // 
            this.cboExsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExsemester.FormattingEnabled = true;
            this.cboExsemester.Items.AddRange(new object[] {
            "January-April",
            "May-August",
            "September-December"});
            this.cboExsemester.Location = new System.Drawing.Point(170, 289);
            this.cboExsemester.Name = "cboExsemester";
            this.cboExsemester.Size = new System.Drawing.Size(174, 21);
            this.cboExsemester.TabIndex = 51;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 318);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(36, 13);
            this.label43.TabIndex = 50;
            this.label43.Text = "YEAR";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 289);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(66, 13);
            this.label44.TabIndex = 49;
            this.label44.Text = "SEMESTER";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(9, 256);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(97, 13);
            this.label45.TabIndex = 48;
            this.label45.Text = "MISCELLANEOUS";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(9, 220);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(100, 13);
            this.label46.TabIndex = 47;
            this.label46.Text = "STAFF EXPENSES";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(9, 182);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(85, 13);
            this.label47.TabIndex = 46;
            this.label47.Text = "MAINTENANCE";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(9, 150);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(111, 13);
            this.label48.TabIndex = 45;
            this.label48.Text = "OFFICE EQUIPMENT";
            // 
            // wmtxtEsearch
            // 
            this.wmtxtEsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtEsearch.Location = new System.Drawing.Point(521, 51);
            this.wmtxtEsearch.Name = "wmtxtEsearch";
            this.wmtxtEsearch.Size = new System.Drawing.Size(308, 20);
            this.wmtxtEsearch.TabIndex = 66;
            this.wmtxtEsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtEsearch.WaterMarkText = "";
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 512);
            this.Controls.Add(this.wmtxtEsearch);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.btnEupdate);
            this.Controls.Add(this.btnEsearch);
            this.Controls.Add(this.cmbEsearchby);
            this.Controls.Add(this.numericUpDownEyear);
            this.Controls.Add(this.btnEviewsaveddata);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txtOfficeequipment);
            this.Controls.Add(this.txtMaintenance);
            this.Controls.Add(this.txtMiscellaneous);
            this.Controls.Add(this.txtStaffexpenses);
            this.Controls.Add(this.cboExsemester);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label48);
            this.Name = "expenses";
            this.Text = "EXPENSES";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btnEupdate;
        private System.Windows.Forms.Button btnEsearch;
        private System.Windows.Forms.ComboBox cmbEsearchby;
        private System.Windows.Forms.NumericUpDown numericUpDownEyear;
        private System.Windows.Forms.Button btnEviewsaveddata;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txtOfficeequipment;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.TextBox txtMiscellaneous;
        private System.Windows.Forms.TextBox txtStaffexpenses;
        private System.Windows.Forms.ComboBox cboExsemester;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private PROJE.WaterMarkTextBox wmtxtEsearch;
    }
}