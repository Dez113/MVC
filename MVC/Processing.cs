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
            str = string_to_store;
            return str;
        }

    }
}
