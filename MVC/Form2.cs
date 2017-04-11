using System;
using System.Windows.Forms;

namespace MVC
{
    public partial class Form2 : Form, IStringOperations
    {
        string temp = "";
        public delegate void Delegate();
        public event Delegate onPressButton;

        public Form2()
        {
            InitializeComponent();
        }

        public string GetText()
        {
            return temp;
        }

        public void SetText(string to_set)
        {
            textBox1.Text += to_set;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temp = button1.Text;
            onPressButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = button2.Text;
            onPressButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = button3.Text;
            onPressButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp = button4.Text;
            onPressButton();
        }

    }
}
