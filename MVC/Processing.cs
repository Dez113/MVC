using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    class Model                                            // модель (логика и обработка)
    {
        static string str;
        
        public static string ProcessData(string string_to_store)
        {
            int Digits = 0;
            int Letters = 0;
            str = string_to_store;
            
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    Digits++;
                }
                else
                {
                    Letters++;
                }
            }

            if (Digits > 0 && Letters > 0)
            {
                return "Строка из смешанных символов";
            }

            else
            {
                if (Digits > 0 && Letters == 0)
                {
                    return "Строка цифр";
                }
                else
                {
                    return "Строка букв";
                }
            }
        }
    }
}
