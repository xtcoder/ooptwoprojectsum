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
    public partial class LoginForm : Form
    {
        public static string USERTYPE = "";
        public static int USERID = 0;
        public static  string BNAME="";
        public static int BRCHID = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

                    
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please Type your Username");
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please Type Your Password");
                textBox2.Focus();
            }
            else
            {
                Employee q = new Employee();
                q.Empid = Convert.ToInt32(textBox1.Text);
                q.Password = textBox2.Text.Trim().ToString();
               
                bool funcp = q.Loginidandpassword();

                if (funcp == true)
                {

                    string tmp1 = q.Empname;
                    MessageBox.Show("Your Login is Successful");
                    MessageBox.Show("Welcome MR "+tmp1+".");
                    Form1 obj1 = new Form1(q.Empid);
                    LoginForm.USERID = q.Empid;
                    LoginForm.USERTYPE = q.Type;
                    LoginForm.BRCHID = q.BranchId;
                    LoginForm.BNAME = q.getbranchname(q.BranchId);
                    obj1.Show();
                    this.Hide();

                }
                else if (funcp == false)
                {

                    MessageBox.Show("Invalid username or password");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();

                }
        }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddEmployee f2 = new AddEmployee();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
