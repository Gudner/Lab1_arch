using System;
using System.Windows.Forms;


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

            try
            {

                if((a < b) && (n > 0))
                {
                    double integral = myrec.Calculate(n, a, b);
                    //double integral = CalculateFunc(n, a, b);
                    tbR.Text = Convert.ToString(integral);
                }
                else
                {
                    throw new ArgumentException();
                }
            }                
            catch(ArgumentException ex)
            {
                tbR.Text = ($"{ex.Message}");
            }
            
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            //CalculateFunc = trapeze.Calculate;
            try
            {

                if ((a < b) && (n > 0))
                {
                    double integral = trapeze.Calculate(n, a, b);
                    //double integral = CalculateFunc(n, a, b);
                    tbT.Text = Convert.ToString(integral);
                }
                else
                {
                    throw new ArgumentException();
                }

            }
            catch (ArgumentException ex)
            {
                tbT.Text = ($"{ex.Message}");
            }

        }

        private void btnp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aa;
        }
    }
}
