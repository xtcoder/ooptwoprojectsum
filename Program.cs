using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new SalesForm());
            //Application.Run(new BranchForm());
            //Application.Run(new Supplier_ADD());
           //Application.Run(new HQ_Product1());
           //Application.Run(new Purchase_Product());
            //Application.Run(new Branch_Inventory());
        }
    }
}
