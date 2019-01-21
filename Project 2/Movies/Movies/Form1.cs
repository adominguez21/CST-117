using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnSelected_Click(object sender, EventArgs e)
        {
            string movies = "";
            if(checkComedy.Checked)
            {
                movies = movies + checkComedy.Text + "\r\n";
            }
            if(checkAction.Checked)
            {
                movies = movies + checkAction.Text + "\r\n";
            }
                if(checkHorror.Checked)
            {
                movies = movies + checkHorror.Text + "\r\n";
            }
                if(checkSF.Checked)
            {
                movies = movies + checkSF.Text + "\r\n";
            }
                MessageBox.Show(movies);
            }

        private void BtnFavorite_Click(object sender, EventArgs e)
        {
            RadioButton selectedButton = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            string ChosenMovie = "";
           
            if(radioComedy.Checked)
            {
                ChosenMovie = radioComedy.Text;
            }
              else if(radioAction.Checked)
            {
                ChosenMovie = radioAction.Text;
            }
               else if(radioHorror.Checked)
            {
                ChosenMovie = radioHorror.Text;
            }
              else if(radioSF.Checked)
            {
                ChosenMovie = radioSF.Text;
            }
            MessageBox.Show("Your Favorite Movie is:"); 



        }
    }
    }
