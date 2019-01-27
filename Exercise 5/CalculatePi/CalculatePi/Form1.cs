using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number = 0;
            double pi;
            int i = 1;

            do
            {
                if ((i / 2) % 2 == 0)
                {
                    number += (double)(1) / i;
                }
                else
                {
                    number -= (double)(1) / i;
                }
                pi = 4 * number;
                i += 2;
            }
            while (Math.Round(pi, 5) != 3.14159);

            
        }

        private void txtAns_TextChanged(object sender, EventArgs e)
        {
            
            Console.WriteLine("Approximate Value of pi after # of terms is:");
            Console.ReadKey();
        }
    }
}
