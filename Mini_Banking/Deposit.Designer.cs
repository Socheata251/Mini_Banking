namespace MiniBankingSystem
{
    partial class DepositForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblSubDesc;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox pnlAccountInfo;
        private System.Windows.Forms.Label lblAccountHolderLabel;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Label lblAccountTypeLabel;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblAvailableLabel;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblWithdrawalAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblSubDesc = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlAccountInfo = new System.Windows.Forms.GroupBox();
            this.lblAccountHolderLabel = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblAccountTypeLabel = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblAvailableLabel = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblWithdrawalAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Deposit";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.LightGray;
            this.picIcon.Location = new System.Drawing.Point(395, 90);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(80, 80);
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.Location = new System.Drawing.Point(340, 185);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(168, 25);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Process Deposit";
            // 
            // lblSubDesc
            // 
            this.lblSubDesc.AutoSize = true;
            this.lblSubDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubDesc.Location = new System.Drawing.Point(320, 215);
            this.lblSubDesc.Name = "lblSubDesc";
            this.lblSubDesc.Size = new System.Drawing.Size(223, 19);
            this.lblSubDesc.TabIndex = 3;
            this.lblSubDesc.Text = "Add funds to customer account";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountNumber.Location = new System.Drawing.Point(60, 260);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(125, 19);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountNumber.Location = new System.Drawing.Point(60, 285);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(600, 25);
            this.txtAccountNumber.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(680, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlAccountInfo
            // 
            this.pnlAccountInfo.Controls.Add(this.lblAccountHolderLabel);
            this.pnlAccountInfo.Controls.Add(this.lblAccountHolder);
            this.pnlAccountInfo.Controls.Add(this.lblAccountTypeLabel);
            this.pnlAccountInfo.Controls.Add(this.lblAccountType);
            this.pnlAccountInfo.Controls.Add(this.lblAvailableLabel);
            this.pnlAccountInfo.Controls.Add(this.lblAvailable);
            this.pnlAccountInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pnlAccountInfo.Location = new System.Drawing.Point(60, 330);
            this.pnlAccountInfo.Name = "pnlAccountInfo";
            this.pnlAccountInfo.Size = new System.Drawing.Size(780, 110);
            this.pnlAccountInfo.TabIndex = 7;
            this.pnlAccountInfo.TabStop = false;
            this.pnlAccountInfo.Text = "Check";
            this.pnlAccountInfo.Visible = false;
            // 
            // lblAccountHolderLabel
            // 
            this.lblAccountHolderLabel.AutoSize = true;
            this.lblAccountHolderLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountHolderLabel.Location = new System.Drawing.Point(20, 30);
            this.lblAccountHolderLabel.Name = "lblAccountHolderLabel";
            this.lblAccountHolderLabel.Size = new System.Drawing.Size(115, 19);
            this.lblAccountHolderLabel.TabIndex = 0;
            this.lblAccountHolderLabel.Text = "Account Holder:";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountHolder.Location = new System.Drawing.Point(650, 30);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(0, 19);
            this.lblAccountHolder.TabIndex = 1;
            this.lblAccountHolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountTypeLabel
            // 
            this.lblAccountTypeLabel.AutoSize = true;
            this.lblAccountTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountTypeLabel.Location = new System.Drawing.Point(20, 55);
            this.lblAccountTypeLabel.Name = "lblAccountTypeLabel";
            this.lblAccountTypeLabel.Size = new System.Drawing.Size(101, 19);
            this.lblAccountTypeLabel.TabIndex = 2;
            this.lblAccountTypeLabel.Text = "Account Type:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccountType.Location = new System.Drawing.Point(650, 55);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(0, 19);
            this.lblAccountType.TabIndex = 3;
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailableLabel
            // 
            this.lblAvailableLabel.AutoSize = true;
            this.lblAvailableLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvailableLabel.Location = new System.Drawing.Point(20, 80);
            this.lblAvailableLabel.Name = "lblAvailableLabel";
            this.lblAvailableLabel.Size = new System.Drawing.Size(70, 19);
            this.lblAvailableLabel.TabIndex = 4;
            this.lblAvailableLabel.Text = "Available:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvailable.Location = new System.Drawing.Point(650, 80);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(0, 19);
            this.lblAvailable.TabIndex = 5;
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWithdrawalAmount
            // 
            this.lblWithdrawalAmount.AutoSize = true;
            this.lblWithdrawalAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWithdrawalAmount.Location = new System.Drawing.Point(60, 460);
            this.lblWithdrawalAmount.Name = "lblWithdrawalAmount";
            this.lblWithdrawalAmount.Size = new System.Drawing.Size(134, 19);
            this.lblWithdrawalAmount.TabIndex = 8;
            this.lblWithdrawalAmount.Text = "Withdrawal Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAmount.Location = new System.Drawing.Point(60, 485);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(780, 25);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "0.00";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(60, 530);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 19);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description (Optional)";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(60, 555);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(780, 25);
            this.txtDescription.TabIndex = 11;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Red;
            this.btnProcess.Enabled = false;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(60, 605);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(380, 45);
            this.btnProcess.TabIndex = 12;
            this.btnProcess.Text = "PROCESS WITHDRAWAL";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(460, 605);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(380, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblWithdrawalAmount);
            this.Controls.Add(this.pnlAccountInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblSubDesc);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit - Mini Banking System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlAccountInfo.ResumeLayout(false);
            this.pnlAccountInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}