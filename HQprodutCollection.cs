using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class HQprodutCollection
    {
        private HQ_Product[] arr;
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

        public HQ_Product this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        
        public void LoadAll()
        {
            string sql = "SELECT * FROM HQ_Product_Inventory";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new HQ_Product[this.count];

            for (int i = 0; i < this.count; i++)
            {
                HQ_Product p = new HQ_Product();
                p.Productid = (int)dt.Rows[i]["Product_ID"];
                p.ProductType = dt.Rows[i]["Product_Type"].ToString();
                p.ProductExpdate = dt.Rows[i]["Product_EXP_Date"].ToString();
                p.ProductMfgdate = dt.Rows[i]["Product_MFG_Date"].ToString();
                p.SupplierId = Convert.ToInt16(dt.Rows[i]["Supplier_ID"]);
                p.Quantity = Convert.ToInt32(dt.Rows[i]["Product_Quantity"]);
                p.PurchasePrice = Convert.ToInt32(dt.Rows[i]["Product_Purchase_Price"]);
                p.SalesPrice = Convert.ToInt32(dt.Rows[i]["Product_Sales_Price"]);
                p.ProductName = dt.Rows[i]["Product_Name"].ToString();
                p.PurchasedDate = dt.Rows[i]["Purchased_Date"].ToString();
                this.arr[i] = p;
            }
        }
        public void LoadAll2()
        {
            string sql = "SELECT * FROM HQ_Product_Inventory";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new HQ_Product[this.count];

            for (int i = 0; i < this.count; i++)
            {
                HQ_Product p = new HQ_Product();
                p.Productid = (int)dt.Rows[i]["Product_ID"];
                p.ProductType = dt.Rows[i]["Product_Type"].ToString();
           
                p.ProductName = dt.Rows[i]["Product_Name"].ToString();
               
                this.arr[i] = p;
            }
        }

    }
}
