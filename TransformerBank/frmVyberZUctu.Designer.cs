namespace TransformerBank
{
    partial class frmVyberZUctu
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
            this.NtbStavUctu = new Controls.NumericTextBox();
            this.LblCiastka = new System.Windows.Forms.Label();
            this.LblPovolenePrecerpanie = new System.Windows.Forms.Label();
            this.LblStavUctu = new System.Windows.Forms.Label();
            this.NtbPovolenePrecerpanie = new Controls.NumericTextBox();
            this.NtbVyberCiastka = new Controls.NumericTextBox();
            this.BtnVyberHotovosti = new System.Windows.Forms.Button();
            this.BtnZatvor = new System.Windows.Forms.Button();
            this.LblUpozornenie = new System.Windows.Forms.Label();
            this.LblPodakovanie = new System.Windows.Forms.Label();
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
            this.LblPrivitanie.TabIndex = 2;
            this.LblPrivitanie.Text = "LblPrivitanie";
            // 
            // NtbStavUctu
            // 
            this.NtbStavUctu.Enabled = false;
            this.NtbStavUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbStavUctu.ForeColor = System.Drawing.Color.DarkBlue;
            this.NtbStavUctu.Location = new System.Drawing.Point(12, 190);
            this.NtbStavUctu.Name = "NtbStavUctu";
            this.NtbStavUctu.Size = new System.Drawing.Size(210, 45);
            this.NtbStavUctu.TabIndex = 6;
            // 
            // LblCiastka
            // 
            this.LblCiastka.AutoSize = true;
            this.LblCiastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblCiastka.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblCiastka.Location = new System.Drawing.Point(120, 250);
            this.LblCiastka.Name = "LblCiastka";
            this.LblCiastka.Size = new System.Drawing.Size(217, 29);
            this.LblCiastka.TabIndex = 8;
            this.LblCiastka.Text = "Čiastka k výberu";
            this.LblCiastka.Click += new System.EventHandler(this.LblCiastka_Click);
            // 
            // LblPovolenePrecerpanie
            // 
            this.LblPovolenePrecerpanie.AutoSize = true;
            this.LblPovolenePrecerpanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPovolenePrecerpanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblPovolenePrecerpanie.Location = new System.Drawing.Point(268, 158);
            this.LblPovolenePrecerpanie.Name = "LblPovolenePrecerpanie";
            this.LblPovolenePrecerpanie.Size = new System.Drawing.Size(235, 29);
            this.LblPovolenePrecerpanie.TabIndex = 12;
            this.LblPovolenePrecerpanie.Text = "Povolené prečerp.";
            // 
            // LblStavUctu
            // 
            this.LblStavUctu.AutoSize = true;
            this.LblStavUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblStavUctu.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblStavUctu.Location = new System.Drawing.Point(12, 158);
            this.LblStavUctu.Name = "LblStavUctu";
            this.LblStavUctu.Size = new System.Drawing.Size(128, 29);
            this.LblStavUctu.TabIndex = 11;
            this.LblStavUctu.Text = "Stav účtu";
            // 
            // NtbPovolenePrecerpanie
            // 
            this.NtbPovolenePrecerpanie.Enabled = false;
            this.NtbPovolenePrecerpanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbPovolenePrecerpanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.NtbPovolenePrecerpanie.Location = new System.Drawing.Point(273, 190);
            this.NtbPovolenePrecerpanie.Name = "NtbPovolenePrecerpanie";
            this.NtbPovolenePrecerpanie.Size = new System.Drawing.Size(210, 45);
            this.NtbPovolenePrecerpanie.TabIndex = 10;
            // 
            // NtbVyberCiastka
            // 
            this.NtbVyberCiastka.AllowDecimals = false;
            this.NtbVyberCiastka.AllowNegative = false;
            this.NtbVyberCiastka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbVyberCiastka.ForeColor = System.Drawing.Color.DarkBlue;
            this.NtbVyberCiastka.Location = new System.Drawing.Point(125, 282);
            this.NtbVyberCiastka.Name = "NtbVyberCiastka";
            this.NtbVyberCiastka.Size = new System.Drawing.Size(250, 45);
            this.NtbVyberCiastka.TabIndex = 9;
            this.NtbVyberCiastka.TextChanged += new System.EventHandler(this.NtbVyberCiastka_TextChanged);
            // 
            // BtnVyberHotovosti
            // 
            this.BtnVyberHotovosti.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnVyberHotovosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnVyberHotovosti.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnVyberHotovosti.Location = new System.Drawing.Point(31, 381);
            this.BtnVyberHotovosti.Name = "BtnVyberHotovosti";
            this.BtnVyberHotovosti.Size = new System.Drawing.Size(193, 80);
            this.BtnVyberHotovosti.TabIndex = 13;
            this.BtnVyberHotovosti.Text = "Potvrdit výber";
            this.BtnVyberHotovosti.UseVisualStyleBackColor = false;
            this.BtnVyberHotovosti.Click += new System.EventHandler(this.BtnVyberHotovosti_ClickAsync);
            // 
            // BtnZatvor
            // 
            this.BtnZatvor.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnZatvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZatvor.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnZatvor.Location = new System.Drawing.Point(286, 381);
            this.BtnZatvor.Name = "BtnZatvor";
            this.BtnZatvor.Size = new System.Drawing.Size(193, 80);
            this.BtnZatvor.TabIndex = 14;
            this.BtnZatvor.Text = "KONIEC";
            this.BtnZatvor.UseVisualStyleBackColor = false;
            this.BtnZatvor.Click += new System.EventHandler(this.BtnZatvor_Click);
            // 
            // LblUpozornenie
            // 
            this.LblUpozornenie.AutoSize = true;
            this.LblUpozornenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblUpozornenie.ForeColor = System.Drawing.Color.Red;
            this.LblUpozornenie.Location = new System.Drawing.Point(7, 339);
            this.LblUpozornenie.Name = "LblUpozornenie";
            this.LblUpozornenie.Size = new System.Drawing.Size(0, 29);
            this.LblUpozornenie.TabIndex = 15;
            // 
            // LblPodakovanie
            // 
            this.LblPodakovanie.BackColor = System.Drawing.Color.DarkBlue;
            this.LblPodakovanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPodakovanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPodakovanie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPodakovanie.Location = new System.Drawing.Point(31, 22);
            this.LblPodakovanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPodakovanie.Name = "LblPodakovanie";
            this.LblPodakovanie.Size = new System.Drawing.Size(448, 439);
            this.LblPodakovanie.TabIndex = 16;
            this.LblPodakovanie.Text = "Ďakujeme Vám za využitie našich služieb a prajeme Vám pekný deň";
            this.LblPodakovanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPodakovanie.Visible = false;
            // 
            // frmVyberZUctu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 483);
            this.Controls.Add(this.LblPodakovanie);
            this.Controls.Add(this.LblUpozornenie);
            this.Controls.Add(this.BtnZatvor);
            this.Controls.Add(this.BtnVyberHotovosti);
            this.Controls.Add(this.LblPovolenePrecerpanie);
            this.Controls.Add(this.LblStavUctu);
            this.Controls.Add(this.NtbPovolenePrecerpanie);
            this.Controls.Add(this.NtbVyberCiastka);
            this.Controls.Add(this.LblCiastka);
            this.Controls.Add(this.NtbStavUctu);
            this.Controls.Add(this.LblPrivitanie);
            this.MaximumSize = new System.Drawing.Size(530, 530);
            this.MinimumSize = new System.Drawing.Size(530, 530);
            this.Name = "frmVyberZUctu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVyberZUctu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrivitanie;
        private Controls.NumericTextBox NtbStavUctu;
        private System.Windows.Forms.Label LblCiastka;
        private System.Windows.Forms.Label LblPovolenePrecerpanie;
        private System.Windows.Forms.Label LblStavUctu;
        private Controls.NumericTextBox NtbPovolenePrecerpanie;
        private Controls.NumericTextBox NtbVyberCiastka;
        private System.Windows.Forms.Button BtnVyberHotovosti;
        private System.Windows.Forms.Button BtnZatvor;
        private System.Windows.Forms.Label LblUpozornenie;
        private System.Windows.Forms.Label LblPodakovanie;
    }
}