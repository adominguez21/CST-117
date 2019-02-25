namespace Inventory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxQuant = new System.Windows.Forms.GroupBox();
            this.rB20 = new System.Windows.Forms.RadioButton();
            this.rB15 = new System.Windows.Forms.RadioButton();
            this.rB10 = new System.Windows.Forms.RadioButton();
            this.rB5 = new System.Windows.Forms.RadioButton();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.chkColSet = new System.Windows.Forms.CheckBox();
            this.chkPerfSet = new System.Windows.Forms.CheckBox();
            this.chkCologne = new System.Windows.Forms.CheckBox();
            this.chkPerfume = new System.Windows.Forms.CheckBox();
            this.groupBoxBrands = new System.Windows.Forms.GroupBox();
            this.lstBrand = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbOrderMade = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblOrdMade = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblPay = new System.Windows.Forms.Label();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxQuant.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.groupBoxBrands.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.groupBoxQuant);
            this.panel1.Controls.Add(this.groupBoxItems);
            this.panel1.Controls.Add(this.groupBoxBrands);
            this.panel1.Location = new System.Drawing.Point(162, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 291);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxQuant
            // 
            this.groupBoxQuant.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxQuant.Controls.Add(this.rB20);
            this.groupBoxQuant.Controls.Add(this.rB15);
            this.groupBoxQuant.Controls.Add(this.rB10);
            this.groupBoxQuant.Controls.Add(this.rB5);
            this.groupBoxQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuant.Location = new System.Drawing.Point(606, 16);
            this.groupBoxQuant.Name = "groupBoxQuant";
            this.groupBoxQuant.Size = new System.Drawing.Size(200, 242);
            this.groupBoxQuant.TabIndex = 1;
            this.groupBoxQuant.TabStop = false;
            this.groupBoxQuant.Text = "Quantity";
            // 
            // rB20
            // 
            this.rB20.AutoSize = true;
            this.rB20.Location = new System.Drawing.Point(23, 201);
            this.rB20.Name = "rB20";
            this.rB20.Size = new System.Drawing.Size(47, 22);
            this.rB20.TabIndex = 0;
            this.rB20.TabStop = true;
            this.rB20.Text = "20";
            this.rB20.UseVisualStyleBackColor = true;
            // 
            // rB15
            // 
            this.rB15.AutoSize = true;
            this.rB15.Location = new System.Drawing.Point(23, 145);
            this.rB15.Name = "rB15";
            this.rB15.Size = new System.Drawing.Size(47, 22);
            this.rB15.TabIndex = 0;
            this.rB15.TabStop = true;
            this.rB15.Text = "15";
            this.rB15.UseVisualStyleBackColor = true;
            // 
            // rB10
            // 
            this.rB10.AutoSize = true;
            this.rB10.Location = new System.Drawing.Point(23, 89);
            this.rB10.Name = "rB10";
            this.rB10.Size = new System.Drawing.Size(47, 22);
            this.rB10.TabIndex = 0;
            this.rB10.TabStop = true;
            this.rB10.Text = "10";
            this.rB10.UseVisualStyleBackColor = true;
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(23, 36);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(38, 22);
            this.rB5.TabIndex = 0;
            this.rB5.TabStop = true;
            this.rB5.Text = "5";
            this.rB5.UseVisualStyleBackColor = true;
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxItems.Controls.Add(this.chkColSet);
            this.groupBoxItems.Controls.Add(this.chkPerfSet);
            this.groupBoxItems.Controls.Add(this.chkCologne);
            this.groupBoxItems.Controls.Add(this.chkPerfume);
            this.groupBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItems.Location = new System.Drawing.Point(307, 16);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(200, 242);
            this.groupBoxItems.TabIndex = 1;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // chkColSet
            // 
            this.chkColSet.AutoSize = true;
            this.chkColSet.Location = new System.Drawing.Point(17, 201);
            this.chkColSet.Name = "chkColSet";
            this.chkColSet.Size = new System.Drawing.Size(155, 22);
            this.chkColSet.TabIndex = 0;
            this.chkColSet.Text = "Cologne Gift Set";
            this.chkColSet.UseVisualStyleBackColor = true;
            // 
            // chkPerfSet
            // 
            this.chkPerfSet.AutoSize = true;
            this.chkPerfSet.Location = new System.Drawing.Point(18, 145);
            this.chkPerfSet.Name = "chkPerfSet";
            this.chkPerfSet.Size = new System.Drawing.Size(155, 22);
            this.chkPerfSet.TabIndex = 0;
            this.chkPerfSet.Text = "Perfume Gift Set";
            this.chkPerfSet.UseVisualStyleBackColor = true;
            // 
            // chkCologne
            // 
            this.chkCologne.AutoSize = true;
            this.chkCologne.Location = new System.Drawing.Point(17, 89);
            this.chkCologne.Name = "chkCologne";
            this.chkCologne.Size = new System.Drawing.Size(93, 22);
            this.chkCologne.TabIndex = 0;
            this.chkCologne.Text = "Cologne";
            this.chkCologne.UseVisualStyleBackColor = true;
            // 
            // chkPerfume
            // 
            this.chkPerfume.AutoSize = true;
            this.chkPerfume.Location = new System.Drawing.Point(18, 36);
            this.chkPerfume.Name = "chkPerfume";
            this.chkPerfume.Size = new System.Drawing.Size(93, 22);
            this.chkPerfume.TabIndex = 0;
            this.chkPerfume.Text = "Perfume";
            this.chkPerfume.UseVisualStyleBackColor = true;
            // 
            // groupBoxBrands
            // 
            this.groupBoxBrands.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBrands.Controls.Add(this.lstBrand);
            this.groupBoxBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBrands.Location = new System.Drawing.Point(14, 16);
            this.groupBoxBrands.Name = "groupBoxBrands";
            this.groupBoxBrands.Size = new System.Drawing.Size(200, 242);
            this.groupBoxBrands.TabIndex = 1;
            this.groupBoxBrands.TabStop = false;
            this.groupBoxBrands.Text = "Brands ";
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.ItemHeight = 18;
            this.lstBrand.Location = new System.Drawing.Point(4, 21);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(190, 202);
            this.lstBrand.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 76);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.lstOutput);
            this.panel3.Location = new System.Drawing.Point(12, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1471, 138);
            this.panel3.TabIndex = 1;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(20, 21);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(1434, 100);
            this.lstOutput.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1204, 602);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSurname.Location = new System.Drawing.Point(634, 12);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(195, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // cmbOrderMade
            // 
            this.cmbOrderMade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbOrderMade.ForeColor = System.Drawing.Color.Blue;
            this.cmbOrderMade.FormattingEnabled = true;
            this.cmbOrderMade.Location = new System.Drawing.Point(634, 66);
            this.cmbOrderMade.Name = "cmbOrderMade";
            this.cmbOrderMade.Size = new System.Drawing.Size(195, 24);
            this.cmbOrderMade.TabIndex = 4;
            this.cmbOrderMade.Text = "Select Order";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCustomerID.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerID.Location = new System.Drawing.Point(210, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(195, 22);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(210, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 22);
            this.txtName.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(1162, 64);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(195, 24);
            this.cmbType.TabIndex = 4;
            this.cmbType.Text = "Select Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Blue;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Blue;
            this.dateTimePicker1.Location = new System.Drawing.Point(1162, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(56, 12);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(115, 20);
            this.LblID.TabIndex = 6;
            this.LblID.Text = "Customer ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(63, 66);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(108, 20);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "First Name ";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurname.Location = new System.Drawing.Point(496, 10);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(83, 20);
            this.LblSurname.TabIndex = 6;
            this.LblSurname.Text = "Surname";
            // 
            // LblOrdMade
            // 
            this.LblOrdMade.AutoSize = true;
            this.LblOrdMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdMade.Location = new System.Drawing.Point(471, 66);
            this.LblOrdMade.Name = "LblOrdMade";
            this.LblOrdMade.Size = new System.Drawing.Size(108, 20);
            this.LblOrdMade.TabIndex = 6;
            this.LblOrdMade.Text = "Order Made";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(889, 12);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(123, 20);
            this.LblDate.TabIndex = 6;
            this.LblDate.Text = "Date Ordered";
            // 
            // LblPay
            // 
            this.LblPay.AutoSize = true;
            this.LblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPay.Location = new System.Drawing.Point(889, 68);
            this.LblPay.Name = "LblPay";
            this.LblPay.Size = new System.Drawing.Size(170, 20);
            this.LblPay.TabIndex = 6;
            this.LblPay.Text = "Method of Payment";
            // 
            // btnAddMore
            // 
            this.btnAddMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMore.Location = new System.Drawing.Point(386, 602);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(206, 46);
            this.btnAddMore.TabIndex = 7;
            this.btnAddMore.Text = "Add More ";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(778, 602);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 46);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(54, 602);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(174, 45);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Order Items ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1495, 663);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.LblPay);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblOrdMade);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbOrderMade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Violet;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lola\'s Boutique";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxQuant.ResumeLayout(false);
            this.groupBoxQuant.PerformLayout();
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.groupBoxBrands.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxQuant;
        private System.Windows.Forms.RadioButton rB20;
        private System.Windows.Forms.RadioButton rB15;
        private System.Windows.Forms.RadioButton rB10;
        private System.Windows.Forms.RadioButton rB5;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.CheckBox chkColSet;
        private System.Windows.Forms.CheckBox chkPerfSet;
        private System.Windows.Forms.CheckBox chkCologne;
        private System.Windows.Forms.CheckBox chkPerfume;
        private System.Windows.Forms.GroupBox groupBoxBrands;
        private System.Windows.Forms.ListBox lstBrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbOrderMade;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblOrdMade;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblPay;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
    }
}

