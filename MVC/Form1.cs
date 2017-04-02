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

    


    public partial class Form1 : Form, IToForm
    {
        public Form1()
        {
            InitializeComponent();
        }



        
        public delegate void MyDelegate();
        public event MyDelegate onPressEnter;


        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)                                                    
        {                                                                                                               
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")                                                                                
            {
                onPressEnter();
            }

            else
            {
                label1.Text = "";
            }                                                                                                           
        }

        public string GetText()
        {
            return textBox1.Text;
        }

        public void SetText(string toSet)
        {
            label1.Text = toSet;
        }
    }                                                                                                                   
}                                                                                                                       
