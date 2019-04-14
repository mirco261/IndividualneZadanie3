namespace TransformerBank
{
    partial class FrmMain
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
            this.NtbKodKarty = new Controls.NumericTextBox();
            this.NtbPIN = new Controls.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrihlasit = new System.Windows.Forms.Button();
            this.LblInformacieOPrihlaseni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NtbKodKarty
            // 
            this.NtbKodKarty.AllowDecimals = false;
            this.NtbKodKarty.AllowNegative = false;
            this.NtbKodKarty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbKodKarty.Location = new System.Drawing.Point(208, 163);
            this.NtbKodKarty.Name = "NtbKodKarty";
            this.NtbKodKarty.Size = new System.Drawing.Size(239, 45);
            this.NtbKodKarty.TabIndex = 0;
            // 
            // NtbPIN
            // 
            this.NtbPIN.AllowDecimals = false;
            this.NtbPIN.AllowNegative = false;
            this.NtbPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NtbPIN.Location = new System.Drawing.Point(208, 224);
            this.NtbPIN.Name = "NtbPIN";
            this.NtbPIN.Size = new System.Drawing.Size(239, 45);
            this.NtbPIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(84, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "KARTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN";
            // 
            // BtnPrihlasit
            // 
            this.BtnPrihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrihlasit.Location = new System.Drawing.Point(208, 289);
            this.BtnPrihlasit.Name = "BtnPrihlasit";
            this.BtnPrihlasit.Size = new System.Drawing.Size(239, 49);
            this.BtnPrihlasit.TabIndex = 4;
            this.BtnPrihlasit.Text = "Prihlásiť";
            this.BtnPrihlasit.UseVisualStyleBackColor = true;
            this.BtnPrihlasit.Click += new System.EventHandler(this.BtnPrihlasit_Click);
            // 
            // LblInformacieOPrihlaseni
            // 
            this.LblInformacieOPrihlaseni.AutoSize = true;
            this.LblInformacieOPrihlaseni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblInformacieOPrihlaseni.ForeColor = System.Drawing.Color.Maroon;
            this.LblInformacieOPrihlaseni.Location = new System.Drawing.Point(89, 352);
            this.LblInformacieOPrihlaseni.Name = "LblInformacieOPrihlaseni";
            this.LblInformacieOPrihlaseni.Size = new System.Drawing.Size(17, 25);
            this.LblInformacieOPrihlaseni.TabIndex = 5;
            this.LblInformacieOPrihlaseni.Text = " ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(512, 483);
            this.Controls.Add(this.LblInformacieOPrihlaseni);
            this.Controls.Add(this.BtnPrihlasit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NtbPIN);
            this.Controls.Add(this.NtbKodKarty);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(530, 530);
            this.MinimumSize = new System.Drawing.Size(530, 530);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NumericTextBox NtbKodKarty;
        private Controls.NumericTextBox NtbPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPrihlasit;
        private System.Windows.Forms.Label LblInformacieOPrihlaseni;
    }
}

