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
    public partial class Branch_Inventory : Form
    {
        public Branch_Inventory()
        {
            InitializeComponent();
            if (LoginForm.USERTYPE == "hqmanager")
            {
                BranchIDlabel13.Visible = false;
                BranchCollection obj1 = new BranchCollection();
                obj1.LoadAll();
                BranchcomboBox1.DataSource = obj1.LoadedTable;
                BranchcomboBox1.DisplayMember = "Branch_Name";
                BranchcomboBox1.ValueMember = "Branch_ID";
            }
            else
            {
                BranchcomboBox1.Visible = false;
                BranchIDlabel13.Text = LoginForm.BNAME;

            }
            BranchProductColletion obj22 = new BranchProductColletion();
            obj22.LoadAll();
            comboBox1.DataSource = obj22.LoadedTable;
            comboBox1.DisplayMember = "PName";
            comboBox1.ValueMember = "PID";
            
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Branch_Inventory_Load(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false) {
                MessageBox.Show("Please check search");
                checkBox1.Focus();
            }
            else
            {
                Branch_Product bp = new Branch_Product();
                bp.Productid = Convert.ToInt32(comboBox1.SelectedValue);
                if (LoginForm.USERTYPE == "hqmanager")
                {
                    bp.BranchId = Convert.ToInt32(BranchcomboBox1.SelectedValue);
                    bool b=bp.ptype2();
                    if (b == true)
                    {
                        ProductnametextBox1.Text = bp.ProductName;
                        ProductTypetextBox.Text = bp.ProductType;
                        QuantityTextBox.Text = bp.Quantity.ToString();
                        SalespricetextBox4.Text = bp.SalesPrice.ToString();
                        ExpdatetextBox2.Text = bp.ProductExpdate;
                        MfgdatetextBox3.Text = bp.ProductMfgdate;
                        CheckindatetextBox4.Text = bp.CheckInDate;
                        RequestedQuantitytextBox5.Text = bp.ReqQuantity.ToString();
                    }
                    else {

                        MessageBox.Show("this product is not found in Branch ");
                    }

                }
                else
                {
                    bool a = bp.ptype();
                    if (a == true)
                    {

                        ProductnametextBox1.Text = bp.ProductName;
                        ProductTypetextBox.Text = bp.ProductType;
                        QuantityTextBox.Text = bp.Quantity.ToString();
                        SalespricetextBox4.Text = bp.SalesPrice.ToString();
                        ExpdatetextBox2.Text = bp.ProductExpdate;
                        MfgdatetextBox3.Text = bp.ProductMfgdate;
                        CheckindatetextBox4.Text = bp.CheckInDate;
                        RequestedQuantitytextBox5.Text = bp.ReqQuantity.ToString();


                    }
                    else
                    {
                        MessageBox.Show("Error ");
                        comboBox1.Focus();

                    }
                }

            }
        }

        private void ShowallButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.USERTYPE == "hqmanager")
            {
                BranchProductColletion bpc = new BranchProductColletion();
                int param2 = Convert.ToInt32(BranchcomboBox1.SelectedValue);
                if (param2 != 2001)
                {

                    bpc.LoadAll2(param2);
                    dataGridView1.DataSource = bpc.LoadedTable;

                }
                else {
                    MessageBox.Show("PLease select Any Branch Inventory");
                }
            }
              else if(LoginForm.USERTYPE=="manager") {
               BranchProductColletion bpc1 = new BranchProductColletion();
               int temp1 = Convert.ToInt32(LoginForm.BRCHID);
               bpc1.LoadAll2(temp1);
               dataGridView1.DataSource=bpc1.LoadedTable;
            
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BranchcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
          
            if (ProductnametextBox1.Text == "")
            {
                MessageBox.Show("Please Enter Product Nmae");
            }

            else if (ProductTypetextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Priduct Type");
            }

            else if (QuantityTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product Quantity");
            }

            else if (SalespricetextBox4.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Sales price");
            }

            else if (ExpdatetextBox2.Text.Trim() == "")
            {

                MessageBox.Show("Please enter expiry date");
            }

            else if (MfgdatetextBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please enter mfg date");
            }

            else if (CheckindatetextBox4.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Check in date");
            }

            else if (RequestedQuantitytextBox5.Text.Trim() == "")
            {
                MessageBox.Show("Please enter mfg date");
            }

            else
            {
                if (checkBox1.Checked == false)
                {

                    Branch_Product obj1 = new Branch_Product();
                    obj1.ProductType = ProductTypetextBox.Text;
                    obj1.ProductExpdate = ExpdatetextBox2.Text;
                    obj1.ProductMfgdate = MfgdatetextBox3.Text;
                    if (LoginForm.USERTYPE == "hqmanager")
                    {
                        obj1.BranchId = Convert.ToInt32(comboBox1.SelectedValue);
                    }
                    else
                    {
                        obj1.BranchId = LoginForm.BRCHID;
                    }
                    obj1.Quantity = Convert.ToInt32(QuantityTextBox.Text);
                    obj1.ReqQuantity = Convert.ToInt32(RequestedQuantitytextBox5.Text);
                    obj1.SalesPrice = Convert.ToInt32(SalespricetextBox4.Text);
                    obj1.ProductName = ProductnametextBox1.Text;
                    obj1.CheckInDate = CheckindatetextBox4.Text;
                    HQ_Product hp = new HQ_Product();
                    hp.ProductName = obj1.ProductName;
                    hp.ProductType = obj1.ProductType;

                    obj1.Productid = hp.pid();
                    if (obj1.Productid == 0)
                    {
                        MessageBox.Show("Product is not listed in HQ");
                    }
                    else
                    {

                        bool b = obj1.newentry();

                        MessageBox.Show("  Product Information listed Sucessfully");


                    }

                }
                else
                {
                    if (LoginForm.USERTYPE == "hqmanager")
                    {
                        MessageBox.Show("You can Only view");
                    }
                    else
                    {

                        Branch_Product obj11 = new Branch_Product();
                        obj11.ProductName = ProductnametextBox1.Text;
                        obj11.ProductType = ProductTypetextBox.Text;
                        obj11.SalesPrice = Convert.ToInt32(SalespricetextBox4.Text);
                        obj11.ProductMfgdate = MfgdatetextBox3.Text;
                        obj11.ProductExpdate = ExpdatetextBox2.Text;
                        obj11.Quantity = Convert.ToInt32(QuantityTextBox.Text);
                        obj11.ReqQuantity = Convert.ToInt32(RequestedQuantitytextBox5.Text);
                        obj11.CheckInDate = CheckindatetextBox4.Text;
                        HQ_Product hp1 = new HQ_Product();
                        hp1.ProductName = obj11.ProductName;
                        hp1.ProductType = obj11.ProductType;
                        obj11.Productid = hp1.pid();
                        obj11.proupdate();


                        MessageBox.Show("Product information updated");
                    }

                }
            
            }

                
                

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BranchIDlabel13_Click(object sender, EventArgs e)
        {

        }
    }
}
