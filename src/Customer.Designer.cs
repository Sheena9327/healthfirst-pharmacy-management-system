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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelGreeting = new System.Windows.Forms.Label();
            this.labelUploadPrompt = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridViewMedications = new System.Windows.Forms.DataGridView();
            this.labelMedicationDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelGreeting.Location = new System.Drawing.Point(30, 20);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(125, 31);
            this.labelGreeting.TabIndex = 0;
            this.labelGreeting.Text = "Hey User";
            // 
            // labelUploadPrompt
            // 
            this.labelUploadPrompt.AutoSize = true;
            this.labelUploadPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUploadPrompt.Location = new System.Drawing.Point(30, 70);
            this.labelUploadPrompt.Name = "labelUploadPrompt";
            this.labelUploadPrompt.Size = new System.Drawing.Size(209, 25);
            this.labelUploadPrompt.TabIndex = 1;
            this.labelUploadPrompt.Text = "Upload Prescription:";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonUpload.Location = new System.Drawing.Point(260, 65);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(125, 35);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // dataGridViewPrescriptions
            // 
            this.dataGridViewPrescriptions.AllowUserToAddRows = false;
            this.dataGridViewPrescriptions.AllowUserToDeleteRows = false;
            this.dataGridViewPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(30, 120);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.ReadOnly = true;
            this.dataGridViewPrescriptions.RowHeadersVisible = false;
            this.dataGridViewPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewPrescriptions.TabIndex = 3;
            this.dataGridViewPrescriptions.SelectionChanged += new System.EventHandler(this.dataGridViewPrescriptions_SelectionChanged);
            // 
            // dataGridViewMedications
            // 
            this.dataGridViewMedications.AllowUserToAddRows = false;
            this.dataGridViewMedications.AllowUserToDeleteRows = false;
            this.dataGridViewMedications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedications.Location = new System.Drawing.Point(30, 310);
            this.dataGridViewMedications.Name = "dataGridViewMedications";
            this.dataGridViewMedications.ReadOnly = true;
            this.dataGridViewMedications.RowHeadersVisible = false;
            this.dataGridViewMedications.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewMedications.TabIndex = 4;
            // 
            // labelMedicationDetails
            // 
            this.labelMedicationDetails.AutoSize = true;
            this.labelMedicationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMedicationDetails.Location = new System.Drawing.Point(30, 280);
            this.labelMedicationDetails.Name = "labelMedicationDetails";
            this.labelMedicationDetails.Size = new System.Drawing.Size(171, 25);
            this.labelMedicationDetails.TabIndex = 5;
            this.labelMedicationDetails.Text = "Medication Details:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.labelMedicationDetails);
            this.Controls.Add(this.dataGridViewMedications);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.labelUploadPrompt);
            this.Controls.Add(this.labelGreeting);
            this.Name = "MainForm";
            this.Text = "Prescription Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Label labelUploadPrompt;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.DataGridView dataGridViewMedications;
        private System.Windows.Forms.Label labelMedicationDetails;
    }
}
