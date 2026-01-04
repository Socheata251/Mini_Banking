namespace MiniBankingSystem
{
    partial class WithdrawalForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlAccountInfo;
        private System.Windows.Forms.Label lblAccountHolderLabel;
        private System.Windows.Forms.Label lblAccountHolderValue;
        private System.Windows.Forms.Label lblAccountTypeLabel;
        private System.Windows.Forms.Label lblAccountTypeValue;
        private System.Windows.Forms.Label lblAvailableBalanceLabel;
        private System.Windows.Forms.Label lblAvailableBalanceValue;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;



        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.pnlAccountInfo = new System.Windows.Forms.Panel();
            this.lblAvailableBalanceValue = new System.Windows.Forms.Label();
            this.lblAvailableBalanceLabel = new System.Windows.Forms.Label();
            this.lblAccountTypeValue = new System.Windows.Forms.Label();
            this.lblAccountTypeLabel = new System.Windows.Forms.Label();
            this.lblAccountHolderValue = new System.Windows.Forms.Label();
            this.lblAccountHolderLabel = new System.Windows.Forms.Label();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlAccountInfo.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.pbIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 120);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(358, 75);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(285, 20);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Withdraw funds from customer account";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pbIcon.Location = new System.Drawing.Point(405, 20);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 60);
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(310, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Process Withdrawal";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtAccountNumber);
            this.pnlSearch.Controls.Add(this.lblAccountNumber);
            this.pnlSearch.Location = new System.Drawing.Point(30, 140);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(840, 80);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(650, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAccountNumber.Location = new System.Drawing.Point(200, 27);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(420, 27);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.Location = new System.Drawing.Point(25, 30);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(134, 20);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // pnlAccountInfo
            // 
            this.pnlAccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccountInfo.Controls.Add(this.lblAvailableBalanceValue);
            this.pnlAccountInfo.Controls.Add(this.lblAvailableBalanceLabel);
            this.pnlAccountInfo.Controls.Add(this.lblAccountTypeValue);
            this.pnlAccountInfo.Controls.Add(this.lblAccountTypeLabel);
            this.pnlAccountInfo.Controls.Add(this.lblAccountHolderValue);
            this.pnlAccountInfo.Controls.Add(this.lblAccountHolderLabel);
            this.pnlAccountInfo.Location = new System.Drawing.Point(30, 240);
            this.pnlAccountInfo.Name = "pnlAccountInfo";
            this.pnlAccountInfo.Size = new System.Drawing.Size(840, 100);
            this.pnlAccountInfo.TabIndex = 2;
            this.pnlAccountInfo.Visible = false;
            // 
            // lblAvailableBalanceValue
            // 
            this.lblAvailableBalanceValue.AutoSize = true;
            this.lblAvailableBalanceValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvailableBalanceValue.Location = new System.Drawing.Point(615, 55);
            this.lblAvailableBalanceValue.Name = "lblAvailableBalanceValue";
            this.lblAvailableBalanceValue.Size = new System.Drawing.Size(58, 25);
            this.lblAvailableBalanceValue.TabIndex = 5;
            this.lblAvailableBalanceValue.Text = "$0.00";
            // 
            // lblAvailableBalanceLabel
            // 
            this.lblAvailableBalanceLabel.AutoSize = true;
            this.lblAvailableBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvailableBalanceLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblAvailableBalanceLabel.Location = new System.Drawing.Point(615, 25);
            this.lblAvailableBalanceLabel.Name = "lblAvailableBalanceLabel";
            this.lblAvailableBalanceLabel.Size = new System.Drawing.Size(122, 19);
            this.lblAvailableBalanceLabel.TabIndex = 4;
            this.lblAvailableBalanceLabel.Text = "Available Balance:";
            // 
            // lblAccountTypeValue
            // 
            this.lblAccountTypeValue.AutoSize = true;
            this.lblAccountTypeValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountTypeValue.Location = new System.Drawing.Point(330, 55);
            this.lblAccountTypeValue.Name = "lblAccountTypeValue";
            this.lblAccountTypeValue.Size = new System.Drawing.Size(16, 20);
            this.lblAccountTypeValue.TabIndex = 3;
            this.lblAccountTypeValue.Text = "-";
            // 
            // lblAccountTypeLabel
            // 
            this.lblAccountTypeLabel.AutoSize = true;
            this.lblAccountTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountTypeLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblAccountTypeLabel.Location = new System.Drawing.Point(330, 25);
            this.lblAccountTypeLabel.Name = "lblAccountTypeLabel";
            this.lblAccountTypeLabel.Size = new System.Drawing.Size(98, 19);
            this.lblAccountTypeLabel.TabIndex = 2;
            this.lblAccountTypeLabel.Text = "Account Type:";
            // 
            // lblAccountHolderValue
            // 
            this.lblAccountHolderValue.AutoSize = true;
            this.lblAccountHolderValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountHolderValue.Location = new System.Drawing.Point(25, 55);
            this.lblAccountHolderValue.Name = "lblAccountHolderValue";
            this.lblAccountHolderValue.Size = new System.Drawing.Size(16, 20);
            this.lblAccountHolderValue.TabIndex = 1;
            this.lblAccountHolderValue.Text = "-";
            // 
            // lblAccountHolderLabel
            // 
            this.lblAccountHolderLabel.AutoSize = true;
            this.lblAccountHolderLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountHolderLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblAccountHolderLabel.Location = new System.Drawing.Point(25, 25);
            this.lblAccountHolderLabel.Name = "lblAccountHolderLabel";
            this.lblAccountHolderLabel.Size = new System.Drawing.Size(110, 19);
            this.lblAccountHolderLabel.TabIndex = 0;
            this.lblAccountHolderLabel.Text = "Account Holder:";
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.BackColor = System.Drawing.Color.White;
            this.pnlTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransaction.Controls.Add(this.txtDescription);
            this.pnlTransaction.Controls.Add(this.lblDescription);
            this.pnlTransaction.Controls.Add(this.txtAmount);
            this.pnlTransaction.Controls.Add(this.lblAmount);
            this.pnlTransaction.Location = new System.Drawing.Point(30, 360);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(840, 150);
            this.pnlTransaction.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.Location = new System.Drawing.Point(200, 85);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(610, 45);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(25, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(200, 25);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 31);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(25, 30);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnProcess);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 530);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(900, 70);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(550, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(375, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnProcess.Enabled = false;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(200, 15);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(150, 40);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process Withdrawal";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // WithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTransaction);
            this.Controls.Add(this.pnlAccountInfo);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WithdrawalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal - Mini Banking System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlAccountInfo.ResumeLayout(false);
            this.pnlAccountInfo.PerformLayout();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
        }
    }
}