// ============================================
// File: WithdrawalForm.cs
// ============================================
using Mini_Banking;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class WithdrawalForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int currentAccountID = 0;

        public WithdrawalForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Disable search button during operation
            btnSearch.Enabled = false;
            btnSearch.Text = "Searching...";
            Cursor = Cursors.WaitCursor;

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
                    lblAccountHolderValue.Text = dt.Rows[0]["CustomerName"].ToString();
                    lblAccountTypeValue.Text = dt.Rows[0]["AccountType"].ToString();
                    lblAvailableBalanceValue.Text = "$" + Convert.ToDecimal(dt.Rows[0]["Balance"]).ToString("N2");

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
                    txtAmount.Enabled = false;
                    txtDescription.Enabled = false;
                    btnProcess.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSearch.Enabled = true;
                btnSearch.Text = "Search";
                Cursor = Cursors.Default;
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

                // Confirm withdrawal
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to withdraw ${amount:N2}?",
                    "Confirm Withdrawal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@AccountID", currentAccountID),
                    new SqlParameter("@Amount", amount),
                    new SqlParameter("@Description", txtDescription.Text.Trim()),
                    new SqlParameter("@ProcessedBy", UserSession.UserID)
                };

                DataTable resultData = db.ExecuteStoredProcedure("sp_ProcessWithdrawal", parameters);

                if (resultData.Rows.Count > 0)
                {
                    string transactionNumber = resultData.Rows[0]["TransactionNumber"].ToString();
                    decimal newBalance = Convert.ToDecimal(resultData.Rows[0]["NewBalance"]);

                    MessageBox.Show($"Withdrawal successful!\n\n" +
                        $"Transaction Number: {transactionNumber}\n" +
                        $"Amount Withdrawn: ${amount:N2}\n" +
                        $"New Balance: ${newBalance:N2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Insufficient balance"))
                {
                    MessageBox.Show("Insufficient balance for this withdrawal!", "Error",
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
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
            lblAccountHolderValue.Text = "-";
            lblAccountTypeValue.Text = "-";
            lblAvailableBalanceValue.Text = "$0.00";
            pnlAccountInfo.Visible = false;
            btnProcess.Enabled = false;
            txtAmount.Enabled = false;
            txtDescription.Enabled = false;
            currentAccountID = 0;
            txtAccountNumber.Focus();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, decimal point, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}

// ============================================
// File: WithdrawalForm.Designer.cs
// ============================================
