namespace Mini_Banking
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTBLogout = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTBDashboard = new Sunny.UI.UIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtbAccounts = new Sunny.UI.UIButton();
            this.BtbCustomers = new Sunny.UI.UIButton();
            this.BtbDeposit = new Sunny.UI.UIButton();
            this.BtbReport = new Sunny.UI.UIButton();
            this.BrbTransfer = new Sunny.UI.UIButton();
            this.BtbTransations = new Sunny.UI.UIButton();
            this.BtbWithdraw = new Sunny.UI.UIButton();
            this.BtbTT = new Sunny.UI.UIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtbBA = new Sunny.UI.UIButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtbTotal = new Sunny.UI.UIButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtbActive = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTBLogout);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 107);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.BtbReport);
            this.panel2.Controls.Add(this.BrbTransfer);
            this.panel2.Controls.Add(this.BtbTransations);
            this.panel2.Controls.Add(this.BtbWithdraw);
            this.panel2.Controls.Add(this.BtbDeposit);
            this.panel2.Controls.Add(this.BtbCustomers);
            this.panel2.Controls.Add(this.BtbAccounts);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BTBDashboard);
            this.panel2.Location = new System.Drawing.Point(4, -19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1068);
            this.panel2.TabIndex = 1;
            // 
            // BTBLogout
            // 
            this.BTBLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTBLogout.FillColor = System.Drawing.Color.Red;
            this.BTBLogout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTBLogout.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTBLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTBLogout.Location = new System.Drawing.Point(1060, 41);
            this.BTBLogout.MinimumSize = new System.Drawing.Size(1, 1);
            this.BTBLogout.Name = "BTBLogout";
            this.BTBLogout.Radius = 10;
            this.BTBLogout.RectColor = System.Drawing.Color.Red;
            this.BTBLogout.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTBLogout.RectPressColor = System.Drawing.Color.Maroon;
            this.BTBLogout.RectSelectedColor = System.Drawing.Color.Firebrick;
            this.BTBLogout.Size = new System.Drawing.Size(93, 38);
            this.BTBLogout.TabIndex = 0;
            this.BTBLogout.Text = "Logout";
            this.BTBLogout.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BTBLogout.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Administrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role: Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(284, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dashboard Overview";
            // 
            // BTBDashboard
            // 
            this.BTBDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTBDashboard.FillColor = System.Drawing.Color.DarkBlue;
            this.BTBDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTBDashboard.Location = new System.Drawing.Point(-7, 129);
            this.BTBDashboard.MinimumSize = new System.Drawing.Size(1, 1);
            this.BTBDashboard.Name = "BTBDashboard";
            this.BTBDashboard.RectColor = System.Drawing.Color.DarkBlue;
            this.BTBDashboard.Size = new System.Drawing.Size(251, 57);
            this.BTBDashboard.TabIndex = 0;
            this.BTBDashboard.Text = "Dashboard";
            this.BTBDashboard.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "MBAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Banking System";
            // 
            // BtbAccounts
            // 
            this.BtbAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbAccounts.FillColor = System.Drawing.Color.DarkBlue;
            this.BtbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbAccounts.Location = new System.Drawing.Point(0, 255);
            this.BtbAccounts.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbAccounts.Name = "BtbAccounts";
            this.BtbAccounts.RectColor = System.Drawing.Color.DarkBlue;
            this.BtbAccounts.Size = new System.Drawing.Size(251, 57);
            this.BtbAccounts.TabIndex = 4;
            this.BtbAccounts.Text = "Accounts";
            this.BtbAccounts.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BtbCustomers
            // 
            this.BtbCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbCustomers.FillColor = System.Drawing.Color.DarkBlue;
            this.BtbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbCustomers.Location = new System.Drawing.Point(0, 192);
            this.BtbCustomers.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbCustomers.Name = "BtbCustomers";
            this.BtbCustomers.RectColor = System.Drawing.Color.DarkBlue;
            this.BtbCustomers.Size = new System.Drawing.Size(251, 57);
            this.BtbCustomers.TabIndex = 5;
            this.BtbCustomers.Text = "Customers";
            this.BtbCustomers.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BtbDeposit
            // 
            this.BtbDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbDeposit.FillColor = System.Drawing.Color.DarkBlue;
            this.BtbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbDeposit.Location = new System.Drawing.Point(-6, 318);
            this.BtbDeposit.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbDeposit.Name = "BtbDeposit";
            this.BtbDeposit.RectColor = System.Drawing.Color.DarkBlue;
            this.BtbDeposit.Size = new System.Drawing.Size(251, 57);
            this.BtbDeposit.TabIndex = 6;
            this.BtbDeposit.Text = "Deposit";
            this.BtbDeposit.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BtbReport
            // 
            this.BtbReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbReport.FillColor = System.Drawing.Color.DarkBlue;
            this.BtbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbReport.Location = new System.Drawing.Point(-6, 570);
            this.BtbReport.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbReport.Name = "BtbReport";
            this.BtbReport.RectColor = System.Drawing.Color.DarkBlue;
            this.BtbReport.Size = new System.Drawing.Size(251, 57);
            this.BtbReport.TabIndex = 10;
            this.BtbReport.Text = "Report";
            this.BtbReport.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BrbTransfer
            // 
            this.BrbTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrbTransfer.FillColor = System.Drawing.Color.DarkBlue;
            this.BrbTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BrbTransfer.Location = new System.Drawing.Point(0, 444);
            this.BrbTransfer.MinimumSize = new System.Drawing.Size(1, 1);
            this.BrbTransfer.Name = "BrbTransfer";
            this.BrbTransfer.RectColor = System.Drawing.Color.DarkBlue;
            this.BrbTransfer.Size = new System.Drawing.Size(251, 57);
            this.BrbTransfer.TabIndex = 9;
            this.BrbTransfer.Text = "Transfer";
            this.BrbTransfer.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BtbTransations
            // 
            this.BtbTransations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbTransations.FillColor = System.Drawing.Color.DarkBlue;
            this.BtbTransations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbTransations.Location = new System.Drawing.Point(0, 507);
            this.BtbTransations.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbTransations.Name = "BtbTransations";
            this.BtbTransations.RectColor = System.Drawing.Color.DarkBlue;
            this.BtbTransations.Size = new System.Drawing.Size(251, 57);
            this.BtbTransations.TabIndex = 8;
            this.BtbTransations.Text = "Transations";
            this.BtbTransations.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BtbWithdraw
            // 
            this.BtbWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbWithdraw.FillColor = System.Drawing.Color.DarkBlue;
            this.BtbWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbWithdraw.Location = new System.Drawing.Point(-7, 381);
            this.BtbWithdraw.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbWithdraw.Name = "BtbWithdraw";
            this.BtbWithdraw.RectColor = System.Drawing.Color.DarkBlue;
            this.BtbWithdraw.Size = new System.Drawing.Size(251, 57);
            this.BtbWithdraw.TabIndex = 7;
            this.BtbWithdraw.Text = "Withdraw";
            this.BtbWithdraw.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // BtbTT
            // 
            this.BtbTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbTT.FillColor = System.Drawing.Color.White;
            this.BtbTT.FillColor2 = System.Drawing.Color.White;
            this.BtbTT.FillDisableColor = System.Drawing.Color.Silver;
            this.BtbTT.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.BtbTT.FillPressColor = System.Drawing.Color.DodgerBlue;
            this.BtbTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbTT.Location = new System.Drawing.Point(745, 391);
            this.BtbTT.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbTT.Name = "BtbTT";
            this.BtbTT.Radius = 15;
            this.BtbTT.RectPressColor = System.Drawing.Color.White;
            this.BtbTT.Size = new System.Drawing.Size(412, 154);
            this.BtbTT.TabIndex = 7;
            this.BtbTT.Text = "47";
            this.BtbTT.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(765, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total\'s Transactions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(774, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 37);
            this.label9.TabIndex = 10;
            this.label9.Text = "41";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(309, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "$2.5M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(312, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Balance";
            // 
            // BtbBA
            // 
            this.BtbBA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbBA.FillColor = System.Drawing.Color.White;
            this.BtbBA.FillColor2 = System.Drawing.Color.White;
            this.BtbBA.FillDisableColor = System.Drawing.Color.Silver;
            this.BtbBA.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.BtbBA.FillPressColor = System.Drawing.Color.DodgerBlue;
            this.BtbBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbBA.Location = new System.Drawing.Point(292, 391);
            this.BtbBA.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbBA.Name = "BtbBA";
            this.BtbBA.Radius = 15;
            this.BtbBA.RectPressColor = System.Drawing.Color.White;
            this.BtbBA.Size = new System.Drawing.Size(412, 154);
            this.BtbBA.TabIndex = 11;
            this.BtbBA.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(309, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "156";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(312, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total Customers";
            // 
            // BtbTotal
            // 
            this.BtbTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbTotal.FillColor = System.Drawing.Color.White;
            this.BtbTotal.FillColor2 = System.Drawing.Color.White;
            this.BtbTotal.FillDisableColor = System.Drawing.Color.Silver;
            this.BtbTotal.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.BtbTotal.FillPressColor = System.Drawing.Color.DodgerBlue;
            this.BtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbTotal.Location = new System.Drawing.Point(292, 202);
            this.BtbTotal.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbTotal.Name = "BtbTotal";
            this.BtbTotal.Radius = 15;
            this.BtbTotal.RectPressColor = System.Drawing.Color.White;
            this.BtbTotal.Size = new System.Drawing.Size(412, 154);
            this.BtbTotal.TabIndex = 17;
            this.BtbTotal.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(762, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 37);
            this.label12.TabIndex = 16;
            this.label12.Text = "243";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(765, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Active Acounts";
            // 
            // BtbActive
            // 
            this.BtbActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtbActive.FillColor = System.Drawing.Color.White;
            this.BtbActive.FillColor2 = System.Drawing.Color.White;
            this.BtbActive.FillDisableColor = System.Drawing.Color.Silver;
            this.BtbActive.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.BtbActive.FillPressColor = System.Drawing.Color.DodgerBlue;
            this.BtbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtbActive.Location = new System.Drawing.Point(745, 202);
            this.BtbActive.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtbActive.Name = "BtbActive";
            this.BtbActive.Radius = 15;
            this.BtbActive.RectPressColor = System.Drawing.Color.White;
            this.BtbActive.Size = new System.Drawing.Size(412, 154);
            this.BtbActive.TabIndex = 14;
            this.BtbActive.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1177, 952);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtbTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtbActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtbBA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtbTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "MBAS-Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton BTBLogout;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIButton BtbReport;
        private Sunny.UI.UIButton BrbTransfer;
        private Sunny.UI.UIButton BtbTransations;
        private Sunny.UI.UIButton BtbWithdraw;
        private Sunny.UI.UIButton BtbDeposit;
        private Sunny.UI.UIButton BtbCustomers;
        private Sunny.UI.UIButton BtbAccounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIButton BTBDashboard;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton BtbTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UIButton BtbBA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UIButton BtbTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Sunny.UI.UIButton BtbActive;
    }
}

