using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace Lab1_arch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static Func<int, int, int, double> CalculateFunc;
        private void btR_Click(object sender, EventArgs e)
        {
            Rectangle myrec = new Rectangle();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            //CalculateFunc = myrec.Calculate;
            //double integral = CalculateFunc(n, a, b);
            //var tn = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double integral = myrec.Calculate(n, a, b, (x) =>
            {
                return (10 * x) - Math.Log(14 * x);
            });
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //var tk = DateTime.Now;
            if (integral == 0.0)
            {
                tbR.Text = $"{myrec.ErrorInformation}";
            }
            else
            {
                tbR.Text = Convert.ToString(integral);
                tbTime.Text = Convert.ToString("Время выполнения " + elapsedTime);
            }
      
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            //CalculateFunc = trapeze.Calculate;
            //double integral = CalculateFunc(n, a, b);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //var tn = DateTime.Now;
            double integral = trapeze.Calculate(n, a, b, (x) =>
            {
                return (10 * x) - Math.Log(14 * x);
            });
            //var tk = DateTime.Now;
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            if (integral == 0.0)
            {
                tbT.Text = $"{trapeze.ErrorInformation}";
            }
            else
            {
                tbT.Text = Convert.ToString(integral);
                tbTime.Text = Convert.ToString("Время выполнения " + elapsedTime);
            }            

        }

        private void btnp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aa;
        }

        private void btRP_Click(object sender, EventArgs e)
        {
            Rectangle myrec = new Rectangle();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            //CalculateFunc = myrec.Calculate;
            //double integral = CalculateFunc(n, a, b);
            //var tn = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double integral = myrec.PCalculate(n, a, b, (x) =>
            {
                return (10 * x) - Math.Log(14 * x);
            });
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            // double integral = myrec.Result;

            //var tk = DateTime.Now;
            if (integral == 0.0)
            {
                tbRP.Text = $"{myrec.ErrorInformation}";
            }
            else
            {
                tbRP.Text = Convert.ToString(integral);
                tbTimeP.Text = Convert.ToString("Время параллельного выполнения " + elapsedTime);
            }

        }

        private void btTP_Click(object sender, EventArgs e)
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            //CalculateFunc = trapeze.Calculate;
            //double integral = CalculateFunc(n, a, b);
            //var tn = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double integral = trapeze.PCalculate(n, a, b, (x) =>
            {
                return (10 * x) - Math.Log(14 * x);
            });
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //var tk = DateTime.Now;
            if (integral == 0.0)
            {
                tbTP.Text = $"{trapeze.ErrorInformation}";
            }
            else
            {
                tbTP.Text = Convert.ToString(integral);
                tbTimeP.Text = Convert.ToString("Время параллельного выполнения " + elapsedTime);
            }
        }

    }
}
