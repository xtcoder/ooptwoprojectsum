using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace WindowsFormsApplication2
{
    class BranchProductColletion
    {
        public Branch_Product[] arr;
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

        public Branch_Product this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }


        public void LoadAll()
        {
            string sql = "SELECT * FROM Branch_Product";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new Branch_Product[this.count];

            for (int i = 0; i < this.count; i++)
            {
                Branch_Product p = new Branch_Product();
                p.Productid = (int)dt.Rows[i]["PID"];
                p.ProductType = dt.Rows[i]["P_Type"].ToString();
                p.ProductExpdate = dt.Rows[i]["P_EXP_Date"].ToString();
                p.ProductMfgdate = dt.Rows[i]["P_MFG_Date"].ToString();
                p.BranchId=Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
                p.Quantity = Convert.ToInt32(dt.Rows[i]["P_Quantity"]);
                p.ReqQuantity = Convert.ToInt32(dt.Rows[i]["Requested_Quantity"]);
                p.SalesPrice = Convert.ToInt32(dt.Rows[i]["P_Sales_Price"]);
                p.ProductName = dt.Rows[i]["PName"].ToString();
                p.CheckInDate= dt.Rows[i]["CheckIn_Date"].ToString();
                this.arr[i] = p;
            }
        }
        public bool LoadAll2(int param)
        {
            string sql = "SELECT * FROM Branch_Product where Branch_ID= " + param;
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new Branch_Product[this.count];

            for (int i = 0; i < this.count; i++)
            {
                Branch_Product p = new Branch_Product();
                p.Productid = (int)dt.Rows[i]["PID"];
                p.ProductType = dt.Rows[i]["P_Type"].ToString();
                p.ProductExpdate = dt.Rows[i]["P_EXP_Date"].ToString();
                p.ProductMfgdate = dt.Rows[i]["P_MFG_Date"].ToString();
                p.BranchId = Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
                p.Quantity = Convert.ToInt32(dt.Rows[i]["P_Quantity"]);
                p.ReqQuantity = Convert.ToInt32(dt.Rows[i]["Requested_Quantity"]);
                p.SalesPrice = Convert.ToInt32(dt.Rows[i]["P_Sales_Price"]);
                p.ProductName = dt.Rows[i]["PName"].ToString();
                p.CheckInDate = dt.Rows[i]["CheckIn_Date"].ToString();
                this.arr[i] = p;
            }
            return true;


        }

         }
    }
       
    

