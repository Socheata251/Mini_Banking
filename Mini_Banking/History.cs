// ============================================
// File: HistoryForm.cs (FIXED VERSION)
// ============================================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBankingSystem
{
    public partial class HistoryForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public HistoryForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
            lblRecordCount.Text = "Total Records: 0";
        }

        private void InitializeDataGridView()
        {
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ReadOnly = true;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Columns.Clear();

            // Make sure column names match the stored procedure output
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransactionNumber",
                HeaderText = "Transaction #",
                Width = 180
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransactionType",
                HeaderText = "Type",
                Width = 100
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Amount",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransactionDate",
                HeaderText = "Date & Time",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "MM/dd/yyyy HH:mm:ss"
                }
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 250
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BalanceAfter",
                HeaderText = "Balance After",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
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

                // Get AccountID
                string query = "SELECT AccountID FROM Accounts WHERE AccountNumber = @AccountNumber";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@AccountNumber", txtAccountNumber.Text.Trim())
                };

                object accountID = db.ExecuteScalar(query, param);

                if (accountID == null)
                {
                    MessageBox.Show("Account not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvTransactions.DataSource = null;
                    lblRecordCount.Text = "Total Records: 0";
                    return;
                }

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@AccountID", accountID),
                    new SqlParameter("@StartDate", dtpStartDate.Value.Date),
                    new SqlParameter("@EndDate", dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1))
                };

                DataTable dt = db.ExecuteStoredProcedure("sp_GetTransactionHistory", parameters);
                dgvTransactions.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    lblRecordCount.Text = "Total Records: 0";
                    MessageBox.Show("No transactions found for the selected period.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblRecordCount.Text = $"Total Records: {dt.Rows.Count}";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database Error: " + sqlEx.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransactions.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("PDF export functionality requires additional libraries like iTextSharp or iText7.\n\n" +
                    "To implement:\n" +
                    "1. Install NuGet package: itext7\n" +
                    "2. Create PDF document\n" +
                    "3. Add table with transaction data\n" +
                    "4. Save to file",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sample code for PDF export (requires iText7):
                /*
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.FileName = $"TransactionHistory_{DateTime.Now:yyyyMMdd}.pdf";
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new PdfWriter(saveDialog.FileName))
                    using (var pdf = new PdfDocument(writer))
                    {
                        var document = new Document(pdf);
                        document.Add(new Paragraph("Transaction History Report"));
                        
                        var table = new Table(6);
                        // Add headers
                        table.AddHeaderCell("Transaction #");
                        table.AddHeaderCell("Type");
                        table.AddHeaderCell("Amount");
                        table.AddHeaderCell("Date & Time");
                        table.AddHeaderCell("Description");
                        table.AddHeaderCell("Balance After");
                        
                        // Add data
                        foreach (DataGridViewRow row in dgvTransactions.Rows)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                table.AddCell(row.Cells[i].Value?.ToString() ?? "");
                            }
                        }
                        
                        document.Add(table);
                        document.Close();
                    }
                    MessageBox.Show("PDF exported successfully!", "Success");
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransactions.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Excel export functionality requires additional libraries like EPPlus or ClosedXML.\n\n" +
                    "To implement:\n" +
                    "1. Install NuGet package: EPPlus or ClosedXML\n" +
                    "2. Create workbook and worksheet\n" +
                    "3. Fill with transaction data\n" +
                    "4. Save to file",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sample code for Excel export (requires EPPlus):
                /*
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FileName = $"TransactionHistory_{DateTime.Now:yyyyMMdd}.xlsx";
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Transactions");
                        
                        // Add headers
                        for (int i = 0; i < dgvTransactions.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvTransactions.Columns[i].HeaderText;
                        }
                        
                        // Add data
                        for (int i = 0; i < dgvTransactions.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvTransactions.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dgvTransactions.Rows[i].Cells[j].Value;
                            }
                        }
                        
                        package.SaveAs(new FileInfo(saveDialog.FileName));
                    }
                    MessageBox.Show("Excel exported successfully!", "Success");
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// ============================================
// File: HistoryForm.Designer.cs (FIXED VERSION)
// ============================================
