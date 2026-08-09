using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LoginRegistrationForm
{
    public partial class MainForm : Form
    {
        private List<string> pharmacists;
        private List<string> salesManagers;

        public MainForm()
        {
            InitializeComponent();
            pharmacists = new List<string>(); // List of pharmacists
            salesManagers = new List<string>(); // List of sales managers

            // For demonstration purposes, we'll add some sample data
            pharmacists.Add("John Doe");
            salesManagers.Add("Jane Smith");

            // Load data into UI
            UpdateCounts();
        }

        // Method to update the count of pharmacists and sales managers
        private void UpdateCounts()
        {
            labelPharmacistsCount.Text = pharmacists.Count.ToString();
            labelSalesManagersCount.Text = salesManagers.Count.ToString();
        }

        // Add Pharmacist button click event
        private void buttonAddPharmacist_Click(object sender, EventArgs e)
        {
            string pharmacistName = textBoxPharmacistName.Text;
            if (string.IsNullOrEmpty(pharmacistName))
            {
                MessageBox.Show("Please enter a valid name for the pharmacist.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new pharmacist to the list
            pharmacists.Add(pharmacistName);

            // Update the counts
            UpdateCounts();

            // Clear the input field
            textBoxPharmacistName.Clear();

            MessageBox.Show("Pharmacist added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Add Sales Manager button click event
        private void buttonAddSalesManager_Click(object sender, EventArgs e)
        {
            string salesManagerName = textBoxSalesManagerName.Text;
            if (string.IsNullOrEmpty(salesManagerName))
            {
                MessageBox.Show("Please enter a valid name for the sales manager.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new sales manager to the list
            salesManagers.Add(salesManagerName);

            // Update the counts
            UpdateCounts();

            // Clear the input field
            textBoxSalesManagerName.Clear();

            MessageBox.Show("Sales Manager added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
