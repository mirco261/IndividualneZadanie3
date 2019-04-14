namespace TransformerBank
{
    partial class FrmStavUctu
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
            this.LblPrivitanie = new System.Windows.Forms.Label();
            this.BtnZatvor = new System.Windows.Forms.Button();
            this.NtbStavUctu = new Controls.NumericTextBox();
            this.NtbPovolenePrecerpanie = new Controls.NumericTextBox();
            this.LblStavUctu = new System.Windows.Forms.Label();
            this.LblPovolenePrecerpanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPrivitanie
            // 
            this.LblPrivitanie.AutoSize = true;
            this.LblPrivitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPrivitanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblPrivitanie.Location = new System.Drawing.Point(21, 22);
            this.LblPrivitanie.Name = "LblPrivitanie";
            this.LblPrivitanie.Size = new System.Drawing.Size(165, 29);
            this.LblPrivitanie.TabIndex = 1;
            this.LblPrivitanie.Text = "LblPrivitanie";
            // 
            // BtnZatvor
            // 
            this.BtnZatvor.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnZatvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZatvor.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnZatvor.Location = new System.Drawing.Point(286, 381);
            this.BtnZatvor.Name = "BtnZatvor";
            this.BtnZatvor.Size = new System.Drawing.Size(193, 80);
            this.BtnZatvor.TabIndex = 3;
            this.BtnZatvor.Text = "NÁVRAT";
            this.BtnZatvor.UseVisualStyleBackColor = false;
            this.BtnZatvor.Click += new System.EventHandler(this.BtnZatvor_Click);
            // 
            // NtbStavUctu
            // 
            this.NtbStavUctu.Enabled = false;
            this.NtbStavUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbStavUctu.ForeColor = System.Drawing.Color.DarkBlue;
            this.NtbStavUctu.Location = new System.Drawing.Point(133, 177);
            this.NtbStavUctu.Name = "NtbStavUctu";
            this.NtbStavUctu.Size = new System.Drawing.Size(247, 45);
            this.NtbStavUctu.TabIndex = 5;
            // 
            // NtbPovolenePrecerpanie
            // 
            this.NtbPovolenePrecerpanie.Enabled = false;
            this.NtbPovolenePrecerpanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbPovolenePrecerpanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.NtbPovolenePrecerpanie.Location = new System.Drawing.Point(133, 282);
            this.NtbPovolenePrecerpanie.Name = "NtbPovolenePrecerpanie";
            this.NtbPovolenePrecerpanie.Size = new System.Drawing.Size(247, 45);
            this.NtbPovolenePrecerpanie.TabIndex = 6;
            // 
            // LblStavUctu
            // 
            this.LblStavUctu.AutoSize = true;
            this.LblStavUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblStavUctu.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblStavUctu.Location = new System.Drawing.Point(128, 145);
            this.LblStavUctu.Name = "LblStavUctu";
            this.LblStavUctu.Size = new System.Drawing.Size(128, 29);
            this.LblStavUctu.TabIndex = 7;
            this.LblStavUctu.Text = "Stav účtu";
            // 
            // LblPovolenePrecerpanie
            // 
            this.LblPovolenePrecerpanie.AutoSize = true;
            this.LblPovolenePrecerpanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPovolenePrecerpanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblPovolenePrecerpanie.Location = new System.Drawing.Point(128, 250);
            this.LblPovolenePrecerpanie.Name = "LblPovolenePrecerpanie";
            this.LblPovolenePrecerpanie.Size = new System.Drawing.Size(279, 29);
            this.LblPovolenePrecerpanie.TabIndex = 8;
            this.LblPovolenePrecerpanie.Text = "Povolené prečerpanie";
            // 
            // FrmStavUctu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 483);
            this.Controls.Add(this.LblPovolenePrecerpanie);
            this.Controls.Add(this.LblStavUctu);
            this.Controls.Add(this.NtbPovolenePrecerpanie);
            this.Controls.Add(this.NtbStavUctu);
            this.Controls.Add(this.BtnZatvor);
            this.Controls.Add(this.LblPrivitanie);
            this.MaximumSize = new System.Drawing.Size(530, 530);
            this.MinimumSize = new System.Drawing.Size(530, 530);
            this.Name = "FrmStavUctu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStavUctu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrivitanie;
        private System.Windows.Forms.Button BtnZatvor;
        private Controls.NumericTextBox NtbStavUctu;
        private Controls.NumericTextBox NtbPovolenePrecerpanie;
        private System.Windows.Forms.Label LblStavUctu;
        private System.Windows.Forms.Label LblPovolenePrecerpanie;
    }
}