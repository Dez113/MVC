using System.Windows.Forms;

namespace MVC
{
    public partial class Form1 : Form, IStringOperations
    {
        public delegate void MyDelegate();
        public event MyDelegate onPressEnter;


        public Form1()
        {
            InitializeComponent();
        }

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
