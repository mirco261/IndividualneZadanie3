namespace BankSystem
{
    partial class frmAccounts
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
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwZoznamKlientov = new System.Windows.Forms.DataGridView();
            this.txbMeno = new System.Windows.Forms.TextBox();
            this.txbPriezvisko = new System.Windows.Forms.TextBox();
            this.txbIBAN = new System.Windows.Forms.TextBox();
            this.lblMeno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZoznamKlientov)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdManageAccount.Location = new System.Drawing.Point(256, 230);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(75, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.CmdManageAccount_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(136, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 91);
            this.label4.TabIndex = 11;
            this.label4.Text = "^\r\nButton na menežovanie aktuálne zvoleného účtu v gride";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwZoznamKlientov
            // 
            this.dgwZoznamKlientov.AllowUserToAddRows = false;
            this.dgwZoznamKlientov.AllowUserToDeleteRows = false;
            this.dgwZoznamKlientov.AllowUserToOrderColumns = true;
            this.dgwZoznamKlientov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwZoznamKlientov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgwZoznamKlientov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZoznamKlientov.Location = new System.Drawing.Point(12, 74);
            this.dgwZoznamKlientov.Name = "dgwZoznamKlientov";
            this.dgwZoznamKlientov.ReadOnly = true;
            this.dgwZoznamKlientov.Size = new System.Drawing.Size(560, 150);
            this.dgwZoznamKlientov.TabIndex = 12;
            // 
            // txbMeno
            // 
            this.txbMeno.Location = new System.Drawing.Point(13, 48);
            this.txbMeno.Name = "txbMeno";
            this.txbMeno.Size = new System.Drawing.Size(100, 20);
            this.txbMeno.TabIndex = 13;
            this.txbMeno.TextChanged += new System.EventHandler(this.TxbMeno_TextChanged);
            // 
            // txbPriezvisko
            // 
            this.txbPriezvisko.Location = new System.Drawing.Point(120, 48);
            this.txbPriezvisko.Name = "txbPriezvisko";
            this.txbPriezvisko.Size = new System.Drawing.Size(100, 20);
            this.txbPriezvisko.TabIndex = 14;
            this.txbPriezvisko.TextChanged += new System.EventHandler(this.TxbPriezvisko_TextChanged);
            // 
            // txbIBAN
            // 
            this.txbIBAN.Location = new System.Drawing.Point(226, 48);
            this.txbIBAN.Name = "txbIBAN";
            this.txbIBAN.Size = new System.Drawing.Size(100, 20);
            this.txbIBAN.TabIndex = 15;
            this.txbIBAN.TextChanged += new System.EventHandler(this.TxbIBAN_TextChanged);
            // 
            // lblMeno
            // 
            this.lblMeno.AutoSize = true;
            this.lblMeno.Location = new System.Drawing.Point(13, 29);
            this.lblMeno.Name = "lblMeno";
            this.lblMeno.Size = new System.Drawing.Size(66, 13);
            this.lblMeno.TabIndex = 16;
            this.lblMeno.Text = "Krstné meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrovanie klienta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Priezvisko";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(223, 29);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(32, 13);
            this.lblIBAN.TabIndex = 19;
            this.lblIBAN.Text = "IBAN";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMeno);
            this.Controls.Add(this.txbIBAN);
            this.Controls.Add(this.txbPriezvisko);
            this.Controls.Add(this.txbMeno);
            this.Controls.Add(this.dgwZoznamKlientov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdManageAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dgwZoznamKlientov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwZoznamKlientov;
        private System.Windows.Forms.TextBox txbMeno;
        private System.Windows.Forms.TextBox txbPriezvisko;
        private System.Windows.Forms.TextBox txbIBAN;
        private System.Windows.Forms.Label lblMeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIBAN;
    }
}