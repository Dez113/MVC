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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)                //  метод который вызывает метод контроллера                                           //
        {                                                                                                               //
            if (e.KeyCode == Keys.Enter)                                                                                //
            {
                Processing.ProcessData();
            }                                                                                                           //
        }

        public string GetText()
        {
            return textBox1.Text;
        }

        public void SetLabelText(string string_to_set)
        {
            label1.Text = string_to_set;
        }
    }                                                                                                                   //
}                                                                                                                       //
