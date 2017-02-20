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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)                                                    //
        {                                                                                                               //
            if (e.KeyCode == Keys.Enter)                                                                                //
            {                                                                                                           //
                string get_string = textBox1.Text;                                  // получаем текст                   //
                string processed_string = Processing.ProcessData(get_string);       // обрабатываем                     // контроллер
                label1.Text = processed_string;                                     // выводим                          //
            }                                                                                                           //
        }                                                                                                               //
    }                                                                                                                   //
}                                                                                                                       //
