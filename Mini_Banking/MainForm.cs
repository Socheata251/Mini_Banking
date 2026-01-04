// ============================================
// File: MainForm.cs
// ============================================
using Mini_Banking;
using System;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateUserInfo();
        }

        private void UpdateUserInfo()
        {
            lblUserInfo.Text = $"Welcome, {UserSession.FullName} ({UserSession.Role})";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm();
            form.ShowDialog();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            WithdrawalForm form = new WithdrawalForm();
            form.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm form = new TransferForm();
            form.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.Clear();
                this.Close();
            }
        }
    }
}

// ============================================
// File: MainForm.Designer.cs
// ============================================
