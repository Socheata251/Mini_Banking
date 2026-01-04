// ============================================
// File: CustomerForm.cs
// ============================================
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class CustomerForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public CustomerForm()
        {
            InitializeComponent();
            LoadGenderComboBox();
        }

        private void LoadGenderComboBox()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Select Gender");
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtNationalID.Text) ||
                    cmbGender.SelectedIndex == 0)
                {
                    MessageBox.Show("Please fill all required fields (marked with *)!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert customer
                string query = @"INSERT INTO Customers 
                    (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, Email, Address, NationalID, CreatedBy)
                    VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @PhoneNumber, @Email, @Address, @NationalID, @CreatedBy)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@FirstName", txtFirstName.Text.Trim()),
                    new SqlParameter("@LastName", txtLastName.Text.Trim()),
                    new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value),
                    new SqlParameter("@Gender", cmbGender.SelectedItem.ToString()),
                    new SqlParameter("@PhoneNumber", txtPhoneNumber.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@NationalID", txtNationalID.Text.Trim()),
                   // new SqlParameter("@CreatedBy", UserSession.UserID)
                };

                int result = db.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Customer registered successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("National ID already exists in the system!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtNationalID.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = 0;
            dtpDateOfBirth.Value = DateTime.Now;
            txtFirstName.Focus();
        }
    }
}

// ============================================
// File: CustomerForm.Designer.cs
// ============================================
