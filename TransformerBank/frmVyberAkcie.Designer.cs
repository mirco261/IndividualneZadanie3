namespace TransformerBank
{
    partial class frmVyberAkcie
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
            this.BtnVyberHotovosti = new System.Windows.Forms.Button();
            this.BtnZatvor = new System.Windows.Forms.Button();
            this.BtnStavUctu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPrivitanie
            // 
            this.LblPrivitanie.AutoSize = true;
            this.LblPrivitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPrivitanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblPrivitanie.Location = new System.Drawing.Point(26, 22);
            this.LblPrivitanie.Name = "LblPrivitanie";
            this.LblPrivitanie.Size = new System.Drawing.Size(165, 29);
            this.LblPrivitanie.TabIndex = 0;
            this.LblPrivitanie.Text = "LblPrivitanie";
            // 
            // BtnVyberHotovosti
            // 
            this.BtnVyberHotovosti.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnVyberHotovosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnVyberHotovosti.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnVyberHotovosti.Location = new System.Drawing.Point(31, 381);
            this.BtnVyberHotovosti.Name = "BtnVyberHotovosti";
            this.BtnVyberHotovosti.Size = new System.Drawing.Size(193, 80);
            this.BtnVyberHotovosti.TabIndex = 1;
            this.BtnVyberHotovosti.Text = "Výber hotovosti";
            this.BtnVyberHotovosti.UseVisualStyleBackColor = false;
            this.BtnVyberHotovosti.Click += new System.EventHandler(this.BtnVyberHotovosti_Click);
            // 
            // BtnZatvor
            // 
            this.BtnZatvor.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnZatvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZatvor.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnZatvor.Location = new System.Drawing.Point(286, 381);
            this.BtnZatvor.Name = "BtnZatvor";
            this.BtnZatvor.Size = new System.Drawing.Size(193, 80);
            this.BtnZatvor.TabIndex = 2;
            this.BtnZatvor.Text = "KONIEC";
            this.BtnZatvor.UseVisualStyleBackColor = false;
            this.BtnZatvor.Click += new System.EventHandler(this.BtnZatvor_Click);
            // 
            // BtnStavUctu
            // 
            this.BtnStavUctu.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnStavUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnStavUctu.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnStavUctu.Location = new System.Drawing.Point(31, 277);
            this.BtnStavUctu.Name = "BtnStavUctu";
            this.BtnStavUctu.Size = new System.Drawing.Size(193, 80);
            this.BtnStavUctu.TabIndex = 3;
            this.BtnStavUctu.Text = "Stav účtu";
            this.BtnStavUctu.UseVisualStyleBackColor = false;
            this.BtnStavUctu.Click += new System.EventHandler(this.BtnStavUctu_Click);
            // 
            // frmVyberAkcie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 483);
            this.Controls.Add(this.BtnStavUctu);
            this.Controls.Add(this.BtnZatvor);
            this.Controls.Add(this.BtnVyberHotovosti);
            this.Controls.Add(this.LblPrivitanie);
            this.MaximumSize = new System.Drawing.Size(530, 530);
            this.MinimumSize = new System.Drawing.Size(530, 530);
            this.Name = "frmVyberAkcie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVyberAkcie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrivitanie;
        private System.Windows.Forms.Button BtnVyberHotovosti;
        private System.Windows.Forms.Button BtnZatvor;
        private System.Windows.Forms.Button BtnStavUctu;
    }
}