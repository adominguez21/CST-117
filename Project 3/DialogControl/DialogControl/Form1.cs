using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s1, s2; 
        WriteLine ("n\t ====== String Manipulation =====");
        WriteLine ();
        WriteLine("\t Enter the 1st string : " );
        WriteLine();
        Write("\t ");
        s1= ReadLine();

        WriteLine(); // From new line
        WriteLine("\t Enter the 2nd string : " );
        WriteLine();
        Write("\t ");
        s2= ReadLine();

        WriteLine("n\t ======String Operation =====");
        WriteLine("n\n\n\n\t ====== Convert ======");
        WriteLine("\t Enter the 1st string : " );
        WriteLine();
        
        WriteLine(" \n\t The string (0) in lower case: (1)", s1, s1.ToLower(()));
        WriteLine();

        WriteLine(" \n\t The string (0) in upper case: (1)", s1, s1.ToLower(()));
        WriteLine();

        WriteLine(" \n\t The string (0) in lower case: (1)", s2, s2.ToLower(()));
        WriteLine();

        WriteLine(" \n\t The string (0) in upper case: (1)", s2, s2.ToLower(()));
        WriteLine();


        WriteLine("\n\t ======= Thank You ======");
        ReadLine(); // To hold the control screen 

        OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text = ofd.SafeFileName;

                
            }
        }
    }
}
