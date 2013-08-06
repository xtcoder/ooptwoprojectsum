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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            BranchCollection obj = new BranchCollection();
            obj.LoadAll();
            comboBox1.DataSource = obj.LoadedTable;
            comboBox1.ValueMember = "Branch_ID";
            comboBox1.DisplayMember = "Branch_Name";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please Username");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please T Password");
            }
            else if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Please write Your employee type");
            }
            
            else
            {
                Employee p = new Employee();
                p.Empname = textBox1.Text;
                p.Password= textBox2.Text;
                p.Address = textBox3.Text;
                p.Type = textBox4.Text;
                p.Salary = Convert.ToInt32(textBox5.Text);
                p.BranchId =Convert.ToInt32( comboBox1.SelectedValue);
                bool s2=p.createnewuser();
                if (s2 ==false) {
                    MessageBox.Show("User already Existed");
                }
                else{

                
                MessageBox.Show("new employee created");}
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Showallbutton_Click(object sender, EventArgs e)
        {
            EmployeeCollection ec = new EmployeeCollection();
            ec.LoadAll();
            dataGridView1.DataSource=ec.LoadedTable;
        }
    }
}
