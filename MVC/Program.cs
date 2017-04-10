using System;
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
            //form1.onPressEnter += P1.DoWork;                                          // доступны только методы реализованные в интерфейсе
            form2.onPressButton += P1.DoWork;
            Application.Run(form2);
            
        }
    }
}
