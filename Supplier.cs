using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Supplier
    {
        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }
        private string SupplierName;

        public string SupplierName1
        {
            get { return SupplierName; }
            set { SupplierName = value; }
        }
        private string supplierp_P_Type;

        public string Supplier_P_Type
        {
            get { return supplierp_P_Type; }
            set { supplierp_P_Type = value; }
        }
        private int supplierPhone;

        public int SupplierPhone
        {
            get { return supplierPhone; }
            set { supplierPhone = value; }
        }
        private string supplierAddress;

        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }
        public bool createnewSupplier(string sname,string sprotype,int sphone,string  saddress){
            string sql1 = "SELECT * FROM Supplier WHERE Supplier_Name='" + sname + "' and Supplier_P_Type='" + sprotype + "' and Supplier_Address= '" + saddress+"'and Supplier_Phone= "+sphone;
        
            DataTable dt = DataAccess.GetDataTable(sql1);
           
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else {
                string sql = "INSERT INTO Supplier(Supplier_Name,Supplier_P_Type,Supplier_Phone,Supplier_Address) VALUES ('" + sname + "','" +sprotype +"',"+sphone+",'"+ saddress + "')";
                DataAccess.ExecuteSQL(sql);
                return true;
            }
        }
        public bool Load(int id)
        {
            string sql = "SELECT * FROM Supplier WHERE Supplier_ID=" + id;
            DataTable dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                this.SupplierId = id;
                this.SupplierName = dt.Rows[0]["Supplier_Name"].ToString();
                this.supplierp_P_Type = dt.Rows[0]["Supplier_P_Type"].ToString();
                this.SupplierPhone = Convert.ToInt32(dt.Rows[0]["Supplier_Phone"]);
                this.SupplierAddress = dt.Rows[0]["Supplier_Address"].ToString();
                return true;
            }
            else
            {
               
                return false;
            }
        }
    }
}
