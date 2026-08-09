using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS 10\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();

            // Populate the ComboBox with roles
            comboBox1.Items.Add("Customer");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Pharmacist");
            comboBox1.Items.Add("Sales Manager");

            // Optionally, set a default selected index
            comboBox1.SelectedIndex = 0;
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND passowrd = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged in successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected role
            string selectedRole = comboBox1.SelectedItem.ToString();

            // Example: Display the selected role in a message box
            MessageBox.Show($"You selected: {selectedRole}", "Role Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Perform role-specific actions here
            switch (selectedRole)
            {
                case "Customer":
                    // Actions for Customer
                    break;

                case "Admin":
                    // Actions for Admin
                    break;

                case "Pharmacist":
                    // Actions for Pharmacist
                    break;

                case "Sales Manager":
                    // Actions for Sales Manager
                    break;

                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click events if needed
        }
    }
}
