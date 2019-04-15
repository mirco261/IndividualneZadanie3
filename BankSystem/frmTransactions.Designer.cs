namespace BankSystem
{
    partial class FrmTransactions
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
            this.DgvTransakcie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransakcie)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTransakcie
            // 
            this.DgvTransakcie.AllowUserToAddRows = false;
            this.DgvTransakcie.AllowUserToDeleteRows = false;
            this.DgvTransakcie.AllowUserToOrderColumns = true;
            this.DgvTransakcie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTransakcie.Location = new System.Drawing.Point(0, 0);
            this.DgvTransakcie.Margin = new System.Windows.Forms.Padding(2);
            this.DgvTransakcie.Name = "DgvTransakcie";
            this.DgvTransakcie.ReadOnly = true;
            this.DgvTransakcie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvTransakcie.RowTemplate.Height = 24;
            this.DgvTransakcie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTransakcie.Size = new System.Drawing.Size(984, 511);
            this.DgvTransakcie.TabIndex = 0;
            // 
            // FrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.DgvTransakcie);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FrmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoznam transakcií";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransakcie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTransakcie;
    }
}