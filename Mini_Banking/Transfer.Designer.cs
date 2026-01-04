namespace MiniBankingSystem
{
    partial class TransferForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.PictureBox picIcon;
    private System.Windows.Forms.Label lblSubTitle;
    private System.Windows.Forms.Label lblSubDesc;
    private System.Windows.Forms.Label lblFromAccount;
    private System.Windows.Forms.TextBox txtFromAccount;
    private System.Windows.Forms.Label lblFromAccountInfo;
    private System.Windows.Forms.Label lblToAccount;
    private System.Windows.Forms.TextBox txtToAccount;
    private System.Windows.Forms.Label lblToAccountInfo;
    private System.Windows.Forms.Label lblTransferAmount;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.Label lblTransactionFee;
    private System.Windows.Forms.TextBox txtFee;
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
        this.lblFromAccount = new System.Windows.Forms.Label();
        this.txtFromAccount = new System.Windows.Forms.TextBox();
        this.lblFromAccountInfo = new System.Windows.Forms.Label();
        this.lblToAccount = new System.Windows.Forms.Label();
        this.txtToAccount = new System.Windows.Forms.TextBox();
        this.lblToAccountInfo = new System.Windows.Forms.Label();
        this.lblTransferAmount = new System.Windows.Forms.Label();
        this.txtAmount = new System.Windows.Forms.TextBox();
        this.lblTransactionFee = new System.Windows.Forms.Label();
        this.txtFee = new System.Windows.Forms.TextBox();
        this.lblDescription = new System.Windows.Forms.Label();
        this.txtDescription = new System.Windows.Forms.TextBox();
        this.btnProcess = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(950, 60);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(30, 12);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(122, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Transfer";
        // 
        // picIcon
        // 
        this.picIcon.BackColor = System.Drawing.Color.LightGray;
        this.picIcon.Location = new System.Drawing.Point(420, 80);
        this.picIcon.Name = "picIcon";
        this.picIcon.Size = new System.Drawing.Size(80, 80);
        this.picIcon.TabIndex = 1;
        this.picIcon.TabStop = false;
        // 
        // lblSubTitle
        // 
        this.lblSubTitle.AutoSize = true;
        this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblSubTitle.Location = new System.Drawing.Point(360, 175);
        this.lblSubTitle.Name = "lblSubTitle";
        this.lblSubTitle.Size = new System.Drawing.Size(166, 25);
        this.lblSubTitle.TabIndex = 2;
        this.lblSubTitle.Text = "Process Transfer";
        // 
        // lblSubDesc
        // 
        this.lblSubDesc.AutoSize = true;
        this.lblSubDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblSubDesc.Location = new System.Drawing.Point(330, 205);
        this.lblSubDesc.Name = "lblSubDesc";
        this.lblSubDesc.Size = new System.Drawing.Size(248, 19);
        this.lblSubDesc.TabIndex = 3;
        this.lblSubDesc.Text = "Transfer funds between two account";
        // 
        // lblFromAccount
        // 
        this.lblFromAccount.AutoSize = true;
        this.lblFromAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblFromAccount.Location = new System.Drawing.Point(40, 250);
        this.lblFromAccount.Name = "lblFromAccount";
        this.lblFromAccount.Size = new System.Drawing.Size(155, 19);
        this.lblFromAccount.TabIndex = 4;
        this.lblFromAccount.Text = "From Account Number";
        // 
        // txtFromAccount
        // 
        this.txtFromAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtFromAccount.Location = new System.Drawing.Point(40, 275);
        this.txtFromAccount.Name = "txtFromAccount";
        this.txtFromAccount.Size = new System.Drawing.Size(870, 25);
        this.txtFromAccount.TabIndex = 5;
        this.txtFromAccount.Leave += new System.EventHandler(this.txtFromAccount_Leave);
        // 
        // lblFromAccountInfo
        // 
        this.lblFromAccountInfo.AutoSize = true;
        this.lblFromAccountInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblFromAccountInfo.Location = new System.Drawing.Point(40, 305);
        this.lblFromAccountInfo.Name = "lblFromAccountInfo";
        this.lblFromAccountInfo.Size = new System.Drawing.Size(0, 15);
        this.lblFromAccountInfo.TabIndex = 6;
        // 
        // lblToAccount
        // 
        this.lblToAccount.AutoSize = true;
        this.lblToAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblToAccount.Location = new System.Drawing.Point(40, 340);
        this.lblToAccount.Name = "lblToAccount";
        this.lblToAccount.Size = new System.Drawing.Size(137, 19);
        this.lblToAccount.TabIndex = 7;
        this.lblToAccount.Text = "To account Number";
        // 
        // txtToAccount
        // 
        this.txtToAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtToAccount.Location = new System.Drawing.Point(40, 365);
        this.txtToAccount.Name = "txtToAccount";
        this.txtToAccount.Size = new System.Drawing.Size(870, 25);
        this.txtToAccount.TabIndex = 8;
        this.txtToAccount.Leave += new System.EventHandler(this.txtToAccount_Leave);
        // 
        // lblToAccountInfo
        // 
        this.lblToAccountInfo.AutoSize = true;
        this.lblToAccountInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblToAccountInfo.Location = new System.Drawing.Point(40, 395);
        this.lblToAccountInfo.Name = "lblToAccountInfo";
        this.lblToAccountInfo.Size = new System.Drawing.Size(0, 15);
        this.lblToAccountInfo.TabIndex = 9;
        // 
        // lblTransferAmount
        // 
        this.lblTransferAmount.AutoSize = true;
        this.lblTransferAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblTransferAmount.Location = new System.Drawing.Point(40, 430);
        this.lblTransferAmount.Name = "lblTransferAmount";
        this.lblTransferAmount.Size = new System.Drawing.Size(121, 19);
        this.lblTransferAmount.TabIndex = 10;
        this.lblTransferAmount.Text = "Transfer Amount";
        // 
        // txtAmount
        // 
        this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtAmount.Location = new System.Drawing.Point(40, 455);
        this.txtAmount.Name = "txtAmount";
        this.txtAmount.Size = new System.Drawing.Size(420, 25);
        this.txtAmount.TabIndex = 11;
        this.txtAmount.Text = "0.00";
        // 
        // lblTransactionFee
        // 
        this.lblTransactionFee.AutoSize = true;
        this.lblTransactionFee.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblTransactionFee.Location = new System.Drawing.Point(490, 430);
        this.lblTransactionFee.Name = "lblTransactionFee";
        this.lblTransactionFee.Size = new System.Drawing.Size(111, 19);
        this.lblTransactionFee.TabIndex = 12;
        this.lblTransactionFee.Text = "Transaction Fee";
        // 
        // txtFee
        // 
        this.txtFee.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtFee.Location = new System.Drawing.Point(490, 455);
        this.txtFee.Name = "txtFee";
        this.txtFee.Size = new System.Drawing.Size(420, 25);
        this.txtFee.TabIndex = 13;
        this.txtFee.Text = "0.00";
        // 
        // lblDescription
        // 
        this.lblDescription.AutoSize = true;
        this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblDescription.Location = new System.Drawing.Point(40, 500);
        this.lblDescription.Name = "lblDescription";
        this.lblDescription.Size = new System.Drawing.Size(145, 19);
        this.lblDescription.TabIndex = 14;
        this.lblDescription.Text = "Description (Optional)";
        // 
        // txtDescription
        // 
        this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtDescription.Location = new System.Drawing.Point(40, 525);
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(870, 25);
        this.txtDescription.TabIndex = 15;
        // 
        // btnProcess
        // 
        this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
        this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnProcess.ForeColor = System.Drawing.Color.White;
        this.btnProcess.Location = new System.Drawing.Point(40, 575);
        this.btnProcess.Name = "btnProcess";
        this.btnProcess.Size = new System.Drawing.Size(420, 45);
        this.btnProcess.TabIndex = 16;
        this.btnProcess.Text = "PROCESS TRANSFER";
        this.btnProcess.UseVisualStyleBackColor = false;
        this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
        // 
        // btnCancel
        // 
        this.btnCancel.BackColor = System.Drawing.Color.Red;
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnCancel.ForeColor = System.Drawing.Color.White;
        this.btnCancel.Location = new System.Drawing.Point(490, 575);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(420, 45);
        this.btnCancel.TabIndex = 17;
        this.btnCancel.Text = "CANCEL";
        this.btnCancel.UseVisualStyleBackColor = false;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // TransferForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(950, 650);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnProcess);
        this.Controls.Add(this.txtDescription);
        this.Controls.Add(this.lblDescription);
        this.Controls.Add(this.txtFee);
        this.Controls.Add(this.lblTransactionFee);
        this.Controls.Add(this.txtAmount);
        this.Controls.Add(this.lblTransferAmount);
        this.Controls.Add(this.lblToAccountInfo);
        this.Controls.Add(this.txtToAccount);
        this.Controls.Add(this.lblToAccount);
        this.Controls.Add(this.lblFromAccountInfo);
        this.Controls.Add(this.txtFromAccount);
        this.Controls.Add(this.lblFromAccount);
        this.Controls.Add(this.lblSubDesc);
        this.Controls.Add(this.lblSubTitle);
        this.Controls.Add(this.picIcon);
        this.Controls.Add(this.pnlHeader);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "TransferForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Transfer - Mini Banking System";
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
}