using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Processing                                            // модель (логика и обработка)
    {
        public static string ProcessData(string get_string)
        {
            return get_string.ToUpper();
        }
    }
}
