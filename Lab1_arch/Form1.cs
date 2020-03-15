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

        private void btR_Click(object sender, EventArgs e)
        {
            Rectangle myrec = new Rectangle();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            double integral = myrec.Calculate(n, a, b);
            tbR.Text = Convert.ToString(integral);
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            int a = Convert.ToInt32(tbA.Text);
            int b = Convert.ToInt32(tbB.Text);
            double integral = trapeze.Calculate(n, a, b);
            tbT.Text = Convert.ToString(integral);
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aa;
        }
    }
}
