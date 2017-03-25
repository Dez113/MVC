using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public delegate void first_delegate();
    //public static first_delegate sda;
    
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
            Controller P1 = new Controller(form1);
            form1.onPressEnter += P1.DoWork;
            Application.Run(form1);

            
        }
    }
}
