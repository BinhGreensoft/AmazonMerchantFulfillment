using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonMerchantFulfillment
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


            // for test only
            //
            AmazonMerchantFulfillment.Business.ParaBs bs = new Business.ParaBs();
            AmazonMerchantFulfillment.DataDefinition.Para ds = null;
            bs.GetData(ref ds);
            //
            // end test

            Application.Run(new MainUI());
        }
    }
}
