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
        public DateTime Datum { get; set; }

        //inicializujem si dataview 
        FrmAccountViewModel NovyKlient = new FrmAccountViewModel();

        /// <summary>
        /// Načíta klienta do textboxov vo formulári (môžem použiť načítaného alebo random)
        /// </summary>
        /// <param name="klient"></param>
        private void NacitajKlientaDoTextBoxov(ModelKlient klient)
        {
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
        /// Keď pridávam nového klienta
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();

            //zobrazím správne tlačidlá na ukladanie
            btnUlozitStarehoKlienta.Visible = false;
            btnUlozNovehoKlienta.Visible = true;
            this.Text = "Pridanie nového klienta";
         }

        /// <summary>
        /// Frm použitý pri úprave existujúceho klienta
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
            this.Text = "Editácia existujúceho klienta";

            //Zobrazím tlačidlo na uloženie existujúceho klienta
            btnUlozitStarehoKlienta.Visible = true;
            btnUlozNovehoKlienta.Visible = false;

            //Zapíšem si ID klienta
            ID = clientId;

            //vytvorím si všetky potrebné veci z viewModelu
            FrmAccountViewModel KlientPrenos = new FrmAccountViewModel();
            ModelKlient klient = new ModelKlient();

            //načítam všetky polia klientom
            klient = KlientPrenos.NacitajKlientaPodlaID(clientId);
            NacitajKlientaDoTextBoxov(klient);
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
            NacitajKlientaDoTextBoxov(randomKlient);

            //prebijem hodnoty random hodnotami
            txbIBAN.Text = NovyKlient.VratIBAN();
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
            Datum = DateTime.Now;    

            //vynechám medzery na OP
            CisloOP = CisloOP.Replace(" ", "");

            NovyKlient.ZapisKlientaDoDb(Meno, Priezvisko, Adresa, Mesto, CisloOP, Telefon, Mail, IBAN, Precerpanie, Datum);
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

            //vynechám medzery na OP
            CisloOP = CisloOP.Replace(" ", "");

            NovyKlient.UpravKlientaDoDb(ID, Meno, Priezvisko, Adresa, Mesto, CisloOP, Telefon, Mail, IBAN, Precerpanie);
            this.Close();
        }
    }
}
