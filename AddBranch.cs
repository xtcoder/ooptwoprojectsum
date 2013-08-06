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
    public partial class AddBranch : Form
    {
        public AddBranch()
        {
            InitializeComponent();
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }

        private void showallbutton1_Click(object sender, EventArgs e)
        {
            BranchCollection obj = new BranchCollection();
            obj.LoadAll();
            dataGridView1.DataSource=obj.LoadedTable;
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {

                MessageBox.Show("Please Enter a Branch name");
                textBox2.Focus();
            }

            else if (textBox1.Text.Trim() == "")
            {

                MessageBox.Show("Please Enter a Branch Location");
                textBox1.Focus();
            }
            else {
                Branch b = new Branch();
                b.Branchname = textBox2.Text;
                b.BranchLocation = textBox1.Text;
                if (b.createnewbranch() == true)
                {
                    MessageBox.Show("New Branch Created");
                }
                else {
                    MessageBox.Show("This Branch Is Already existing");
                }
            
            }
        }
    }
}
