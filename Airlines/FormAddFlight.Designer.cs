namespace Airlines {
    partial class FormAddFlight {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtbDestinationDes = new System.Windows.Forms.RichTextBox();
            this.rtbFlightNumberDes = new System.Windows.Forms.RichTextBox();
            this.rtbDepartureTimeDes = new System.Windows.Forms.RichTextBox();
            this.btnAddNewFlight = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbFlightNumber = new System.Windows.Forms.TextBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rtbDestinationDes
            // 
            this.rtbDestinationDes.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDestinationDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDestinationDes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDestinationDes.Location = new System.Drawing.Point(12, 12);
            this.rtbDestinationDes.Name = "rtbDestinationDes";
            this.rtbDestinationDes.ReadOnly = true;
            this.rtbDestinationDes.Size = new System.Drawing.Size(156, 30);
            this.rtbDestinationDes.TabIndex = 0;
            this.rtbDestinationDes.Text = "Destination:";
            // 
            // rtbFlightNumberDes
            // 
            this.rtbFlightNumberDes.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbFlightNumberDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFlightNumberDes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFlightNumberDes.Location = new System.Drawing.Point(12, 48);
            this.rtbFlightNumberDes.Name = "rtbFlightNumberDes";
            this.rtbFlightNumberDes.ReadOnly = true;
            this.rtbFlightNumberDes.Size = new System.Drawing.Size(156, 30);
            this.rtbFlightNumberDes.TabIndex = 1;
            this.rtbFlightNumberDes.Text = "Flight number:";
            // 
            // rtbDepartureTimeDes
            // 
            this.rtbDepartureTimeDes.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDepartureTimeDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDepartureTimeDes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDepartureTimeDes.Location = new System.Drawing.Point(12, 87);
            this.rtbDepartureTimeDes.Name = "rtbDepartureTimeDes";
            this.rtbDepartureTimeDes.ReadOnly = true;
            this.rtbDepartureTimeDes.Size = new System.Drawing.Size(156, 30);
            this.rtbDepartureTimeDes.TabIndex = 2;
            this.rtbDepartureTimeDes.Text = "Departure time:";
            // 
            // btnAddNewFlight
            // 
            this.btnAddNewFlight.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewFlight.Location = new System.Drawing.Point(36, 123);
            this.btnAddNewFlight.Name = "btnAddNewFlight";
            this.btnAddNewFlight.Size = new System.Drawing.Size(93, 29);
            this.btnAddNewFlight.TabIndex = 3;
            this.btnAddNewFlight.Text = "Add flight";
            this.btnAddNewFlight.UseVisualStyleBackColor = true;
            this.btnAddNewFlight.Click += new System.EventHandler(this.btnAddNewFlight_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(174, 12);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(129, 20);
            this.tbDestination.TabIndex = 4;
            // 
            // tbFlightNumber
            // 
            this.tbFlightNumber.Location = new System.Drawing.Point(174, 51);
            this.tbFlightNumber.Name = "tbFlightNumber";
            this.tbFlightNumber.Size = new System.Drawing.Size(129, 20);
            this.tbFlightNumber.TabIndex = 5;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CustomFormat = "dd.MM.yyyy H:mm";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(174, 87);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(129, 20);
            this.dtpDepartureTime.TabIndex = 7;
            this.dtpDepartureTime.Value = new System.DateTime(2019, 10, 20, 0, 0, 0, 0);
            // 
            // FormAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(320, 168);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.tbFlightNumber);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.btnAddNewFlight);
            this.Controls.Add(this.rtbDepartureTimeDes);
            this.Controls.Add(this.rtbFlightNumberDes);
            this.Controls.Add(this.rtbDestinationDes);
            this.Name = "FormAddFlight";
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.FormAddFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDestinationDes;
        private System.Windows.Forms.RichTextBox rtbFlightNumberDes;
        private System.Windows.Forms.RichTextBox rtbDepartureTimeDes;
        private System.Windows.Forms.Button btnAddNewFlight;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbFlightNumber;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
    }
}