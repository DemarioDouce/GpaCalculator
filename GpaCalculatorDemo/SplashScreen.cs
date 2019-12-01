using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpaCalculatorDemo
{
    public partial class SplashScreen : Form
    {
        int counter = 20;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                this.Close();
            }
        }
    }
}
