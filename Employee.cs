using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Employee
    {
        
        private DataTable dt;
        public DataTable LoadedTable
        {
            get { return this.dt; }

        }
        
        private int empid;

        public int Empid
        {
            get { return empid; }
            set { empid = value; }
        }
        private string empname;


        public string Empname
        {
            get { return empname; }
            set { empname = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private int branchId;

        public int BranchId
        {
            get { return branchId; }
            set { branchId = value; }
        }
        private int deptno;

        public int Deptno
        {
            get { return deptno; }
            set { deptno = value; }
        }

        public bool Save()
        {
            string sql = "SELECT * FROM Employee WHERE empno=" + this.Empid;
            DataTable dt = DataAccess.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = "UPDATE Employee SET Emp_Name='" + this.Empname + "', Password=" + this.Password + ", Type=" + this.Type + "', Salary=" + this.Salary + "', Address=" + this.Address + "', Branch_ID=" + this.BranchId+ "', Dept_NO=" + this.Deptno + " WHERE Emp_ID=" + this.Empid;
                DataAccess.ExecuteSQL(sql);
                return true;
            }
            else
            {

                sql = "INSERT INTO Employee (Emp_Name,Password, Type,Salary,Address,Branch_ID,Dept_NO) VALUES ('" + this.Empname + "'," + this.Password + "," + this.Type + this.Salary + "," + this.Address + "," + this.BranchId + "," + this.Deptno + ")";
                DataAccess.ExecuteSQL(sql);
                return true;
            }
        }
        public bool createnewuser(){
            
        
            string sql1 = "SELECT * FROM Employee WHERE (Emp_Name='" + this.Empname +"' and Password='"+this.Password+"' and Address= '"+this.Address+"')";
            DataTable dt = DataAccess.GetDataTable(sql1);
            if(dt.Rows.Count>0){
                
                return false ;
            }
            else{

                string sql="INSERT INTO Employee(Emp_Name,Password,Type,Salary,Address,Branch_ID) VALUES ('" + this.Empname + "','" + this.Password+ "','" + this.Type + "'," + this.Salary + ",'" + this.Address + "'," + this.BranchId +")";
                DataAccess.ExecuteSQL(sql);
                
                return true;
            }
        }
            
        
        

        public bool Load(int id)  {
       
            string sql = "SELECT * FROM Employee WHERE Emp_ID=" + id;
            DataTable dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                this.Empid = empid;
                this.Empname = dt.Rows[0]["Emp_Name"].ToString();
                this.Password = dt.Rows[0]["Password"].ToString();
                this.Type = dt.Rows[0]["Type"].ToString();
                this.Salary = Convert.ToInt32(dt.Rows[0]["Salary"]);
                this.Address = dt.Rows[0]["Address"].ToString();
                this.BranchId = Convert.ToInt16(dt.Rows[0]["Branch_ID"]);

                string sql1 = "SELECT Branch.Branch_Name,Branch.Branch_ID FROM Branch INNER JOIN Employee ON Branch.Branch_ID = Employee.Branch_ID WHERE  (Employee.Emp_ID = " + this.Empid + ")";
                this.dt = DataAccess.GetDataTable(sql);
              
              
                this.dt = DataAccess.GetDataTable(sql1);
                return true;
            }
            else {
                
              return false;
            }
        }
       

       
        public string getbranchname(int branchid)
        {
            string sql = " SELECT Branch_Name FROM Branch WHERE Branch_ID= " + branchid;
            DataTable dt = DataAccess.GetDataTable(sql);
            string returnstring = dt.Rows[0]["Branch_Name"].ToString();
            return returnstring;
        }
       
        public void updatefromform1(){

            //string sql = "UPDATE Employee SET Emp_Name='" + aname+ "', Password=" + aPassword + ", Address=" + aAddress + " WHERE Emp_ID=" + aEmpid;
            string sql = "UPDATE Employee SET Emp_Name= '" + this.Empname + "' WHERE Emp_ID=" + this.Empid;
            DataAccess.ExecuteSQL(sql);
            string sql1 = "UPDATE Employee SET Address= '" + this.Address + "' WHERE Emp_ID=" + this.Empid;
            DataAccess.ExecuteSQL(sql1);
            string sql2 = "UPDATE Employee SET Password= '" + this.Password + "' WHERE Emp_ID=" + this.Empid;
            DataAccess.ExecuteSQL(sql2);
            
            
        
        }


        public bool Loginidandpassword()
        {

            string sql = "select  *  from Employee where Emp_ID=" +this.Empid + " and password = '" + this.Password+ "'";

            DataTable dt = DataAccess.GetDataTable(sql);
            if (dt.Rows.Count> 0)
            {
                this.Empid = empid;
                this.Empname = dt.Rows[0]["Emp_Name"].ToString();
                this.Password = dt.Rows[0]["Password"].ToString();
                this.Type = dt.Rows[0]["Type"].ToString();
                this.Salary = Convert.ToInt32(dt.Rows[0]["Salary"]);
                this.Address = dt.Rows[0]["Address"].ToString();
                this.BranchId = Convert.ToInt16(dt.Rows[0]["Branch_ID"]);
                return true;
            }

            else
            {
                return false;

            }
        }
       
        
      
    }
}
