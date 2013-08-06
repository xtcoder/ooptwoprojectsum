

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class CashMemo
    {
        private int cashMemoNO;

        public int CashMemoNO
        {
            get { return cashMemoNO; }
            set { cashMemoNO = value; }
        }
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private int customerPhone;

        public int CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public void newentry(){
            
            string sql = "INSERT INTO CashMemo(Customer_name,Customer_phone,Date) VALUES ('" + this.CustomerName + "'," + this.CustomerPhone +",'"+this.Date +"')";
            DataAccess.ExecuteSQL(sql);
           // string sql1 = "SELECT * FROM CashMemo WHERE ( Customer_name='" + this.CustomerName + "' and Customer_phone= " + this.CustomerPhone + " and Date= '" + this.Date + "')";


            //DataTable dt = DataAccess.GetDataTable(sql1);
            //this.CashMemoNO = Convert.ToInt32(dt.Rows[0]["Cashmemo_NO"]);
            //Have to be Scope IDentity SQL
           

        }
        public int returnid(){

            string sql1 = "SELECT * FROM CashMemo WHERE ( Customer_name='" + this.CustomerName + "' and Customer_phone= " + this.CustomerPhone + " and Date= '" + this.Date + "')";


            DataTable dt = DataAccess.GetDataTable(sql1);
            this.CashMemoNO = Convert.ToInt32(dt.Rows[0]["Cashmemo_NO"]);
            int a = this.CashMemoNO;
            return a;
        
        }
    }
}
