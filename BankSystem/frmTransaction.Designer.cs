namespace BankSystem
{
    partial class FrmTransaction
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
            this.components = new System.ComponentModel.Container();
            this.LblPrijemca = new System.Windows.Forms.Label();
            this.LblOdosielatel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbOdosielatel = new System.Windows.Forms.ComboBox();
            this.CmbPrijimatel = new System.Windows.Forms.ComboBox();
            this.LblOdosielatelMeno = new System.Windows.Forms.Label();
            this.LblPrijemcaMeno = new System.Windows.Forms.Label();
            this.LblOdosielatelAdresa = new System.Windows.Forms.Label();
            this.LblIbanOdosielatela = new System.Windows.Forms.Label();
            this.LblPrijemcaAdresa = new System.Windows.Forms.Label();
            this.LblIbanPrijemca = new System.Windows.Forms.Label();
            this.CmbOdosielatelAdresa = new System.Windows.Forms.ComboBox();
            this.CmbOdosielatelIBAN = new System.Windows.Forms.ComboBox();
            this.repoTransakciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repoTransakciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CmbPrijimatelAdresa = new System.Windows.Forms.ComboBox();
            this.CmbPrijimatelIBAN = new System.Windows.Forms.ComboBox();
            this.BtnUskutocnitPlatbu = new System.Windows.Forms.Button();
            this.NtbSuma = new Controls.NumericTextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.TxbVariabilnySymbol = new System.Windows.Forms.TextBox();
            this.TxbSpecifickySymbol = new System.Windows.Forms.TextBox();
            this.TxbKonstatnySymbol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxbSprava = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPrijemca
            // 
            this.LblPrijemca.BackColor = System.Drawing.Color.Moccasin;
            this.LblPrijemca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPrijemca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPrijemca.Location = new System.Drawing.Point(328, 9);
            this.LblPrijemca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrijemca.Name = "LblPrijemca";
            this.LblPrijemca.Size = new System.Drawing.Size(300, 220);
            this.LblPrijemca.TabIndex = 6;
            this.LblPrijemca.Text = "Príjemca";
            this.LblPrijemca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblOdosielatel
            // 
            this.LblOdosielatel.BackColor = System.Drawing.Color.Firebrick;
            this.LblOdosielatel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOdosielatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdosielatel.ForeColor = System.Drawing.Color.Snow;
            this.LblOdosielatel.Location = new System.Drawing.Point(13, 9);
            this.LblOdosielatel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOdosielatel.Name = "LblOdosielatel";
            this.LblOdosielatel.Size = new System.Drawing.Size(300, 220);
            this.LblOdosielatel.TabIndex = 5;
            this.LblOdosielatel.Text = "Odosielateľ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(615, 161);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbOdosielatel
            // 
            this.CmbOdosielatel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOdosielatel.FormattingEnabled = true;
            this.CmbOdosielatel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CmbOdosielatel.Location = new System.Drawing.Point(38, 80);
            this.CmbOdosielatel.Name = "CmbOdosielatel";
            this.CmbOdosielatel.Size = new System.Drawing.Size(248, 24);
            this.CmbOdosielatel.TabIndex = 8;
            this.CmbOdosielatel.SelectedIndexChanged += new System.EventHandler(this.CmbOdosielatel_SelectedIndexChanged);
            // 
            // CmbPrijimatel
            // 
            this.CmbPrijimatel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPrijimatel.FormattingEnabled = true;
            this.CmbPrijimatel.Location = new System.Drawing.Point(368, 80);
            this.CmbPrijimatel.Name = "CmbPrijimatel";
            this.CmbPrijimatel.Size = new System.Drawing.Size(248, 24);
            this.CmbPrijimatel.TabIndex = 9;
            // 
            // LblOdosielatelMeno
            // 
            this.LblOdosielatelMeno.AutoSize = true;
            this.LblOdosielatelMeno.BackColor = System.Drawing.Color.Firebrick;
            this.LblOdosielatelMeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdosielatelMeno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblOdosielatelMeno.Location = new System.Drawing.Point(35, 60);
            this.LblOdosielatelMeno.Name = "LblOdosielatelMeno";
            this.LblOdosielatelMeno.Size = new System.Drawing.Size(80, 17);
            this.LblOdosielatelMeno.TabIndex = 10;
            this.LblOdosielatelMeno.Text = "Odosielateľ";
            // 
            // LblPrijemcaMeno
            // 
            this.LblPrijemcaMeno.AutoSize = true;
            this.LblPrijemcaMeno.BackColor = System.Drawing.Color.Moccasin;
            this.LblPrijemcaMeno.Location = new System.Drawing.Point(502, 60);
            this.LblPrijemcaMeno.Name = "LblPrijemcaMeno";
            this.LblPrijemcaMeno.Size = new System.Drawing.Size(114, 17);
            this.LblPrijemcaMeno.TabIndex = 11;
            this.LblPrijemcaMeno.Text = "Vyberte prijemcu";
            this.LblPrijemcaMeno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblOdosielatelAdresa
            // 
            this.LblOdosielatelAdresa.AutoSize = true;
            this.LblOdosielatelAdresa.BackColor = System.Drawing.Color.Firebrick;
            this.LblOdosielatelAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdosielatelAdresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblOdosielatelAdresa.Location = new System.Drawing.Point(35, 110);
            this.LblOdosielatelAdresa.Name = "LblOdosielatelAdresa";
            this.LblOdosielatelAdresa.Size = new System.Drawing.Size(53, 17);
            this.LblOdosielatelAdresa.TabIndex = 12;
            this.LblOdosielatelAdresa.Text = "Adresa";
            // 
            // LblIbanOdosielatela
            // 
            this.LblIbanOdosielatela.AutoSize = true;
            this.LblIbanOdosielatela.BackColor = System.Drawing.Color.Firebrick;
            this.LblIbanOdosielatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIbanOdosielatela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblIbanOdosielatela.Location = new System.Drawing.Point(35, 160);
            this.LblIbanOdosielatela.Name = "LblIbanOdosielatela";
            this.LblIbanOdosielatela.Size = new System.Drawing.Size(39, 17);
            this.LblIbanOdosielatela.TabIndex = 13;
            this.LblIbanOdosielatela.Text = "IBAN";
            // 
            // LblPrijemcaAdresa
            // 
            this.LblPrijemcaAdresa.AutoSize = true;
            this.LblPrijemcaAdresa.BackColor = System.Drawing.Color.Moccasin;
            this.LblPrijemcaAdresa.Location = new System.Drawing.Point(565, 110);
            this.LblPrijemcaAdresa.Name = "LblPrijemcaAdresa";
            this.LblPrijemcaAdresa.Size = new System.Drawing.Size(53, 17);
            this.LblPrijemcaAdresa.TabIndex = 14;
            this.LblPrijemcaAdresa.Text = "Adresa";
            this.LblPrijemcaAdresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblIbanPrijemca
            // 
            this.LblIbanPrijemca.AutoSize = true;
            this.LblIbanPrijemca.BackColor = System.Drawing.Color.Moccasin;
            this.LblIbanPrijemca.Location = new System.Drawing.Point(577, 160);
            this.LblIbanPrijemca.Name = "LblIbanPrijemca";
            this.LblIbanPrijemca.Size = new System.Drawing.Size(39, 17);
            this.LblIbanPrijemca.TabIndex = 15;
            this.LblIbanPrijemca.Text = "IBAN";
            // 
            // CmbOdosielatelAdresa
            // 
            this.CmbOdosielatelAdresa.Enabled = false;
            this.CmbOdosielatelAdresa.FormattingEnabled = true;
            this.CmbOdosielatelAdresa.Location = new System.Drawing.Point(38, 130);
            this.CmbOdosielatelAdresa.Name = "CmbOdosielatelAdresa";
            this.CmbOdosielatelAdresa.Size = new System.Drawing.Size(248, 24);
            this.CmbOdosielatelAdresa.TabIndex = 20;
            // 
            // CmbOdosielatelIBAN
            // 
            this.CmbOdosielatelIBAN.Enabled = false;
            this.CmbOdosielatelIBAN.FormattingEnabled = true;
            this.CmbOdosielatelIBAN.Location = new System.Drawing.Point(38, 180);
            this.CmbOdosielatelIBAN.Name = "CmbOdosielatelIBAN";
            this.CmbOdosielatelIBAN.Size = new System.Drawing.Size(248, 24);
            this.CmbOdosielatelIBAN.TabIndex = 21;
            // 
            // repoTransakciaBindingSource
            // 
            this.repoTransakciaBindingSource.DataSource = typeof(Data.Repositories.RepoTransakcia);
            // 
            // repoTransakciaBindingSource1
            // 
            this.repoTransakciaBindingSource1.DataSource = typeof(Data.Repositories.RepoTransakcia);
            // 
            // CmbPrijimatelAdresa
            // 
            this.CmbPrijimatelAdresa.Enabled = false;
            this.CmbPrijimatelAdresa.FormattingEnabled = true;
            this.CmbPrijimatelAdresa.Location = new System.Drawing.Point(368, 130);
            this.CmbPrijimatelAdresa.Name = "CmbPrijimatelAdresa";
            this.CmbPrijimatelAdresa.Size = new System.Drawing.Size(248, 24);
            this.CmbPrijimatelAdresa.TabIndex = 22;
            // 
            // CmbPrijimatelIBAN
            // 
            this.CmbPrijimatelIBAN.Enabled = false;
            this.CmbPrijimatelIBAN.FormattingEnabled = true;
            this.CmbPrijimatelIBAN.Location = new System.Drawing.Point(368, 180);
            this.CmbPrijimatelIBAN.Name = "CmbPrijimatelIBAN";
            this.CmbPrijimatelIBAN.Size = new System.Drawing.Size(248, 24);
            this.CmbPrijimatelIBAN.TabIndex = 23;
            // 
            // BtnUskutocnitPlatbu
            // 
            this.BtnUskutocnitPlatbu.BackColor = System.Drawing.Color.Indigo;
            this.BtnUskutocnitPlatbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUskutocnitPlatbu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUskutocnitPlatbu.Location = new System.Drawing.Point(230, 471);
            this.BtnUskutocnitPlatbu.Name = "BtnUskutocnitPlatbu";
            this.BtnUskutocnitPlatbu.Size = new System.Drawing.Size(180, 70);
            this.BtnUskutocnitPlatbu.TabIndex = 24;
            this.BtnUskutocnitPlatbu.Text = "PLATBA";
            this.BtnUskutocnitPlatbu.UseVisualStyleBackColor = false;
            this.BtnUskutocnitPlatbu.Click += new System.EventHandler(this.BtnUskutocnitPlatbu_Click);
            // 
            // NtbSuma
            // 
            this.NtbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbSuma.Location = new System.Drawing.Point(230, 262);
            this.NtbSuma.Name = "NtbSuma";
            this.NtbSuma.Size = new System.Drawing.Size(200, 36);
            this.NtbSuma.TabIndex = 25;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuma.Location = new System.Drawing.Point(262, 234);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(138, 25);
            this.lblSuma.TabIndex = 28;
            this.lblSuma.Text = "Čiastka v EUR";
            this.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbVariabilnySymbol
            // 
            this.TxbVariabilnySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbVariabilnySymbol.Location = new System.Drawing.Point(24, 359);
            this.TxbVariabilnySymbol.Name = "TxbVariabilnySymbol";
            this.TxbVariabilnySymbol.Size = new System.Drawing.Size(180, 30);
            this.TxbVariabilnySymbol.TabIndex = 29;
            // 
            // TxbSpecifickySymbol
            // 
            this.TxbSpecifickySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbSpecifickySymbol.Location = new System.Drawing.Point(230, 359);
            this.TxbSpecifickySymbol.Name = "TxbSpecifickySymbol";
            this.TxbSpecifickySymbol.Size = new System.Drawing.Size(180, 30);
            this.TxbSpecifickySymbol.TabIndex = 30;
            // 
            // TxbKonstatnySymbol
            // 
            this.TxbKonstatnySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbKonstatnySymbol.Location = new System.Drawing.Point(436, 359);
            this.TxbKonstatnySymbol.Name = "TxbKonstatnySymbol";
            this.TxbKonstatnySymbol.Size = new System.Drawing.Size(180, 30);
            this.TxbKonstatnySymbol.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(26, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Variabilný symbol";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkCyan;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(232, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Špecifický symbol";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkCyan;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(434, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Konštantný symbol";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbSprava
            // 
            this.TxbSprava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbSprava.Location = new System.Drawing.Point(24, 426);
            this.TxbSprava.Name = "TxbSprava";
            this.TxbSprava.Size = new System.Drawing.Size(592, 30);
            this.TxbSprava.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkCyan;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(26, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "Správa pre príjemcu";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 553);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxbSprava);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxbKonstatnySymbol);
            this.Controls.Add(this.TxbSpecifickySymbol);
            this.Controls.Add(this.TxbVariabilnySymbol);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.NtbSuma);
            this.Controls.Add(this.BtnUskutocnitPlatbu);
            this.Controls.Add(this.CmbPrijimatelIBAN);
            this.Controls.Add(this.CmbPrijimatelAdresa);
            this.Controls.Add(this.CmbOdosielatelIBAN);
            this.Controls.Add(this.CmbOdosielatelAdresa);
            this.Controls.Add(this.LblIbanPrijemca);
            this.Controls.Add(this.LblPrijemcaAdresa);
            this.Controls.Add(this.LblIbanOdosielatela);
            this.Controls.Add(this.LblOdosielatelAdresa);
            this.Controls.Add(this.LblPrijemcaMeno);
            this.Controls.Add(this.LblOdosielatelMeno);
            this.Controls.Add(this.CmbPrijimatel);
            this.Controls.Add(this.CmbOdosielatel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPrijemca);
            this.Controls.Add(this.LblOdosielatel);
            this.Name = "FrmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrijemca;
        private System.Windows.Forms.Label LblOdosielatel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbOdosielatel;
        private System.Windows.Forms.ComboBox CmbPrijimatel;
        private System.Windows.Forms.Label LblOdosielatelMeno;
        private System.Windows.Forms.Label LblPrijemcaMeno;
        private System.Windows.Forms.Label LblOdosielatelAdresa;
        private System.Windows.Forms.Label LblIbanOdosielatela;
        private System.Windows.Forms.Label LblPrijemcaAdresa;
        private System.Windows.Forms.Label LblIbanPrijemca;
        private System.Windows.Forms.ComboBox CmbOdosielatelAdresa;
        private System.Windows.Forms.ComboBox CmbOdosielatelIBAN;
        private System.Windows.Forms.BindingSource repoTransakciaBindingSource;
        private System.Windows.Forms.BindingSource repoTransakciaBindingSource1;
        private System.Windows.Forms.ComboBox CmbPrijimatelAdresa;
        private System.Windows.Forms.ComboBox CmbPrijimatelIBAN;
        private System.Windows.Forms.Button BtnUskutocnitPlatbu;
        private Controls.NumericTextBox NtbSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox TxbVariabilnySymbol;
        private System.Windows.Forms.TextBox TxbSpecifickySymbol;
        private System.Windows.Forms.TextBox TxbKonstatnySymbol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxbSprava;
        private System.Windows.Forms.Label label13;
    }
}