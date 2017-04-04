using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface IForm
    {
        string GetText();
        void SetText(string to_set);
    }

    //interface IControll
    //{
    //    void DoWork();
    //}
}
