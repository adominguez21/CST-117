namespace Movies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSF = new System.Windows.Forms.CheckBox();
            this.checkHorror = new System.Windows.Forms.CheckBox();
            this.checkAction = new System.Windows.Forms.CheckBox();
            this.checkComedy = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSF = new System.Windows.Forms.RadioButton();
            this.radioHorror = new System.Windows.Forms.RadioButton();
            this.radioAction = new System.Windows.Forms.RadioButton();
            this.radioComedy = new System.Windows.Forms.RadioButton();
            this.BtnSelected = new System.Windows.Forms.Button();
            this.BtnFavorite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSF);
            this.groupBox1.Controls.Add(this.checkHorror);
            this.groupBox1.Controls.Add(this.checkAction);
            this.groupBox1.Controls.Add(this.checkComedy);
            this.groupBox1.Location = new System.Drawing.Point(41, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What kinds of movies do you like?";
            // 
            // checkSF
            // 
            this.checkSF.AutoSize = true;
            this.checkSF.Location = new System.Drawing.Point(17, 117);
            this.checkSF.Name = "checkSF";
            this.checkSF.Size = new System.Drawing.Size(125, 21);
            this.checkSF.TabIndex = 0;
            this.checkSF.Text = "Science Fiction";
            this.checkSF.UseVisualStyleBackColor = true;
            // 
            // checkHorror
            // 
            this.checkHorror.AutoSize = true;
            this.checkHorror.Location = new System.Drawing.Point(17, 90);
            this.checkHorror.Name = "checkHorror";
            this.checkHorror.Size = new System.Drawing.Size(71, 21);
            this.checkHorror.TabIndex = 0;
            this.checkHorror.Text = "Horror";
            this.checkHorror.UseVisualStyleBackColor = true;
            // 
            // checkAction
            // 
            this.checkAction.AutoSize = true;
            this.checkAction.Location = new System.Drawing.Point(17, 63);
            this.checkAction.Name = "checkAction";
            this.checkAction.Size = new System.Drawing.Size(69, 21);
            this.checkAction.TabIndex = 0;
            this.checkAction.Text = "Action";
            this.checkAction.UseVisualStyleBackColor = true;
            // 
            // checkComedy
            // 
            this.checkComedy.AutoSize = true;
            this.checkComedy.Location = new System.Drawing.Point(17, 36);
            this.checkComedy.Name = "checkComedy";
            this.checkComedy.Size = new System.Drawing.Size(81, 21);
            this.checkComedy.TabIndex = 0;
            this.checkComedy.Text = "Comedy";
            this.checkComedy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSF);
            this.groupBox2.Controls.Add(this.radioHorror);
            this.groupBox2.Controls.Add(this.radioAction);
            this.groupBox2.Controls.Add(this.radioComedy);
            this.groupBox2.Location = new System.Drawing.Point(440, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 175);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Which one is your favorite?";
            // 
            // radioSF
            // 
            this.radioSF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.radioSF.AutoCheck = false;
            this.radioSF.AutoSize = true;
            this.radioSF.Location = new System.Drawing.Point(29, 117);
            this.radioSF.Name = "radioSF";
            this.radioSF.Size = new System.Drawing.Size(124, 21);
            this.radioSF.TabIndex = 0;
            this.radioSF.TabStop = true;
            this.radioSF.Text = "Science Fiction";
            this.radioSF.UseVisualStyleBackColor = true;
            // 
            // radioHorror
            // 
            this.radioHorror.AutoCheck = false;
            this.radioHorror.AutoSize = true;
            this.radioHorror.Location = new System.Drawing.Point(29, 90);
            this.radioHorror.Name = "radioHorror";
            this.radioHorror.Size = new System.Drawing.Size(70, 21);
            this.radioHorror.TabIndex = 0;
            this.radioHorror.Text = "Horror";
            this.radioHorror.UseVisualStyleBackColor = true;
            // 
            // radioAction
            // 
            this.radioAction.AutoCheck = false;
            this.radioAction.AutoSize = true;
            this.radioAction.Location = new System.Drawing.Point(29, 62);
            this.radioAction.Name = "radioAction";
            this.radioAction.Size = new System.Drawing.Size(68, 21);
            this.radioAction.TabIndex = 0;
            this.radioAction.Text = "Action";
            this.radioAction.UseVisualStyleBackColor = true;
            // 
            // radioComedy
            // 
            this.radioComedy.AllowDrop = true;
            this.radioComedy.AutoCheck = false;
            this.radioComedy.AutoSize = true;
            this.radioComedy.Checked = true;
            this.radioComedy.Location = new System.Drawing.Point(29, 36);
            this.radioComedy.Name = "radioComedy";
            this.radioComedy.Size = new System.Drawing.Size(80, 21);
            this.radioComedy.TabIndex = 0;
            this.radioComedy.Text = "Comedy";
            this.radioComedy.UseVisualStyleBackColor = true;
            // 
            // BtnSelected
            // 
            this.BtnSelected.Location = new System.Drawing.Point(88, 291);
            this.BtnSelected.Name = "BtnSelected";
            this.BtnSelected.Size = new System.Drawing.Size(186, 52);
            this.BtnSelected.TabIndex = 1;
            this.BtnSelected.Text = "Selected Movies";
            this.BtnSelected.UseVisualStyleBackColor = true;
            this.BtnSelected.Click += new System.EventHandler(this.BtnSelected_Click);
            // 
            // BtnFavorite
            // 
            this.BtnFavorite.Location = new System.Drawing.Point(493, 291);
            this.BtnFavorite.Name = "BtnFavorite";
            this.BtnFavorite.Size = new System.Drawing.Size(186, 52);
            this.BtnFavorite.TabIndex = 1;
            this.BtnFavorite.Text = "Favorite Movies";
            this.BtnFavorite.UseVisualStyleBackColor = true;
            this.BtnFavorite.Click += new System.EventHandler(this.BtnFavorite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFavorite);
            this.Controls.Add(this.BtnSelected);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Movie Types";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkSF;
        private System.Windows.Forms.CheckBox checkHorror;
        private System.Windows.Forms.CheckBox checkAction;
        private System.Windows.Forms.CheckBox checkComedy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSF;
        private System.Windows.Forms.RadioButton radioHorror;
        private System.Windows.Forms.RadioButton radioAction;
        private System.Windows.Forms.RadioButton radioComedy;
        private System.Windows.Forms.Button BtnSelected;
        private System.Windows.Forms.Button BtnFavorite;
    }
}

