

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class SoldProductcs
    {
        private int branchID;

        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        private string pname;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        private int productSalesUnitPrice;


        public int ProductSalesUnitPrice
        {
            get { return productSalesUnitPrice; }
            set { productSalesUnitPrice = value; }
        }

        private string ptype;

        public string Ptype
        {
            get { return ptype; }
            set { ptype = value; }
        }

        private string prodducExpDate;

        public string ProdducExpDate
        {
            get { return prodducExpDate; }
            set { prodducExpDate = value; }
        }
        private string mfgDate;

        public string MfgDate
        {
            get { return mfgDate; }
            set { mfgDate = value; }
        }
        private int quantity;


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private int totalPrice;

        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        private int cashMemoNo;

        public int CashMemoNo
        {
            get { return cashMemoNo; }
            set { cashMemoNo = value; }
        }
        private string soldDate;

        public string SoldDate
        {
            get { return soldDate; }
            set { soldDate = value; }
        }
        public bool newentry()
        {


            string sql = "INSERT INTO Sold_Product(Branch_ID,PID,PName,P_Sales_Unit_Price,P_Type,P_EXP_Date,P_MFG_Date,P_Quantity,P_Total_Price,Cash_Memo_No,Sold_Date) VALUES (" + this.BranchID + "," + this.ProductId + ",'" + this.Pname + "'," + this.ProductSalesUnitPrice + ",'" + this.Ptype + "','" + this.ProdducExpDate+ "','" + this.MfgDate + "'," + this.Quantity + "," + this.TotalPrice + ","+this.CashMemoNo+",'"+this.SoldDate +"')";
            DataAccess.ExecuteSQL(sql);
            return true;
            



        }
       
    }
}
