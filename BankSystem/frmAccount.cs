using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.Properties;
using Controls;
using Data.Models;

namespace BankSystem
{
    public partial class frmAccount : Form
    {
        //properties na zapisovanie nového klienta
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Adresa { get; set; }
        public string Mesto { get; set; }
        public string CisloOP { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string IBAN { get; set; }
        public int Precerpanie { get; set; }
        public int PocetKariet { get; set; }

        //inicializujem si dataview 
        FrmAccountViewModel NovyKlient = new FrmAccountViewModel();

        
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();

            //Vygeneruje IBAN
            txbIBAN.Text = NovyKlient.VratIBAN();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
        }



        private void BtnRandomKlient_Click(object sender, EventArgs e)
        {
            ModelKlient randomKlient = new ModelKlient();

            //načítam si random klienta z randomizeru
            randomKlient = NovyKlient.VratRandomKlienta();

            //Naplním jednotlivé textboxy random hodnotami
            txbKrstneMeno.Text = randomKlient.Meno;
            txbPriezvisko.Text = randomKlient.Priezvisko;
            txbUlica.Text = randomKlient.Ulica;
            txbMesto.Text = randomKlient.Mesto;
            txbObcianskyPreukaz.Text = randomKlient.OP;
            txbTelefon.Text = randomKlient.Telefon;
            txbMail.Text = randomKlient.Mail;
            IBAN = txbIBAN.Text;
            Precerpanie = (int)nudPrecerpanie.Value;
        }

        private void BtnUlozKlienta_Click(object sender, EventArgs e)
        {
            Meno = txbKrstneMeno.Text;
            Priezvisko = txbPriezvisko.Text;
            Adresa = txbUlica.Text;
            Mesto = txbMesto.Text;
            CisloOP = txbObcianskyPreukaz.Text;
            Telefon = txbTelefon.Text;
            Mail = txbMail.Text;
            IBAN = txbIBAN.Text;
            Precerpanie = (int)nudPrecerpanie.Value;

            NovyKlient.ZapisKlientaDoDb(Meno, Priezvisko, Adresa, Mesto, CisloOP, Telefon, Mail, IBAN, Precerpanie);
            this.Close();

        }
    }
}
