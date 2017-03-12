using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public delegate void first_delegate();
    public static first_delegate sda;
    
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Application.Run(form1);

            Processing P1 = new Processing(form1);
            //P1.ProcessData(this);
            first_delegate del = new first_delegate(P1.ProcessData);
        }
    }
}
