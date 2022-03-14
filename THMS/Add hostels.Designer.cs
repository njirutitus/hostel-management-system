namespace THMS
{
    partial class Add_Hostels
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
            this.cmbHgender = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.btnHacancel = new System.Windows.Forms.Button();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.btnHsearch = new System.Windows.Forms.Button();
            this.cmbHsearchby = new System.Windows.Forms.ComboBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.btnAhviewsaveddata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtAdditionalitems = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtHostelname = new System.Windows.Forms.TextBox();
            this.cboOwnerid = new System.Windows.Forms.ComboBox();
            this.cmdRemoveitem = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtRent = new PROJE.WaterMarkTextBox();
            this.wmtxtHsearch = new PROJE.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHgender
            // 
            this.cmbHgender.FormattingEnabled = true;
            this.cmbHgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "UNSPECIFIED"});
            this.cmbHgender.Location = new System.Drawing.Point(153, 226);
            this.cmbHgender.Name = "cmbHgender";
            this.cmbHgender.Size = new System.Drawing.Size(219, 21);
            this.cmbHgender.TabIndex = 78;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(30, 232);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(104, 15);
            this.label72.TabIndex = 77;
            this.label72.Text = "Allowed Gender";
            // 
            // btnHacancel
            // 
            this.btnHacancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacancel.Location = new System.Drawing.Point(120, 420);
            this.btnHacancel.Name = "btnHacancel";
            this.btnHacancel.Size = new System.Drawing.Size(88, 33);
            this.btnHacancel.TabIndex = 76;
            this.btnHacancel.Text = "&CANCEL";
            this.btnHacancel.UseVisualStyleBackColor = true;
            this.btnHacancel.Click += new System.EventHandler(this.btnHacancel_Click);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(74, 54);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(193, 15);
            this.label67.TabIndex = 75;
            this.label67.Text = "Hostelid Must be Selected from the Table";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(50, 38);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(210, 15);
            this.label66.TabIndex = 74;
            this.label66.Text = "NB: To  Delete an Hostel Its corresponding ";
            // 
            // btnHsearch
            // 
            this.btnHsearch.Location = new System.Drawing.Point(898, 46);
            this.btnHsearch.Name = "btnHsearch";
            this.btnHsearch.Size = new System.Drawing.Size(75, 23);
            this.btnHsearch.TabIndex = 73;
            this.btnHsearch.Text = "&Search";
            this.btnHsearch.UseVisualStyleBackColor = true;
            this.btnHsearch.Click += new System.EventHandler(this.btnHsearch_Click);
            // 
            // cmbHsearchby
            // 
            this.cmbHsearchby.FormattingEnabled = true;
            this.cmbHsearchby.Items.AddRange(new object[] {
            "OWNER ID",
            "HOSTEL NAME",
            "MAXIMUM DISTANCE",
            "HOSTEL ID"});
            this.cmbHsearchby.Location = new System.Drawing.Point(560, 38);
            this.cmbHsearchby.Name = "cmbHsearchby";
            this.cmbHsearchby.Size = new System.Drawing.Size(306, 21);
            this.cmbHsearchby.TabIndex = 72;
            this.cmbHsearchby.Text = "search by";
            this.cmbHsearchby.SelectedIndexChanged += new System.EventHandler(this.cmbHsearchby_SelectedIndexChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(153, 163);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(219, 20);
            this.numericUpDown3.TabIndex = 71;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(26, 170);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(95, 13);
            this.label57.TabIndex = 70;
            this.label57.Text = "Max Occupants";
            // 
            // btnAhviewsaveddata
            // 
            this.btnAhviewsaveddata.Location = new System.Drawing.Point(410, 50);
            this.btnAhviewsaveddata.Name = "btnAhviewsaveddata";
            this.btnAhviewsaveddata.Size = new System.Drawing.Size(110, 22);
            this.btnAhviewsaveddata.TabIndex = 69;
            this.btnAhviewsaveddata.Text = "&View Saved Data";
            this.btnAhviewsaveddata.UseVisualStyleBackColor = true;
            this.btnAhviewsaveddata.Click += new System.EventHandler(this.btnAhviewsaveddata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 378);
            this.dataGridView1.TabIndex = 68;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Bedsitter",
            "Selfcontained"});
            this.cboCategory.Location = new System.Drawing.Point(153, 196);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(219, 21);
            this.cboCategory.TabIndex = 67;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(26, 199);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 18);
            this.label28.TabIndex = 66;
            this.label28.Text = "Category";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(153, 257);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(219, 20);
            this.txtDistance.TabIndex = 65;
            this.txtDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistance_KeyPress);
            // 
            // txtAdditionalitems
            // 
            this.txtAdditionalitems.Location = new System.Drawing.Point(153, 298);
            this.txtAdditionalitems.Name = "txtAdditionalitems";
            this.txtAdditionalitems.Size = new System.Drawing.Size(219, 20);
            this.txtAdditionalitems.TabIndex = 64;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(153, 134);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(219, 20);
            this.txtCapacity.TabIndex = 63;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // txtHostelname
            // 
            this.txtHostelname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHostelname.Location = new System.Drawing.Point(153, 81);
            this.txtHostelname.Name = "txtHostelname";
            this.txtHostelname.Size = new System.Drawing.Size(219, 20);
            this.txtHostelname.TabIndex = 62;
            // 
            // cboOwnerid
            // 
            this.cboOwnerid.FormattingEnabled = true;
            this.cboOwnerid.Items.AddRange(new object[] {
            "4",
            "2",
            "7",
            "8",
            "9"});
            this.cboOwnerid.Location = new System.Drawing.Point(153, 107);
            this.cboOwnerid.Name = "cboOwnerid";
            this.cboOwnerid.Size = new System.Drawing.Size(219, 21);
            this.cboOwnerid.TabIndex = 61;
            this.cboOwnerid.Click += new System.EventHandler(this.cboOwnerid_Click);
            // 
            // cmdRemoveitem
            // 
            this.cmdRemoveitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemoveitem.Location = new System.Drawing.Point(191, 365);
            this.cmdRemoveitem.Name = "cmdRemoveitem";
            this.cmdRemoveitem.Size = new System.Drawing.Size(113, 33);
            this.cmdRemoveitem.TabIndex = 60;
            this.cmdRemoveitem.Text = "&DELETE";
            this.cmdRemoveitem.UseVisualStyleBackColor = true;
            this.cmdRemoveitem.Click += new System.EventHandler(this.cmdRemoveitem_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(46, 365);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 36);
            this.cmdAdd.TabIndex = 58;
            this.cmdAdd.Text = "&ADD";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(26, 334);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 18);
            this.label29.TabIndex = 57;
            this.label29.Text = "Rent Per Room";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(26, 136);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 18);
            this.label30.TabIndex = 56;
            this.label30.Text = "Capacity";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(26, 300);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 18);
            this.label31.TabIndex = 55;
            this.label31.Text = "Additinal Items";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(26, 259);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(118, 18);
            this.label32.TabIndex = 54;
            this.label32.Text = "Distance(metres)";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(26, 110);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 18);
            this.label33.TabIndex = 53;
            this.label33.Text = "Owner Id";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(26, 83);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 18);
            this.label34.TabIndex = 52;
            this.label34.Text = "Name";
            // 
            // txtRent
            // 
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRent.Location = new System.Drawing.Point(153, 332);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(219, 20);
            this.txtRent.TabIndex = 79;
            this.txtRent.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtRent.WaterMarkText = "";
            this.txtRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRent_KeyPress);
            // 
            // wmtxtHsearch
            // 
            this.wmtxtHsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtHsearch.Location = new System.Drawing.Point(560, 65);
            this.wmtxtHsearch.Name = "wmtxtHsearch";
            this.wmtxtHsearch.Size = new System.Drawing.Size(306, 20);
            this.wmtxtHsearch.TabIndex = 80;
            this.wmtxtHsearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtHsearch.WaterMarkText = "";
            // 
            // Add_Hostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 506);
            this.Controls.Add(this.wmtxtHsearch);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.cmbHgender);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.btnHacancel);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.btnHsearch);
            this.Controls.Add(this.cmbHsearchby);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.btnAhviewsaveddata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtAdditionalitems);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtHostelname);
            this.Controls.Add(this.cboOwnerid);
            this.Controls.Add(this.cmdRemoveitem);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Name = "Add_Hostels";
            this.Text = "Add_Hostels";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHgender;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Button btnHacancel;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btnHsearch;
        private System.Windows.Forms.ComboBox cmbHsearchby;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Button btnAhviewsaveddata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtAdditionalitems;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtHostelname;
        private System.Windows.Forms.ComboBox cboOwnerid;
        private System.Windows.Forms.Button cmdRemoveitem;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private PROJE.WaterMarkTextBox txtRent;
        private PROJE.WaterMarkTextBox wmtxtHsearch;


    }
}