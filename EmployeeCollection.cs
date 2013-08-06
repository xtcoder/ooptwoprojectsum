using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class EmployeeCollection
    {
        
        private Employee[] arr;
        private int count;
        private DataTable dt;
        public DataTable LoadedTable
        {
            get { return this.dt; }

        }
        public int Count
        {
            get { return this.count; }
        }

        public Employee this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        public void LoadAll()
        {
            string sql = "SELECT * FROM Employee";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new Employee[this.count];

            for (int i = 0; i < this.count; i++)
            {
                Employee p = new Employee();
                p.Empid = (int)dt.Rows[i]["Emp_ID"];
                p.Empname = dt.Rows[i]["Emp_Name"].ToString();
                p.Password=dt.Rows[i]["Password"].ToString();
                p.Type= dt.Rows[i]["Type"].ToString();
                p.Salary = Convert.ToInt32(dt.Rows[i]["salary"]);
                p.Address = dt.Rows[i]["Address"].ToString();
                p.BranchId = Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
               // p.Deptno = (int)dt.Rows[i]["Dept_NO"];
                this.arr[i] = p;
            }
        }

        public void SaveAll()
        {
            for (int i = 0; i < this.count; i++)
            {
                string sql = "SELECT * FROM Employee WHERE Emp_ID=" + this.arr[i].Empid;
                this.dt = DataAccess.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    sql = "UPDATE Employee SET Emp_Name='" + this.arr[i].Empname + "', Password=" + this.arr[i].Password + ", Type=" + this.arr[i].Type + "', Salary=" + this.arr[i].Salary + "', Address=" + this.arr[i].Address + "', Branch=" + this.arr[i].BranchId + "', Dept_NO=" + this.arr[i].Deptno + " WHERE Emp_ID=" + this.arr[i].Empid;
                    DataAccess.ExecuteSQL(sql);
                }
                else
                {
                    sql = "INSERT INTO Employee (Emp_Name,Password, Type,Salary,Address,Branch,Dept_NO) VALUES ('" + this.arr[i].Empname + "'," + this.arr[i].Password + "," + this.arr[i].Type + this.arr[i].Salary + "," + this.arr[i].Address + "," + this.arr[i].BranchId + "," + this.arr[i].Deptno + ")";
                    DataAccess.ExecuteSQL(sql);
                }
            }

        }
    }
}
