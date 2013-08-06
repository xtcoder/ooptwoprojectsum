using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class SupplierCollection
    {
        private Supplier[] arr;
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

        public Supplier this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        public void LoadAll()
        {
            string sql = "SELECT * FROM Supplier";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new Supplier[this.count];

            for (int i = 0; i < this.count; i++)
            {
                Supplier p = new Supplier();
                p.SupplierId = (int)dt.Rows[i]["Supplier_ID"];
                p.SupplierName1 = dt.Rows[i]["Supplier_Name"].ToString();
                p.Supplier_P_Type = dt.Rows[i]["Supplier_P_Type"].ToString();
                p.SupplierAddress = dt.Rows[i]["Supplier_Address"].ToString();

                p.SupplierPhone = (int)dt.Rows[i]["Supplier_Phone"];
                this.arr[i] = p;
            }
        }

        
    }
}