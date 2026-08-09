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
            this.dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            this.buttonAddMedicine = new System.Windows.Forms.Button();
            this.buttonUpdateMedicine = new System.Windows.Forms.Button();
            this.buttonDeleteMedicine = new System.Windows.Forms.Button();
            this.textBoxMedicineName = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.labelMedicineName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelExpiry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedicines
            // 
            this.dataGridViewMedicines.AllowUserToAddRows = false;
            this.dataGridViewMedicines.AllowUserToDeleteRows = false;
            this.dataGridViewMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicines.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMedicines.Name = "dataGridViewMedicines";
            this.dataGridViewMedicines.ReadOnly = true;
            this.dataGridViewMedicines.RowHeadersVisible = false;
            this.dataGridViewMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicines.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewMedicines.TabIndex = 0;
            // 
            // buttonAddMedicine
            // 
            this.buttonAddMedicine.Location = new System.Drawing.Point(12, 400);
            this.buttonAddMedicine.Name = "buttonAddMedicine";
            this.buttonAddMedicine.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMedicine.TabIndex = 1;
            this.buttonAddMedicine.Text = "Add";
            this.buttonAddMedicine.UseVisualStyleBackColor = true;
            this.buttonAddMedicine.Click += new System.EventHandler(this.buttonAddMedicine_Click);
            // 
            // buttonUpdateMedicine
            // 
            this.buttonUpdateMedicine.Location = new System.Drawing.Point(93, 400);
            this.buttonUpdateMedicine.Name = "buttonUpdateMedicine";
            this.buttonUpdateMedicine.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMedicine.TabIndex = 2;
            this.buttonUpdateMedicine.Text = "Update";
            this.buttonUpdateMedicine.UseVisualStyleBackColor = true;
            this.buttonUpdateMedicine.Click += new System.EventHandler(this.buttonUpdateMedicine_Click);
            // 
            // buttonDeleteMedicine
            // 
            this.buttonDeleteMedicine.Location = new System.Drawing.Point(174, 400);
            this.buttonDeleteMedicine.Name = "buttonDeleteMedicine";
            this.buttonDeleteMedicine.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMedicine.TabIndex = 3;
            this.buttonDeleteMedicine.Text = "Delete";
            this.buttonDeleteMedicine.UseVisualStyleBackColor = true;
            this.buttonDeleteMedicine.Click += new System.EventHandler(this.buttonDeleteMedicine_Click);
            // 
            // textBoxMedicineName
            // 
            this.textBoxMedicineName.Location = new System.Drawing.Point(137, 170);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(200, 20);
            this.textBoxMedicineName.TabIndex = 4;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(137, 200);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownQuantity.TabIndex = 5;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(137, 230);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPrice.TabIndex = 6;
            // 
            // dateTimePickerExpiry
            // 
            this.dateTimePickerExpiry.Location = new System.Drawing.Point(137, 260);
            this.dateTimePickerExpiry.Name = "dateTimePickerExpiry";
            this.dateTimePickerExpiry.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerExpiry.TabIndex = 7;
            // 
            // labelMedicineName
            // 
            this.labelMedicineName.AutoSize = true;
            this.labelMedicineName.Location = new System.Drawing.Point(12, 170);
            this.labelMedicineName.Name = "labelMedicineName";
            this.labelMedicineName.Size = new System.Drawing.Size(87, 13);
            this.labelMedicineName.TabIndex = 8;
            this.labelMedicineName.Text = "Medicine Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 200);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(50, 13);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 230);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Price:";
            // 
            // labelExpiry
            // 
            this.labelExpiry.AutoSize = true;
            this.labelExpiry.Location = new System.Drawing.Point(12, 260);
            this.labelExpiry.Name = "labelExpiry";
            this.labelExpiry.Size = new System.Drawing.Size(38, 13);
            this.labelExpiry.TabIndex = 11;
            this.labelExpiry.Text = "Expiry:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.labelExpiry);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelMedicineName);
            this.Controls.Add(this.dateTimePickerExpiry);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.textBoxMedicineName);
            this.Controls.Add(this.buttonDeleteMedicine);
            this.Controls.Add(this.buttonUpdateMedicine);
            this.Controls.Add(this.buttonAddMedicine);
            this.Controls.Add(this.dataGridViewMedicines);
            this.Name = "MainForm";
            this.Text = "Sales Manager - Medicine Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Button buttonAddMedicine;
        private System.Windows.Forms.Button buttonUpdateMedicine;
        private System.Windows.Forms.Button buttonDeleteMedicine;
        private System.Windows.Forms.TextBox textBoxMedicineName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiry;
        private System.Windows.Forms.Label labelMedicineName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelExpiry;
    }
}
