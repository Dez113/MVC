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
        delegate string GetTxt();
        public void ProcessData()
        {
            GetTxt Get = new GetTxt(Form1.GetText());
            string text = Get();
            
            // делегат который будет получать текст и передавать для выведения в лэйбл
        }
    }
}
