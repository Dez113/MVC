using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public delegate void DelegateToView_SetInfo(string string_to_set);
    public delegate string DelegateToView_GetInfo();
    class Controller// : IControll
    {
        IToForm f;
         
        public DelegateToView_GetInfo Get;
        public DelegateToView_SetInfo Set;

        public Controller(IToForm form1)
        {
            f = form1;
        }

        public void DoWork()
        {
            string get_from_view = f.GetText();
            string result = Model.ProcessData(get_from_view);
            f.SetText(result);
        }
    }
}
