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
        public delegate void Delegate();
        public event Delegate onPressButton;

        public string GetText()
        {
            return var;
        }

        public void SetText(string to_set)
        {
            textBox1.Text = to_set;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var = button1.Text;
            onPressButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var = button2.Text;
            onPressButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var = button3.Text;
            onPressButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var = button4.Text;
            onPressButton();
        }
    }
}
