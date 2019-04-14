using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;

namespace TransformerBank
{
    public partial class frmVyberZUctu : Form
    {
        ModelBankomat klientVyber = new ModelBankomat();

        FrmVyberZUctuViewModel viewModel = new FrmVyberZUctuViewModel();

        ModelTransakcia transakcia = new ModelTransakcia();
        
        public frmVyberZUctu(ModelBankomat klient)
        {
            InitializeComponent();

            //Naplním si klienta informáciami
            klientVyber = klient;

            LblPrivitanie.Text = $"Vážený zákazník {klientVyber.KlientMeno}\nZadajte čiastku,\nktorú chcete vybrať z účtu";

            //naplním hodnoty
            NtbPovolenePrecerpanie.Text = klientVyber.Precerpanie.ToString();
            NtbStavUctu.Text = klientVyber.StavUctu.ToString();



        }

        private void LblCiastka_Click(object sender, EventArgs e)
        {

        }

        private void BtnZatvor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NtbVyberCiastka_TextChanged(object sender, EventArgs e)
        {


        }

        private async void BtnVyberHotovosti_ClickAsync(object sender, EventArgs e)
        {

            //vyhodnotím, či môže vôbec urobiť výber
            if (NtbVyberCiastka.Text == "")
            {
                LblUpozornenie.Text = "Zadajte hodnotu na výber";
            }

            else if (klientVyber.StavUctu - int.Parse(NtbVyberCiastka.Text) < -klientVyber.Precerpanie)
            {
                LblUpozornenie.Text = "Nedostatok peňazí na výber";
            }
            //ak má dosť peňazí, urobí výber
            else
            {
                LblUpozornenie.Text = "";

                //Zapíš transakciu
                transakcia.OdosielatelUcetID = klientVyber.IDUcet;
                transakcia.Sprava = "Výber z bankomatu";
                transakcia.Suma = int.Parse(NtbVyberCiastka.Text);
                viewModel.ZapisTransakciu(transakcia);

                //Zobrazím podľakovanie a zavrem frm
                LblPodakovanie.Visible = true;
                await Task.Delay(4000);

                //Zatvorím frm
                this.Close();

            }
        }
    }
}
