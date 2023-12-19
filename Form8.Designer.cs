namespace BMSAdminPanel
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.listViewTourTable = new System.Windows.Forms.ListView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTourTable
            // 
            this.listViewTourTable.HideSelection = false;
            this.listViewTourTable.Location = new System.Drawing.Point(6, 57);
            this.listViewTourTable.Name = "listViewTourTable";
            this.listViewTourTable.Size = new System.Drawing.Size(532, 346);
            this.listViewTourTable.TabIndex = 0;
            this.listViewTourTable.UseCompatibleStateImageBehavior = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Tour";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.listViewTourTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 454);
            this.MinimumSize = new System.Drawing.Size(566, 454);
            this.Name = "Form8";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTourTable;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnAdd;
    }
}