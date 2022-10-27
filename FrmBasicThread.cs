using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juanima_BasicThread
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreadClass threadClass = new MyThreadClass();

            Console.WriteLine("-Before starting thread-");
            ThreadStart delObjThread = new ThreadStart(threadClass.Thread1);

            Thread ThreadA = new Thread(delObjThread);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delObjThread);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of thread-");

            label1.Text = "-End of thread-";
        }
    }
 }
