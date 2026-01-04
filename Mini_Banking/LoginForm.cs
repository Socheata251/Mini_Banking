// ============================================
// File: LoginForm.cs
// ============================================
using Mini_Banking;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter username and password!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Simple hash for demo - use proper hashing in production
                string passwordHash = txtPassword.Text; // Replace with actual hash

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", txtUsername.Text.Trim()),
                    new SqlParameter("@PasswordHash", passwordHash)
                };

                DataTable dt = db.ExecuteStoredProcedure("sp_AuthenticateUser", parameters);

                if (dt.Rows.Count > 0)
                {
                    UserSession.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    UserSession.Username = dt.Rows[0]["Username"].ToString();
                    UserSession.FullName = dt.Rows[0]["FullName"].ToString();
                    UserSession.Role = dt.Rows[0]["Role"].ToString();

                    MessageBox.Show($"Welcome {UserSession.FullName}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

// ============================================
// File: LoginForm.Designer.cs
// ============================================

