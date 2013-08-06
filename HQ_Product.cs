using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class HQ_Product
    {
        
        private int productid;

        public int Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private string productType;

        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string productExpdate;

        public string ProductExpdate
        {
            get { return productExpdate; }
            set { productExpdate = value; }
        }
        private string productMfgdate;

        public string ProductMfgdate
        {
            get { return productMfgdate; }
            set { productMfgdate = value; }
        }
        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int purchasePrice;

        public int PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        private int salesPrice;

        public int SalesPrice
        {
            get { return salesPrice; }
            set { salesPrice = value; }
        }
        private string purchasedDate;

        public string PurchasedDate
        {
            get { return purchasedDate; }
            set { purchasedDate = value; }
        }
        public int pid() {

            string sql1 = "SELECT * FROM HQ_Product_Inventory WHERE ( Product_Name='" + this.ProductName + "' and Product_Type='" + this.ProductType + "')";

            DataTable dt = DataAccess.GetDataTable(sql1);

            if (dt.Rows.Count > 0)
            {
                int a = Convert.ToInt32(dt.Rows[0]["Product_ID"]);
                return a;
            }
            else
            {
                
              
                return 0 ;
            }
        }

        public bool addnewproduct(string ProductName1,string ProductType1,int SupplierId1){


            string sql1 = "SELECT * FROM HQ_Product_Inventory WHERE Product_Name='" + ProductName1 + "' and Product_Type='" + ProductType1 + "'and Supplier_ID= " + SupplierId1;
        
            DataTable dt = DataAccess.GetDataTable(sql1);
           
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else {
                string sql = "INSERT INTO HQ_Product_Inventory(Product_Name,Product_Type,Supplier_ID) VALUES ('" + ProductName1 + "','" + ProductType1 + "','" + SupplierId1 +  "')";
                DataAccess.ExecuteSQL(sql);
                return true;
            }
        
        }
        public bool ptype() { 
            
        
            string sql = "SELECT * FROM HQ_Product_Inventory WHERE Product_ID=" + this.Productid;
            DataTable dt = DataAccess.GetDataTable(sql);
           
            if (dt.Rows.Count > 0)
            {
               
                this.ProductType= dt.Rows[0]["Product_Type"].ToString();
                this.ProductName=dt.Rows[0]["Product_Name"].ToString();
                this.productExpdate = dt.Rows[0]["Product_EXP_Date"].ToString();
                this.productMfgdate = dt.Rows[0]["Product_MFG_Date"].ToString();
                this.SupplierId = Convert.ToInt32(dt.Rows[0]["Supplier_ID"].ToString());
                this.Quantity =Convert.ToInt32( dt.Rows[0]["Product_Quantity"]);
                this.PurchasePrice = Convert.ToInt32(dt.Rows[0]["Product_Purchase_Price"]);
                this.SalesPrice=Convert.ToInt32(dt.Rows[0]["Product_Sales_Price"]);
                this.PurchasedDate=dt.Rows[0]["Purchased_Date"].ToString();
                return true;

               
            }
            else
            {

                
                return false;
            }

        
        
        } 
        public void proupdate(){
           
            string sql = "UPDATE HQ_Product_Inventory SET Product_Quantity= " +this.Quantity + " WHERE Product_ID=" +this.productid;
            DataAccess.ExecuteSQL(sql);

            string sql1 = "UPDATE HQ_Product_Inventory SET Product_Sales_Price= " + this.SalesPrice + " WHERE Product_ID=" + this.Productid;
            DataAccess.ExecuteSQL(sql1);

            string sql2 = "UPDATE HQ_Product_Inventory SET Product_Purchase_Price= " + this.PurchasePrice + " WHERE Product_ID=" + this.Productid;
            DataAccess.ExecuteSQL(sql2);

            string sql3 = "UPDATE HQ_Product_Inventory SET Product_EXP_Date= '" + this.productExpdate + "' WHERE Product_ID=" + this.Productid;
            DataAccess.ExecuteSQL(sql3);

            string sql4 = "UPDATE HQ_Product_Inventory SET Product_MFG_Date= '" +this.ProductMfgdate + "' WHERE Product_ID=" + this.Productid;
            DataAccess.ExecuteSQL(sql4);

            string sql5 = "UPDATE HQ_Product_Inventory SET Purchased_Date= '" + this.PurchasedDate + "' WHERE Product_ID=" + this.Productid;
            DataAccess.ExecuteSQL(sql5);

           
            
            
        }

        public bool newentry()
        {
            

            string sql1 = "SELECT * FROM HQ_Product_Inventory WHERE Product_Name='" + this.ProductName + "' and Product_Type='" + this.ProductType + "'and Supplier_ID= " + this.SupplierId;

            DataTable dt = DataAccess.GetDataTable(sql1);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string sql = "INSERT INTO HQ_Product_Inventory(Product_Type,Product_EXP_Date,Product_MFG_Date,Supplier_ID,Product_Quantity,Product_Purchase_Price,Product_Sales_Price,Product_Name,Purchased_Date) VALUES ('" + this.ProductType + "','" + this.ProductExpdate + "','" + this.ProductMfgdate + "'," +this.SupplierId +","+this.quantity+","+this.PurchasePrice+","+this.SalesPrice+",'"+this.ProductName+"','"+this.PurchasedDate+"')";
                DataAccess.ExecuteSQL(sql);
                return true;
            }



        }
    }
}
