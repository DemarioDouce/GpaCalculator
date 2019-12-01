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
    public partial class RandomGpaCalculationForm : Form
    {
        GpaCalculator GpaCalculator;

        public RandomGpaCalculationForm(GpaCalculator parent)
        {
            InitializeComponent();
            GpaCalculator = parent;
        }
    }
}
