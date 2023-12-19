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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnToday = new System.Windows.Forms.Button();
            this.BtnTomorrow = new System.Windows.Forms.Button();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DateTimePicker1.Location = new System.Drawing.Point(180, 357);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(440, 38);
            this.DateTimePicker1.TabIndex = 1;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // BtnToday
            // 
            this.BtnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnToday.Location = new System.Drawing.Point(180, 406);
            this.BtnToday.Name = "BtnToday";
            this.BtnToday.Size = new System.Drawing.Size(210, 55);
            this.BtnToday.TabIndex = 2;
            this.BtnToday.Text = "Today";
            this.BtnToday.UseVisualStyleBackColor = true;
            this.BtnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // BtnTomorrow
            // 
            this.BtnTomorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnTomorrow.Location = new System.Drawing.Point(410, 406);
            this.BtnTomorrow.Name = "BtnTomorrow";
            this.BtnTomorrow.Size = new System.Drawing.Size(210, 55);
            this.BtnTomorrow.TabIndex = 3;
            this.BtnTomorrow.Text = "Tomorrow";
            this.BtnTomorrow.UseVisualStyleBackColor = true;
            this.BtnTomorrow.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.SystemColors.Window;
            this.BtnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BtnBuy.Location = new System.Drawing.Point(238, 476);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(325, 73);
            this.BtnBuy.TabIndex = 8;
            this.BtnBuy.Text = "Show Tours";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(434, 255);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(302, 46);
            this.ComboBoxTo.TabIndex = 9;
            this.ComboBoxTo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(549, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "TO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(65, 255);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(302, 46);
            this.ComboBoxFrom.TabIndex = 10;
            this.ComboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ComboBoxFrom);
            this.Controls.Add(this.ComboBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.BtnToday);
            this.Controls.Add(this.BtnTomorrow);
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
        private System.Windows.Forms.Button BtnToday;
        private System.Windows.Forms.Button BtnTomorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.ComboBox ComboBoxTo;
        private System.Windows.Forms.ComboBox ComboBoxFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

