using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    


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
            Form2 form2 = new Form2();
            Controller P1 = new Controller((IStringOperations) form2);                  //создание экземпляра котроллера

            //form1.onPressEnter += P1.DoWork;                       // доступны только методы реализованные в интерфейсе
            form2.onPressButton += P1.DoWork;
            //P1.Get = form1.GetText;
            //P1.Set = form1.SetText;


            Application.Run(form2);

            
            

        }
    }
}
