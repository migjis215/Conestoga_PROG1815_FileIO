
namespace Assignment3
{
    partial class StockPortfolioTracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnCreateOpen = new System.Windows.Forms.Button();
            this.grpAddUpdate = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtNumberOfShares = new System.Windows.Forms.TextBox();
            this.txtSharePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.dateOfTransaction = new System.Windows.Forms.DateTimePicker();
            this.radSell = new System.Windows.Forms.RadioButton();
            this.radBuy = new System.Windows.Forms.RadioButton();
            this.btnGetNewId = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtTickerSymbol = new System.Windows.Forms.TextBox();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTransactionIdToDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpAddUpdate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name and path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(50, 61);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(759, 31);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "c:\\JisungKim\\assignment3\\transactions.txt";
            // 
            // btnCreateOpen
            // 
            this.btnCreateOpen.Location = new System.Drawing.Point(830, 57);
            this.btnCreateOpen.Name = "btnCreateOpen";
            this.btnCreateOpen.Size = new System.Drawing.Size(220, 45);
            this.btnCreateOpen.TabIndex = 2;
            this.btnCreateOpen.Text = "Create/Open file";
            this.btnCreateOpen.UseVisualStyleBackColor = true;
            this.btnCreateOpen.Click += new System.EventHandler(this.btnCreateOpen_Click);
            // 
            // grpAddUpdate
            // 
            this.grpAddUpdate.Controls.Add(this.btnClear);
            this.grpAddUpdate.Controls.Add(this.btnAddUpdate);
            this.grpAddUpdate.Controls.Add(this.txtCommission);
            this.grpAddUpdate.Controls.Add(this.txtNumberOfShares);
            this.grpAddUpdate.Controls.Add(this.txtSharePrice);
            this.grpAddUpdate.Controls.Add(this.label8);
            this.grpAddUpdate.Controls.Add(this.label9);
            this.grpAddUpdate.Controls.Add(this.label10);
            this.grpAddUpdate.Controls.Add(this.txtNotes);
            this.grpAddUpdate.Controls.Add(this.dateOfTransaction);
            this.grpAddUpdate.Controls.Add(this.radSell);
            this.grpAddUpdate.Controls.Add(this.radBuy);
            this.grpAddUpdate.Controls.Add(this.btnGetNewId);
            this.grpAddUpdate.Controls.Add(this.txtCompany);
            this.grpAddUpdate.Controls.Add(this.txtTickerSymbol);
            this.grpAddUpdate.Controls.Add(this.txtTransactionId);
            this.grpAddUpdate.Controls.Add(this.label7);
            this.grpAddUpdate.Controls.Add(this.label6);
            this.grpAddUpdate.Controls.Add(this.label5);
            this.grpAddUpdate.Controls.Add(this.label4);
            this.grpAddUpdate.Controls.Add(this.label3);
            this.grpAddUpdate.Controls.Add(this.label2);
            this.grpAddUpdate.Location = new System.Drawing.Point(50, 123);
            this.grpAddUpdate.Name = "grpAddUpdate";
            this.grpAddUpdate.Size = new System.Drawing.Size(626, 809);
            this.grpAddUpdate.TabIndex = 3;
            this.grpAddUpdate.TabStop = false;
            this.grpAddUpdate.Text = " Add/Update transaction ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 722);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 45);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(212, 722);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnAddUpdate.TabIndex = 20;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(212, 657);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(180, 31);
            this.txtCommission.TabIndex = 19;
            // 
            // txtNumberOfShares
            // 
            this.txtNumberOfShares.Location = new System.Drawing.Point(212, 600);
            this.txtNumberOfShares.Name = "txtNumberOfShares";
            this.txtNumberOfShares.Size = new System.Drawing.Size(180, 31);
            this.txtNumberOfShares.TabIndex = 17;
            // 
            // txtSharePrice
            // 
            this.txtSharePrice.Location = new System.Drawing.Point(212, 543);
            this.txtSharePrice.Name = "txtSharePrice";
            this.txtSharePrice.Size = new System.Drawing.Size(180, 31);
            this.txtSharePrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 543);
            this.label8.MinimumSize = new System.Drawing.Size(200, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Share price:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 600);
            this.label9.MinimumSize = new System.Drawing.Size(200, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "# of shares:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 657);
            this.label10.MinimumSize = new System.Drawing.Size(200, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Commission:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(212, 346);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(381, 167);
            this.txtNotes.TabIndex = 13;
            this.txtNotes.Text = "";
            // 
            // dateOfTransaction
            // 
            this.dateOfTransaction.CustomFormat = "  dddd, MMM dd, yyyy";
            this.dateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfTransaction.Location = new System.Drawing.Point(212, 288);
            this.dateOfTransaction.Name = "dateOfTransaction";
            this.dateOfTransaction.Size = new System.Drawing.Size(381, 31);
            this.dateOfTransaction.TabIndex = 11;
            // 
            // radSell
            // 
            this.radSell.AutoSize = true;
            this.radSell.Location = new System.Drawing.Point(413, 233);
            this.radSell.Name = "radSell";
            this.radSell.Size = new System.Drawing.Size(85, 29);
            this.radSell.TabIndex = 9;
            this.radSell.Text = " Sell";
            this.radSell.UseVisualStyleBackColor = true;
            // 
            // radBuy
            // 
            this.radBuy.AutoSize = true;
            this.radBuy.Checked = true;
            this.radBuy.Location = new System.Drawing.Point(212, 233);
            this.radBuy.Name = "radBuy";
            this.radBuy.Size = new System.Drawing.Size(86, 29);
            this.radBuy.TabIndex = 8;
            this.radBuy.TabStop = true;
            this.radBuy.Text = " Buy";
            this.radBuy.UseVisualStyleBackColor = true;
            // 
            // btnGetNewId
            // 
            this.btnGetNewId.Location = new System.Drawing.Point(413, 57);
            this.btnGetNewId.Name = "btnGetNewId";
            this.btnGetNewId.Size = new System.Drawing.Size(180, 45);
            this.btnGetNewId.TabIndex = 2;
            this.btnGetNewId.Text = "Get new ID";
            this.btnGetNewId.UseVisualStyleBackColor = true;
            this.btnGetNewId.Click += new System.EventHandler(this.btnGetNewId_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(212, 175);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(381, 31);
            this.txtCompany.TabIndex = 6;
            // 
            // txtTickerSymbol
            // 
            this.txtTickerSymbol.Location = new System.Drawing.Point(212, 118);
            this.txtTickerSymbol.Name = "txtTickerSymbol";
            this.txtTickerSymbol.Size = new System.Drawing.Size(180, 31);
            this.txtTickerSymbol.TabIndex = 4;
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(212, 61);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(180, 31);
            this.txtTransactionId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.MinimumSize = new System.Drawing.Size(200, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ticker symbol:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.MinimumSize = new System.Drawing.Size(200, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Company:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.MinimumSize = new System.Drawing.Size(200, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transaction Type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 289);
            this.label4.MinimumSize = new System.Drawing.Size(200, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 346);
            this.label3.MinimumSize = new System.Drawing.Size(200, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Notes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.MinimumSize = new System.Drawing.Size(200, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtTransactionIdToDelete);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(50, 953);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Delete transaction ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete transaction";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTransactionIdToDelete
            // 
            this.txtTransactionIdToDelete.Location = new System.Drawing.Point(212, 49);
            this.txtTransactionIdToDelete.Name = "txtTransactionIdToDelete";
            this.txtTransactionIdToDelete.Size = new System.Drawing.Size(180, 31);
            this.txtTransactionIdToDelete.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.MinimumSize = new System.Drawing.Size(200, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Transaction ID:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(696, 134);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(2275, 798);
            this.txtDisplay.TabIndex = 5;
            this.txtDisplay.Text = "";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(797, 998);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(253, 45);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display transaction";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Location = new System.Drawing.Point(1076, 998);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(180, 45);
            this.btnEmptyFile.TabIndex = 7;
            this.btnEmptyFile.Text = "Empty file";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(1282, 998);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(1855, 953);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.Size = new System.Drawing.Size(1116, 126);
            this.txtMessages.TabIndex = 10;
            this.txtMessages.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1732, 953);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Messages:";
            // 
            // StockPortfolioTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3021, 1112);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAddUpdate);
            this.Controls.Add(this.btnCreateOpen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "StockPortfolioTracker";
            this.Text = "Stock Portfolio Tracker";
            this.Load += new System.EventHandler(this.StockPortfolioTracker_Load);
            this.grpAddUpdate.ResumeLayout(false);
            this.grpAddUpdate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnCreateOpen;
        private System.Windows.Forms.GroupBox grpAddUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtNumberOfShares;
        private System.Windows.Forms.TextBox txtSharePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dateOfTransaction;
        private System.Windows.Forms.RadioButton radSell;
        private System.Windows.Forms.RadioButton radBuy;
        private System.Windows.Forms.Button btnGetNewId;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtTickerSymbol;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTransactionIdToDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnEmptyFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.Label label12;
    }
}

