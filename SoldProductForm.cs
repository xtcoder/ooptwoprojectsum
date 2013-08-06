using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SoldProductForm : Form
    {
        public SoldProductForm()
        {
            InitializeComponent();
            if (LoginForm.USERTYPE == "hqmanager")
            {
                BranchCollection obj = new BranchCollection();
                obj.LoadAll();
                BranchnamecomboBox1.DataSource = obj.LoadedTable;
                BranchnamecomboBox1.ValueMember = "Branch_ID";
                BranchnamecomboBox1.DisplayMember = "Branch_Name";
                Branchnamelabel2.Visible = false;


                BranchProductColletion bpc = new BranchProductColletion();
                bpc.LoadAll();
                productidcomboBox2.DataSource = bpc.LoadedTable;
                productidcomboBox2.DisplayMember = "PName";
                productidcomboBox2.ValueMember = "PID";
                SoldproducCollection sp = new SoldproducCollection();
                sp.LoadAll();
                datecomboBox3.DataSource = sp.LoadedTable;
                datecomboBox3.ValueMember = "Sold_Date";
                datecomboBox3.DisplayMember = "Sold_Date";

                SupplierCollection sc = new SupplierCollection();
                sc.LoadAll();
                supplieridcomboBox4.DataSource = sc.LoadedTable;
                supplieridcomboBox4.ValueMember = "Supplier_ID";
                supplieridcomboBox4.DisplayMember = "Supplier_Name";
            }
            else if (LoginForm.USERTYPE == "manager")
            {
                Branchnamelabel2.Text = LoginForm.BNAME;
                BranchnamecomboBox1.Visible = false;

                BranchProductColletion bpc = new BranchProductColletion();

                bpc.LoadAll2(LoginForm.BRCHID);
                productidcomboBox2.DataSource = bpc.LoadedTable;
                productidcomboBox2.DisplayMember = "PName";
                productidcomboBox2.ValueMember = "PID";
                SoldproducCollection sp = new SoldproducCollection();
                sp.LoadAll();
                datecomboBox3.DataSource = sp.LoadedTable;
                datecomboBox3.ValueMember = "Sold_Date";
                datecomboBox3.DisplayMember = "Sold_Date";

                SupplierCollection sc = new SupplierCollection();
                sc.LoadAll();
                supplieridcomboBox4.DataSource = sc.LoadedTable;
                supplieridcomboBox4.ValueMember = "Supplier_ID";
                supplieridcomboBox4.DisplayMember = "Supplier_Name";

            }
        }

        private void BranchNamelabel1_Click(object sender, EventArgs e)
        {

        }

        private void SoldProductForm_Load(object sender, EventArgs e)
        {
            //if (LoginForm.USERTYPE == "hqmanager")
            //{
            //    BranchCollection obj = new BranchCollection();
            //    obj.LoadAll();
            //    BranchnamecomboBox1.DataSource = obj.LoadedTable;
            //    BranchnamecomboBox1.ValueMember = "Branch_ID";
            //    BranchnamecomboBox1.DisplayMember = "Branch_Name";
            //    Branchnamelabel2.Visible = false;


            //    BranchProductColletion bpc = new BranchProductColletion();
            //    bpc.LoadAll();
            //    productidcomboBox2.DataSource = bpc.LoadedTable;
            //    productidcomboBox2.DisplayMember = "PName";
            //    productidcomboBox2.ValueMember = "PID";
            //    SoldproducCollection sp = new SoldproducCollection();
            //    sp.LoadAll();
            //    datecomboBox3.DataSource = sp.LoadedTable;
            //    datecomboBox3.ValueMember = "Sold_Date";
            //    datecomboBox3.DisplayMember = "Sold_Date";

            //    SupplierCollection sc = new SupplierCollection();
            //    sc.LoadAll();
            //    supplieridcomboBox4.DataSource = sc.LoadedTable;
            //    supplieridcomboBox4.ValueMember = "Supplier_Name";
            //    supplieridcomboBox4.DisplayMember = "Supplier_ID";
            //}
            //else if (LoginForm.USERTYPE == "manager")
            //{
            //    Branchnamelabel2.Text = LoginForm.BNAME;
            //    BranchnamecomboBox1.Visible = false;



            //}
        }

        private void Showbutton1_Click(object sender, EventArgs e)
        {
            if (LoginForm.USERTYPE == "hqmanager")
            {

                SoldproducCollection spc = new SoldproducCollection();

               
                
                
                 if (searchbyproductidcheckBox2.Checked == true)
                {

                    int temp1 = Convert.ToInt32(productidcomboBox2.SelectedValue);
                    int temp2 = Convert.ToInt32(BranchnamecomboBox1.SelectedValue);
                    if (spc.searchbypid(temp1, temp2) == true)
                    {

                        dataGridView1.DataSource = spc.LoadedTable;

                    }
                    else
                    {
                        MessageBox.Show("this product is not sold");
                    }

                }
                else if (searchbyDatecheckBox3.Checked == true)
                {

                    int temp2 = Convert.ToInt32(BranchnamecomboBox1.SelectedValue);
                    string s = datecomboBox3.SelectedValue.ToString();
                    if (spc.searchbydate(s, temp2) == true)
                    {

                        dataGridView1.DataSource = spc.LoadedTable;

                    }
                    else
                    {
                        MessageBox.Show("this branch has no product sell yet");
                    }

                }
                else if (searchbysupplieridcheckBox1.Checked == true)
                {

                    int temp2 = Convert.ToInt32(BranchnamecomboBox1.SelectedValue);
                    int temp1 = Convert.ToInt32(supplieridcomboBox4.SelectedValue);
                    if (spc.searchbysupid(temp2, temp1) == true)
                    {

                        dataGridView1.DataSource = spc.LoadedTable;

                    }
                    else
                    {
                        MessageBox.Show("this supplier has no sale yet");
                    }

                }
            }
            else if (LoginForm.USERTYPE == "manager")
            {

                SoldproducCollection spc = new SoldproducCollection();
               
                if (searchbyproductidcheckBox2.Checked == true)
                {

                    int temp1 = Convert.ToInt32(productidcomboBox2.SelectedValue);
                    int temp2 = LoginForm.BRCHID;
                    if (spc.searchbypid(temp1, temp2) == true)
                    {

                        dataGridView1.DataSource = spc.LoadedTable;

                    }
                    else
                    {
                        MessageBox.Show("this product is not sold");
                    }

                }
                else if (searchbyDatecheckBox3.Checked == true)
                {

                    int temp2 = LoginForm.BRCHID;
                    string s = datecomboBox3.SelectedValue.ToString();
                    if (spc.searchbydate(s, temp2) == true)
                    {

                        dataGridView1.DataSource = spc.LoadedTable;

                    }
                    else
                    {
                        MessageBox.Show("this branch has no product sell yet");
                    }

                }
                else if (searchbysupplieridcheckBox1.Checked == true)
                {

                    int temp2 = LoginForm.BRCHID;
                    int temp1 = Convert.ToInt32(supplieridcomboBox4.SelectedValue);
                    if (spc.searchbysupid(temp2, temp1) == true)
                    {

                        dataGridView1.DataSource = spc.LoadedTable;

                    }
                    else
                    {
                        MessageBox.Show("this supplier has no sale yet");
                    }


                }
            }
        }
    }
}