namespace LoginRegistrationForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.labelPrescriptions = new System.Windows.Forms.Label();
            this.labelMedicationDetails = new System.Windows.Forms.Label();
            this.textBoxMedicineName = new System.Windows.Forms.TextBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStopDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.buttonMarkIssued = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrescriptions
            // 
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.RowHeadersWidth = 51;
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(750, 200);
            this.dataGridViewPrescriptions.TabIndex = 0;
            // 
            // labelPrescriptions
            // 
            this.labelPrescriptions.AutoSize = true;
            this.labelPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPrescriptions.Location = new System.Drawing.Point(20, 20);
            this.labelPrescriptions.Name = "labelPrescriptions";
            this.labelPrescriptions.Size = new System.Drawing.Size(201, 25);
            this.labelPrescriptions.TabIndex = 1;
            this.labelPrescriptions.Text = "Prescription Overview";
            // 
            // labelMedicationDetails
            // 
            this.labelMedicationDetails.AutoSize = true;
            this.labelMedicationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMedicationDetails.Location = new System.Drawing.Point(20, 280);
            this.labelMedicationDetails.Name = "labelMedicationDetails";
            this.labelMedicationDetails.Size = new System.Drawing.Size(177, 25);
            this.labelMedicationDetails.TabIndex = 2;
            this.labelMedicationDetails.Text = "Medication Details:";
            // 
            // textBoxMedicineName
            // 
            this.textBoxMedicineName.Location = new System.Drawing.Point(150, 320);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(200, 22);
            this.textBoxMedicineName.TabIndex = 3;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Location = new System.Drawing.Point(150, 360);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(200, 22);
            this.textBoxDosage.TabIndex = 4;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(150, 400);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 5;
            // 
            // dateTimePickerStopDate
            // 
            this.dateTimePickerStopDate.Location = new System.Drawing.Point(150, 440);
            this.dateTimePickerStopDate.Name = "dateTimePickerStopDate";
            this.dateTimePickerStopDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStopDate.TabIndex = 6;
            // 
            // dateTimePickerExpiryDate
            // 
            this.dateTimePickerExpiryDate.Location = new System.Drawing.Point(150, 480);
            this.dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            this.dateTimePickerExpiryDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExpiryDate.TabIndex = 7;
            // 
            // buttonMarkIssued
            // 
            this.buttonMarkIssued.Location = new System.Drawing.Point(150, 520);
            this.buttonMarkIssued.Name = "buttonMarkIssued";
            this.buttonMarkIssued.Size = new System.Drawing.Size(200, 30);
            this.buttonMarkIssued.TabIndex = 8;
            this.buttonMarkIssued.Text = "Mark as Issued";
            this.buttonMarkIssued.UseVisualStyleBackColor = true;
            this.buttonMarkIssued.Click += new System.EventHandler(this.buttonMarkIssued_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(-4, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(-4, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dosage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(-4, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(-4, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(-4, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Expiry";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMarkIssued);
            this.Controls.Add(this.dateTimePickerExpiryDate);
            this.Controls.Add(this.dateTimePickerStopDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxMedicineName);
            this.Controls.Add(this.labelMedicationDetails);
            this.Controls.Add(this.labelPrescriptions);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Name = "MainForm";
            this.Text = "Pharmacist Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.Label labelPrescriptions;
        private System.Windows.Forms.Label labelMedicationDetails;
        private System.Windows.Forms.TextBox textBoxMedicineName;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStopDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDate;
        private System.Windows.Forms.Button buttonMarkIssued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
