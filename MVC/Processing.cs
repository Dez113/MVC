using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    class Processing                                            // модель (логика и обработка)
    {
        Form1 F1;

        public Processing(Form1 F)
        {
            F1 = F;
            //ProcessData();
        }
        //delegate string GetTxt();
        public void ProcessData()
        {
            //GetTxt Get = new GetTxt(Form1 F1);
            
            string text = F1.GetText();

            F1.SetText(text);
            
            // делегат который будет получать текст и передавать для выведения в лэйбл
        }

    }
}
