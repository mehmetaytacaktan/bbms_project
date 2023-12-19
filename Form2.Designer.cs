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
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnNextDay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(120, 56);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPrevDay
            // 
            this.BtnPrevDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.BtnPrevDay.Location = new System.Drawing.Point(13, 287);
            this.BtnPrevDay.Name = "BtnPrevDay";
            this.BtnPrevDay.Size = new System.Drawing.Size(60, 60);
            this.BtnPrevDay.TabIndex = 1;
            this.BtnPrevDay.Text = "<";
            this.BtnPrevDay.UseVisualStyleBackColor = true;
            this.BtnPrevDay.Click += new System.EventHandler(this.BtnPrevDay_Click);
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.DateTimePicker2.Location = new System.Drawing.Point(99, 287);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(584, 48);
            this.DateTimePicker2.TabIndex = 3;
            this.DateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // BtnNextDay
            // 
            this.BtnNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.BtnNextDay.Location = new System.Drawing.Point(713, 287);
            this.BtnNextDay.Name = "BtnNextDay";
            this.BtnNextDay.Size = new System.Drawing.Size(60, 60);
            this.BtnNextDay.TabIndex = 2;
            this.BtnNextDay.Text = ">";
            this.BtnNextDay.UseVisualStyleBackColor = true;
            this.BtnNextDay.Click += new System.EventHandler(this.BtnNextDay_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(12, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 171);
            this.panel3.TabIndex = 8;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.BackColor = System.Drawing.Color.RosyBrown;
            this.checkBoxFemale.Location = new System.Drawing.Point(114, 342);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Padding = new System.Windows.Forms.Padding(30, 8, 30, 8);
            this.checkBoxFemale.Size = new System.Drawing.Size(75, 30);
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
            this.checkBoxMale.Location = new System.Drawing.Point(195, 342);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Padding = new System.Windows.Forms.Padding(30, 8, 30, 8);
            this.checkBoxMale.Size = new System.Drawing.Size(75, 30);
            this.checkBoxMale.TabIndex = 9;
            this.checkBoxMale.UseVisualStyleBackColor = false;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNextDay);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.BtnPrevDay);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form2";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnPrevDay;
        private System.Windows.Forms.Button BtnNextDay;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}