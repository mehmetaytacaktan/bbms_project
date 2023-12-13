namespace BMSAdminPanel
{
    partial class Form12
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.groupBoxTour = new System.Windows.Forms.GroupBox();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.dtPickerArrival = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.cmbboxTripID = new System.Windows.Forms.ComboBox();
            this.cmbboxBusID = new System.Windows.Forms.ComboBox();
            this.cmbboxTo = new System.Windows.Forms.ComboBox();
            this.cmbboxFrom = new System.Windows.Forms.ComboBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblBusTrip = new System.Windows.Forms.Label();
            this.lblBusID = new System.Windows.Forms.Label();
            this.groupBoxTour.SuspendLayout();
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
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click_1);
            // 
            // groupBoxTour
            // 
            this.groupBoxTour.Controls.Add(this.btnAddTour);
            this.groupBoxTour.Controls.Add(this.dtPickerArrival);
            this.groupBoxTour.Controls.Add(this.dtPickerDeparture);
            this.groupBoxTour.Controls.Add(this.cmbboxTripID);
            this.groupBoxTour.Controls.Add(this.cmbboxBusID);
            this.groupBoxTour.Controls.Add(this.cmbboxTo);
            this.groupBoxTour.Controls.Add(this.cmbboxFrom);
            this.groupBoxTour.Controls.Add(this.lblArrival);
            this.groupBoxTour.Controls.Add(this.lblDeparture);
            this.groupBoxTour.Controls.Add(this.lblTo);
            this.groupBoxTour.Controls.Add(this.lblFrom);
            this.groupBoxTour.Controls.Add(this.lblBusTrip);
            this.groupBoxTour.Controls.Add(this.lblBusID);
            this.groupBoxTour.Location = new System.Drawing.Point(12, 81);
            this.groupBoxTour.Name = "groupBoxTour";
            this.groupBoxTour.Size = new System.Drawing.Size(776, 273);
            this.groupBoxTour.TabIndex = 1;
            this.groupBoxTour.TabStop = false;
            // 
            // btnAddTour
            // 
            this.btnAddTour.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddTour.Location = new System.Drawing.Point(680, 226);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(75, 23);
            this.btnAddTour.TabIndex = 16;
            this.btnAddTour.Text = "Add Tour";
            this.btnAddTour.UseVisualStyleBackColor = false;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // dtPickerArrival
            // 
            this.dtPickerArrival.Location = new System.Drawing.Point(555, 158);
            this.dtPickerArrival.Name = "dtPickerArrival";
            this.dtPickerArrival.Size = new System.Drawing.Size(200, 20);
            this.dtPickerArrival.TabIndex = 15;
            // 
            // dtPickerDeparture
            // 
            this.dtPickerDeparture.Location = new System.Drawing.Point(555, 65);
            this.dtPickerDeparture.Name = "dtPickerDeparture";
            this.dtPickerDeparture.Size = new System.Drawing.Size(200, 20);
            this.dtPickerDeparture.TabIndex = 14;
            // 
            // cmbboxTripID
            // 
            this.cmbboxTripID.FormattingEnabled = true;
            this.cmbboxTripID.Location = new System.Drawing.Point(54, 164);
            this.cmbboxTripID.Name = "cmbboxTripID";
            this.cmbboxTripID.Size = new System.Drawing.Size(121, 21);
            this.cmbboxTripID.TabIndex = 13;
            // 
            // cmbboxBusID
            // 
            this.cmbboxBusID.FormattingEnabled = true;
            this.cmbboxBusID.Location = new System.Drawing.Point(54, 68);
            this.cmbboxBusID.Name = "cmbboxBusID";
            this.cmbboxBusID.Size = new System.Drawing.Size(121, 21);
            this.cmbboxBusID.TabIndex = 12;
            // 
            // cmbboxTo
            // 
            this.cmbboxTo.FormattingEnabled = true;
            this.cmbboxTo.Location = new System.Drawing.Point(250, 164);
            this.cmbboxTo.Name = "cmbboxTo";
            this.cmbboxTo.Size = new System.Drawing.Size(121, 21);
            this.cmbboxTo.TabIndex = 11;
            // 
            // cmbboxFrom
            // 
            this.cmbboxFrom.FormattingEnabled = true;
            this.cmbboxFrom.Location = new System.Drawing.Point(250, 68);
            this.cmbboxFrom.Name = "cmbboxFrom";
            this.cmbboxFrom.Size = new System.Drawing.Size(121, 21);
            this.cmbboxFrom.TabIndex = 10;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(419, 164);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(112, 13);
            this.lblArrival.TabIndex = 5;
            this.lblArrival.Text = "Arrival Time and Date:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(419, 71);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(130, 13);
            this.lblDeparture.TabIndex = 4;
            this.lblDeparture.Text = "Departure Time and Date:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(211, 167);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(211, 71);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // lblBusTrip
            // 
            this.lblBusTrip.AutoSize = true;
            this.lblBusTrip.Location = new System.Drawing.Point(6, 167);
            this.lblBusTrip.Name = "lblBusTrip";
            this.lblBusTrip.Size = new System.Drawing.Size(42, 13);
            this.lblBusTrip.TabIndex = 1;
            this.lblBusTrip.Text = "Trip ID:";
            // 
            // lblBusID
            // 
            this.lblBusID.AutoSize = true;
            this.lblBusID.Location = new System.Drawing.Point(6, 71);
            this.lblBusID.Name = "lblBusID";
            this.lblBusID.Size = new System.Drawing.Size(42, 13);
            this.lblBusID.TabIndex = 0;
            this.lblBusID.Text = "Bus ID:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTour);
            this.Controls.Add(this.btnGoBack);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBoxTour.ResumeLayout(false);
            this.groupBoxTour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.GroupBox groupBoxTour;
        private System.Windows.Forms.ComboBox cmbboxTripID;
        private System.Windows.Forms.ComboBox cmbboxBusID;
        private System.Windows.Forms.ComboBox cmbboxTo;
        private System.Windows.Forms.ComboBox cmbboxFrom;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblBusTrip;
        private System.Windows.Forms.Label lblBusID;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.DateTimePicker dtPickerArrival;
        private System.Windows.Forms.DateTimePicker dtPickerDeparture;
    }
}