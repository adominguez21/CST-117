using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        String OrderDetails = "{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        } 

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            chkPerfume.Checked = false;
            chkCologne.Checked = false;
            chkPerfSet.Checked = false;
            chkColSet.Checked = false;

            rB5.Checked = false;
            rB10.Checked = false;
            rB15.Checked = false;
            rB20.Checked = false;

            lstBrand.SelectedItems.Clear();
            cmbOrderMade.Text = "Select Order";
            cmbType.Text = "Select Type";

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
        txtCustomerID.Clear();
        txtName.Clear();
        txtSurname.Clear();
        chkPerfume.Checked = false;
        chkCologne.Checked = false;
        chkPerfSet.Checked = false;
        chkColSet.Checked = false;

        rB5.Checked = false;
        rB10.Checked = false;
        rB15.Checked = false;
        rB20.Checked = false;

        lstBrand.SelectedItems.Clear();
        lstOutput.Items.Clear();
        lstOutput.Items.Add(String.Format(OrderDetails, "Customer ID", "Firstname", "Surname", "Order Made", "Method of Payment", "Date of Order", "Price"));
            cmbOrderMade.Text = "Select Order";
        cmbType.Text = "Select Type";

    }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            String ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price;
            double USA_Price = 45.65;


            ID = txtCustomerID.Text;
            Firstname = txtName.Text;
            Surname = txtSurname.Text;
            SelectOrder = cmbOrderMade.Text;
            SelectType = cmbType.Text;
            SelectDate = dateTimePicker1.Text;

            if (lstBrand.Text == "")
            {
                MessageBox.Show("You must select a brand", "Brands", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((chkPerfume.Checked == false) && (chkCologne.Checked == false) && (chkPerfSet.Checked == false) && (chkColSet.Checked == false))
            {
                MessageBox.Show("You must select an item", "Items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((rB5.Checked == false) && (rB10.Checked == false) && (rB15.Checked == false) && (rB20.Checked == false))
            {
                MessageBox.Show("You must select quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //---------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Calvin Klein" && chkPerfume.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkPerfume.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkPerfume.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkPerfume.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Calvin Klein" && chkCologne.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkCologne.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkCologne.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkCologne.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Calvin Klein" && chkPerfSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkPerfSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkPerfSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkPerfSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Calvin Klein" && chkColSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkColSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkColSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Calvin Klein" && chkColSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //Versace Next
            //---------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Versace" && chkPerfume.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkPerfume.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkPerfume.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkPerfume.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Versace" && chkCologne.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkCologne.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkCologne.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkCologne.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Versace" && chkPerfSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkPerfSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkPerfSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkPerfSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Versace" && chkColSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkColSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkColSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Versace" && chkColSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            // Kenneth Cole next 
            //---------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Kenneth Cole" && chkPerfume.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkPerfume.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkPerfume.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkPerfume.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Kenneth Cole" && chkCologne.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkCologne.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkCologne.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkCologne.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Kenneth Cole" && chkPerfSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkPerfSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkPerfSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkPerfSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Kenneth Cole" && chkColSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkColSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkColSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Kenneth Cole" && chkColSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //Ariana Grande next
            //---------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Ariana Grande" && chkPerfume.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkPerfume.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkPerfume.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkPerfume.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Ariana Grande" && chkCologne.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkCologne.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkCologne.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkCologne.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Ariana Grande" && chkPerfSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkPerfSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkPerfSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkPerfSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Ariana Grande" && chkColSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkColSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkColSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Ariana Grande" && chkColSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //Disney next
            //---------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Disney" && chkPerfume.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkPerfume.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkPerfume.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkPerfume.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Disney" && chkCologne.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkCologne.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkCologne.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkCologne.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Disney" && chkPerfSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkPerfSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkPerfSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkPerfSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Disney" && chkColSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkColSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkColSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Disney" && chkColSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //Paco Rabanne next
            //---------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Paco Rabanne" && chkPerfume.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkPerfume.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkPerfume.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkPerfume.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Paco Rabanne" && chkCologne.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkCologne.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkCologne.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkCologne.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Paco Rabanne" && chkPerfSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkPerfSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkPerfSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkPerfSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            //----------------------------------------------------------------------------------------------------------------------------
            if (lstBrand.Text == "Paco Rabanne" && chkColSet.Checked == true && rB5.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 5));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkColSet.Checked == true && rB10.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 10));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkColSet.Checked == true && rB15.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 15));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }
            else if (lstBrand.Text == "Paco Rabanne" && chkColSet.Checked == true && rB20.Checked == true)
            {
                Price = String.Format("{0:C}", (USA_Price * 20));
                lstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Price));
            }



        }
    private void Form1_Load(object sender, EventArgs e)
        {
            lstOutput.Items.Add(String.Format(OrderDetails,"Customer ID","Firstname","Surname","Order Made","Method of Payment","Date of Order", "Price"));

            cmbOrderMade.Items.Add("Select Order");
            cmbOrderMade.Items.Add("Account");
            cmbOrderMade.Items.Add("Telephone");
            cmbOrderMade.Items.Add("Instore Order");
            cmbOrderMade.Items.Add("Online Order");

            cmbType.Items.Add("Select Type");
            cmbType.Items.Add("Cash");
            cmbType.Items.Add("Master Card");
            cmbType.Items.Add("Visa Card");
            cmbType.Items.Add("Direct Debit");

            lstBrand.Items.Add("Calvin Klein");
            lstBrand.Items.Add("Versace");
            lstBrand.Items.Add("Kenneth Cole");
            lstBrand.Items.Add("Ariana Grande");
            lstBrand.Items.Add("Disney");
            lstBrand.Items.Add("Paco Rabanne");
           
            chkPerfume.Checked = false;
            chkCologne.Checked = false;
            chkPerfSet.Checked = false;
            chkColSet.Checked = false;

            rB5.Checked = false;
            rB10.Checked = false;
            rB15.Checked = false;
            rB20.Checked = false;

        }
    }
        
    

        
    }
