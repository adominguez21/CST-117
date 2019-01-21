namespace TimeCalculator
{
    partial class TimeCalculator
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
            this.lblseconds = new System.Windows.Forms.Label();
            this.lblworks = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.txtseconds = new System.Windows.Forms.TextBox();
            this.txtworks = new System.Windows.Forms.TextBox();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblseconds
            // 
            this.lblseconds.AutoSize = true;
            this.lblseconds.Location = new System.Drawing.Point(74, 66);
            this.lblseconds.Name = "lblseconds";
            this.lblseconds.Size = new System.Drawing.Size(127, 20);
            this.lblseconds.TabIndex = 0;
            this.lblseconds.Text = "Enter the Seconds";
            // 
            // lblworks
            // 
            this.lblworks.AutoSize = true;
            this.lblworks.Location = new System.Drawing.Point(74, 132);
            this.lblworks.Name = "lblworks";
            this.lblworks.Size = new System.Drawing.Size(163, 20);
            this.lblworks.TabIndex = 0;
            this.lblworks.Text = "Enter Number of Works";
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Location = new System.Drawing.Point(74, 252);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(0, 20);
            this.lbldisplay.TabIndex = 0;
            this.lbldisplay.Click += new System.EventHandler(this.lbldisplay_Click);
            // 
            // txtseconds
            // 
            this.txtseconds.Location = new System.Drawing.Point(286, 60);
            this.txtseconds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtseconds.Name = "txtseconds";
            this.txtseconds.Size = new System.Drawing.Size(100, 27);
            this.txtseconds.TabIndex = 1;
            this.txtseconds.TextChanged += new System.EventHandler(this.txtseconds_TextChanged);
            // 
            // txtworks
            // 
            this.txtworks.Location = new System.Drawing.Point(286, 129);
            this.txtworks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtworks.Name = "txtworks";
            this.txtworks.Size = new System.Drawing.Size(100, 27);
            this.txtworks.TabIndex = 1;
            this.txtworks.TextChanged += new System.EventHandler(this.txtworks_TextChanged);
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(286, 246);
            this.txtdisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(100, 27);
            this.txtdisplay.TabIndex = 1;
            this.txtdisplay.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(69, 388);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(204, 76);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(380, 388);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(204, 76);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.txtworks);
            this.Controls.Add(this.txtseconds);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lblworks);
            this.Controls.Add(this.lblseconds);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimeCalculator";
            this.Text = "TimeCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblseconds;
        private System.Windows.Forms.Label lblworks;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.TextBox txtseconds;
        private System.Windows.Forms.TextBox txtworks;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnclear;
    }
}

