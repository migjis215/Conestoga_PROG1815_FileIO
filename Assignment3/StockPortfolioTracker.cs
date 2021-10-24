/*
 * Program ID: Assignment3
 * 
 * Purpose: Creating a form to store and manage input values in a text file
 * 
 * Revision History: 
 *      Jisung Kim, 2021.03.22: Created
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class StockPortfolioTracker : Form
    {
        public StockPortfolioTracker()
        {
            InitializeComponent();
        }

        string path;
        string fileName;
        string recordInput;
        string record;
        string tickerSymbol;
        string company;
        string type;
        string notes;

        DateTime transactionDate;

        int transactionIdInput;
        int transactionId;
        int shares;
        double sharePrice;
        double commission;
        double totalAssetValue = 0;
        double totalTransactionValue = 0;

        bool isUpdate = false;
        bool isDelete = false;

        StreamReader reader;
        StreamWriter writer;

        // Set the MaxDate to Now so that the transaction date cannot be in the future
        // Open an existing transaction record file, or create the file if it does not exist
        private void StockPortfolioTracker_Load(object sender, EventArgs e)
        {
            dateOfTransaction.MaxDate = DateTime.Now;
            btnCreateOpen_Click(sender, e);
        }

        // Open an existing transaction record file, or create the file if it does not exist
        private void btnCreateOpen_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtDisplay.Text = "";

            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                txtPath.Focus();
                txtMessages.Text = "Please enter the path and name of the file";
                return;
            }            

            if (File.Exists(txtPath.Text))
            {
                fileName = txtPath.Text;
                btnDisplay_Click(sender, e);
            }
            else
            {
                try
                {
                    path = Path.GetDirectoryName(txtPath.Text);
                    fileName = Path.GetFileName(txtPath.Text);

                    if (string.IsNullOrWhiteSpace(fileName))
                    {
                        txtPath.Focus();
                        txtMessages.Text = "Please enter the file name";
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                    }

                    File.Create(txtPath.Text).Dispose();
                }
                catch (Exception ex)
                {
                    txtMessages.Text = "Exception creating directory and file: " + ex.Message;
                }

                fileName = txtPath.Text;                
                txtMessages.Text = "A new file has been created";
            }
        }

        // Find the transaction ID number that is not already existed
        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            
            bool isNewId = false;
            int i;
            List<int> keys = new List<int>();

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        Parse();
                        keys.Add(transactionId);
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception making transaction ID list: " + ex.Message;
            }

            if ( keys.Count == 0)
            {
                txtTransactionId.Text = "1";
            }
            else
            {
                for (i = 1; i <= keys.Count; i++)
                {
                    if (i != keys[i - 1])
                    {
                        txtTransactionId.Text = i.ToString();
                        isNewId = true;
                        break;
                    }
                }

                if (!isNewId)
                {
                    txtTransactionId.Text = i.ToString();
                }
            }
        }

        // Save new records for new transaction ID or update records for existing ID
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtMessages.Text = CheckInputs();

            if (txtMessages.Text != "")
            {
                return;
            }

            recordInput = $"{txtTransactionId.Text}\t" +
                          $"{txtTickerSymbol.Text}\t" +
                          $"{txtCompany.Text}\t" +
                          $"{type}\t" +
                          $"{dateOfTransaction.Value}\t" +
                          $"{txtSharePrice.Text}\t" +
                          $"{txtNumberOfShares.Text}\t" +
                          $"{txtCommission.Text}\t" +
                          $"{totalAssetValue}\t" +
                          $"{totalTransactionValue}\t" +
                          $"{notes}";

            if (isUpdate)
            {
                DeleteRecord(transactionIdInput, fileName);
            }

            try
            {
                using (writer = new StreamWriter(fileName, append: true))
                {
                    writer.WriteLine(recordInput);

                    if (isUpdate)
                    {
                        txtMessages.Text = "The record has been updated";
                    }
                    else
                    {
                        txtMessages.Text = "A new record has been added";
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception writing a new record: " + ex.Message;                
            }

            SortRecords();
        }

        // Check that the values entered are in the correct form
        private string CheckInputs()
        {
            string errorMessages = "";

            // Transaction ID
            txtTransactionId.Text = (txtTransactionId.Text + "").Trim();

            if (string.IsNullOrWhiteSpace(txtTransactionId.Text))
            {
                if (errorMessages == "")
                {
                    txtTransactionId.Focus();
                }
                errorMessages += "Please enter the transaction ID\n";
            }
            else if (!int.TryParse(txtTransactionId.Text, out transactionIdInput))
            {
                if (errorMessages == "")
                {
                    txtTransactionId.SelectAll();
                    txtTransactionId.Focus();
                }
                errorMessages += "Transaction ID is not an integer\n";
            }
            else if (transactionIdInput <= 0)
            {
                if (errorMessages == "")
                {
                    txtTransactionId.SelectAll();
                    txtTransactionId.Focus();
                }
                errorMessages += "Transaction ID must be a number greater than zero\n";
            }
            else
            {
                isUpdate = CheckExistingRecord(transactionIdInput, fileName);
            }

            // Ticker Symbol
            txtTickerSymbol.Text = (txtTickerSymbol.Text + "").Trim();

            if (txtTickerSymbol.Text == "")
            {
                if (errorMessages == "")
                {
                    txtTickerSymbol.Focus();
                }
                errorMessages += "Please enter the ticker symbol\n";
            }

            // Company
            txtCompany.Text = (txtCompany.Text + "").Trim();

            if (txtCompany.Text == "")
            {
                if (errorMessages == "")
                {
                    txtCompany.Focus();
                }
                errorMessages += "Please enter the company name\n";
            }

            // Type
            if (radBuy.Checked)
            {
                type = "BUY";
            }
            else
            {
                type = "SELL";
            }

            // Date
            if (dateOfTransaction.Value > DateTime.Now)
            {
                if (errorMessages == "")
                {
                    dateOfTransaction.Focus();
                }
                errorMessages += "The date of transaction cannot be in the future";
            }

            // Notes
            txtNotes.Text = (txtNotes.Text + "").Trim();

            if (txtNotes.Text == "")
            {
                if (errorMessages == "")
                {
                    txtNotes.Focus();
                }
                errorMessages += "Please enter the notes\n";
            }
            else
            {
                notes = txtNotes.Text.Replace("\n", " ");
            }

            // Share Price
            txtSharePrice.Text = (txtSharePrice.Text + "").Trim();

            if (string.IsNullOrWhiteSpace(txtSharePrice.Text))
            {
                if (errorMessages == "")
                {
                    txtSharePrice.Focus();
                }
                errorMessages += "Please enter the share price\n";
            }
            else if (!double.TryParse(txtSharePrice.Text, out sharePrice))
            {
                if (errorMessages == "")
                {
                    txtSharePrice.SelectAll();
                    txtSharePrice.Focus();
                }
                errorMessages += "Transaction ID is not a number\n";
            }
            else if (sharePrice <= 0)
            {
                if (errorMessages == "")
                {
                    txtSharePrice.SelectAll();
                    txtSharePrice.Focus();
                }
                errorMessages += "Share price must be a number greater than zero\n";
            }

            // Shares
            txtNumberOfShares.Text = (txtNumberOfShares.Text + "").Trim();

            if (string.IsNullOrWhiteSpace(txtNumberOfShares.Text))
            {
                if (errorMessages == "")
                {
                    txtNumberOfShares.Focus();
                }
                errorMessages += "Please enter the numbrer of shares ID\n";
            }
            else if (!int.TryParse(txtNumberOfShares.Text, out shares))
            {
                if (errorMessages == "")
                {
                    txtNumberOfShares.SelectAll();
                    txtNumberOfShares.Focus();
                }
                errorMessages += "The number of shares is not an integer\n";
            }
            else if (shares <= 0)
            {
                if (errorMessages == "")
                {
                    txtTransactionId.SelectAll();
                    txtNumberOfShares.Focus();
                }
                errorMessages += "The number of shares must be a number greater than zero\n";
            }

            // Commission
            txtCommission.Text = (txtCommission.Text + "").Trim();

            if (string.IsNullOrWhiteSpace(txtCommission.Text))
            {
                if (errorMessages == "")
                {
                    txtCommission.Focus();
                }
                errorMessages += "Please enter the commission\n";
            }
            else if (!double.TryParse(txtCommission.Text, out commission))
            {
                if (errorMessages == "")
                {
                    txtCommission.SelectAll();
                    txtCommission.Focus();
                }
                errorMessages += "Commission is not a number\n";
            }
            else if (commission <= 0)
            {
                if (errorMessages == "")
                {
                    txtCommission.SelectAll();
                    txtCommission.Focus();
                }
                errorMessages += "Commission must be a number greater than zero\n";
            }

            // Total Asset Value
            if (sharePrice > 0 && shares > 0)
            {
                totalAssetValue = sharePrice * shares;
            }

            // Total Transaction Value
            if (commission > 0 && totalAssetValue > 0)
            {
                totalTransactionValue = totalAssetValue - commission;
            }

            return errorMessages;
        }

        // Check that the transaction ID is already sotred in the file
        private bool CheckExistingRecord(int keyValue, string filePath)
        {
            bool isExisting = false;

            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        Parse();

                        if (keyValue == transactionId)
                        {
                            isExisting = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception checking whether transaction ID exists: " + ex.Message;
            }

            return isExisting;
        }

        // Clear all contents of input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtTransactionId.Text = "";
            txtTickerSymbol.Text = "";
            txtCompany.Text = "";
            radBuy.Checked = true;
            dateOfTransaction.Value = DateTime.Today;
            txtNotes.Text = "";
            txtSharePrice.Text = "";
            txtNumberOfShares.Text = "";
            txtCommission.Text = "";
        }

        // Check that the transaction ID value the user want to delete is valid
        // Deletes a record with the same transactiong ID value as the entered transaction ID
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            
            if (string.IsNullOrWhiteSpace(txtTransactionIdToDelete.Text))
            {
                txtTransactionIdToDelete.Focus();
                txtMessages.Text = "Please enter the transaction ID to delete";
                return;
            }
            
            if (!int.TryParse(txtTransactionIdToDelete.Text, out transactionIdInput))
            {
                txtTransactionIdToDelete.SelectAll();
                txtTransactionIdToDelete.Focus();
                txtMessages.Text = "Transaction ID is not an integer";
                return;
            }

            if (transactionIdInput <= 0)
            {
                txtTransactionIdToDelete.SelectAll();
                txtMessages.Text = "Transaction ID must be a number greater than zero";
                return;
            }
            
            isDelete = CheckExistingRecord(transactionIdInput, fileName);
            
            if (!isDelete)
            {
                txtMessages.Text = "Record not found";
                return;
            }

            DeleteRecord(transactionIdInput, fileName);
            txtTransactionIdToDelete.Text = "";
        }

        // Deletes a record with the same transactiong ID value as the entered transaction ID
        private void DeleteRecord(int keyValue, string filePath)
        {
            List<string> records = new List<string>();

            try
            {
                using (reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        Parse();

                        if (keyValue != transactionId)
                        {
                            records.Add(record);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception deleting a record: " + ex.Message;
            }

            try
            {
                using (writer = new StreamWriter(filePath, append: false))
                {
                    foreach (var item in records)
                    {
                        writer.WriteLine(item);
                    }
                }

                txtMessages.Text = "The record has been deleted";
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception writing a record after deleting: " + ex.Message;
            }
        }

        // Sort by transaction ID
        private void SortRecords()
        {
            List<int> keys = new List<int>();
            List<string> records = new List<string>();

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        Parse();
                        keys.Add(transactionId);
                        records.Add(record);
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception making lists for sorting: " + ex.Message;
            }

            keys.Sort();

            try
            {
                using (writer = new StreamWriter(fileName, append: false))
                {
                    for (int i = 0; i < keys.Count; i++)
                    {
                        for (int j = 0; j < records.Count; j++)
                        {
                            if (keys[i].ToString() == records[j].Substring(0, records[j].IndexOf("\t")))
                            {
                                writer.WriteLine(records[j]);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception sorting records: " + ex.Message;
            }
        }

        // Displays all the contents of the current file along with the header
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtDisplay.Text = "";

            txtDisplay.Text = "TransactionID".PadRight(15).Substring(0, 15) +
                              "TickerSymbol".PadRight(15).Substring(0, 15) +
                              "Company".PadRight(15).Substring(0, 15) +
                              "Type".PadRight(15).Substring(0, 15) +
                              "Date".PadRight(15).Substring(0, 15) +
                              "SharePrice".PadRight(15).Substring(0, 15) +
                              "#Shares".PadRight(15).Substring(0, 15) +
                              "Commission".PadRight(15).Substring(0, 15) +
                              "TotalAssetValue".PadRight(18).Substring(0, 18) +
                              "TotalTransactionValue\n";

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        Parse();

                        txtDisplay.Text += transactionId.ToString().PadRight(15).Substring(0, 15) +
                                           tickerSymbol.PadRight(15).Substring(0, 15) +
                                           company.PadRight(15).Substring(0, 15) +
                                           type.PadRight(15).Substring(0, 15) +
                                           transactionDate.ToString("M'/'dd'/'yyyy").PadRight(15).Substring(0, 15) +
                                           sharePrice.ToString("c").PadRight(15).Substring(0, 15) +
                                           shares.ToString().PadRight(15).Substring(0, 15) +
                                           commission.ToString("c").PadRight(15).Substring(0, 15) +
                                           totalAssetValue.ToString("c").PadRight(18).Substring(0, 18) +
                                           totalTransactionValue.ToString("c") + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text = "Exception display records: " + ex.Message;
            }

            if (fileName != txtPath.Text)
            {
                txtMessages.Text = "Click the \"Create/Open file\" button " +
                                   "to create another file or change the path";
            }
        }

        // Change the contents of the input values to thge correct form
        private void Parse()
        {
            string[] fields = record.Split('\t');

            transactionId = Convert.ToInt32(fields[0]);
            tickerSymbol = fields[1].ToUpper();
            company = fields[2];
            type = fields[3];
            transactionDate = Convert.ToDateTime(fields[4]);
            sharePrice = Convert.ToDouble(fields[5]);
            shares = Convert.ToInt32(fields[6]);
            commission = Convert.ToDouble(fields[7]);
            totalAssetValue = Convert.ToDouble(fields[8]);
            totalTransactionValue = Convert.ToDouble(fields[9]);
        }

        // Clear all contents of the file
        private void btnEmptyFile_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";

            string answer = MessageBox.Show("Are you sure you want to delete all records?", 
                                            "Delete All Records", 
                                            MessageBoxButtons.OKCancel, 
                                            MessageBoxIcon.Warning).ToString();

            if (answer == "OK")
            {
                using (writer = new StreamWriter(fileName, append: false))
                {
                    writer.Write("");
                }

                txtMessages.Text = "All records have been deleted";
            }
        }

        // Exit the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
