namespace BankSystem
{
    partial class frmAccount
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
            this.lblNadpis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbKrstneMeno = new System.Windows.Forms.TextBox();
            this.txbPriezvisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUlica = new System.Windows.Forms.TextBox();
            this.txbMesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbObcianskyPreukaz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbIBAN = new System.Windows.Forms.TextBox();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.btnUlozNovehoKlienta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPrecerpanie = new System.Windows.Forms.NumericUpDown();
            this.btnRandomKlient = new System.Windows.Forms.Button();
            this.btnUlozitStarehoKlienta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecerpanie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNadpis
            // 
            this.lblNadpis.AutoSize = true;
            this.lblNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNadpis.Location = new System.Drawing.Point(17, 16);
            this.lblNadpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNadpis.Name = "lblNadpis";
            this.lblNadpis.Size = new System.Drawing.Size(219, 20);
            this.lblNadpis.TabIndex = 0;
            this.lblNadpis.Text = "Zadávanie nového klienta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Krstné meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priezvisko";
            // 
            // txbKrstneMeno
            // 
            this.txbKrstneMeno.Location = new System.Drawing.Point(21, 78);
            this.txbKrstneMeno.Margin = new System.Windows.Forms.Padding(4);
            this.txbKrstneMeno.Name = "txbKrstneMeno";
            this.txbKrstneMeno.Size = new System.Drawing.Size(132, 22);
            this.txbKrstneMeno.TabIndex = 3;
            // 
            // txbPriezvisko
            // 
            this.txbPriezvisko.Location = new System.Drawing.Point(163, 78);
            this.txbPriezvisko.Margin = new System.Windows.Forms.Padding(4);
            this.txbPriezvisko.Name = "txbPriezvisko";
            this.txbPriezvisko.Size = new System.Drawing.Size(132, 22);
            this.txbPriezvisko.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ulica, číslo domu";
            // 
            // txbUlica
            // 
            this.txbUlica.Location = new System.Drawing.Point(304, 78);
            this.txbUlica.Margin = new System.Windows.Forms.Padding(4);
            this.txbUlica.Name = "txbUlica";
            this.txbUlica.Size = new System.Drawing.Size(132, 22);
            this.txbUlica.TabIndex = 6;
            // 
            // txbMesto
            // 
            this.txbMesto.Location = new System.Drawing.Point(445, 78);
            this.txbMesto.Margin = new System.Windows.Forms.Padding(4);
            this.txbMesto.Name = "txbMesto";
            this.txbMesto.Size = new System.Drawing.Size(132, 22);
            this.txbMesto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mesto";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(304, 130);
            this.txbMail.Margin = new System.Windows.Forms.Padding(4);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(273, 22);
            this.txbMail.TabIndex = 12;
            // 
            // txbTelefon
            // 
            this.txbTelefon.Location = new System.Drawing.Point(163, 130);
            this.txbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txbTelefon.Name = "txbTelefon";
            this.txbTelefon.Size = new System.Drawing.Size(132, 22);
            this.txbTelefon.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefónne číslo";
            // 
            // txbObcianskyPreukaz
            // 
            this.txbObcianskyPreukaz.Location = new System.Drawing.Point(21, 130);
            this.txbObcianskyPreukaz.Margin = new System.Windows.Forms.Padding(4);
            this.txbObcianskyPreukaz.Name = "txbObcianskyPreukaz";
            this.txbObcianskyPreukaz.Size = new System.Drawing.Size(132, 22);
            this.txbObcianskyPreukaz.TabIndex = 14;
            this.txbObcianskyPreukaz.TextChanged += new System.EventHandler(this.TxbObcianskyPreukaz_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Číslo OP";
            // 
            // txbIBAN
            // 
            this.txbIBAN.Enabled = false;
            this.txbIBAN.Location = new System.Drawing.Point(21, 197);
            this.txbIBAN.Margin = new System.Windows.Forms.Padding(4);
            this.txbIBAN.Name = "txbIBAN";
            this.txbIBAN.Size = new System.Drawing.Size(273, 22);
            this.txbIBAN.TabIndex = 16;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(17, 176);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(39, 17);
            this.lblIBAN.TabIndex = 15;
            this.lblIBAN.Text = "IBAN";
            // 
            // btnUlozNovehoKlienta
            // 
            this.btnUlozNovehoKlienta.Location = new System.Drawing.Point(21, 245);
            this.btnUlozNovehoKlienta.Margin = new System.Windows.Forms.Padding(4);
            this.btnUlozNovehoKlienta.Name = "btnUlozNovehoKlienta";
            this.btnUlozNovehoKlienta.Size = new System.Drawing.Size(557, 28);
            this.btnUlozNovehoKlienta.TabIndex = 17;
            this.btnUlozNovehoKlienta.Text = "Uložiť nového klienta";
            this.btnUlozNovehoKlienta.UseVisualStyleBackColor = true;
            this.btnUlozNovehoKlienta.Click += new System.EventHandler(this.BtnUlozKlienta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Prečerpanie";
            // 
            // nudPrecerpanie
            // 
            this.nudPrecerpanie.Location = new System.Drawing.Point(304, 198);
            this.nudPrecerpanie.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrecerpanie.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecerpanie.Name = "nudPrecerpanie";
            this.nudPrecerpanie.Size = new System.Drawing.Size(133, 22);
            this.nudPrecerpanie.TabIndex = 19;
            // 
            // btnRandomKlient
            // 
            this.btnRandomKlient.Location = new System.Drawing.Point(445, 198);
            this.btnRandomKlient.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomKlient.Name = "btnRandomKlient";
            this.btnRandomKlient.Size = new System.Drawing.Size(133, 28);
            this.btnRandomKlient.TabIndex = 20;
            this.btnRandomKlient.Text = "Náhodný klient";
            this.btnRandomKlient.UseVisualStyleBackColor = true;
            this.btnRandomKlient.Click += new System.EventHandler(this.BtnRandomKlient_Click);
            // 
            // btnUlozitStarehoKlienta
            // 
            this.btnUlozitStarehoKlienta.Location = new System.Drawing.Point(20, 245);
            this.btnUlozitStarehoKlienta.Margin = new System.Windows.Forms.Padding(4);
            this.btnUlozitStarehoKlienta.Name = "btnUlozitStarehoKlienta";
            this.btnUlozitStarehoKlienta.Size = new System.Drawing.Size(557, 28);
            this.btnUlozitStarehoKlienta.TabIndex = 21;
            this.btnUlozitStarehoKlienta.Text = "Uložiť úpravy klienta";
            this.btnUlozitStarehoKlienta.UseVisualStyleBackColor = true;
            this.btnUlozitStarehoKlienta.Click += new System.EventHandler(this.BtnUlozitStarehoKlienta_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 278);
            this.Controls.Add(this.btnUlozitStarehoKlienta);
            this.Controls.Add(this.btnRandomKlient);
            this.Controls.Add(this.nudPrecerpanie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUlozNovehoKlienta);
            this.Controls.Add(this.txbIBAN);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.txbObcianskyPreukaz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbMesto);
            this.Controls.Add(this.txbUlica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPriezvisko);
            this.Controls.Add(this.txbKrstneMeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNadpis);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(617, 325);
            this.MinimumSize = new System.Drawing.Size(617, 325);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecerpanie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNadpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbKrstneMeno;
        private System.Windows.Forms.TextBox txbPriezvisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUlica;
        private System.Windows.Forms.TextBox txbMesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbObcianskyPreukaz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbIBAN;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Button btnUlozNovehoKlienta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPrecerpanie;
        private System.Windows.Forms.Button btnRandomKlient;
        private System.Windows.Forms.Button btnUlozitStarehoKlienta;
    }
}