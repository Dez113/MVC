using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Controller
    {
        Form1 F;
        public Controller(Form1 form1)
        {
            F = form1;
            F.onPressEnter += DoWork;
        }

        public void DoWork()
        {
            string to_return = Model.ProcessData(F.GetText());
            F.SetText(to_return);
        }
    }
}
