using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginRegistrationForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadPrescriptionData();
        }

        // Load the prescription data into the table
        private void LoadPrescriptionData()
        {
            DataTable prescriptionTable = new DataTable();
            prescriptionTable.Columns.Add("Prescription ID", typeof(string));
            prescriptionTable.Columns.Add("Status", typeof(string));
            prescriptionTable.Columns.Add("Photo Path", typeof(string)); // Hidden column for image path

            // Sample prescriptions
            prescriptionTable.Rows.Add("P001", "Not Issued", "C:\\Prescriptions\\P001.jpg");
            prescriptionTable.Rows.Add("P002", "Not Issued", "C:\\Prescriptions\\P002.jpg");
            prescriptionTable.Rows.Add("P003", "Issued", "C:\\Prescriptions\\P003.jpg");

            dataGridViewPrescriptions.DataSource = prescriptionTable;

            // Configure DataGridView appearance
            dataGridViewPrescriptions.Columns["Photo Path"].Visible = false; // Hide path column
            dataGridViewPrescriptions.SelectionChanged += dataGridViewPrescriptions_SelectionChanged;
        }

        // Handle selection change in prescription table
        private void dataGridViewPrescriptions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPrescriptions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPrescriptions.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value.ToString();
                buttonMarkIssued.Enabled = status == "Not Issued";
            }
        }

        // Mark the selected prescription as issued
        private void buttonMarkIssued_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrescriptions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPrescriptions.SelectedRows[0];
                string prescriptionId = selectedRow.Cells["Prescription ID"].Value.ToString();

                // Validate medication details
                string medicineName = textBoxMedicineName.Text.Trim();
                string dosage = textBoxDosage.Text.Trim();
                DateTime startDate = dateTimePickerStartDate.Value;
                DateTime stopDate = dateTimePickerStopDate.Value;
                DateTime expiryDate = dateTimePickerExpiryDate.Value;

                if (string.IsNullOrWhiteSpace(medicineName) || string.IsNullOrWhiteSpace(dosage))
                {
                    MessageBox.Show("Please fill out all medication details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update prescription status and save medication details
                selectedRow.Cells["Status"].Value = "Issued";
                MessageBox.Show($"Prescription {prescriptionId} marked as Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after marking issued
                textBoxMedicineName.Clear();
                textBoxDosage.Clear();
                dateTimePickerStartDate.Value = DateTime.Now;
                dateTimePickerStopDate.Value = DateTime.Now;
                dateTimePickerExpiryDate.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Please select a prescription to issue.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
