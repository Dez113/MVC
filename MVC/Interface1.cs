﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface IToForm
    {
        string GetText();
        void SetText(string to_set);
    }

    interface IControll
    {
        void DoWork();
    }
}