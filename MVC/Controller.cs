﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public delegate void DelegateToView_SetInfo(string string_to_set);
    public delegate string DelegateToView_GetInfo();
    class Controller
    {
        IStringOperations F;
        //public DelegateToView_GetInfo Get;
        //public DelegateToView_SetInfo Set;

        public Controller(IStringOperations form)
        {
            F = form;
        }

        public void DoWork()
        {
            string get_from_view = F.GetText();
            string result = Model.getInstance().ProcessData2(get_from_view);
            F.SetText(result);
        }
    }
}
