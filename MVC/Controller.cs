using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Controller
    {
        delegate string DelegateToModel(string string_to_process);                      // объявление типов делегатов
        delegate string DelegateToView_GetInfo();
        delegate void DelegateToView_SetInfo(string string_to_set);
        Form1 F;
        public Controller(Form1 form1)
        {
            F = form1;
            //F.onPressEnter += DoWork;
        }

        public void DoWork()
        {
            DelegateToView_GetInfo Get = new DelegateToView_GetInfo(F.GetText);          // создание делегатов
            DelegateToModel Process = new DelegateToModel(Model.ProcessData);
            DelegateToView_SetInfo Set = new DelegateToView_SetInfo(F.SetText);

            string get_from_view = Get();
            string result = Process(get_from_view);
            Set(result);
            
        }
    }
}
