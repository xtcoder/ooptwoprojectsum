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
    public partial class Purchase_Product : Form
    {
        public Purchase_Product()
        {
            InitializeComponent();
            HQprodutCollection hc=new HQprodutCollection();
            hc.LoadAll();
            comboBox1.DataSource=hc.LoadedTable;
            comboBox1.ValueMember = "Product_ID";
            comboBox1.DisplayMember = "Product_Name";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Product_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                MessageBox.Show("Please check search");
            }
            else {
                HQ_Product obj = new HQ_Product();
                obj.Productid = Convert.ToInt32(comboBox1.SelectedValue);
               bool a = obj.ptype();
                if (a == true) {

                   pnametextBox.Text= obj.ProductName;
                    expdatetextBox6.Text = obj.ProductExpdate;
                    mfgdatetextBox7.Text = obj.ProductMfgdate;
                    supplieridtextBox12.Text = obj.SupplierId.ToString();
                    quantitytextBox3.Text = obj.Quantity.ToString();
                    purchasepricetextBox13.Text = obj.PurchasePrice.ToString();
                    salespricetextBox4.Text = obj.SalesPrice.ToString();
                    pnametextBox.Text = obj.ProductName;
                    purchaseddatetextBox8.Text = obj.PurchasedDate;
                    producttypetextBox2.Text = obj.ProductType;
                }
                else {
                    MessageBox.Show("Please enter Valid ID");
                    comboBox1.Focus();
                }
           
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnametextBox.Text.Trim() == "") {
                MessageBox.Show("Please Enter Product Nmae");
            }
            else if (supplieridtextBox12.Text.Trim() == "") {
                MessageBox.Show("Please enter supplier ID");
            }
           else if (producttypetextBox2.Text.Trim()=="") {
                MessageBox.Show("Please enter Product Type=");
            }

            else if (purchasepricetextBox13.Text.Trim() == "") {
                MessageBox.Show("Please enter Purchase price");
            }
            else if(quantitytextBox3.Text.Trim()==""){

                MessageBox.Show("Please enter quantity");
            }
            else if (salespricetextBox4.Text.Trim() == "") {
                MessageBox.Show("Please enter sales price");
            }
            else if (expdatetextBox6.Text.Trim()=="") {
                MessageBox.Show("Please enter exp date");
            }
            else if (mfgdatetextBox7.Text.Trim() == "")
            {
                MessageBox.Show("Please enter mfg date");
            }
            else if(purchasepricetextBox13.Text.Trim()==""){
                MessageBox.Show("Please enter purchase price ");
            }
            else
            {
               
                if (checkBox1.Checked ==false)
                {

                    HQ_Product obj1 = new HQ_Product();
                    obj1.ProductType = producttypetextBox2.Text;
                    obj1.ProductExpdate = expdatetextBox6.Text;
                    obj1.ProductMfgdate = mfgdatetextBox7.Text;
                    obj1.SupplierId = Convert.ToInt32(supplieridtextBox12.Text);
                    obj1.Quantity = Convert.ToInt32(quantitytextBox3.Text);
                    obj1.PurchasePrice = Convert.ToInt32(purchasepricetextBox13.Text);
                    obj1.SalesPrice = Convert.ToInt32(salespricetextBox4.Text);
                    obj1.ProductName = pnametextBox.Text;
                    obj1.PurchasedDate = purchaseddatetextBox8.Text;
                    bool b=obj1.newentry();
                    if (b == true)
                    {
                        MessageBox.Show(" New Product Information listed Sucessfully");
                    }
                    else {
                        MessageBox.Show("This product is already inlisted");
                    }
                }
                else {

                    HQ_Product obj11 = new HQ_Product();
                  
                    obj11.ProductExpdate = expdatetextBox6.Text;
                    obj11.ProductMfgdate = mfgdatetextBox7.Text;
                  
                    obj11.Quantity = Convert.ToInt32(quantitytextBox3.Text);
                    obj11.PurchasePrice = Convert.ToInt32(purchasepricetextBox13.Text);
                    obj11.SalesPrice = Convert.ToInt32(salespricetextBox4.Text);
                 
                    obj11.PurchasedDate = purchaseddatetextBox8.Text;
                    obj11.Productid = Convert.ToInt32(comboBox1.SelectedValue);
                    obj11.proupdate();
                    MessageBox.Show("Product information updated");
                    
                }
            }

          }
        

        private void button3_Click(object sender, EventArgs e)
        {
            HQprodutCollection obj = new HQprodutCollection();
            obj.LoadAll();
            dataGridView1.DataSource = obj.LoadedTable;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void purchaseddatetextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void mfgdatetextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void expdatetextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void producttypetextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pridducidtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void salespricetextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitytextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplieridtextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void purchasepricetextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
