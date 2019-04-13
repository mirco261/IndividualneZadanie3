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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbOdosielatel = new System.Windows.Forms.ComboBox();
            this.CmbPrijimatel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbOdosielatelAdresa = new System.Windows.Forms.ComboBox();
            this.CmbOdosielatelIBAN = new System.Windows.Forms.ComboBox();
            this.repoTransakciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repoTransakciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CmbPrijimatelAdresa = new System.Windows.Forms.ComboBox();
            this.CmbPrijimatelIBAN = new System.Windows.Forms.ComboBox();
            this.BtnUskutocnitPlatbu = new System.Windows.Forms.Button();
            this.NtbSuma = new Controls.NumericTextBox();
            this.lblUcetOdosielatela = new System.Windows.Forms.Label();
            this.lblUcetPrijimatela = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.TxbVariabilnySymbol = new System.Windows.Forms.TextBox();
            this.TxbSpecifickySymbol = new System.Windows.Forms.TextBox();
            this.TxbKonstatnySymbol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 220);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prijímateľ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 220);
            this.label1.TabIndex = 5;
            this.label1.Text = "Odosielateľ";
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
            this.CmbOdosielatel.Location = new System.Drawing.Point(38, 81);
            this.CmbOdosielatel.Name = "CmbOdosielatel";
            this.CmbOdosielatel.Size = new System.Drawing.Size(248, 24);
            this.CmbOdosielatel.TabIndex = 8;
            this.CmbOdosielatel.SelectedIndexChanged += new System.EventHandler(this.CmbOdosielatel_SelectedIndexChanged);
            // 
            // CmbPrijimatel
            // 
            this.CmbPrijimatel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPrijimatel.FormattingEnabled = true;
            this.CmbPrijimatel.Location = new System.Drawing.Point(368, 81);
            this.CmbPrijimatel.Name = "CmbPrijimatel";
            this.CmbPrijimatel.Size = new System.Drawing.Size(248, 24);
            this.CmbPrijimatel.TabIndex = 9;
            this.CmbPrijimatel.SelectedIndexChanged += new System.EventHandler(this.CmbPrijimatel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vyberte odosielateľa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Moccasin;
            this.label5.Location = new System.Drawing.Point(490, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vyberte prijímateľa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Firebrick;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Firebrick;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(38, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "IBAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Moccasin;
            this.label8.Location = new System.Drawing.Point(563, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adresa";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Moccasin;
            this.label9.Location = new System.Drawing.Point(577, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "IBAN";
            // 
            // CmbOdosielatelAdresa
            // 
            this.CmbOdosielatelAdresa.Enabled = false;
            this.CmbOdosielatelAdresa.FormattingEnabled = true;
            this.CmbOdosielatelAdresa.Location = new System.Drawing.Point(38, 134);
            this.CmbOdosielatelAdresa.Name = "CmbOdosielatelAdresa";
            this.CmbOdosielatelAdresa.Size = new System.Drawing.Size(248, 24);
            this.CmbOdosielatelAdresa.TabIndex = 20;
            // 
            // CmbOdosielatelIBAN
            // 
            this.CmbOdosielatelIBAN.Enabled = false;
            this.CmbOdosielatelIBAN.FormattingEnabled = true;
            this.CmbOdosielatelIBAN.Location = new System.Drawing.Point(38, 185);
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
            this.CmbPrijimatelAdresa.Location = new System.Drawing.Point(368, 134);
            this.CmbPrijimatelAdresa.Name = "CmbPrijimatelAdresa";
            this.CmbPrijimatelAdresa.Size = new System.Drawing.Size(248, 24);
            this.CmbPrijimatelAdresa.TabIndex = 22;
            // 
            // CmbPrijimatelIBAN
            // 
            this.CmbPrijimatelIBAN.Enabled = false;
            this.CmbPrijimatelIBAN.FormattingEnabled = true;
            this.CmbPrijimatelIBAN.Location = new System.Drawing.Point(368, 185);
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
            this.BtnUskutocnitPlatbu.Click += new System.EventHandler(this.button1_Click);
            // 
            // NtbSuma
            // 
            this.NtbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbSuma.Location = new System.Drawing.Point(230, 262);
            this.NtbSuma.Name = "NtbSuma";
            this.NtbSuma.Size = new System.Drawing.Size(200, 36);
            this.NtbSuma.TabIndex = 25;
            // 
            // lblUcetOdosielatela
            // 
            this.lblUcetOdosielatela.AutoSize = true;
            this.lblUcetOdosielatela.Location = new System.Drawing.Point(12, 524);
            this.lblUcetOdosielatela.Name = "lblUcetOdosielatela";
            this.lblUcetOdosielatela.Size = new System.Drawing.Size(54, 17);
            this.lblUcetOdosielatela.TabIndex = 26;
            this.lblUcetOdosielatela.Text = "label10";
            // 
            // lblUcetPrijimatela
            // 
            this.lblUcetPrijimatela.AutoSize = true;
            this.lblUcetPrijimatela.Location = new System.Drawing.Point(574, 524);
            this.lblUcetPrijimatela.Name = "lblUcetPrijimatela";
            this.lblUcetPrijimatela.Size = new System.Drawing.Size(54, 17);
            this.lblUcetPrijimatela.TabIndex = 27;
            this.lblUcetPrijimatela.Text = "label11";
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
            this.label12.Location = new System.Drawing.Point(438, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Konštantný symbol";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(24, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 30);
            this.textBox1.TabIndex = 35;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxbKonstatnySymbol);
            this.Controls.Add(this.TxbSpecifickySymbol);
            this.Controls.Add(this.TxbVariabilnySymbol);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblUcetPrijimatela);
            this.Controls.Add(this.lblUcetOdosielatela);
            this.Controls.Add(this.NtbSuma);
            this.Controls.Add(this.BtnUskutocnitPlatbu);
            this.Controls.Add(this.CmbPrijimatelIBAN);
            this.Controls.Add(this.CmbPrijimatelAdresa);
            this.Controls.Add(this.CmbOdosielatelIBAN);
            this.Controls.Add(this.CmbOdosielatelAdresa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbPrijimatel);
            this.Controls.Add(this.CmbOdosielatel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTransakciaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbOdosielatel;
        private System.Windows.Forms.ComboBox CmbPrijimatel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbOdosielatelAdresa;
        private System.Windows.Forms.ComboBox CmbOdosielatelIBAN;
        private System.Windows.Forms.BindingSource repoTransakciaBindingSource;
        private System.Windows.Forms.BindingSource repoTransakciaBindingSource1;
        private System.Windows.Forms.ComboBox CmbPrijimatelAdresa;
        private System.Windows.Forms.ComboBox CmbPrijimatelIBAN;
        private System.Windows.Forms.Button BtnUskutocnitPlatbu;
        private Controls.NumericTextBox NtbSuma;
        private System.Windows.Forms.Label lblUcetOdosielatela;
        private System.Windows.Forms.Label lblUcetPrijimatela;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox TxbVariabilnySymbol;
        private System.Windows.Forms.TextBox TxbSpecifickySymbol;
        private System.Windows.Forms.TextBox TxbKonstatnySymbol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
    }
}