namespace BankSystem
{
    partial class FrmClientManagement
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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdNewTransaction = new System.Windows.Forms.Button();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMenoPriezvisko = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTelefonneCislo = new System.Windows.Forms.Label();
            this.lblMailovaAdresa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblStavNaUcte = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPovolenePrecerpanie = new System.Windows.Forms.Label();
            this.lblObcianskyPreukaz = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(16, 210);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(149, 28);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update info";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Location = new System.Drawing.Point(523, 315);
            this.cmdNewTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(149, 28);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "New transaction";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.CmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Location = new System.Drawing.Point(523, 423);
            this.cmdCloseAccount.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(149, 28);
            this.cmdCloseAccount.TabIndex = 6;
            this.cmdCloseAccount.Text = "Close account";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.CmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(523, 210);
            this.cmdAllTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(149, 28);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.CmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Location = new System.Drawing.Point(16, 423);
            this.cmdWithdrawal.Margin = new System.Windows.Forms.Padding(4);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(149, 28);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Withdrawal";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.CmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Location = new System.Drawing.Point(16, 315);
            this.cmdDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(149, 28);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.CmdDeposit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(999, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 478);
            this.label2.TabIndex = 11;
            this.label2.Text = "Niekde v tomto okne bude grid s platobnými kartami priradenými k účtu.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(171, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 74);
            this.label3.TabIndex = 12;
            this.label3.Text = "< Odklik na úpravu údajov o účte/klientovi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(680, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 74);
            this.label4.TabIndex = 13;
            this.label4.Text = "< Odklik na zatvorenie účtu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(171, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 74);
            this.label5.TabIndex = 14;
            this.label5.Text = "< Odklik na vloženie peňazí na účet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(173, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 74);
            this.label6.TabIndex = 15;
            this.label6.Text = "< Odklik na výber peňazí z účtu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(680, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 74);
            this.label7.TabIndex = 16;
            this.label7.Text = "< Odklik na zobrazenie transakcií na účte";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(680, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 74);
            this.label8.TabIndex = 17;
            this.label8.Text = "< Odklik na zadanie novej transakcie";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vlastník účtu";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(17, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Adresa";
            // 
            // lblMenoPriezvisko
            // 
            this.lblMenoPriezvisko.AutoSize = true;
            this.lblMenoPriezvisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenoPriezvisko.Location = new System.Drawing.Point(143, 11);
            this.lblMenoPriezvisko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenoPriezvisko.Name = "lblMenoPriezvisko";
            this.lblMenoPriezvisko.Size = new System.Drawing.Size(118, 20);
            this.lblMenoPriezvisko.TabIndex = 20;
            this.lblMenoPriezvisko.Text = "Vlastník účtu";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(143, 46);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(68, 20);
            this.lblAdresa.TabIndex = 21;
            this.lblAdresa.Text = "Adresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(17, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Telefón";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(17, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mail";
            // 
            // lblTelefonneCislo
            // 
            this.lblTelefonneCislo.AutoSize = true;
            this.lblTelefonneCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefonneCislo.Location = new System.Drawing.Point(143, 105);
            this.lblTelefonneCislo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonneCislo.Name = "lblTelefonneCislo";
            this.lblTelefonneCislo.Size = new System.Drawing.Size(137, 20);
            this.lblTelefonneCislo.TabIndex = 24;
            this.lblTelefonneCislo.Text = "Telefónne číslo";
            // 
            // lblMailovaAdresa
            // 
            this.lblMailovaAdresa.AutoSize = true;
            this.lblMailovaAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMailovaAdresa.Location = new System.Drawing.Point(143, 137);
            this.lblMailovaAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailovaAdresa.Name = "lblMailovaAdresa";
            this.lblMailovaAdresa.Size = new System.Drawing.Size(136, 20);
            this.lblMailovaAdresa.TabIndex = 25;
            this.lblMailovaAdresa.Text = "Mailova adresa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(519, 105);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "IBAN";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIBAN.Location = new System.Drawing.Point(519, 137);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(52, 20);
            this.lblIBAN.TabIndex = 27;
            this.lblIBAN.Text = "IBAN";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.Location = new System.Drawing.Point(519, 11);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(102, 20);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Stav na účte";
            // 
            // lblStavNaUcte
            // 
            this.lblStavNaUcte.AutoSize = true;
            this.lblStavNaUcte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStavNaUcte.Location = new System.Drawing.Point(519, 43);
            this.lblStavNaUcte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStavNaUcte.Name = "lblStavNaUcte";
            this.lblStavNaUcte.Size = new System.Drawing.Size(114, 20);
            this.lblStavNaUcte.TabIndex = 29;
            this.lblStavNaUcte.Text = "Stav na účte";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(773, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Povolené prečerpanie";
            // 
            // lblPovolenePrecerpanie
            // 
            this.lblPovolenePrecerpanie.AutoSize = true;
            this.lblPovolenePrecerpanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPovolenePrecerpanie.Location = new System.Drawing.Point(773, 43);
            this.lblPovolenePrecerpanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPovolenePrecerpanie.Name = "lblPovolenePrecerpanie";
            this.lblPovolenePrecerpanie.Size = new System.Drawing.Size(114, 20);
            this.lblPovolenePrecerpanie.TabIndex = 31;
            this.lblPovolenePrecerpanie.Text = "Stav na účte";
            // 
            // lblObcianskyPreukaz
            // 
            this.lblObcianskyPreukaz.AutoSize = true;
            this.lblObcianskyPreukaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObcianskyPreukaz.Location = new System.Drawing.Point(143, 76);
            this.lblObcianskyPreukaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObcianskyPreukaz.Name = "lblObcianskyPreukaz";
            this.lblObcianskyPreukaz.Size = new System.Drawing.Size(35, 20);
            this.lblObcianskyPreukaz.TabIndex = 33;
            this.lblObcianskyPreukaz.Text = "OP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(19, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Číslo OP";
            // 
            // FrmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 505);
            this.Controls.Add(this.lblObcianskyPreukaz);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblPovolenePrecerpanie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblStavNaUcte);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblMailovaAdresa);
            this.Controls.Add(this.lblTelefonneCislo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblMenoPriezvisko);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdDeposit);
            this.Controls.Add(this.cmdWithdrawal);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdCloseAccount);
            this.Controls.Add(this.cmdNewTransaction);
            this.Controls.Add(this.cmdUpdate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmClientManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseAccount;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMenoPriezvisko;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTelefonneCislo;
        private System.Windows.Forms.Label lblMailovaAdresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblStavNaUcte;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPovolenePrecerpanie;
        private System.Windows.Forms.Label lblObcianskyPreukaz;
        private System.Windows.Forms.Label label15;
    }
}