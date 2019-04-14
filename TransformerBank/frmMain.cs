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

        int pokus = 1;
        string CisloKartyAktualna;
        string CisloKartyPredchadzajuca;

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
                    //načítam si kartu, ktorú teraz použil
                    CisloKartyAktualna = NtbKodKarty.Text;

                    //ak sa karty rovnaju, započítam pokus
                    if (CisloKartyAktualna == CisloKartyPredchadzajuca)
                    {
                        //navýšim počet pokusov
                        pokus++;
                    }

                    //prevezmem hodnotu aktualnej karty do predchádzajúcej
                    CisloKartyPredchadzajuca = CisloKartyAktualna;

                    //ak dosiahol počet pokusov, zablokujem kartu
                    if (pokus == 3)
                    {
                        LblInformacieOPrihlaseni.Text = "Platobná karta bola zablokovaná";
                        ViewModel.ZablokujKartu(int.Parse(NtbKodKarty.Text));
                    }
                    //ak nedosiahol, iba upozorním že nezadal dobrú kombináciu karty a pin
                    else
                    {
                        LblInformacieOPrihlaseni.Text = "Zadal si nesprávnu kombináciu karty a PIN";
                    }
                }

                //ak je všetko v poriadku, otvorím nové okno a pošlem informáciu o klientovi
                else
                {
                    using (frmVyberAkcie newForm = new frmVyberAkcie(klient))
                    {
                        newForm.ShowDialog();
                    }

                    //vymažem hodnoty na defaultne
                    NtbKodKarty.Text = "";
                    NtbPIN.Text = "";
                    pokus = 1;
                }
            }


        }
    }
}
