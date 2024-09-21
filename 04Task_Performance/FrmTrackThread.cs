using System;
using System.Threading;
using System.Windows.Forms;

namespace _04Task_Performance
{
    public partial class FrmTrackThread : Form
    {
        Thread threadA, threadB, threadC, threadD;

        public FrmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            threadA = new Thread(new ThreadStart(MyThreadClass.Thread1)) { Name = "Thread A" };
            threadB = new Thread(new ThreadStart(MyThreadClass.Thread2)) { Name = "Thread B" };
            threadC = new Thread(new ThreadStart(MyThreadClass.Thread1)) { Name = "Thread C" };
            threadD = new Thread(new ThreadStart(MyThreadClass.Thread2)) { Name = "Thread D" };

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();


            lblThread.Text = "-End Of Thread-";
        }
    }
}