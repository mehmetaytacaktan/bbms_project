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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuy = new CustomControls.RJControls.RJButton();
            this.BtnTomorrow = new CustomControls.RJControls.RJButton();
            this.BtnToday = new CustomControls.RJControls.RJButton();
            this.Logout = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DateTimePicker1.Location = new System.Drawing.Point(177, 306);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(440, 38);
            this.DateTimePicker1.TabIndex = 1;
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.BackColor = System.Drawing.Color.White;
            this.ComboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(401, 261);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(216, 39);
            this.ComboBoxTo.TabIndex = 9;
            this.ComboBoxTo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "TO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.BackColor = System.Drawing.Color.White;
            this.ComboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(177, 261);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(216, 39);
            this.ComboBoxFrom.TabIndex = 10;
            this.ComboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBuy.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBuy.BorderColor = System.Drawing.Color.Black;
            this.BtnBuy.BorderRadius = 20;
            this.BtnBuy.BorderSize = 0;
            this.BtnBuy.FlatAppearance.BorderSize = 0;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuy.ForeColor = System.Drawing.Color.Black;
            this.BtnBuy.Location = new System.Drawing.Point(268, 449);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(265, 50);
            this.BtnBuy.TabIndex = 12;
            this.BtnBuy.Text = "Show Tours";
            this.BtnBuy.TextColor = System.Drawing.Color.Black;
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click_1);
            // 
            // BtnTomorrow
            // 
            this.BtnTomorrow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnTomorrow.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnTomorrow.BorderColor = System.Drawing.Color.Black;
            this.BtnTomorrow.BorderRadius = 20;
            this.BtnTomorrow.BorderSize = 0;
            this.BtnTomorrow.FlatAppearance.BorderSize = 0;
            this.BtnTomorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTomorrow.ForeColor = System.Drawing.Color.Black;
            this.BtnTomorrow.Location = new System.Drawing.Point(437, 371);
            this.BtnTomorrow.Name = "BtnTomorrow";
            this.BtnTomorrow.Size = new System.Drawing.Size(180, 50);
            this.BtnTomorrow.TabIndex = 13;
            this.BtnTomorrow.Text = "Tomorrow";
            this.BtnTomorrow.TextColor = System.Drawing.Color.Black;
            this.BtnTomorrow.UseVisualStyleBackColor = false;
            this.BtnTomorrow.Click += new System.EventHandler(this.BtnTomorrow_Click);
            // 
            // BtnToday
            // 
            this.BtnToday.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnToday.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnToday.BorderColor = System.Drawing.Color.Black;
            this.BtnToday.BorderRadius = 20;
            this.BtnToday.BorderSize = 0;
            this.BtnToday.FlatAppearance.BorderSize = 0;
            this.BtnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToday.ForeColor = System.Drawing.Color.Black;
            this.BtnToday.Location = new System.Drawing.Point(177, 371);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Size = new System.Drawing.Size(180, 50);
            this.BtnToday.TabIndex = 14;
            this.BtnToday.Text = "Today";
            this.BtnToday.TextColor = System.Drawing.Color.Black;
            this.BtnToday.UseVisualStyleBackColor = false;
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click_1);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Orange;
            this.Logout.BackgroundColor = System.Drawing.Color.Orange;
            this.Logout.BorderColor = System.Drawing.Color.Black;
            this.Logout.BorderRadius = 20;
            this.Logout.BorderSize = 0;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(180, 50);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "Logout";
            this.Logout.TextColor = System.Drawing.Color.Black;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Orange;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Orange;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(12, 68);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(180, 50);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "Profile";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.BtnToday);
            this.Controls.Add(this.BtnTomorrow);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.ComboBoxFrom);
            this.Controls.Add(this.ComboBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTo;
        private System.Windows.Forms.ComboBox ComboBoxFrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton BtnBuy;
        private CustomControls.RJControls.RJButton BtnTomorrow;
        private CustomControls.RJControls.RJButton BtnToday;
        private CustomControls.RJControls.RJButton Logout;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}

