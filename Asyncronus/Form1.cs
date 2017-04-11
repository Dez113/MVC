using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Asyncronus
{
    public partial class Form1 : Form
    {
        bool isWorking = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isWorking)
            {
                Debug.WriteLine("Bworker is started");
                backgroundWorker1.RunWorkerAsync();
                isWorking = true;
            }
            else
            {
                Debug.WriteLine("Stoping Bworker");
                backgroundWorker1.CancelAsync();
                Debug.WriteLine("Bworker was stoped");
            }
            
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("backgroundWorker is working");
            Random random = new Random();
            int random_int;

            for (int i=0; i < 50000; i++)
            {
                for (int j=0; j < 50000; j++)
                {
                    random_int = random.Next(1000);
                    Debug.WriteLine(random_int);
                    //label1.Text = random_int.ToString();
                }
            }
            Debug.WriteLine("backgroundWorker is stoped");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("button2 is pressed");
        }
    }
}
