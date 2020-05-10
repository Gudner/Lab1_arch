using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace Lab1_arch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btCancel.Enabled = false;
        }

        CancellationTokenSource cts;        

        private async void GetResultR()
        {
            Rectangle myrec = new Rectangle();

            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);

            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };

            pgb.Value = 0;
            bool answerReady = true;
            double integral = 0;
            try
            {
                stopWatch.Start();                
                integral = await myrec.Calculate(n, a, b, cts.Token, progress, (x) =>
                {
                    return (10 * x) - Math.Log(14 * x);
                });
                stopWatch.Stop();

            }
            catch (OperationCanceledException)
            {
                tbR.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbR.Text = "Ошибка";
                answerReady = false;
            }

            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
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
            btR.Enabled = true;
            btCancel.Enabled = false;

        }

        private async void GetResultT()
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            pgb.Value = 0;
            bool answerReady = true;

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };

            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double integral = 0;

            try
            {
                stopWatch.Start();
                integral = await trapeze.Calculate(n, a, b, cts.Token, progress, (x) =>
                {
                    return (10 * x) - Math.Log(14 * x);
                });
                stopWatch.Stop();

            }
            catch (OperationCanceledException)
            {
                tbT.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbT.Text = "Ошибка";
                answerReady = false;
            }

            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
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
            btT.Enabled = true;
            btCancel.Enabled = false;   

        }

        private async void GetResultRP()
        {
            Rectangle myrec = new Rectangle();

            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);

            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };

            pgb.Value = 0;
            bool answerReady = true;
            double integral = 0;
            try
            {
                stopWatch.Start();
                integral = await myrec.PCalculate(n, a, b, cts.Token, progress, (x) =>
                {
                    return (10 * x) - Math.Log(14 * x);
                });
                stopWatch.Stop();

            }
            catch (OperationCanceledException)
            {
                tbRP.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbRP.Text = "Ошибка";
                answerReady = false;
            }

            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
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
            btRP.Enabled = true;
            btCancel.Enabled = false;

        }

        private async void GetResultTP()
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            pgb.Value = 0;
            bool answerReady = true;

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pgb.Value = e; };

            cts = new CancellationTokenSource();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double integral = 0;

            try
            {
                stopWatch.Start();
                integral = await trapeze.PCalculate(n, a, b, cts.Token, progress, (x) =>
                {
                    return (10 * x) - Math.Log(14 * x);
                });
                stopWatch.Stop();

            }
            catch (OperationCanceledException)
            {
                tbTP.Text = "Отмена";
                answerReady = false;
            }
            catch
            {
                tbTP.Text = "Ошибка";
                answerReady = false;
            }

            if (answerReady)
            {
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
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
            btTP.Enabled = true;
            btCancel.Enabled = false;

        }

        private void btR_Click(object sender, EventArgs e)
        {
            btR.Enabled = false;
            btCancel.Enabled = true;
            GetResultR();            
        }

        private void btT_Click(object sender, EventArgs e)
        {
            btT.Enabled = false;
            btCancel.Enabled = true;
            GetResultT();

        }

        private void btnp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aa;
        }

        private void btRP_Click(object sender, EventArgs e)
        {
            btRP.Enabled = false;
            btCancel.Enabled = true;
            GetResultRP();

        }

        private void btTP_Click(object sender, EventArgs e)
        {
            btTP.Enabled = false;
            btCancel.Enabled = true;
            GetResultTP();
        }


        private void btCancel_Click_1(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
    }
}
