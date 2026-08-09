using System;
using System.Data;
using System.Drawing;
using System.IO;
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

        // Simulate loading prescription data
        private void LoadPrescriptionData()
        {
            DataTable prescriptionTable = new DataTable();
            prescriptionTable.Columns.Add("Prescription ID", typeof(int));
            prescriptionTable.Columns.Add("Status", typeof(string));
            prescriptionTable.Columns.Add("Date Uploaded", typeof(DateTime));
            prescriptionTable.Columns.Add("Prescription Image", typeof(Image));  // Add an image column

            // Sample prescriptions
            prescriptionTable.Rows.Add(1, "Issued", DateTime.Now.AddDays(-3), null);
            prescriptionTable.Rows.Add(2, "Not Issued", DateTime.Now.AddDays(-1), null);
            prescriptionTable.Rows.Add(3, "Issued", DateTime.Now, null);




            dataGridViewPrescriptions.DataSource = prescriptionTable;
        }

        // Load medication details for the selected prescription
        private void LoadMedicationDetails(int prescriptionId)
        {
            DataTable medicationTable = new DataTable();
            medicationTable.Columns.Add("Medicine Name", typeof(string));
            medicationTable.Columns.Add("Dosage", typeof(string));
            medicationTable.Columns.Add("Start Date", typeof(DateTime));
            medicationTable.Columns.Add("Stop Date", typeof(DateTime));
            medicationTable.Columns.Add("Expiry", typeof(DateTime));

            // Sample medication data based on Prescription ID
            if (prescriptionId == 1)
            {
                medicationTable.Rows.Add("Paracetamol", "500 mg", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5), DateTime.Now.AddMonths(6));
                medicationTable.Rows.Add("Ibuprofen", "200 mg", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5), DateTime.Now.AddMonths(12));
            }
            else if (prescriptionId == 3)
            {
                medicationTable.Rows.Add("Amoxicillin", "250 mg", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(7), DateTime.Now.AddMonths(3));
            }

            dataGridViewMedications.DataSource = medicationTable;
        }

        // Handle the prescription selection from the table
        private void dataGridViewPrescriptions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPrescriptions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPrescriptions.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value.ToString();

                if (status == "Issued")
                {
                    int prescriptionId = Convert.ToInt32(selectedRow.Cells["Prescription ID"].Value);
                    LoadMedicationDetails(prescriptionId);
                }
                else
                {
                    dataGridViewMedications.DataSource = null;
                }
            }
        }

        // Upload prescription and set the image in the table
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Prescription Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image uploadedImage = Image.FromFile(filePath);

                    MessageBox.Show($"File uploaded successfully: {filePath}", "Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Add new prescription to the list (initially "Not Issued")
                    var prescriptionTable = (DataTable)dataGridViewPrescriptions.DataSource;
                    prescriptionTable.Rows.Add(prescriptionTable.Rows.Count + 1, "Not Issued", DateTime.Now, uploadedImage);
                }
            }
        }
    }
}
