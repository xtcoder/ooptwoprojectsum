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
    public partial class SalesForm : Form
    {
        
        int Rowcount = 0;
        int totalprice=0;
        public SalesForm()
        {
            InitializeComponent();

        }

        private void Remove_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[Rowcount].Cells[0].Value = ProductNamecomboBox1.SelectedValue;
            Branch_Product bp = new Branch_Product();
            int a = Convert.ToInt32(ProductNamecomboBox1.SelectedValue);
            bp.Productid = a;
            bp.ptype();
            dataGridView1.Rows[Rowcount].Cells[1].Value = bp.ProductName;
           
            
            dataGridView1.Rows[Rowcount].Cells[2].Value = unitpricetextBox2.Text;
            dataGridView1.Rows[Rowcount].Cells[3].Value = quantitytextBox1.Text;

            int t = Convert.ToInt32(quantitytextBox1.Text);
            int t1 = Convert.ToInt32(unitpricetextBox2.Text);
            int t2 = t1 * t;
            string st = t2.ToString();
            dataGridView1.Rows[Rowcount].Cells[4].Value = st;
            totalprice+=t2;
            if (Rowcount > 0) {
                dataGridView1.Rows[Rowcount-1].Cells[5].Value = "";
            }
            
            dataGridView1.Rows[Rowcount].Cells[5].Value =totalprice.ToString();
          
         
            Rowcount++;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CashMemo cm = new CashMemo();

            cm.CustomerName = textBoxCname.Text;
            cm.CustomerPhone = Convert.ToInt32(textBoxcPhone.Text);
            cm.Date = DateTime.Today.ToShortDateString();
            cm.newentry();
            cm.CashMemoNO = cm.returnid();
            for (int i = 0; i <= Rowcount-1; i++) {

                SoldProductcs sp = new SoldProductcs();
                sp.BranchID = LoginForm.BRCHID;
                sp.ProductId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                Branch_Product bp1=new Branch_Product();
                bp1.Productid=sp.ProductId;
                bp1.BranchId=sp.BranchID;
                bp1.ptype2();
                sp.Pname = bp1.ProductName;
                sp.ProductSalesUnitPrice = bp1.SalesPrice;
                sp.Ptype = bp1.ProductType;
                sp.ProdducExpDate = bp1.ProductExpdate;
                sp.MfgDate = bp1.ProductMfgdate;
                sp.Quantity=Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                bp1.Quantity -= sp.Quantity;
                bp1.proupdate2(bp1.Quantity);
                sp.TotalPrice = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                sp.CashMemoNo = cm.CashMemoNO;
                sp.SoldDate = DateTime.Today.ToShortDateString();
                sp.newentry();
                
                }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            BranchProductColletion obj22 = new BranchProductColletion();
            obj22.LoadAll();

            ProductNamecomboBox1.DataSource = obj22.LoadedTable;
            ProductNamecomboBox1.DisplayMember = "PName";
            ProductNamecomboBox1.ValueMember = "PID";
            Branch_Product bp=new Branch_Product();
            bp.Productid= Convert.ToInt32(ProductNamecomboBox1.SelectedValue);
            bp.BranchId = LoginForm.BRCHID;
            bp.ptype2();
            quantitytextBox1.Text=bp.Quantity.ToString();
            unitpricetextBox2.Text = bp.SalesPrice.ToString();

            Branchnamelabel.Text = LoginForm.BNAME;
            datetextBox1.Text = DateTime.Today.Date.ToShortDateString();

           
        }

        private void ProductNamecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                Branch_Product bp = new Branch_Product();
                //int i = Convert.ToInt32(((DataRowView)ProductNamecomboBox1.SelectedValue)["PID"]);
                //    bp.Productid = i;
            //bp.Productid=Convert.ToInt32(ProductNamecomboBox1.SelectedValue);
                
                bp.BranchId = LoginForm.BRCHID;
           
                bp.ptype2();
                quantitytextBox1.Text = bp.Quantity.ToString();
                unitpricetextBox2.Text = bp.SalesPrice.ToString();
            
        }

        private void Calculatebutton3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
