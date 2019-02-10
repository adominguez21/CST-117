namespace FatCarbohydrates
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
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.btnFat = new System.Windows.Forms.Button();
            this.btnCarbs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(149, 9);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(484, 44);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Calories Fat Carbohydrates";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.Location = new System.Drawing.Point(39, 129);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(195, 24);
            this.lblFat.TabIndex = 1;
            this.lblFat.Text = "Number of Fat Grams ";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs.Location = new System.Drawing.Point(39, 207);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(277, 24);
            this.lblCarbs.TabIndex = 1;
            this.lblCarbs.Text = "Number of Carbohydrate Grams";
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(445, 131);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(188, 22);
            this.txtFat.TabIndex = 2;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(445, 207);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(188, 22);
            this.txtCarbs.TabIndex = 2;
            // 
            // btnFat
            // 
            this.btnFat.Location = new System.Drawing.Point(127, 290);
            this.btnFat.Name = "btnFat";
            this.btnFat.Size = new System.Drawing.Size(189, 60);
            this.btnFat.TabIndex = 3;
            this.btnFat.Text = "Fat Calories";
            this.btnFat.UseVisualStyleBackColor = true;
            this.btnFat.Click += new System.EventHandler(this.btnFat_Click);
            // 
            // btnCarbs
            // 
            this.btnCarbs.Location = new System.Drawing.Point(410, 290);
            this.btnCarbs.Name = "btnCarbs";
            this.btnCarbs.Size = new System.Drawing.Size(189, 60);
            this.btnCarbs.TabIndex = 3;
            this.btnCarbs.Text = "Carbohydrate Calories";
            this.btnCarbs.UseVisualStyleBackColor = true;
            this.btnCarbs.Click += new System.EventHandler(this.btnCarbs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(614, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 446);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCarbs);
            this.Controls.Add(this.btnFat);
            this.Controls.Add(this.txtCarbs);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblCalories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.Button btnFat;
        private System.Windows.Forms.Button btnCarbs;
        private System.Windows.Forms.Button btnExit;
    }
}

