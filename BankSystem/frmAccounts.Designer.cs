﻿namespace BankSystem
{
    partial class FrmAccounts
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
            this.cmdManageAccount.Location = new System.Drawing.Point(17, 391);
            this.cmdManageAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(746, 29);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Pracuj s vybraným riadkom";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.CmdManageAccount_Click);
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
            this.dgwZoznamKlientov.Location = new System.Drawing.Point(16, 91);
            this.dgwZoznamKlientov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwZoznamKlientov.Name = "dgwZoznamKlientov";
            this.dgwZoznamKlientov.ReadOnly = true;
            this.dgwZoznamKlientov.Size = new System.Drawing.Size(747, 292);
            this.dgwZoznamKlientov.TabIndex = 12;
            // 
            // txbMeno
            // 
            this.txbMeno.Location = new System.Drawing.Point(17, 59);
            this.txbMeno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMeno.Name = "txbMeno";
            this.txbMeno.Size = new System.Drawing.Size(132, 22);
            this.txbMeno.TabIndex = 13;
            this.txbMeno.TextChanged += new System.EventHandler(this.TxbMeno_TextChanged);
            // 
            // txbPriezvisko
            // 
            this.txbPriezvisko.Location = new System.Drawing.Point(160, 59);
            this.txbPriezvisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPriezvisko.Name = "txbPriezvisko";
            this.txbPriezvisko.Size = new System.Drawing.Size(132, 22);
            this.txbPriezvisko.TabIndex = 14;
            this.txbPriezvisko.TextChanged += new System.EventHandler(this.TxbPriezvisko_TextChanged);
            // 
            // txbIBAN
            // 
            this.txbIBAN.Location = new System.Drawing.Point(301, 59);
            this.txbIBAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIBAN.Name = "txbIBAN";
            this.txbIBAN.Size = new System.Drawing.Size(132, 22);
            this.txbIBAN.TabIndex = 15;
            this.txbIBAN.TextChanged += new System.EventHandler(this.TxbIBAN_TextChanged);
            // 
            // lblMeno
            // 
            this.lblMeno.AutoSize = true;
            this.lblMeno.Location = new System.Drawing.Point(17, 36);
            this.lblMeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeno.Name = "lblMeno";
            this.lblMeno.Size = new System.Drawing.Size(88, 17);
            this.lblMeno.TabIndex = 16;
            this.lblMeno.Text = "Krstné meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrovanie klienta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Priezvisko";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(297, 36);
            this.lblIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(39, 17);
            this.lblIBAN.TabIndex = 19;
            this.lblIBAN.Text = "IBAN";
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 433);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMeno);
            this.Controls.Add(this.txbIBAN);
            this.Controls.Add(this.txbPriezvisko);
            this.Controls.Add(this.txbMeno);
            this.Controls.Add(this.dgwZoznamKlientov);
            this.Controls.Add(this.cmdManageAccount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dgwZoznamKlientov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
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