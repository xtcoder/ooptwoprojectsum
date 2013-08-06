using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class BranchCollection
    {

        private Branch[] arr;
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

        public Branch this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        public void LoadAll()
        {
            string sql = "SELECT * FROM Branch";
            this.dt = DataAccess.GetDataTable(sql);
            this.count = dt.Rows.Count;
            this.arr = new Branch[this.count];

            for (int i = 0; i < this.count; i++)
            {
                Branch p = new Branch();
                p.Branchid = (int)dt.Rows[i]["Branch_ID"];
                p.BranchLocation = dt.Rows[i]["Branch_Name"].ToString();
                p.Branchname = dt.Rows[i]["Branch_Location"].ToString();

                this.arr[i] = p;
            }
        }

       

        }

    }

