namespace BMSAdminPanel
{
    partial class AddTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTour));
            this.groupBoxTour = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.cmbboxBusID = new System.Windows.Forms.ComboBox();
            this.cmbboxFrom = new System.Windows.Forms.ComboBox();
            this.cmbboxTo = new System.Windows.Forms.ComboBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.groupBoxTour.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTour
            // 
            this.groupBoxTour.Controls.Add(this.button2);
            this.groupBoxTour.Controls.Add(this.label5);
            this.groupBoxTour.Controls.Add(this.label2);
            this.groupBoxTour.Controls.Add(this.label1);
            this.groupBoxTour.Controls.Add(this.button1);
            this.groupBoxTour.Controls.Add(this.dtArrival);
            this.groupBoxTour.Controls.Add(this.dtDeparture);
            this.groupBoxTour.Controls.Add(this.cmbboxBusID);
            this.groupBoxTour.Controls.Add(this.cmbboxFrom);
            this.groupBoxTour.Controls.Add(this.cmbboxTo);
            this.groupBoxTour.Controls.Add(this.lblArrival);
            this.groupBoxTour.Controls.Add(this.lblDeparture);
            this.groupBoxTour.Location = new System.Drawing.Point(16, 98);
            this.groupBoxTour.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTour.Name = "groupBoxTour";
            this.groupBoxTour.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTour.Size = new System.Drawing.Size(1013, 331);
            this.groupBoxTour.TabIndex = 1;
            this.groupBoxTour.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(732, 210);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remove Tour";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(683, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bus ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(371, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "From:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(732, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Tour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtArrival
            // 
            this.dtArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtArrival.Location = new System.Drawing.Point(329, 283);
            this.dtArrival.Margin = new System.Windows.Forms.Padding(4);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.Size = new System.Drawing.Size(367, 30);
            this.dtArrival.TabIndex = 15;
            // 
            // dtDeparture
            // 
            this.dtDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDeparture.Location = new System.Drawing.Point(329, 226);
            this.dtDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.dtDeparture.Name = "dtDeparture";
            this.dtDeparture.Size = new System.Drawing.Size(367, 30);
            this.dtDeparture.TabIndex = 14;
            // 
            // cmbboxBusID
            // 
            this.cmbboxBusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbboxBusID.FormattingEnabled = true;
            this.cmbboxBusID.Location = new System.Drawing.Point(792, 46);
            this.cmbboxBusID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxBusID.Name = "cmbboxBusID";
            this.cmbboxBusID.Size = new System.Drawing.Size(203, 33);
            this.cmbboxBusID.TabIndex = 13;
            this.cmbboxBusID.SelectedIndexChanged += new System.EventHandler(this.cmbboxBusID_SelectedIndexChanged);
            // 
            // cmbboxFrom
            // 
            this.cmbboxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbboxFrom.FormattingEnabled = true;
            this.cmbboxFrom.Location = new System.Drawing.Point(119, 46);
            this.cmbboxFrom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxFrom.Name = "cmbboxFrom";
            this.cmbboxFrom.Size = new System.Drawing.Size(203, 33);
            this.cmbboxFrom.TabIndex = 12;
            // 
            // cmbboxTo
            // 
            this.cmbboxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbboxTo.FormattingEnabled = true;
            this.cmbboxTo.Location = new System.Drawing.Point(435, 46);
            this.cmbboxTo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxTo.Name = "cmbboxTo";
            this.cmbboxTo.Size = new System.Drawing.Size(203, 33);
            this.cmbboxTo.TabIndex = 10;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArrival.ForeColor = System.Drawing.Color.White;
            this.lblArrival.Location = new System.Drawing.Point(108, 283);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(201, 29);
            this.lblArrival.TabIndex = 5;
            this.lblArrival.Text = "Arrival and Date:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDeparture.ForeColor = System.Drawing.Color.White;
            this.lblDeparture.Location = new System.Drawing.Point(67, 226);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(247, 29);
            this.lblDeparture.TabIndex = 4;
            this.lblDeparture.Text = "Departure  and Date:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGoBack.Location = new System.Drawing.Point(16, 15);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(128, 48);
            this.btnGoBack.TabIndex = 17;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // AddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1043, 434);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.groupBoxTour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 481);
            this.MinimumSize = new System.Drawing.Size(1061, 481);
            this.Name = "AddTour";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form12_FormClosing);
            this.groupBoxTour.ResumeLayout(false);
            this.groupBoxTour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTour;
        private System.Windows.Forms.ComboBox cmbboxBusID;
        private System.Windows.Forms.ComboBox cmbboxFrom;
        private System.Windows.Forms.ComboBox cmbboxTo;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}