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



    public partial class FrmMain : Form
    {
        FrmMainViewModel ViewModel = new FrmMainViewModel();

        ModelBankomat klient = new ModelBankomat();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrihlasit_Click(object sender, EventArgs e)
        {
            //ošetrím aby vstupné boxy boli vyplnené
            if (NtbKodKarty.Text == "" || NtbPIN.Text == "")
            {
                LblInformacieOPrihlaseni.Text = "Vstupné údaje nesmú byť prázdne";
            }
            else
            {
                //Naplním si klienta do premennej
                klient = ViewModel.NacitajKlienta(int.Parse(NtbKodKarty.Text), int.Parse(NtbPIN.Text));

                //Ak kombinácia karty a PIN nenašla klienta, zakričím 
                if (klient == null)
                {
                    LblInformacieOPrihlaseni.Text = "Zadal si nesprávnu kombináciu karty a PIN";
                }

                //ak je všetko v poriadku, otvorím nové okno a pošlem informáciu o klientovi
                else
                {
                    using (frmVyberAkcie newForm = new frmVyberAkcie(klient))
                    {
                        newForm.ShowDialog();
                    }

                    //vymažem hodnoty na prazdne
                    NtbKodKarty.Text = "";
                    NtbPIN.Text = "";
                }
            }


        }
    }
}
