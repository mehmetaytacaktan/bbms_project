namespace formProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnPrevDay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnNextDay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BtnBack.Location = new System.Drawing.Point(17, 22);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(239, 103);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPrevDay
            // 
            this.BtnPrevDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.BtnPrevDay.Location = new System.Drawing.Point(23, 11);
            this.BtnPrevDay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrevDay.Name = "BtnPrevDay";
            this.BtnPrevDay.Size = new System.Drawing.Size(60, 55);
            this.BtnPrevDay.TabIndex = 1;
            this.BtnPrevDay.Text = "<";
            this.BtnPrevDay.UseVisualStyleBackColor = true;
            this.BtnPrevDay.Click += new System.EventHandler(this.BtnPrevDay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::formProject.Properties.Resources.Logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(274, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 148);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.DateTimePicker2);
            this.panel2.Controls.Add(this.BtnNextDay);
            this.panel2.Controls.Add(this.BtnPrevDay);
            this.panel2.Location = new System.Drawing.Point(16, 172);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 76);
            this.panel2.TabIndex = 7;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DateTimePicker2.Location = new System.Drawing.Point(91, 15);
            this.DateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(514, 45);
            this.DateTimePicker2.TabIndex = 3;
            this.DateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // BtnNextDay
            // 
            this.BtnNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.BtnNextDay.Location = new System.Drawing.Point(613, 9);
            this.BtnNextDay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNextDay.Name = "BtnNextDay";
            this.BtnNextDay.Size = new System.Drawing.Size(60, 55);
            this.BtnNextDay.TabIndex = 2;
            this.BtnNextDay.Text = ">";
            this.BtnNextDay.UseVisualStyleBackColor = true;
            this.BtnNextDay.Click += new System.EventHandler(this.BtnNextDay_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(16, 256);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 234);
            this.panel3.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Form2";
            this.Text = "Freedom Tourism";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnPrevDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnNextDay;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Panel panel3;
    }
}