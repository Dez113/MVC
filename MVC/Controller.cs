using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public delegate void DelegateToView_SetInfo(string string_to_set);
    public delegate string DelegateToView_GetInfo();
    class Controller : IControll
    {
        Form1 F;
        public DelegateToView_GetInfo Get;
        public DelegateToView_SetInfo Set;

        public Controller(Form1 form1)
        {
            F = form1;
        }

        public void DoWork()
        {
            string get_from_view = Get();
            string result = Model.ProcessData(get_from_view);
            Set(result);
        }
    }
}
