﻿namespace BMSAdminPanel
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblClientID = new System.Windows.Forms.Label();
            this.cmbboxClientIDs = new System.Windows.Forms.ComboBox();
            this.btnClientIDSearch = new System.Windows.Forms.Button();
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(526, 254);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(147, 72);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 13);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "Client ID:";
            // 
            // cmbboxClientIDs
            // 
            this.cmbboxClientIDs.FormattingEnabled = true;
            this.cmbboxClientIDs.Location = new System.Drawing.Point(232, 69);
            this.cmbboxClientIDs.Name = "cmbboxClientIDs";
            this.cmbboxClientIDs.Size = new System.Drawing.Size(121, 21);
            this.cmbboxClientIDs.TabIndex = 3;
            // 
            // btnClientIDSearch
            // 
            this.btnClientIDSearch.Location = new System.Drawing.Point(388, 69);
            this.btnClientIDSearch.Name = "btnClientIDSearch";
            this.btnClientIDSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClientIDSearch.TabIndex = 4;
            this.btnClientIDSearch.Text = "Search";
            this.btnClientIDSearch.UseVisualStyleBackColor = true;
            this.btnClientIDSearch.Click += new System.EventHandler(this.btnClientIDSearch_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.btnClientIDSearch);
            this.Controls.Add(this.cmbboxClientIDs);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGoBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 454);
            this.MinimumSize = new System.Drawing.Size(566, 454);
            this.Name = "Form9";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form9_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.ComboBox cmbboxClientIDs;
        private System.Windows.Forms.Button btnClientIDSearch;
    }
}