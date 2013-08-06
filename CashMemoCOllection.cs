
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace WindowsFormsApplication2
{
    class CashMemoCOllection
    {

        private CashMemo[] arr;
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

        public CashMemo this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        public void LoadAll()
        {
            string sql = "SELECT * FROM CashMemo";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new CashMemo[this.count];

            for (int i = 0; i < this.count; i++)
            {
                CashMemo p = new CashMemo();
                p.CashMemoNO = (int)dt.Rows[i]["Cashmemo_NO"];
                p.CustomerPhone = (int)dt.Rows[i]["Customer_phone"];
                p.CustomerName = dt.Rows[i]["Customer_name"].ToString();
                p.Date = dt.Rows[i]["Date"].ToString();             
                this.arr[i] = p;
            }
        }

    }
}
