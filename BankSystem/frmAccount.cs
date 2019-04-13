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
        public int ID { get; set; }
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
            btnUlozitStarehoKlienta.Visible = false;
            btnUlozNovehoKlienta.Visible = true;

 

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

            //Zobrazím tlačidlo na uloženie existujúceho klienta
            btnUlozitStarehoKlienta.Visible = true;
            btnUlozNovehoKlienta.Visible = false;

            //Zapíšem si ID klienta
            ID = clientId;

            FrmAccountViewModel KlientPrenos = new FrmAccountViewModel();

            ModelKlient klient = new ModelKlient();

            klient = KlientPrenos.NacitajKlientaPodlaID(clientId);

            txbKrstneMeno.Text = klient.Meno;
            txbPriezvisko.Text = klient.Priezvisko;
            txbUlica.Text = klient.Ulica;
            txbMesto.Text = klient.Mesto;
            txbObcianskyPreukaz.Text = klient.OP;
            txbTelefon.Text = klient.Telefon;
            txbMail.Text = klient.Mail;
            txbIBAN.Text = klient.IBAN;
            nudPrecerpanie.Value = klient.Precerpanie;
        }


        /// <summary>
        /// tlačidlom vygenerujem random klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRandomKlient_Click(object sender, EventArgs e)
        {
            ModelKlient randomKlient = new ModelKlient();

            Random precerpanieRnd = new Random();

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
            nudPrecerpanie.Value = precerpanieRnd.Next(200,1000);
        }


        //Keď je zákazník nový, použijem toto tlačidlo
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

            //vynechám medzery na OP
            CisloOP = CisloOP.Replace(" ", "");

            NovyKlient.ZapisKlientaDoDb(Meno, Priezvisko, Adresa, Mesto, CisloOP, Telefon, Mail, IBAN, Precerpanie);
            this.Close();

        }


        //Keď upravujem už existujúceho klienta, použijem toto tlačidlo
        private void BtnUlozitStarehoKlienta_Click(object sender, EventArgs e)
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

            NovyKlient.UpravKlientaDoDb(ID, Meno, Priezvisko, Adresa, Mesto, CisloOP, Telefon, Mail, IBAN, Precerpanie);
            this.Close();
        }

        private void TxbObcianskyPreukaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
