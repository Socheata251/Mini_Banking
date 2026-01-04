// ============================================
// File: DepositForm.cs
// ============================================
using Mini_Banking;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class DepositForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int currentAccountID = 0;

        public DepositForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
                {
                    MessageBox.Show("Please enter account number!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@AccountNumber", txtAccountNumber.Text.Trim())
                };

                DataTable dt = db.ExecuteStoredProcedure("sp_GetAccountDetails", parameters);

                if (dt.Rows.Count > 0)
                {
                    currentAccountID = Convert.ToInt32(dt.Rows[0]["AccountID"]);
                    lblAccountHolder.Text = dt.Rows[0]["CustomerName"].ToString();
                    lblAccountType.Text = dt.Rows[0]["AccountType"].ToString();
                    lblAvailable.Text = "$" + Convert.ToDecimal(dt.Rows[0]["Balance"]).ToString("N2");

                    pnlAccountInfo.Visible = true;
                    txtAmount.Enabled = true;
                    txtDescription.Enabled = true;
                    btnProcess.Enabled = true;
                    txtAmount.Focus();
                }
                else
                {
                    MessageBox.Show("Account not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlAccountInfo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount;
                if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter valid amount!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@AccountID", currentAccountID),
                    new SqlParameter("@Amount", amount),
                    new SqlParameter("@Description", txtDescription.Text.Trim()),
                    new SqlParameter("@ProcessedBy", UserSession.UserID)
                };

                DataTable result = db.ExecuteStoredProcedure("sp_ProcessDeposit", parameters);

                if (result.Rows.Count > 0)
                {
                    string transactionNumber = result.Rows[0]["TransactionNumber"].ToString();
                    decimal newBalance = Convert.ToDecimal(result.Rows[0]["NewBalance"]);

                    MessageBox.Show($"Deposit successful!\n\nTransaction Number: {transactionNumber}\nNew Balance: ${newBalance:N2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing deposit: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtAccountNumber.Clear();
            txtAmount.Clear();
            txtDescription.Clear();
            pnlAccountInfo.Visible = false;
            btnProcess.Enabled = false;
            txtAmount.Enabled = false;
            txtDescription.Enabled = false;
            currentAccountID = 0;
            txtAccountNumber.Focus();
        }
    }
}

// ============================================
// File: DepositForm.Designer.cs
// ============================================
