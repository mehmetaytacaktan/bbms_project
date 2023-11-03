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
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BtnBack.Location = new System.Drawing.Point(13, 18);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 84);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPrevDay
            // 
            this.BtnPrevDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.BtnPrevDay.Location = new System.Drawing.Point(17, 9);
            this.BtnPrevDay.Name = "BtnPrevDay";
            this.BtnPrevDay.Size = new System.Drawing.Size(45, 45);
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
            this.pictureBox1.Location = new System.Drawing.Point(206, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 120);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.DateTimePicker2);
            this.panel2.Controls.Add(this.BtnNextDay);
            this.panel2.Controls.Add(this.BtnPrevDay);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 62);
            this.panel2.TabIndex = 7;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DateTimePicker2.Location = new System.Drawing.Point(68, 14);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(386, 35);
            this.DateTimePicker2.TabIndex = 3;
            this.DateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // BtnNextDay
            // 
            this.BtnNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.BtnNextDay.Location = new System.Drawing.Point(460, 7);
            this.BtnNextDay.Name = "BtnNextDay";
            this.BtnNextDay.Size = new System.Drawing.Size(45, 45);
            this.BtnNextDay.TabIndex = 2;
            this.BtnNextDay.Text = ">";
            this.BtnNextDay.UseVisualStyleBackColor = true;
            this.BtnNextDay.Click += new System.EventHandler(this.BtnNextDay_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(12, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 171);
            this.panel3.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label20.Location = new System.Drawing.Point(3, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(165, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ankara > İstanbul";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label19.Location = new System.Drawing.Point(190, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 31);
            this.label19.TabIndex = 1;
            this.label19.Text = "00:15";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label18.Location = new System.Drawing.Point(373, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 31);
            this.label18.TabIndex = 2;
            this.label18.Text = "250TL";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.Location = new System.Drawing.Point(192, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 24);
            this.label17.TabIndex = 3;
            this.label17.Text = "07H00M";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(27, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "2+1";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Location = new System.Drawing.Point(31, 506);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(470, 71);
            this.panel7.TabIndex = 5;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.BackColor = System.Drawing.Color.RosyBrown;
            this.checkBoxFemale.Location = new System.Drawing.Point(39, 207);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Padding = new System.Windows.Forms.Padding(30, 3, 29, 2);
            this.checkBoxFemale.Size = new System.Drawing.Size(74, 19);
            this.checkBoxFemale.TabIndex = 4;
            this.checkBoxFemale.UseVisualStyleBackColor = false;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.BackColor = System.Drawing.Color.SkyBlue;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Location = new System.Drawing.Point(119, 207);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Padding = new System.Windows.Forms.Padding(30, 3, 29, 2);
            this.checkBoxMale.Size = new System.Drawing.Size(74, 19);
            this.checkBoxMale.TabIndex = 9;
            this.checkBoxMale.UseVisualStyleBackColor = false;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 454);
            this.MinimumSize = new System.Drawing.Size(566, 454);
            this.Name = "Form2";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
    }
}