namespace BankSystem
{
    partial class FrmMain
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
            this.btnHladajKlienta = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbHladajKlienta = new System.Windows.Forms.TextBox();
            this.lblInfoOUzivatelovi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgwTOP10 = new System.Windows.Forms.DataGridView();
            this.tabControlStatistiky = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.NtbSumaNaUctoch = new Controls.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NtbPocetAktivnychUctov = new Controls.NumericTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvTopMesta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwTOP10)).BeginInit();
            this.tabControlStatistiky.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTopMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHladajKlienta
            // 
            this.btnHladajKlienta.Location = new System.Drawing.Point(801, 129);
            this.btnHladajKlienta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHladajKlienta.Name = "btnHladajKlienta";
            this.btnHladajKlienta.Size = new System.Drawing.Size(149, 28);
            this.btnHladajKlienta.TabIndex = 2;
            this.btnHladajKlienta.Text = "Find client";
            this.btnHladajKlienta.UseVisualStyleBackColor = true;
            this.btnHladajKlienta.Click += new System.EventHandler(this.CmdFindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(482, 220);
            this.cmdNewAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(149, 28);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "New account";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.CmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(482, 295);
            this.cmdAllAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(149, 28);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "All accounts";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.CmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(482, 369);
            this.cmdAllTransactions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(149, 28);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.CmdAllTransactions_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(483, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 106);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pre vyhľadanie zadajte klientov údaj:\r\n- Priezvisko\r\n- Číslo občianskeho preukazu" +
    "\r\n- IBAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(639, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 74);
            this.label3.TabIndex = 7;
            this.label3.Text = "< Odklik na vytvorenie nového účtu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(639, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 74);
            this.label4.TabIndex = 8;
            this.label4.Text = "< Odklik na evidenciu s účtami/klientami.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(639, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 74);
            this.label5.TabIndex = 9;
            this.label5.Text = "< Odklik na evidenciu s transakciami.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbHladajKlienta
            // 
            this.txbHladajKlienta.Location = new System.Drawing.Point(482, 131);
            this.txbHladajKlienta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbHladajKlienta.Name = "txbHladajKlienta";
            this.txbHladajKlienta.Size = new System.Drawing.Size(312, 22);
            this.txbHladajKlienta.TabIndex = 10;
            // 
            // lblInfoOUzivatelovi
            // 
            this.lblInfoOUzivatelovi.AutoSize = true;
            this.lblInfoOUzivatelovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoOUzivatelovi.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfoOUzivatelovi.Location = new System.Drawing.Point(485, 158);
            this.lblInfoOUzivatelovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoOUzivatelovi.Name = "lblInfoOUzivatelovi";
            this.lblInfoOUzivatelovi.Size = new System.Drawing.Size(0, 20);
            this.lblInfoOUzivatelovi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 541);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manažérske prehľady";
            // 
            // DgwTOP10
            // 
            this.DgwTOP10.AllowUserToAddRows = false;
            this.DgwTOP10.AllowUserToDeleteRows = false;
            this.DgwTOP10.AllowUserToOrderColumns = true;
            this.DgwTOP10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgwTOP10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwTOP10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgwTOP10.Location = new System.Drawing.Point(3, 3);
            this.DgwTOP10.Name = "DgwTOP10";
            this.DgwTOP10.ReadOnly = true;
            this.DgwTOP10.RowTemplate.Height = 24;
            this.DgwTOP10.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwTOP10.Size = new System.Drawing.Size(426, 397);
            this.DgwTOP10.TabIndex = 12;
            // 
            // tabControlStatistiky
            // 
            this.tabControlStatistiky.Controls.Add(this.tabPage2);
            this.tabControlStatistiky.Controls.Add(this.tabPage1);
            this.tabControlStatistiky.Controls.Add(this.tabPage3);
            this.tabControlStatistiky.Location = new System.Drawing.Point(12, 34);
            this.tabControlStatistiky.Name = "tabControlStatistiky";
            this.tabControlStatistiky.SelectedIndex = 0;
            this.tabControlStatistiky.Size = new System.Drawing.Size(440, 432);
            this.tabControlStatistiky.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DgwTOP10);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TOP10 klientov";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.NtbPocetAktivnychUctov);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.NtbSumaNaUctoch);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Štatistiky";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DgvTopMesta);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(432, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TOP Mestá";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // NtbSumaNaUctoch
            // 
            this.NtbSumaNaUctoch.Enabled = false;
            this.NtbSumaNaUctoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbSumaNaUctoch.Location = new System.Drawing.Point(6, 45);
            this.NtbSumaNaUctoch.Name = "NtbSumaNaUctoch";
            this.NtbSumaNaUctoch.Size = new System.Drawing.Size(284, 36);
            this.NtbSumaNaUctoch.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Peniaze uložené v banke";
            // 
            // NtbPocetAktivnychUctov
            // 
            this.NtbPocetAktivnychUctov.Enabled = false;
            this.NtbPocetAktivnychUctov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbPocetAktivnychUctov.Location = new System.Drawing.Point(6, 129);
            this.NtbPocetAktivnychUctov.Name = "NtbPocetAktivnychUctov";
            this.NtbPocetAktivnychUctov.Size = new System.Drawing.Size(284, 36);
            this.NtbPocetAktivnychUctov.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Počet aktívnych účtov";
            // 
            // DgvTopMesta
            // 
            this.DgvTopMesta.AllowUserToAddRows = false;
            this.DgvTopMesta.AllowUserToDeleteRows = false;
            this.DgvTopMesta.AllowUserToOrderColumns = true;
            this.DgvTopMesta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvTopMesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTopMesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTopMesta.Location = new System.Drawing.Point(3, 3);
            this.DgvTopMesta.Name = "DgvTopMesta";
            this.DgvTopMesta.ReadOnly = true;
            this.DgvTopMesta.RowTemplate.Height = 24;
            this.DgvTopMesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTopMesta.Size = new System.Drawing.Size(426, 397);
            this.DgvTopMesta.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 478);
            this.Controls.Add(this.tabControlStatistiky);
            this.Controls.Add(this.lblInfoOUzivatelovi);
            this.Controls.Add(this.txbHladajKlienta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.btnHladajKlienta);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(600, 200);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank System";
            ((System.ComponentModel.ISupportInitialize)(this.DgwTOP10)).EndInit();
            this.tabControlStatistiky.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTopMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHladajKlienta;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbHladajKlienta;
        private System.Windows.Forms.Label lblInfoOUzivatelovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgwTOP10;
        private System.Windows.Forms.TabControl tabControlStatistiky;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private Controls.NumericTextBox NtbSumaNaUctoch;
        private System.Windows.Forms.Label label7;
        private Controls.NumericTextBox NtbPocetAktivnychUctov;
        private System.Windows.Forms.DataGridView DgvTopMesta;
    }
}

