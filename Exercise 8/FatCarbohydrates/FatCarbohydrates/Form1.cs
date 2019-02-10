using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatCarbohydrates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            double fat;
            double value;
            fat = double.Parse(txtFat.Text);
            // converts string to double 

            value = FatCalories(fat);

            // calls method with fat as arguments 
            MessageBox.Show("The number of calories from" + "fat are:" + value);
        }
           private double FatCalories(double fat)
        {
            return (fat * 9);
            //calculates calories from fat
        }

        private void btnCarbs_Click(object sender, EventArgs e)
        {
            double carbs;
            double cal;
            carbs = double.Parse(txtCarbs.Text);
            //converts string to double 
            cal = CarbCalories(carbs);
            //calls method with carbohydrates as arguments
            MessageBox.Show("The number of calories from" + "Carbohydrates are:" + cal);

        }
        private double CarbCalories(double carbs)
        {
            //calculates calories from carbohydrates
            return (carbs * 4);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
