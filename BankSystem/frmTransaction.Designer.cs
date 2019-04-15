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
            this.CmbPrijimatelAdresa = new System.Windows.Forms.ComboBox();
            this.CmbPrijimatelIBAN = new System.Windows.Forms.ComboBox();
            this.BtnUskutocnitPlatbu = new System.Windows.Forms.Button();
            this.NtbSuma = new Controls.NumericTextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxbSprava = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUpozornenie = new System.Windows.Forms.Label();
            this.NtbVS = new Controls.NumericTextBox();
            this.NtbSS = new Controls.NumericTextBox();
            this.NtbKS = new Controls.NumericTextBox();
            this.SuspendLayout();
            // 
            // LblPrijemca
            // 
            this.LblPrijemca.BackColor = System.Drawing.Color.Moccasin;
            this.LblPrijemca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPrijemca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPrijemca.Location = new System.Drawing.Point(246, 7);
            this.LblPrijemca.Name = "LblPrijemca";
            this.LblPrijemca.Size = new System.Drawing.Size(226, 179);
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
            this.LblOdosielatel.Location = new System.Drawing.Point(10, 7);
            this.LblOdosielatel.Name = "LblOdosielatel";
            this.LblOdosielatel.Size = new System.Drawing.Size(226, 179);
            this.LblOdosielatel.TabIndex = 5;
            this.LblOdosielatel.Text = "Odosielateľ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 131);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbOdosielatel
            // 
            this.CmbOdosielatel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOdosielatel.FormattingEnabled = true;
            this.CmbOdosielatel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CmbOdosielatel.Location = new System.Drawing.Point(28, 65);
            this.CmbOdosielatel.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOdosielatel.Name = "CmbOdosielatel";
            this.CmbOdosielatel.Size = new System.Drawing.Size(187, 21);
            this.CmbOdosielatel.TabIndex = 0;
            // 
            // CmbPrijimatel
            // 
            this.CmbPrijimatel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPrijimatel.FormattingEnabled = true;
            this.CmbPrijimatel.Location = new System.Drawing.Point(276, 65);
            this.CmbPrijimatel.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPrijimatel.Name = "CmbPrijimatel";
            this.CmbPrijimatel.Size = new System.Drawing.Size(187, 21);
            this.CmbPrijimatel.TabIndex = 3;
            // 
            // LblOdosielatelMeno
            // 
            this.LblOdosielatelMeno.AutoSize = true;
            this.LblOdosielatelMeno.BackColor = System.Drawing.Color.Firebrick;
            this.LblOdosielatelMeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdosielatelMeno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblOdosielatelMeno.Location = new System.Drawing.Point(26, 49);
            this.LblOdosielatelMeno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOdosielatelMeno.Name = "LblOdosielatelMeno";
            this.LblOdosielatelMeno.Size = new System.Drawing.Size(61, 13);
            this.LblOdosielatelMeno.TabIndex = 10;
            this.LblOdosielatelMeno.Text = "Odosielateľ";
            // 
            // LblPrijemcaMeno
            // 
            this.LblPrijemcaMeno.AutoSize = true;
            this.LblPrijemcaMeno.BackColor = System.Drawing.Color.Moccasin;
            this.LblPrijemcaMeno.Location = new System.Drawing.Point(376, 49);
            this.LblPrijemcaMeno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrijemcaMeno.Name = "LblPrijemcaMeno";
            this.LblPrijemcaMeno.Size = new System.Drawing.Size(85, 13);
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
            this.LblOdosielatelAdresa.Location = new System.Drawing.Point(26, 89);
            this.LblOdosielatelAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOdosielatelAdresa.Name = "LblOdosielatelAdresa";
            this.LblOdosielatelAdresa.Size = new System.Drawing.Size(40, 13);
            this.LblOdosielatelAdresa.TabIndex = 12;
            this.LblOdosielatelAdresa.Text = "Adresa";
            // 
            // LblIbanOdosielatela
            // 
            this.LblIbanOdosielatela.AutoSize = true;
            this.LblIbanOdosielatela.BackColor = System.Drawing.Color.Firebrick;
            this.LblIbanOdosielatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIbanOdosielatela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblIbanOdosielatela.Location = new System.Drawing.Point(26, 130);
            this.LblIbanOdosielatela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIbanOdosielatela.Name = "LblIbanOdosielatela";
            this.LblIbanOdosielatela.Size = new System.Drawing.Size(32, 13);
            this.LblIbanOdosielatela.TabIndex = 13;
            this.LblIbanOdosielatela.Text = "IBAN";
            // 
            // LblPrijemcaAdresa
            // 
            this.LblPrijemcaAdresa.AutoSize = true;
            this.LblPrijemcaAdresa.BackColor = System.Drawing.Color.Moccasin;
            this.LblPrijemcaAdresa.Location = new System.Drawing.Point(424, 89);
            this.LblPrijemcaAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrijemcaAdresa.Name = "LblPrijemcaAdresa";
            this.LblPrijemcaAdresa.Size = new System.Drawing.Size(40, 13);
            this.LblPrijemcaAdresa.TabIndex = 14;
            this.LblPrijemcaAdresa.Text = "Adresa";
            this.LblPrijemcaAdresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblIbanPrijemca
            // 
            this.LblIbanPrijemca.AutoSize = true;
            this.LblIbanPrijemca.BackColor = System.Drawing.Color.Moccasin;
            this.LblIbanPrijemca.Location = new System.Drawing.Point(433, 130);
            this.LblIbanPrijemca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIbanPrijemca.Name = "LblIbanPrijemca";
            this.LblIbanPrijemca.Size = new System.Drawing.Size(32, 13);
            this.LblIbanPrijemca.TabIndex = 15;
            this.LblIbanPrijemca.Text = "IBAN";
            // 
            // CmbOdosielatelAdresa
            // 
            this.CmbOdosielatelAdresa.Enabled = false;
            this.CmbOdosielatelAdresa.FormattingEnabled = true;
            this.CmbOdosielatelAdresa.Location = new System.Drawing.Point(28, 106);
            this.CmbOdosielatelAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOdosielatelAdresa.Name = "CmbOdosielatelAdresa";
            this.CmbOdosielatelAdresa.Size = new System.Drawing.Size(187, 21);
            this.CmbOdosielatelAdresa.TabIndex = 1;
            // 
            // CmbOdosielatelIBAN
            // 
            this.CmbOdosielatelIBAN.Enabled = false;
            this.CmbOdosielatelIBAN.FormattingEnabled = true;
            this.CmbOdosielatelIBAN.Location = new System.Drawing.Point(28, 146);
            this.CmbOdosielatelIBAN.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOdosielatelIBAN.Name = "CmbOdosielatelIBAN";
            this.CmbOdosielatelIBAN.Size = new System.Drawing.Size(187, 21);
            this.CmbOdosielatelIBAN.TabIndex = 2;
            // 
            // CmbPrijimatelAdresa
            // 
            this.CmbPrijimatelAdresa.Enabled = false;
            this.CmbPrijimatelAdresa.FormattingEnabled = true;
            this.CmbPrijimatelAdresa.Location = new System.Drawing.Point(276, 106);
            this.CmbPrijimatelAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPrijimatelAdresa.Name = "CmbPrijimatelAdresa";
            this.CmbPrijimatelAdresa.Size = new System.Drawing.Size(187, 21);
            this.CmbPrijimatelAdresa.TabIndex = 4;
            // 
            // CmbPrijimatelIBAN
            // 
            this.CmbPrijimatelIBAN.Enabled = false;
            this.CmbPrijimatelIBAN.FormattingEnabled = true;
            this.CmbPrijimatelIBAN.Location = new System.Drawing.Point(276, 146);
            this.CmbPrijimatelIBAN.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPrijimatelIBAN.Name = "CmbPrijimatelIBAN";
            this.CmbPrijimatelIBAN.Size = new System.Drawing.Size(187, 21);
            this.CmbPrijimatelIBAN.TabIndex = 5;
            // 
            // BtnUskutocnitPlatbu
            // 
            this.BtnUskutocnitPlatbu.BackColor = System.Drawing.Color.Indigo;
            this.BtnUskutocnitPlatbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUskutocnitPlatbu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUskutocnitPlatbu.Location = new System.Drawing.Point(172, 431);
            this.BtnUskutocnitPlatbu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUskutocnitPlatbu.Name = "BtnUskutocnitPlatbu";
            this.BtnUskutocnitPlatbu.Size = new System.Drawing.Size(135, 57);
            this.BtnUskutocnitPlatbu.TabIndex = 11;
            this.BtnUskutocnitPlatbu.Text = "PLATBA";
            this.BtnUskutocnitPlatbu.UseVisualStyleBackColor = false;
            this.BtnUskutocnitPlatbu.Click += new System.EventHandler(this.BtnUskutocnitPlatbu_Click);
            // 
            // NtbSuma
            // 
            this.NtbSuma.AllowNegative = false;
            this.NtbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbSuma.Location = new System.Drawing.Point(172, 213);
            this.NtbSuma.Margin = new System.Windows.Forms.Padding(2);
            this.NtbSuma.MaxLength = 10;
            this.NtbSuma.Name = "NtbSuma";
            this.NtbSuma.Size = new System.Drawing.Size(151, 30);
            this.NtbSuma.TabIndex = 6;
            this.NtbSuma.TextChanged += new System.EventHandler(this.NtbSuma_TextChanged);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuma.Location = new System.Drawing.Point(196, 190);
            this.lblSuma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(112, 20);
            this.lblSuma.TabIndex = 28;
            this.lblSuma.Text = "Čiastka v EUR";
            this.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(20, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Variabilný symbol";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkCyan;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(174, 269);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Špecifický symbol";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkCyan;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(326, 269);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Konštantný symbol";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbSprava
            // 
            this.TxbSprava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxbSprava.Location = new System.Drawing.Point(18, 346);
            this.TxbSprava.Margin = new System.Windows.Forms.Padding(2);
            this.TxbSprava.Name = "TxbSprava";
            this.TxbSprava.Size = new System.Drawing.Size(445, 26);
            this.TxbSprava.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkCyan;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(20, 323);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Správa pre príjemcu";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpozornenie
            // 
            this.lblUpozornenie.AutoSize = true;
            this.lblUpozornenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozornenie.ForeColor = System.Drawing.Color.Red;
            this.lblUpozornenie.Location = new System.Drawing.Point(13, 396);
            this.lblUpozornenie.Name = "lblUpozornenie";
            this.lblUpozornenie.Size = new System.Drawing.Size(134, 25);
            this.lblUpozornenie.TabIndex = 37;
            this.lblUpozornenie.Text = "Upozornenie";
            // 
            // NtbVS
            // 
            this.NtbVS.AllowDecimals = false;
            this.NtbVS.AllowNegative = false;
            this.NtbVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbVS.Location = new System.Drawing.Point(18, 291);
            this.NtbVS.MaxLength = 10;
            this.NtbVS.Name = "NtbVS";
            this.NtbVS.Size = new System.Drawing.Size(136, 26);
            this.NtbVS.TabIndex = 7;
            // 
            // NtbSS
            // 
            this.NtbSS.AllowDecimals = false;
            this.NtbSS.AllowNegative = false;
            this.NtbSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbSS.Location = new System.Drawing.Point(177, 291);
            this.NtbSS.MaxLength = 10;
            this.NtbSS.Name = "NtbSS";
            this.NtbSS.Size = new System.Drawing.Size(136, 26);
            this.NtbSS.TabIndex = 8;
            // 
            // NtbKS
            // 
            this.NtbKS.AllowDecimals = false;
            this.NtbKS.AllowNegative = false;
            this.NtbKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbKS.Location = new System.Drawing.Point(329, 291);
            this.NtbKS.MaxLength = 10;
            this.NtbKS.Name = "NtbKS";
            this.NtbKS.Size = new System.Drawing.Size(136, 26);
            this.NtbKS.TabIndex = 9;
            // 
            // FrmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 499);
            this.Controls.Add(this.NtbKS);
            this.Controls.Add(this.NtbSS);
            this.Controls.Add(this.NtbVS);
            this.Controls.Add(this.lblUpozornenie);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxbSprava);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
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
        private System.Windows.Forms.ComboBox CmbPrijimatelAdresa;
        private System.Windows.Forms.ComboBox CmbPrijimatelIBAN;
        private System.Windows.Forms.Button BtnUskutocnitPlatbu;
        private Controls.NumericTextBox NtbSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxbSprava;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUpozornenie;
        private Controls.NumericTextBox NtbVS;
        private Controls.NumericTextBox NtbSS;
        private Controls.NumericTextBox NtbKS;
    }
}