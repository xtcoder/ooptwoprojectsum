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
    public partial class Form1 : Form
    {
        public Form1(int id)
        {
            InitializeComponent();
            Employee p = new Employee();
            p.Load(id);
            label1.Text = id.ToString();
            textBox1.Text = p.Empname;
            textBox2.Text = p.Address;
            textBox3.Text = Convert.ToString(p.BranchId);
            int temp = p.BranchId;
            textBox4.Text = p.getbranchname(temp);
            textBox5.Text = p.Password;
            textBox6.Text = p.Type;
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
                
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBranch ab = new AddBranch();
            ab.Show();
            
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee p = new Employee();
            p.Empname=textBox1.Text.ToString();
            p.Address=textBox2.Text.ToString();
            p.Password=textBox5.Text.ToString();
            p.Empid=Convert.ToInt32(label1.Text);
            p.updatefromform1();
            MessageBox.Show("Your information Saved Successfully");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (LoginForm.USERTYPE == "hqmanager")
            {
                toolStripMenuItem1.Visible = false;


            }
            if (LoginForm.USERTYPE == "manager")
            {
                hQInventoryToolStripMenuItem.Visible = false;
               // employeeEditToolStripMenuItem.Visible = false;
                MenutoolStripMenuItem1.Visible = false;
                toolStripMenuItem3.Visible = false;
            }
            if (LoginForm.USERTYPE == "sales")
            {
                toolStripMenuItem2.Visible = false;
                MenutoolStripMenuItem1.Visible = false;
                reportToolStripMenuItem.Visible = false;
               // employeeEditToolStripMenuItem.Visible = false;
                hQInventoryToolStripMenuItem.Visible = false;
                //employeeToolStripMenuItem.Visible = false;
                branchInventoryToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = false;

            }
           
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void productHQToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();
            
              
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Close();
            lf.Show();
            
        }

        private void hQInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Product pp = new Purchase_Product();
            pp.Show();
           
        }

        private void branchInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branch_Inventory obj = new Branch_Inventory();
            obj.Show();
        }

        private void reportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SoldProductForm spf = new SoldProductForm();
            spf.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
        }
    }
}
