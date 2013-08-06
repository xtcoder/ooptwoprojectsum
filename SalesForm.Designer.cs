namespace WindowsFormsApplication2
{
    partial class SalesForm
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
            this.buttonComplete = new System.Windows.Forms.Button();
            this.textBoxCname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcPhone = new System.Windows.Forms.TextBox();
            this.Addbutton4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Branchnamelabel = new System.Windows.Forms.Label();
            this.Productnamelabel = new System.Windows.Forms.Label();
            this.ProductQuantitylabel = new System.Windows.Forms.Label();
            this.datetextBox1 = new System.Windows.Forms.TextBox();
            this.Datelabel3 = new System.Windows.Forms.Label();
            this.quantitytextBox1 = new System.Windows.Forms.TextBox();
            this.unitpricetextBox2 = new System.Windows.Forms.TextBox();
            this.Unitpricelabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(747, 477);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(80, 33);
            this.buttonComplete.TabIndex = 2;
            this.buttonComplete.Text = "Complete";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxCname
            // 
            this.textBoxCname.Location = new System.Drawing.Point(130, 49);
            this.textBoxCname.Name = "textBoxCname";
            this.textBoxCname.Size = new System.Drawing.Size(100, 22);
            this.textBoxCname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Phone";
            // 
            // textBoxcPhone
            // 
            this.textBoxcPhone.Location = new System.Drawing.Point(130, 98);
            this.textBoxcPhone.Name = "textBoxcPhone";
            this.textBoxcPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxcPhone.TabIndex = 8;
            // 
            // Addbutton4
            // 
            this.Addbutton4.Location = new System.Drawing.Point(453, 105);
            this.Addbutton4.Name = "Addbutton4";
            this.Addbutton4.Size = new System.Drawing.Size(64, 23);
            this.Addbutton4.TabIndex = 12;
            this.Addbutton4.Text = "Add";
            this.Addbutton4.UseVisualStyleBackColor = true;
            this.Addbutton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxcPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(666, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 140);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(15, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 260);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.Name = "Column6";
            // 
            // ProductNamecomboBox1
            // 
            this.ProductNamecomboBox1.FormattingEnabled = true;
            this.ProductNamecomboBox1.Location = new System.Drawing.Point(15, 104);
            this.ProductNamecomboBox1.Name = "ProductNamecomboBox1";
            this.ProductNamecomboBox1.Size = new System.Drawing.Size(121, 24);
            this.ProductNamecomboBox1.TabIndex = 22;
            this.ProductNamecomboBox1.SelectedIndexChanged += new System.EventHandler(this.ProductNamecomboBox1_SelectedIndexChanged);
            // 
            // Branchnamelabel
            // 
            this.Branchnamelabel.AutoSize = true;
            this.Branchnamelabel.Location = new System.Drawing.Point(12, 24);
            this.Branchnamelabel.Name = "Branchnamelabel";
            this.Branchnamelabel.Size = new System.Drawing.Size(46, 17);
            this.Branchnamelabel.TabIndex = 24;
            this.Branchnamelabel.Text = "label3";
            this.Branchnamelabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Productnamelabel
            // 
            this.Productnamelabel.AutoSize = true;
            this.Productnamelabel.Location = new System.Drawing.Point(12, 84);
            this.Productnamelabel.Name = "Productnamelabel";
            this.Productnamelabel.Size = new System.Drawing.Size(98, 17);
            this.Productnamelabel.TabIndex = 25;
            this.Productnamelabel.Text = "Product Name";
            // 
            // ProductQuantitylabel
            // 
            this.ProductQuantitylabel.AutoSize = true;
            this.ProductQuantitylabel.Location = new System.Drawing.Point(151, 84);
            this.ProductQuantitylabel.Name = "ProductQuantitylabel";
            this.ProductQuantitylabel.Size = new System.Drawing.Size(114, 17);
            this.ProductQuantitylabel.TabIndex = 26;
            this.ProductQuantitylabel.Text = "Product Quantity";
            // 
            // datetextBox1
            // 
            this.datetextBox1.Location = new System.Drawing.Point(796, 89);
            this.datetextBox1.Name = "datetextBox1";
            this.datetextBox1.Size = new System.Drawing.Size(100, 22);
            this.datetextBox1.TabIndex = 27;
            // 
            // Datelabel3
            // 
            this.Datelabel3.AutoSize = true;
            this.Datelabel3.Location = new System.Drawing.Point(663, 89);
            this.Datelabel3.Name = "Datelabel3";
            this.Datelabel3.Size = new System.Drawing.Size(38, 17);
            this.Datelabel3.TabIndex = 28;
            this.Datelabel3.Text = "Date";
            // 
            // quantitytextBox1
            // 
            this.quantitytextBox1.Location = new System.Drawing.Point(154, 105);
            this.quantitytextBox1.Name = "quantitytextBox1";
            this.quantitytextBox1.Size = new System.Drawing.Size(100, 22);
            this.quantitytextBox1.TabIndex = 29;
            // 
            // unitpricetextBox2
            // 
            this.unitpricetextBox2.Location = new System.Drawing.Point(280, 105);
            this.unitpricetextBox2.Name = "unitpricetextBox2";
            this.unitpricetextBox2.Size = new System.Drawing.Size(100, 22);
            this.unitpricetextBox2.TabIndex = 30;
            // 
            // Unitpricelabel
            // 
            this.Unitpricelabel.AutoSize = true;
            this.Unitpricelabel.Location = new System.Drawing.Point(291, 84);
            this.Unitpricelabel.Name = "Unitpricelabel";
            this.Unitpricelabel.Size = new System.Drawing.Size(69, 17);
            this.Unitpricelabel.TabIndex = 31;
            this.Unitpricelabel.Text = "Unit Price";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 625);
            this.Controls.Add(this.Unitpricelabel);
            this.Controls.Add(this.unitpricetextBox2);
            this.Controls.Add(this.quantitytextBox1);
            this.Controls.Add(this.Datelabel3);
            this.Controls.Add(this.datetextBox1);
            this.Controls.Add(this.ProductQuantitylabel);
            this.Controls.Add(this.Productnamelabel);
            this.Controls.Add(this.Branchnamelabel);
            this.Controls.Add(this.ProductNamecomboBox1);
            this.Controls.Add(this.Addbutton4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonComplete);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.TextBox textBoxCname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcPhone;
        private System.Windows.Forms.Button Addbutton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ProductNamecomboBox1;
        private System.Windows.Forms.Label Branchnamelabel;
        private System.Windows.Forms.Label Productnamelabel;
        private System.Windows.Forms.Label ProductQuantitylabel;
        private System.Windows.Forms.TextBox datetextBox1;
        private System.Windows.Forms.Label Datelabel3;
        private System.Windows.Forms.TextBox quantitytextBox1;
        private System.Windows.Forms.TextBox unitpricetextBox2;
        private System.Windows.Forms.Label Unitpricelabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}