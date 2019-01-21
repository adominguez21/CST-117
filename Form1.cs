using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class TimeCalculator : Form
    {
        // take five variables of double type 
        // take a variable works of int type 
        double seconds, minutes, hours, days, totalsec;

        private void lbldisplay_Click(object sender, EventArgs e)
        {

        }

        private void txtseconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtworks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        int works;

        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //accept the values from user 
            //assigned to the variables
            seconds = Convert.ToDouble
                (txtseconds.Text);
            works = Convert.ToInt32(txtworks.Text);
            //calculate total seconds 
            totalsec = seconds* works;
            // check whether seconds is greater than
            // or equal to 60
            if(totalsec>=60 && totalsec<3600)
            {
                //convert seconds into minutes
                minutes = totalsec/60;
                //show the message in the label
                lbldisplay.Visible = true;
                lbldisplay.Text = "Number of Minutes";
                //show the converted value in textbox
                txtdisplay.Text = Convert.ToString(minutes);
            }
            // check for seconds greater than
            // or equal to 3600
            else if(totalsec>=3600 && totalsec<8640)
            {
                //convert the seconds into hours 
                //display the hours in textbox
                hours= totalsec* 1/3600;
                lbldisplay.Visible = true;
                lbldisplay.Text = Convert.ToString(hours);
         
            }
            //check for seconds greater than
            //or equal to 86400
            else if(totalsec>=86400)
            {
                //convert the seconds into days
                //display the days in textbox
                days= totalsec* 1/86400;
                lbldisplay.Visible = true;
                lbldisplay.Text = "Number of Days";
                txtdisplay.Text = Convert.ToString(days);

            }
            }
        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all the textboxes
            txtworks.Text = "";
            txtseconds.Text = "";
            txtdisplay.Text = "";

        }
    }
}
