namespace BMSAdminPanel
{
    partial class CheckClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckClient));
            this.listview = new System.Windows.Forms.ListView();
            this.lblClientID = new System.Windows.Forms.Label();
            this.cmbboxClientIDs = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.BackColor = System.Drawing.Color.Silver;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(12, 57);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(760, 292);
            this.listview.TabIndex = 1;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblClientID.ForeColor = System.Drawing.Color.White;
            this.lblClientID.Location = new System.Drawing.Point(351, 19);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(92, 25);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "Client ID:";
            // 
            // cmbboxClientIDs
            // 
            this.cmbboxClientIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbboxClientIDs.FormattingEnabled = true;
            this.cmbboxClientIDs.Location = new System.Drawing.Point(449, 15);
            this.cmbboxClientIDs.Name = "cmbboxClientIDs";
            this.cmbboxClientIDs.Size = new System.Drawing.Size(188, 33);
            this.cmbboxClientIDs.TabIndex = 3;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(96, 39);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(643, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.cmbboxClientIDs);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.listview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form9";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form9_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.ComboBox cmbboxClientIDs;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button button1;
    }
}