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
    public partial class Supplier_ADD : Form
    {
        public Supplier_ADD()
        {
            InitializeComponent();
        }

        private void Supplier_ADD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tt7.Text.Trim() != "")
            {
                MessageBox.Show("Plase remove ID to Enter a new Supplier");
            }
            else if (tt1.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Supplier Name");
            }
            else if (tt2.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Supplier Product Type");
            }
            else if (tt3.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Supplier Phone ");
            }
            else if (tt4.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Supplier Addreess ");
            }
            else
            {
                Supplier obj = new Supplier();

                obj.SupplierName1 = tt1.Text;
                obj.Supplier_P_Type = tt2.Text;
                obj.SupplierPhone = Convert.ToInt32(tt3.Text);
                obj.SupplierAddress = tt4.Text;
                bool b=obj.createnewSupplier(obj.SupplierName1, obj.Supplier_P_Type,obj.SupplierPhone,obj.SupplierAddress);
                if (b == true)
                {
                    MessageBox.Show("New Supplier Created");
                }
                if (b == false)
                {
                    MessageBox.Show("This Supplier is Already Existing");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierCollection sc = new SupplierCollection();
            sc.LoadAll();
            dataGridView1.DataSource = sc.LoadedTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tt7.Text == "")
            {
                MessageBox.Show("Enter A valid ID");

            }
            else
            {
                int id;
                id = Convert.ToInt32(tt7.Text);
                Supplier p = new Supplier();

                if (p.Load(id) == true)
                {
                    tt7.Text = id.ToString();
                    tt1.Text = p.SupplierName1.ToString();
                    tt2.Text = p.Supplier_P_Type.ToString();
                    tt3.Text = p.SupplierPhone.ToString();
                    tt4.Text = p.SupplierAddress.ToString();

                }
                else
                {
                    MessageBox.Show("Error loading Supplier information or id not found ");
                }
            }
        }
    }
}
