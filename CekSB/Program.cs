using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekSB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            for (int i = 0; i < i+1; i++)
            {
                //MessageBox.Show("lama menunggu");
                cek();
                 Thread.Sleep(300000);

            }
            


            void cek()
            {
                if (Process.GetProcessesByName("SmartBillingClient").Length > 0)
                {
                    //do nothing
                }
                else
                {
                    //MessageBox.Show("jalankan program");
                    System.Diagnostics.Process.Start("C:\\SmartBilling_Client\\smartstarter.exe");

                }
            }
        }

        
        

        

        
    }
}
