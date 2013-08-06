namespace WindowsFormsApplication2
{
    partial class SoldProductForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Showbutton1 = new System.Windows.Forms.Button();
            this.BranchNamelabel1 = new System.Windows.Forms.Label();
            this.BranchnamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Branchnamelabel2 = new System.Windows.Forms.Label();
            this.searchbyproductidcheckBox2 = new System.Windows.Forms.CheckBox();
            this.searchbyDatecheckBox3 = new System.Windows.Forms.CheckBox();
            this.searchbysupplieridcheckBox1 = new System.Windows.Forms.CheckBox();
            this.productidcomboBox2 = new System.Windows.Forms.ComboBox();
            this.datecomboBox3 = new System.Windows.Forms.ComboBox();
            this.supplieridcomboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // Showbutton1
            // 
            this.Showbutton1.Location = new System.Drawing.Point(660, 222);
            this.Showbutton1.Name = "Showbutton1";
            this.Showbutton1.Size = new System.Drawing.Size(75, 23);
            this.Showbutton1.TabIndex = 1;
            this.Showbutton1.Text = "Show";
            this.Showbutton1.UseVisualStyleBackColor = true;
            this.Showbutton1.Click += new System.EventHandler(this.Showbutton1_Click);
            // 
            // BranchNamelabel1
            // 
            this.BranchNamelabel1.AutoSize = true;
            this.BranchNamelabel1.Location = new System.Drawing.Point(94, 44);
            this.BranchNamelabel1.Name = "BranchNamelabel1";
            this.BranchNamelabel1.Size = new System.Drawing.Size(94, 17);
            this.BranchNamelabel1.TabIndex = 2;
            this.BranchNamelabel1.Text = "Branch Name";
            this.BranchNamelabel1.Click += new System.EventHandler(this.BranchNamelabel1_Click);
            // 
            // BranchnamecomboBox1
            // 
            this.BranchnamecomboBox1.FormattingEnabled = true;
            this.BranchnamecomboBox1.Location = new System.Drawing.Point(204, 44);
            this.BranchnamecomboBox1.Name = "BranchnamecomboBox1";
            this.BranchnamecomboBox1.Size = new System.Drawing.Size(121, 24);
            this.BranchnamecomboBox1.TabIndex = 3;
            // 
            // Branchnamelabel2
            // 
            this.Branchnamelabel2.AutoSize = true;
            this.Branchnamelabel2.Location = new System.Drawing.Point(214, 47);
            this.Branchnamelabel2.Name = "Branchnamelabel2";
            this.Branchnamelabel2.Size = new System.Drawing.Size(46, 17);
            this.Branchnamelabel2.TabIndex = 4;
            this.Branchnamelabel2.Text = "label2";
            // 
            // searchbyproductidcheckBox2
            // 
            this.searchbyproductidcheckBox2.AutoSize = true;
            this.searchbyproductidcheckBox2.Location = new System.Drawing.Point(190, 167);
            this.searchbyproductidcheckBox2.Name = "searchbyproductidcheckBox2";
            this.searchbyproductidcheckBox2.Size = new System.Drawing.Size(96, 21);
            this.searchbyproductidcheckBox2.TabIndex = 6;
            this.searchbyproductidcheckBox2.Text = "Product ID";
            this.searchbyproductidcheckBox2.UseVisualStyleBackColor = true;
            // 
            // searchbyDatecheckBox3
            // 
            this.searchbyDatecheckBox3.AutoSize = true;
            this.searchbyDatecheckBox3.Location = new System.Drawing.Point(353, 167);
            this.searchbyDatecheckBox3.Name = "searchbyDatecheckBox3";
            this.searchbyDatecheckBox3.Size = new System.Drawing.Size(60, 21);
            this.searchbyDatecheckBox3.TabIndex = 7;
            this.searchbyDatecheckBox3.Text = "Date";
            this.searchbyDatecheckBox3.UseVisualStyleBackColor = true;
            // 
            // searchbysupplieridcheckBox1
            // 
            this.searchbysupplieridcheckBox1.AutoSize = true;
            this.searchbysupplieridcheckBox1.Location = new System.Drawing.Point(509, 167);
            this.searchbysupplieridcheckBox1.Name = "searchbysupplieridcheckBox1";
            this.searchbysupplieridcheckBox1.Size = new System.Drawing.Size(99, 21);
            this.searchbysupplieridcheckBox1.TabIndex = 8;
            this.searchbysupplieridcheckBox1.Text = "Supplier ID";
            this.searchbysupplieridcheckBox1.UseVisualStyleBackColor = true;
            // 
            // productidcomboBox2
            // 
            this.productidcomboBox2.FormattingEnabled = true;
            this.productidcomboBox2.Location = new System.Drawing.Point(190, 194);
            this.productidcomboBox2.Name = "productidcomboBox2";
            this.productidcomboBox2.Size = new System.Drawing.Size(121, 24);
            this.productidcomboBox2.TabIndex = 10;
            // 
            // datecomboBox3
            // 
            this.datecomboBox3.FormattingEnabled = true;
            this.datecomboBox3.Location = new System.Drawing.Point(353, 194);
            this.datecomboBox3.Name = "datecomboBox3";
            this.datecomboBox3.Size = new System.Drawing.Size(121, 24);
            this.datecomboBox3.TabIndex = 11;
            // 
            // supplieridcomboBox4
            // 
            this.supplieridcomboBox4.FormattingEnabled = true;
            this.supplieridcomboBox4.Location = new System.Drawing.Point(509, 194);
            this.supplieridcomboBox4.Name = "supplieridcomboBox4";
            this.supplieridcomboBox4.Size = new System.Drawing.Size(121, 24);
            this.supplieridcomboBox4.TabIndex = 12;
            // 
            // SoldProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 518);
            this.Controls.Add(this.supplieridcomboBox4);
            this.Controls.Add(this.datecomboBox3);
            this.Controls.Add(this.productidcomboBox2);
            this.Controls.Add(this.searchbysupplieridcheckBox1);
            this.Controls.Add(this.searchbyDatecheckBox3);
            this.Controls.Add(this.searchbyproductidcheckBox2);
            this.Controls.Add(this.Branchnamelabel2);
            this.Controls.Add(this.BranchnamecomboBox1);
            this.Controls.Add(this.BranchNamelabel1);
            this.Controls.Add(this.Showbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoldProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoldProductForm";
            this.Load += new System.EventHandler(this.SoldProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Showbutton1;
        private System.Windows.Forms.Label BranchNamelabel1;
        private System.Windows.Forms.ComboBox BranchnamecomboBox1;
        private System.Windows.Forms.Label Branchnamelabel2;
        private System.Windows.Forms.CheckBox searchbyproductidcheckBox2;
        private System.Windows.Forms.CheckBox searchbyDatecheckBox3;
        private System.Windows.Forms.CheckBox searchbysupplieridcheckBox1;
        private System.Windows.Forms.ComboBox productidcomboBox2;
        private System.Windows.Forms.ComboBox datecomboBox3;
        private System.Windows.Forms.ComboBox supplieridcomboBox4;
    }
}