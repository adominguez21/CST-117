namespace CalculatePi
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
            this.lblTerms = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Location = new System.Drawing.Point(157, 82);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(113, 17);
            this.lblTerms.TabIndex = 0;
            this.lblTerms.Text = "Enter # of terms:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(245, 138);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(262, 72);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(63, 285);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(279, 17);
            this.lblApp.TabIndex = 3;
            this.lblApp.Text = "Approximate Value of pi after # of terms is: ";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(348, 282);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(222, 22);
            this.txtAns.TabIndex = 4;
            this.txtAns.TextChanged += new System.EventHandler(this.txtAns_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTerms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.TextBox txtAns;
    }
}

