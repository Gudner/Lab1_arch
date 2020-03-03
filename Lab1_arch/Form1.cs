using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double integral = myrec.R(n);
            tbR.Text = Convert.ToString(integral);
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Trapeze trapeze = new Trapeze();
            int n = Convert.ToInt32(tbN.Text);
            double integral = trapeze.T(n);
            tbT.Text = Convert.ToString(integral);
        }
    }
}
