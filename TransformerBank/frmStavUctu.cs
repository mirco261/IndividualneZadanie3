using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;

namespace TransformerBank
{
    public partial class FrmStavUctu : Form
    {
        ModelBankomat klientStav = new ModelBankomat();

        public FrmStavUctu(ModelBankomat klient)
        {
            klientStav = klient;
            InitializeComponent();
            LblPrivitanie.Text = $"Vážený zákazník \n{klientStav.KlientMeno}\n";

            NtbPovolenePrecerpanie.Text = klientStav.Precerpanie.ToString();
            NtbStavUctu.Text = klientStav.StavUctu.ToString();

        }

        private void BtnZatvor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVyberHotovosti_Click(object sender, EventArgs e)
        {
            using (frmVyberZUctu newForm = new frmVyberZUctu(klientStav))
            {
                newForm.ShowDialog();
            }
        }
    }
}
