﻿using System;
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
            Form1 form1 = new Form1();
            Controller P1 = new Controller(form1);                  //создание экземпляра котроллера

            IControll IP1 = (IControll)P1;                          // явное объявление интерфейса
            
            form1.onPressEnter += IP1.DoWork;                       // доступны только методы реализованные в интерфейсе
            P1.Get += form1.GetText;
            P1.Set += form1.SetText;
            Application.Run(form1);

            
            

        }
    }
}
