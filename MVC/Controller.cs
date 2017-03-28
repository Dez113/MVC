using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    
    public delegate void DelegateToView_SetInfo(string string_to_set);
    public delegate string DelegateToView_GetInfo();


    //DelegateToView_GetInfo Get;// = new DelegateToView_GetInfo();          // создание делегатов
    //DelegateToView_SetInfo Set = new DelegateToView_SetInfo(F.SetText);

    class Controller
    {
        Form1 F;
        DelegateToView_GetInfo Get;
        DelegateToView_SetInfo Set;

        public Controller(Form1 form1)
        {
            F = form1;
        }

        

        public void DoWork()
        {
            Get += F.GetText;
            Set += F.SetText;
            string get_from_view = Get();
            string result = Model.ProcessData(get_from_view);
            Set(result);
            
        }
    }
}
