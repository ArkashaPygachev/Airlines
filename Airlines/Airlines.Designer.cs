namespace Airlines {
    partial class Airlines {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbSearchByDestination = new System.Windows.Forms.RadioButton();
            this.rdbSearchByNumber = new System.Windows.Forms.RadioButton();
            this.rdbSearchByTime = new System.Windows.Forms.RadioButton();
            this.tbSearchArg = new System.Windows.Forms.TextBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnAddNewFlightWindow = new System.Windows.Forms.Button();
            this.dtpSearchArgs = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbSearchByDestination);
            this.panel1.Controls.Add(this.rdbSearchByNumber);
            this.panel1.Controls.Add(this.rdbSearchByTime);
            this.panel1.Location = new System.Drawing.Point(82, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 134);
            this.panel1.TabIndex = 0;
            // 
            // rdbSearchByDestination
            // 
            this.rdbSearchByDestination.AutoSize = true;
            this.rdbSearchByDestination.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSearchByDestination.Location = new System.Drawing.Point(19, 92);
            this.rdbSearchByDestination.Name = "rdbSearchByDestination";
            this.rdbSearchByDestination.Size = new System.Drawing.Size(211, 29);
            this.rdbSearchByDestination.TabIndex = 2;
            this.rdbSearchByDestination.TabStop = true;
            this.rdbSearchByDestination.Text = "Seach by destination";
            this.rdbSearchByDestination.UseVisualStyleBackColor = true;
            this.rdbSearchByDestination.CheckedChanged += new System.EventHandler(this.rdbSearchByDestination_CheckedChanged);
            // 
            // rdbSearchByNumber
            // 
            this.rdbSearchByNumber.AutoSize = true;
            this.rdbSearchByNumber.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSearchByNumber.Location = new System.Drawing.Point(19, 55);
            this.rdbSearchByNumber.Name = "rdbSearchByNumber";
            this.rdbSearchByNumber.Size = new System.Drawing.Size(239, 29);
            this.rdbSearchByNumber.TabIndex = 1;
            this.rdbSearchByNumber.TabStop = true;
            this.rdbSearchByNumber.Text = "Search by flight number";
            this.rdbSearchByNumber.UseVisualStyleBackColor = true;
            this.rdbSearchByNumber.CheckedChanged += new System.EventHandler(this.rdbSearchByNumber_CheckedChanged);
            // 
            // rdbSearchByTime
            // 
            this.rdbSearchByTime.AutoSize = true;
            this.rdbSearchByTime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSearchByTime.Location = new System.Drawing.Point(19, 20);
            this.rdbSearchByTime.Name = "rdbSearchByTime";
            this.rdbSearchByTime.Size = new System.Drawing.Size(161, 29);
            this.rdbSearchByTime.TabIndex = 0;
            this.rdbSearchByTime.TabStop = true;
            this.rdbSearchByTime.Text = "Search by time";
            this.rdbSearchByTime.UseVisualStyleBackColor = true;
            this.rdbSearchByTime.CheckedChanged += new System.EventHandler(this.rdbSearchByTime_CheckedChanged);
            // 
            // tbSearchArg
            // 
            this.tbSearchArg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchArg.Location = new System.Drawing.Point(33, 163);
            this.tbSearchArg.Name = "tbSearchArg";
            this.tbSearchArg.Size = new System.Drawing.Size(272, 29);
            this.tbSearchArg.TabIndex = 1;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(311, 163);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(122, 29);
            this.btnAddFlight.TabIndex = 2;
            this.btnAddFlight.Text = "Search flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnAddNewFlightWindow
            // 
            this.btnAddNewFlightWindow.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewFlightWindow.Location = new System.Drawing.Point(101, 208);
            this.btnAddNewFlightWindow.Name = "btnAddNewFlightWindow";
            this.btnAddNewFlightWindow.Size = new System.Drawing.Size(239, 34);
            this.btnAddNewFlightWindow.TabIndex = 3;
            this.btnAddNewFlightWindow.Text = "Add new flight to database";
            this.btnAddNewFlightWindow.UseVisualStyleBackColor = true;
            this.btnAddNewFlightWindow.Click += new System.EventHandler(this.btnAddNewFlightWindow_Click);
            // 
            // dtpSearchArgs
            // 
            this.dtpSearchArgs.CustomFormat = "dd.MM.yyyy H:mm";
            this.dtpSearchArgs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchArgs.Location = new System.Drawing.Point(101, 168);
            this.dtpSearchArgs.Name = "dtpSearchArgs";
            this.dtpSearchArgs.Size = new System.Drawing.Size(204, 20);
            this.dtpSearchArgs.TabIndex = 8;
            this.dtpSearchArgs.Value = new System.DateTime(2019, 10, 20, 0, 0, 0, 0);
            // 
            // Airlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 269);
            this.Controls.Add(this.dtpSearchArgs);
            this.Controls.Add(this.btnAddNewFlightWindow);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.tbSearchArg);
            this.Controls.Add(this.panel1);
            this.Name = "Airlines";
            this.Text = "Airlines";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbSearchByDestination;
        private System.Windows.Forms.RadioButton rdbSearchByNumber;
        private System.Windows.Forms.RadioButton rdbSearchByTime;
        private System.Windows.Forms.TextBox tbSearchArg;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnAddNewFlightWindow;
        private System.Windows.Forms.DateTimePicker dtpSearchArgs;
    }
}

