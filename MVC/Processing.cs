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
        private static Model instance;
        static string str = "";
        
        private Model()
        {

        }

        public static Model getInstance()
        {
            if (instance == null)
                instance = new Model();
            return instance;
        } 

        public string ProcessData(string string_to_store)
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

            
            if (Digits > 0 && Letters == 0)
            {
                return "Строка цифр";
            }
            else
            {
                return "Строка букв";
            }
            
        }

        public string ProcessData2(string string_to_store)
        {
            str += string_to_store;
            return str;
        }
    }
}
