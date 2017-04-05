using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class Form2 : Form, IStringOperations
    {
        public Form2()
        {
            InitializeComponent();
        }

        string var = "";



        public string GetText()
        {
            return var;
        }

        public void SetText(string to_set)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var = button1.Name;

        }
    }
}
