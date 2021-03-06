﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Asyncronus
{
    public partial class Form1 : Form
    {
        
        int random_int;


        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                Debug.WriteLine("Bworker is started");
                backgroundWorker1.RunWorkerAsync();
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                Debug.WriteLine("Stoping Bworker");
                backgroundWorker1.CancelAsync();
                //backgroundWorker1.Dispose();
                timer1.Stop();
                progressBar1.Value = 0;
                Debug.WriteLine("Bworker was stoped");
            }
            
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("backgroundWorker is working");
            Random random = new Random();
            

            for (int i=0; i < 50000; i++)
            {
                if ((i % 500) == 0)
                    //Debug.WriteLine(i);
                    backgroundWorker1.ReportProgress(1);
                for (int j=0; j < 50000; j++)
                {
                    if (backgroundWorker1.CancellationPending)
                        return;
                    random_int = random.Next(1000);
                    
                    //Debug.WriteLine(random_int);
                    //label1.Text = random_int.ToString();
                }
            }
            Debug.WriteLine("backgroundWorker is stoped");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = random_int.ToString();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value += 1;                                //exception
            progressBar1.Increment(1);                            //виснет
            //progressBar1.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done!");
            progressBar1.Value = 0;

        }
    }
}
