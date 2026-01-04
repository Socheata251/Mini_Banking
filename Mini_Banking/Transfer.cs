using Mini_Banking;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class TransferForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int fromAccountID = 0;
        private int toAccountID = 0;

        public TransferForm()
        {
            InitializeComponent();
        }

        private void txtFromAccount_Leave(object sender, EventArgs e)
        {
            LoadAccountInfo(txtFromAccount.Text, lblFromAccountInfo, ref fromAccountID);
        }

        private void txtToAccount_Leave(object sender, EventArgs e)
        {
            LoadAccountInfo(txtToAccount.Text, lblToAccountInfo, ref toAccountID);
        }

        private void LoadAccountInfo(string accountNumber, Label displayLabel, ref int accountID)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(accountNumber))
                {
                    displayLabel.Text = "";
                    accountID = 0;
                    return;
                }

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@AccountNumber", accountNumber.Trim())
                };

                DataTable dt = db.ExecuteStoredProcedure("sp_GetAccountDetails", parameters);

                if (dt.Rows.Count > 0)
                {
                    accountID = Convert.ToInt32(dt.Rows[0]["AccountID"]);
                    string name = dt.Rows[0]["CustomerName"].ToString();
                    string balance = "$" + Convert.ToDecimal(dt.Rows[0]["Balance"]).ToString("N2");
                    string accountType = dt.Rows[0]["AccountType"].ToString();

                    displayLabel.Text = $"Account: {name} | Balance {balance}";
                    displayLabel.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    displayLabel.Text = "Account not found";
                    displayLabel.ForeColor = System.Drawing.Color.Red;
                    accountID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading account: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtFromAccount.Text) ||
                    string.IsNullOrWhiteSpace(txtToAccount.Text))
                {
                    MessageBox.Show("Please enter both account numbers!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtFromAccount.Text.Trim() == txtToAccount.Text.Trim())
                {
                    MessageBox.Show("Source and destination accounts cannot be the same!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (fromAccountID == 0 || toAccountID == 0)
                {
                    MessageBox.Show("Please enter valid account numbers!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal amount, fee = 0;
                if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter valid amount!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal.TryParse(txtFee.Text, out fee);

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@FromAccountID", fromAccountID),
                    new SqlParameter("@ToAccountID", toAccountID),
                    new SqlParameter("@Amount", amount + fee),
                    new SqlParameter("@Description", txtDescription.Text.Trim()),
                    new SqlParameter("@ProcessedBy", UserSession.UserID)
                };

                DataTable result = db.ExecuteStoredProcedure("sp_ProcessTransfer", parameters);

                if (result.Rows.Count > 0)
                {
                    string transactionNumber = result.Rows[0]["TransactionNumber"].ToString();

                    MessageBox.Show($"Transfer successful!\n\nTransaction Number: {transactionNumber}\nAmount Transferred: ${amount:N2}\nTransaction Fee: ${fee:N2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Insufficient balance"))
                {
                    MessageBox.Show("Insufficient balance in source account!", "Error",
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
            txtFromAccount.Clear();
            txtToAccount.Clear();
            txtAmount.Clear();
            txtFee.Clear();
            txtDescription.Clear();
            lblFromAccountInfo.Text = "";
            lblToAccountInfo.Text = "";
            fromAccountID = 0;
            toAccountID = 0;
            txtFromAccount.Focus();
        }
    }
}

// ============================================
// File: TransferForm.Designer.cs
// ============================================
