namespace BMSAdminPanel
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.cmbboxDiscountAmount = new System.Windows.Forms.ComboBox();
            this.btnDisableDiscount = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblStartDiscount = new System.Windows.Forms.Label();
            this.lblEndDiscount = new System.Windows.Forms.Label();
            this.lblDisableDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(19, 107);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(105, 13);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Amount Of Discount:";
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(419, 360);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(119, 43);
            this.btnApplyChanges.TabIndex = 3;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // cmbboxDiscountAmount
            // 
            this.cmbboxDiscountAmount.FormattingEnabled = true;
            this.cmbboxDiscountAmount.Location = new System.Drawing.Point(130, 104);
            this.cmbboxDiscountAmount.Name = "cmbboxDiscountAmount";
            this.cmbboxDiscountAmount.Size = new System.Drawing.Size(121, 21);
            this.cmbboxDiscountAmount.TabIndex = 4;
            // 
            // btnDisableDiscount
            // 
            this.btnDisableDiscount.Location = new System.Drawing.Point(146, 337);
            this.btnDisableDiscount.Name = "btnDisableDiscount";
            this.btnDisableDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDisableDiscount.TabIndex = 5;
            this.btnDisableDiscount.Text = "Disable";
            this.btnDisableDiscount.UseVisualStyleBackColor = true;
            this.btnDisableDiscount.Click += new System.EventHandler(this.btnDisableDiscount_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(289, 241);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // lblStartDiscount
            // 
            this.lblStartDiscount.AutoSize = true;
            this.lblStartDiscount.Location = new System.Drawing.Point(271, 74);
            this.lblStartDiscount.Name = "lblStartDiscount";
            this.lblStartDiscount.Size = new System.Drawing.Size(243, 13);
            this.lblStartDiscount.TabIndex = 8;
            this.lblStartDiscount.Text = "Please Select The Starting Time Of The Discount:";
            // 
            // lblEndDiscount
            // 
            this.lblEndDiscount.AutoSize = true;
            this.lblEndDiscount.Location = new System.Drawing.Point(271, 213);
            this.lblEndDiscount.Name = "lblEndDiscount";
            this.lblEndDiscount.Size = new System.Drawing.Size(240, 13);
            this.lblEndDiscount.TabIndex = 9;
            this.lblEndDiscount.Text = "Please Select The Ending Time Of The Discount:";
            // 
            // lblDisableDiscount
            // 
            this.lblDisableDiscount.AutoSize = true;
            this.lblDisableDiscount.Location = new System.Drawing.Point(19, 342);
            this.lblDisableDiscount.Name = "lblDisableDiscount";
            this.lblDisableDiscount.Size = new System.Drawing.Size(112, 13);
            this.lblDisableDiscount.TabIndex = 10;
            this.lblDisableDiscount.Text = "Disable The Discount:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.lblDisableDiscount);
            this.Controls.Add(this.lblEndDiscount);
            this.Controls.Add(this.lblStartDiscount);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDisableDiscount);
            this.Controls.Add(this.cmbboxDiscountAmount);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnGoBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(566, 454);
            this.MinimumSize = new System.Drawing.Size(566, 454);
            this.Name = "Form10";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form10_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.ComboBox cmbboxDiscountAmount;
        private System.Windows.Forms.Button btnDisableDiscount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblStartDiscount;
        private System.Windows.Forms.Label lblEndDiscount;
        private System.Windows.Forms.Label lblDisableDiscount;
    }
}