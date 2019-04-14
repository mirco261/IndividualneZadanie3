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
    public partial class frmVyberAkcie : Form
    {
        ModelBankomat klientInfo = new ModelBankomat();

        public frmVyberAkcie(ModelBankomat klient)
        {
            klientInfo = klient;
            InitializeComponent();
            LblPrivitanie.Text = $"Dobrý deň zákazník \n{klient.KlientMeno}\nVyberte si z ponuky bankomatu";


        }

        private void BtnStavUctu_Click(object sender, EventArgs e)
        {
            using (FrmStavUctu newForm = new FrmStavUctu(klientInfo))
            {
                newForm.ShowDialog();
            }
        }

        private void BtnZatvor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVyberHotovosti_Click(object sender, EventArgs e)
        {
            using (frmVyberZUctu newForm = new frmVyberZUctu(klientInfo))
            {
                newForm.ShowDialog();
                
            }
            this.Close();
        }
    }
}
