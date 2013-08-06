using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Branch_Product
    {
        private int branchId;

        public int BranchId
        {
            get { return branchId; }
            set { branchId = value; }
        }
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
      
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

      
        private int salesPrice;

        public int SalesPrice
        {
            get { return salesPrice; }
            set { salesPrice = value; }
        }
        private int reqQuantity;

        public int ReqQuantity
        {
            get { return reqQuantity; }
            set { reqQuantity = value; }
        }
        private string checkInDate;


        public string CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        public bool ptype()
        {


            string sql = "SELECT * FROM Branch_Product WHERE PID=" + this.Productid;
            DataTable dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {

                this.ProductType = dt.Rows[0]["P_Type"].ToString();
                this.ProductName = dt.Rows[0]["PName"].ToString();
                this.productExpdate = dt.Rows[0]["P_EXP_Date"].ToString();
                this.productMfgdate = dt.Rows[0]["P_MFG_Date"].ToString();
                this.ReqQuantity = Convert.ToInt32(dt.Rows[0]["Requested_Quantity"].ToString());
                this.Quantity = Convert.ToInt32(dt.Rows[0]["P_Quantity"]);
                this.CheckInDate = dt.Rows[0]["CheckIn_Date"].ToString();
                this.SalesPrice = Convert.ToInt32(dt.Rows[0]["P_Sales_Price"]);
                this.BranchId =Convert.ToInt32( dt.Rows[0]["Branch_ID"]);
                this.Productid = Convert.ToInt32(dt.Rows[0]["PID"]);
                return true;


            }
            else
            {


                return false;
            }



        }
        public bool ptype2()
        {


            string sql1 = "SELECT * FROM Branch_Product WHERE ( Branch_ID=" + this.BranchId + " and PID= " + this.Productid + ")";
            DataTable dt = DataAccess.GetDataTable(sql1);

            if (dt.Rows.Count > 0)
            {

                this.ProductType = dt.Rows[0]["P_Type"].ToString();
                this.ProductName = dt.Rows[0]["PName"].ToString();
                this.productExpdate = dt.Rows[0]["P_EXP_Date"].ToString();
                this.productMfgdate = dt.Rows[0]["P_MFG_Date"].ToString();
                this.ReqQuantity = Convert.ToInt32(dt.Rows[0]["Requested_Quantity"].ToString());
                this.Quantity = Convert.ToInt32(dt.Rows[0]["P_Quantity"]);
                this.CheckInDate = dt.Rows[0]["CheckIn_Date"].ToString();
                this.SalesPrice = Convert.ToInt32(dt.Rows[0]["P_Sales_Price"]);
               
                return true;


            }
            else
            {


                return false;
            }



        }

        public bool newentry()
        {


            string sql1 = "SELECT * FROM Branch_Product WHERE ( PName='" + this.ProductName + "' and P_Type= '" + this.ProductType +"')" ;

            DataTable dt = DataAccess.GetDataTable(sql1);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string sql = "INSERT INTO Branch_Product(PID,Branch_ID,PName,P_Sales_Price,P_Type,P_EXP_Date,P_MFG_Date,P_Quantity,Requested_Quantity,CheckIn_Date) VALUES ("+this.Productid+"," + this.BranchId + ",'" + this.ProductName + "'," + this.salesPrice+ ",'" + this.ProductType + "','" + this.ProductExpdate + "','" + this.ProductMfgdate + "'," + this.Quantity + "," + this.ReqQuantity + ",'" + this.CheckInDate + "')";
                DataAccess.ExecuteSQL(sql);
                return true;
            }



        }

        public void proupdate()
        {

            string sql = "UPDATE Branch_Product SET P_Quantity= " + this.Quantity + " WHERE PID=" + this.Productid;
            DataAccess.ExecuteSQL(sql);

            string sql1 = "UPDATE Branch_Product SET P_Sales_Price= " + this.SalesPrice + " WHERE PID=" + this.Productid;
            DataAccess.ExecuteSQL(sql1);

            string sql2 = "UPDATE Branch_Product SET Requested_Quantity= " + this.ReqQuantity+ " WHERE PID=" + this.Productid;
            DataAccess.ExecuteSQL(sql2);

            string sql3 = "UPDATE Branch_Product SET P_EXP_Date= '" + this.productExpdate + "' WHERE PID=" + this.Productid;
            DataAccess.ExecuteSQL(sql3);

            string sql4 = "UPDATE Branch_Product SET P_MFG_Date= '" + this.ProductMfgdate + "' WHERE PID=" + this.Productid;
            DataAccess.ExecuteSQL(sql4);

            string sql5 = "UPDATE Branch_Product SET CheckIn_Date= '" + this.CheckInDate + "' WHERE PID=" + this.Productid;
            DataAccess.ExecuteSQL(sql5);




        }
        public void proupdate2(int qu)
        {

            string sql = "UPDATE Branch_Product SET P_Quantity= " + qu + " WHERE PID=" + this.Productid +"AND Branch_ID="+this.BranchId;
            DataAccess.ExecuteSQL(sql);

        }


    }
}
