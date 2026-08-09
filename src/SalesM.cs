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
            LoadMedicineData();
        }

        // Simulate loading medicine data
        private void LoadMedicineData()
        {
            DataTable medicineTable = new DataTable();
            medicineTable.Columns.Add("Medicine Name", typeof(string));
            medicineTable.Columns.Add("Quantity", typeof(int));
            medicineTable.Columns.Add("Price", typeof(decimal));
            medicineTable.Columns.Add("Expiry", typeof(DateTime));

            // Sample medicine data
            medicineTable.Rows.Add("Paracetamol", 100, 10.5m, DateTime.Now.AddMonths(6));
            medicineTable.Rows.Add("Ibuprofen", 200, 15.0m, DateTime.Now.AddMonths(-1)); // Expired
            medicineTable.Rows.Add("Amoxicillin", 50, 12.5m, DateTime.Now.AddMonths(3));

            // Set the data source
            dataGridViewMedicines.DataSource = medicineTable;

            // Mark expired medicines in red
            MarkExpiredMedicines(medicineTable);
        }

        // Mark expired medicines in red
        private void MarkExpiredMedicines(DataTable medicineTable)
        {
            foreach (DataGridViewRow row in dataGridViewMedicines.Rows)
            {
                DateTime expiryDate = Convert.ToDateTime(row.Cells["Expiry"].Value);
                if (expiryDate < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Red; // Mark as expired
                }
            }
        }

        // Add new medicine to the table
        private void buttonAddMedicine_Click(object sender, EventArgs e)
        {
            string medicineName = textBoxMedicineName.Text;
            int quantity = (int)numericUpDownQuantity.Value;
            decimal price = numericUpDownPrice.Value;
            DateTime expiry = dateTimePickerExpiry.Value;

            if (string.IsNullOrEmpty(medicineName))
            {
                MessageBox.Show("Please enter a valid medicine name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the current data from the DataGridView
            var medicineTable = (DataTable)dataGridViewMedicines.DataSource;

            // Add the new medicine
            medicineTable.Rows.Add(medicineName, quantity, price, expiry);

            // Mark expired medicines in red
            MarkExpiredMedicines(medicineTable);

            MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Update selected medicine
        private void buttonUpdateMedicine_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMedicines.SelectedRows[0];

                string medicineName = textBoxMedicineName.Text;
                int quantity = (int)numericUpDownQuantity.Value;
                decimal price = numericUpDownPrice.Value;
                DateTime expiry = dateTimePickerExpiry.Value;

                if (string.IsNullOrEmpty(medicineName))
                {
                    MessageBox.Show("Please enter a valid medicine name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the selected row's details
                selectedRow.Cells["Medicine Name"].Value = medicineName;
                selectedRow.Cells["Quantity"].Value = quantity;
                selectedRow.Cells["Price"].Value = price;
                selectedRow.Cells["Expiry"].Value = expiry;

                // Recheck and mark expired medicines
                var medicineTable = (DataTable)dataGridViewMedicines.DataSource;
                MarkExpiredMedicines(medicineTable);

                MessageBox.Show("Medicine details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a medicine to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete selected medicine
        private void buttonDeleteMedicine_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMedicines.SelectedRows[0];
                dataGridViewMedicines.Rows.Remove(selectedRow);

                MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
