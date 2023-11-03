namespace formProject
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
            System.Windows.Forms.PictureBox PicBoxLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnToday = new System.Windows.Forms.Button();
            this.BtnTomorrow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            PicBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PicBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBoxLogo
            // 
            PicBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PicBoxLogo.ErrorImage")));
            PicBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxLogo.Image")));
            PicBoxLogo.Location = new System.Drawing.Point(102, 27);
            PicBoxLogo.Name = "PicBoxLogo";
            PicBoxLogo.Size = new System.Drawing.Size(437, 166);
            PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PicBoxLogo.TabIndex = 0;
            PicBoxLogo.TabStop = false;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DateTimePicker1.Location = new System.Drawing.Point(272, 15);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(247, 24);
            this.DateTimePicker1.TabIndex = 1;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // BtnToday
            // 
            this.BtnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnToday.Location = new System.Drawing.Point(272, 45);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Size = new System.Drawing.Size(123, 42);
            this.BtnToday.TabIndex = 2;
            this.BtnToday.Text = "Today";
            this.BtnToday.UseVisualStyleBackColor = true;
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // BtnTomorrow
            // 
            this.BtnTomorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnTomorrow.Location = new System.Drawing.Point(400, 45);
            this.BtnTomorrow.Name = "BtnTomorrow";
            this.BtnTomorrow.Size = new System.Drawing.Size(117, 42);
            this.BtnTomorrow.TabIndex = 3;
            this.BtnTomorrow.Text = "Tomorrow";
            this.BtnTomorrow.UseVisualStyleBackColor = true;
            this.BtnTomorrow.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.BtnBuy);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DateTimePicker1);
            this.panel1.Controls.Add(this.BtnToday);
            this.panel1.Controls.Add(this.BtnTomorrow);
            this.panel1.Location = new System.Drawing.Point(13, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 176);
            this.panel1.TabIndex = 5;
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.SystemColors.Window;
            this.BtnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnBuy.Location = new System.Drawing.Point(272, 93);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(246, 76);
            this.BtnBuy.TabIndex = 8;
            this.BtnBuy.Text = "Show Tours";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Sienna;
            this.panel3.Controls.Add(this.ComboBoxTo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 77);
            this.panel3.TabIndex = 7;
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(7, 41);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(231, 33);
            this.ComboBoxTo.TabIndex = 9;
            this.ComboBoxTo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "TO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.ComboBoxFrom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 76);
            this.panel2.TabIndex = 6;
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(7, 39);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(231, 33);
            this.ComboBoxFrom.TabIndex = 10;
            this.ComboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(13, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(PicBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 454);
            this.MinimumSize = new System.Drawing.Size(566, 454);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(PicBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button BtnToday;
        private System.Windows.Forms.Button BtnTomorrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.ComboBox ComboBoxTo;
        private System.Windows.Forms.ComboBox ComboBoxFrom;
        private System.Windows.Forms.Button button1;
    }
}

