using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class SoldproducCollection
    {


        private SoldProductcs[] arr;
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

        public SoldProductcs this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        public void LoadAll()
        {
            string sql = "SELECT * FROM Sold_Product";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new SoldProductcs[this.count];

            for (int i = 0; i < this.count; i++)
            {
                SoldProductcs p = new SoldProductcs();
                p.BranchID = Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
                p.ProductId = Convert.ToInt32(dt.Rows[i]["PID"]);
                p.Pname = dt.Rows[i]["PName"].ToString();
                p.ProductSalesUnitPrice = Convert.ToInt32(dt.Rows[i]["P_Sales_Unit_Price"]);
                p.Ptype = dt.Rows[i]["P_Type"].ToString();
                p.ProdducExpDate= dt.Rows[i]["P_EXP_Date"].ToString();
                p.MfgDate = dt.Rows[i]["P_MFG_Date"].ToString();

                p.Quantity = Convert.ToInt32(dt.Rows[i]["P_Quantity"]);
                p.TotalPrice = Convert.ToInt32(dt.Rows[i]["P_Total_Price"]);
                p.CashMemoNo = Convert.ToInt32(dt.Rows[i]["Cash_Memo_NO"]);
                p.SoldDate = dt.Rows[i]["Sold_Date"].ToString();
                this.arr[i] = p;
            }
        }
         public bool searchbypid(int j,int k) {

             string sql = "SELECT * FROM Sold_Product where PID="+j+"AND Branch_ID = "+k;
             this.dt = DataAccess.GetDataTable(sql);
             this.count = dt.Rows.Count;
             this.arr = new SoldProductcs[this.count];
             if (this.count > 0)
             {
                 for (int i = 0; i < this.count; i++)
                 {
                     SoldProductcs p = new SoldProductcs();
                     p.BranchID = Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
                     p.ProductId = Convert.ToInt32(dt.Rows[i]["PID"]);
                     p.Pname = dt.Rows[i]["PName"].ToString();
                     p.ProductSalesUnitPrice = Convert.ToInt32(dt.Rows[i]["P_Sales_Unit_Price"]);
                     p.Ptype = dt.Rows[i]["P_Type"].ToString();
                     p.ProdducExpDate = dt.Rows[i]["P_EXP_Date"].ToString();
                     p.MfgDate = dt.Rows[i]["P_MFG_Date"].ToString();

                     p.Quantity = Convert.ToInt32(dt.Rows[i]["P_Quantity"]);
                     p.TotalPrice = Convert.ToInt32(dt.Rows[i]["P_Total_Price"]);
                     p.CashMemoNo = Convert.ToInt32(dt.Rows[i]["Cash_Memo_NO"]);
                     p.SoldDate = dt.Rows[i]["Sold_Date"].ToString();
                     this.arr[i] = p;
                 }
                 return true;
             }
             else {
                 return false;
             }
        }
         public bool searchbybid(int temp2)
         {

             string sql = "select  *  from Sold_Product where Branch_ID=" + temp2;
             this.dt = DataAccess.GetDataTable(sql);
             this.count = dt.Rows.Count;
             this.arr = new SoldProductcs[this.count];
             if (this.count > 0)
             {
                 for (int i = 0; i < this.count; i++)
                 {
                     SoldProductcs p = new SoldProductcs();
                     p.BranchID = Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
                     p.ProductId = Convert.ToInt32(dt.Rows[i]["PID"]);
                     p.Pname = dt.Rows[i]["PName"].ToString();
                     p.ProductSalesUnitPrice = Convert.ToInt32(dt.Rows[i]["P_Sales_Unit_Price"]);
                     p.Ptype = dt.Rows[i]["P_Type"].ToString();
                     p.ProdducExpDate = dt.Rows[i]["P_EXP_Date"].ToString();
                     p.MfgDate = dt.Rows[i]["P_MFG_Date"].ToString();

                     p.Quantity = Convert.ToInt32(dt.Rows[i]["P_Quantity"]);
                     p.TotalPrice = Convert.ToInt32(dt.Rows[i]["P_Total_Price"]);
                     p.CashMemoNo = Convert.ToInt32(dt.Rows[i]["Cash_Memo_NO"]);
                     p.SoldDate = dt.Rows[i]["Sold_Date"].ToString();
                     this.arr[i] = p;
                 }
                 return true;
             }
             else
             {
                 return false;
             }


         }
         public bool searchbydate(string j, int k)
         {
             string sql = "select  *  from Sold_Product where Sold_Date='" + j + "' AND Branch_ID=" + k;

             this.dt = DataAccess.GetDataTable(sql);
             this.count = dt.Rows.Count;
             this.arr = new SoldProductcs[this.count];
             if (this.count > 0)
             {
                 for (int i = 0; i < this.count; i++)
                 {
                     SoldProductcs p = new SoldProductcs();
                     p.BranchID = Convert.ToInt32(dt.Rows[i]["Branch_ID"]);
                     p.ProductId = Convert.ToInt32(dt.Rows[i]["PID"]);
                     p.Pname = dt.Rows[i]["PName"].ToString();
                     p.ProductSalesUnitPrice = Convert.ToInt32(dt.Rows[i]["P_Sales_Unit_Price"]);
                     p.Ptype = dt.Rows[i]["P_Type"].ToString();
                     p.ProdducExpDate = dt.Rows[i]["P_EXP_Date"].ToString();
                     p.MfgDate = dt.Rows[i]["P_MFG_Date"].ToString();

                     p.Quantity = Convert.ToInt32(dt.Rows[i]["P_Quantity"]);
                     p.TotalPrice = Convert.ToInt32(dt.Rows[i]["P_Total_Price"]);
                     p.CashMemoNo = Convert.ToInt32(dt.Rows[i]["Cash_Memo_NO"]);
                     p.SoldDate = dt.Rows[i]["Sold_Date"].ToString();
                     this.arr[i] = p;
                 }
                 return true;
             }
             else
             {
                 return false;
             }



         }
         public bool searchbysupid(int j, int k)
         {


             

             string sql = "SELECT Sold_Product.Branch_ID, Sold_Product.PID, Sold_Product.PName, Sold_Product.P_Sales_Unit_Price, Sold_Product.P_EXP_Date, Sold_Product.P_Type, Sold_Product.P_MFG_Date, Sold_Product.P_Quantity, Sold_Product.P_Total_Price, Sold_Product.Cash_Memo_No, Sold_Product.Sold_Date, Supplier.Supplier_ID, Supplier.Supplier_Phone, Supplier.Supplier_Name FROM Branch_Product INNER JOIN HQ_Product_Inventory ON Branch_Product.PID = HQ_Product_Inventory.Product_ID INNER JOIN Supplier ON HQ_Product_Inventory.Supplier_ID = Supplier.Supplier_ID CROSS JOIN Sold_Product WHERE ( Sold_Product.Branch_ID ="+k +" ) AND ( Branch_Product.Branch_ID = "+j +") AND ( Supplier.Supplier_ID ="+ k+ ")" ;

             
                 
             this.dt = DataAccess.GetDataTable(sql);
             return true;
                 
             

             

         }

        
    }
}
