using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Branch
    {
        private string branchname;

       
        public string Branchname
        {
            get { return branchname; }
            set { branchname = value; }
        }
        private int branchid;

        public int Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }
        private string branchLocation;

        public string BranchLocation
        {
            get { return branchLocation; }
            set { branchLocation = value; }
        }
        public bool createnewbranch(){
            
            string sql = "SELECT * FROM Branch WHERE( Branch_Name='" + this.Branchname +"' AND Branch_Location= '"+this.BranchLocation +"')"; 
            DataTable dt = DataAccess.GetDataTable(sql);
           
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else {
                string sql1 = "INSERT INTO Branch(Branch_Name,Branch_Location) VALUES ('" + this.Branchname+ "','" +this.BranchLocation + "')";
                DataAccess.ExecuteSQL(sql1);
                return true;
            }
            
        
        }
        public bool Load(int id)
        {
            string sql = "SELECT * FROM Branch WHERE Branch_ID=" + id;
            DataTable dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                this.Branchid = id;
                this.Branchname = dt.Rows[0]["Branch_Name"].ToString();
                this.BranchLocation = dt.Rows[0]["Branch_Location"].ToString();
                
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
