using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Processing                                            // модель (логика и обработка)
    {
        delegate string GetText();
        public void ProcessData()
        {
            GetText Get = new GetText(Form1.GetText());
            
            // делегат который будет получать текст и передавать для выведения в лэйбл
        }
    }
}
