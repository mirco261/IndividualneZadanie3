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
            this.label2 = new System.Windows.Forms.Label();
            this.DgwZoznamPlatobnychKariet = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnPridajKartu = new System.Windows.Forms.Button();
            this.BtnZmenZablokovanieKarty = new System.Windows.Forms.Button();
            this.lblPozadieHornehoMenu = new System.Windows.Forms.Label();
            this.lblDeaktivovanyUcet = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblDatumZalozenia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwZoznamPlatobnychKariet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(12, 171);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(112, 23);
            this.cmdUpdate.TabIndex = 0;
            this.cmdUpdate.Text = "Aktualizuj klienta";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Location = new System.Drawing.Point(392, 256);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(112, 23);
            this.cmdNewTransaction.TabIndex = 4;
            this.cmdNewTransaction.Text = "Peňažný prevod";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.CmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Location = new System.Drawing.Point(392, 344);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdCloseAccount.TabIndex = 5;
            this.cmdCloseAccount.Text = "Deaktivácia účtu";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.CmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(392, 171);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 3;
            this.cmdAllTransactions.Text = "Všetky transakcie";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.CmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Location = new System.Drawing.Point(12, 344);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(112, 23);
            this.cmdWithdrawal.TabIndex = 2;
            this.cmdWithdrawal.Text = "Výber peňazí";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.CmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Location = new System.Drawing.Point(12, 256);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(112, 23);
            this.cmdDeposit.TabIndex = 1;
            this.cmdDeposit.Text = "Vklad peňazí";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.CmdDeposit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(128, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "< Odklik na úpravu údajov o účte/klientovi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(510, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "< Odklik na zatvorenie účtu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(128, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 60);
            this.label5.TabIndex = 14;
            this.label5.Text = "< Odklik na vloženie peňazí na účet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(130, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "< Odklik na výber peňazí z účtu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(510, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 60);
            this.label7.TabIndex = 16;
            this.label7.Text = "< Odklik na zobrazenie transakcií na účte";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(510, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 60);
            this.label8.TabIndex = 17;
            this.label8.Text = "< Odklik na zadanie novej transakcie";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vlastník účtu";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Adresa";
            // 
            // lblMenoPriezvisko
            // 
            this.lblMenoPriezvisko.AutoSize = true;
            this.lblMenoPriezvisko.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMenoPriezvisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenoPriezvisko.Location = new System.Drawing.Point(107, 9);
            this.lblMenoPriezvisko.Name = "lblMenoPriezvisko";
            this.lblMenoPriezvisko.Size = new System.Drawing.Size(101, 17);
            this.lblMenoPriezvisko.TabIndex = 20;
            this.lblMenoPriezvisko.Text = "Vlastník účtu";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(107, 29);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(59, 17);
            this.lblAdresa.TabIndex = 21;
            this.lblAdresa.Text = "Adresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(13, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Telefón";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(13, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mail";
            // 
            // lblTelefonneCislo
            // 
            this.lblTelefonneCislo.AutoSize = true;
            this.lblTelefonneCislo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTelefonneCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefonneCislo.Location = new System.Drawing.Point(107, 79);
            this.lblTelefonneCislo.Name = "lblTelefonneCislo";
            this.lblTelefonneCislo.Size = new System.Drawing.Size(119, 17);
            this.lblTelefonneCislo.TabIndex = 24;
            this.lblTelefonneCislo.Text = "Telefónne číslo";
            // 
            // lblMailovaAdresa
            // 
            this.lblMailovaAdresa.AutoSize = true;
            this.lblMailovaAdresa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblMailovaAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMailovaAdresa.Location = new System.Drawing.Point(107, 99);
            this.lblMailovaAdresa.Name = "lblMailovaAdresa";
            this.lblMailovaAdresa.Size = new System.Drawing.Size(118, 17);
            this.lblMailovaAdresa.TabIndex = 25;
            this.lblMailovaAdresa.Text = "Mailova adresa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(389, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "IBAN";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIBAN.Location = new System.Drawing.Point(389, 111);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(43, 17);
            this.lblIBAN.TabIndex = 27;
            this.lblIBAN.Text = "IBAN";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.Location = new System.Drawing.Point(389, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(87, 17);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Stav na účte";
            // 
            // lblStavNaUcte
            // 
            this.lblStavNaUcte.AutoSize = true;
            this.lblStavNaUcte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblStavNaUcte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStavNaUcte.Location = new System.Drawing.Point(389, 35);
            this.lblStavNaUcte.Name = "lblStavNaUcte";
            this.lblStavNaUcte.Size = new System.Drawing.Size(99, 17);
            this.lblStavNaUcte.TabIndex = 29;
            this.lblStavNaUcte.Text = "Stav na účte";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(580, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Povolené prečerpanie";
            // 
            // lblPovolenePrecerpanie
            // 
            this.lblPovolenePrecerpanie.AutoSize = true;
            this.lblPovolenePrecerpanie.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPovolenePrecerpanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPovolenePrecerpanie.Location = new System.Drawing.Point(580, 35);
            this.lblPovolenePrecerpanie.Name = "lblPovolenePrecerpanie";
            this.lblPovolenePrecerpanie.Size = new System.Drawing.Size(99, 17);
            this.lblPovolenePrecerpanie.TabIndex = 31;
            this.lblPovolenePrecerpanie.Text = "Stav na účte";
            // 
            // lblObcianskyPreukaz
            // 
            this.lblObcianskyPreukaz.AutoSize = true;
            this.lblObcianskyPreukaz.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblObcianskyPreukaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObcianskyPreukaz.Location = new System.Drawing.Point(107, 46);
            this.lblObcianskyPreukaz.Name = "lblObcianskyPreukaz";
            this.lblObcianskyPreukaz.Size = new System.Drawing.Size(30, 17);
            this.lblObcianskyPreukaz.TabIndex = 33;
            this.lblObcianskyPreukaz.Text = "OP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(13, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Číslo OP";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(749, -48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 1645);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgwZoznamPlatobnychKariet
            // 
            this.DgwZoznamPlatobnychKariet.AllowUserToAddRows = false;
            this.DgwZoznamPlatobnychKariet.AllowUserToDeleteRows = false;
            this.DgwZoznamPlatobnychKariet.AllowUserToOrderColumns = true;
            this.DgwZoznamPlatobnychKariet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgwZoznamPlatobnychKariet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DgwZoznamPlatobnychKariet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwZoznamPlatobnychKariet.Location = new System.Drawing.Point(762, 37);
            this.DgwZoznamPlatobnychKariet.Margin = new System.Windows.Forms.Padding(2);
            this.DgwZoznamPlatobnychKariet.Name = "DgwZoznamPlatobnychKariet";
            this.DgwZoznamPlatobnychKariet.ReadOnly = true;
            this.DgwZoznamPlatobnychKariet.RowTemplate.Height = 24;
            this.DgwZoznamPlatobnychKariet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwZoznamPlatobnychKariet.Size = new System.Drawing.Size(346, 271);
            this.DgwZoznamPlatobnychKariet.TabIndex = 7;
            this.DgwZoznamPlatobnychKariet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwZoznamPlatobnychKariet_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkMagenta;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(763, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Zoznam platobných kariet";
            // 
            // BtnPridajKartu
            // 
            this.BtnPridajKartu.Location = new System.Drawing.Point(763, 314);
            this.BtnPridajKartu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPridajKartu.Name = "BtnPridajKartu";
            this.BtnPridajKartu.Size = new System.Drawing.Size(168, 86);
            this.BtnPridajKartu.TabIndex = 6;
            this.BtnPridajKartu.Text = "Pridaj kartu";
            this.BtnPridajKartu.UseVisualStyleBackColor = true;
            this.BtnPridajKartu.Click += new System.EventHandler(this.BtnPridajKartu_Click);
            // 
            // BtnZmenZablokovanieKarty
            // 
            this.BtnZmenZablokovanieKarty.Location = new System.Drawing.Point(935, 314);
            this.BtnZmenZablokovanieKarty.Margin = new System.Windows.Forms.Padding(2);
            this.BtnZmenZablokovanieKarty.Name = "BtnZmenZablokovanieKarty";
            this.BtnZmenZablokovanieKarty.Size = new System.Drawing.Size(173, 87);
            this.BtnZmenZablokovanieKarty.TabIndex = 8;
            this.BtnZmenZablokovanieKarty.Text = "Zablokuj / Odblokuj \r\nkartu";
            this.BtnZmenZablokovanieKarty.UseVisualStyleBackColor = true;
            this.BtnZmenZablokovanieKarty.Click += new System.EventHandler(this.BtnZmenZablokovanieKarty_Click);
            // 
            // lblPozadieHornehoMenu
            // 
            this.lblPozadieHornehoMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPozadieHornehoMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPozadieHornehoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPozadieHornehoMenu.Location = new System.Drawing.Point(-22, -48);
            this.lblPozadieHornehoMenu.Name = "lblPozadieHornehoMenu";
            this.lblPozadieHornehoMenu.Size = new System.Drawing.Size(1166, 198);
            this.lblPozadieHornehoMenu.TabIndex = 9;
            this.lblPozadieHornehoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeaktivovanyUcet
            // 
            this.lblDeaktivovanyUcet.AutoSize = true;
            this.lblDeaktivovanyUcet.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeaktivovanyUcet.ForeColor = System.Drawing.Color.Red;
            this.lblDeaktivovanyUcet.Location = new System.Drawing.Point(245, 35);
            this.lblDeaktivovanyUcet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeaktivovanyUcet.Name = "lblDeaktivovanyUcet";
            this.lblDeaktivovanyUcet.Size = new System.Drawing.Size(686, 76);
            this.lblDeaktivovanyUcet.TabIndex = 39;
            this.lblDeaktivovanyUcet.Text = "Účet bol deaktivovaný";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(13, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Dátum zal.";
            // 
            // LblDatumZalozenia
            // 
            this.LblDatumZalozenia.AutoSize = true;
            this.LblDatumZalozenia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LblDatumZalozenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblDatumZalozenia.Location = new System.Drawing.Point(107, 129);
            this.LblDatumZalozenia.Name = "LblDatumZalozenia";
            this.LblDatumZalozenia.Size = new System.Drawing.Size(164, 17);
            this.LblDatumZalozenia.TabIndex = 41;
            this.LblDatumZalozenia.Text = "Dátum založenia účtu";
            // 
            // FrmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 415);
            this.Controls.Add(this.LblDatumZalozenia);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblDeaktivovanyUcet);
            this.Controls.Add(this.BtnZmenZablokovanieKarty);
            this.Controls.Add(this.BtnPridajKartu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgwZoznamPlatobnychKariet);
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
            this.Controls.Add(this.lblPozadieHornehoMenu);
            this.MaximumSize = new System.Drawing.Size(1129, 454);
            this.MinimumSize = new System.Drawing.Size(1129, 454);
            this.Name = "FrmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manažment klientskych operácií";
            ((System.ComponentModel.ISupportInitialize)(this.DgwZoznamPlatobnychKariet)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgwZoznamPlatobnychKariet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnPridajKartu;
        private System.Windows.Forms.Button BtnZmenZablokovanieKarty;
        private System.Windows.Forms.Label lblPozadieHornehoMenu;
        private System.Windows.Forms.Label lblDeaktivovanyUcet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblDatumZalozenia;
    }
}