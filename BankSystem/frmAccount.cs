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
        ModelKlient Klient = new ModelKlient();

        //property pre posielanie ID
        public int ID { get; set; }

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
        /// Načítam do ModelKlient info o klientovi z formulára
        /// </summary>
        private ModelKlient NacitajKlientaZformulara()
        {
            Klient.Meno = txbKrstneMeno.Text;
            Klient.Priezvisko = txbPriezvisko.Text;
            Klient.Ulica = txbUlica.Text;
            Klient.Mesto = txbMesto.Text;
            Klient.OP = txbObcianskyPreukaz.Text;
            Klient.Telefon = txbTelefon.Text;
            Klient.Mail = txbMail.Text;
            Klient.IBAN = txbIBAN.Text;
            Klient.Precerpanie = (int)nudPrecerpanie.Value;
            Klient.DatumZalozenia = DateTime.Now;

            //vynechám medzery na OP
            Klient.OP = Klient.OP.Replace(" ", "");

            return Klient;
        }

        /// <summary>
        /// Frm použitý pri úprave existujúceho klienta
        /// </summary>
        /// <param name="clientId">ID klienta z minulého frm - aby som vedel ktorého editovať</param>
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
            //Použijem metodu na načítanie klienta z frm
            NacitajKlientaZformulara();

            //Zapíšem nového klienta do DB
            NovyKlient.ZapisKlientaDoDb(Klient);
            this.Close();
        }

        //Keď upravujem už existujúceho klienta, použijem toto tlačidlo
        private void BtnUlozitStarehoKlienta_Click(object sender, EventArgs e)
        {
            //Použijem metodu na načítanie klienta z frm
            Klient = NacitajKlientaZformulara();

            //prebijem ID s ID klienta, aby upravoval toho správneho
            Klient.ID = ID;

            //Updatnem klienta so zvoleným ID do DB
            NovyKlient.UpravKlientaDoDb(Klient);
            this.Close();
        }
    }
}
