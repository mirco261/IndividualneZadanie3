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

namespace BankSystem
{
    public partial class FrmTransaction : Form
    {

        //Vytvorím si objekt pre prenos dát z view Model
        FrmTransactionViewModel viewModel = new FrmTransactionViewModel();

        //vytvorím si objekt transakcie - info o transakcií
        ModelTransakcia transakcia = new ModelTransakcia();

        //vytvorím si novú datatable
        DataTable Prijimatel = new DataTable();
        DataTable Odosielatel = new DataTable();

        //premenna klient id a typ transakcie
        public int Klient { get; set; }
        public int TypTransakcie { get; set; }

        
        /// <summary>
        /// Metoda, pomocou ktorej zapisem do infa o prijimatelovi preneseneho klienta
        /// </summary>
        /// <param name="IdKlienta"></param>
        private void ZapisemKlientaAkoPrijimatela(int IdKlienta)
        {
            Prijimatel = viewModel.NacitajzTabulkyKlientov(IdKlienta);
            CmbPrijimatel.DataSource = Prijimatel;
            CmbPrijimatel.DisplayMember = "Klient";
            CmbPrijimatelAdresa.DataSource = Prijimatel;
            CmbPrijimatelAdresa.DisplayMember = "Adresa";
            CmbPrijimatelIBAN.DataSource = Prijimatel;
            CmbPrijimatelIBAN.DisplayMember = "UcetIBAN";
        }

        /// <summary>
        /// Metoda, pomocou ktorej zapisem do infa o odosielatelovi preneseneho klienta
        /// </summary>
        /// <param name="IdKlienta"></param>
        private void ZapisemKlientaAkoOdosielatela(int IdKlienta)
        {
            Odosielatel = viewModel.NacitajzTabulkyKlientov(IdKlienta);
            CmbOdosielatel.DataSource = Odosielatel;
            CmbOdosielatel.DisplayMember = "Klient";
            CmbOdosielatelAdresa.DataSource = Odosielatel;
            CmbOdosielatelAdresa.DisplayMember = "Adresa";
            CmbOdosielatelIBAN.DataSource = Odosielatel;
            CmbOdosielatelIBAN.DisplayMember = "UcetIBAN";
        }

        /// <summary>
        /// Skryjem info o odosielatelovi - ked napríklad je vklad do banky
        /// </summary>
        private void SkryjemInfoOOdosielatelovi()
        {
            CmbOdosielatel.Visible = false;
            CmbOdosielatelAdresa.Visible = false;
            CmbOdosielatelIBAN.Visible = false;
            LblOdosielatelMeno.Visible = false;
            LblOdosielatelAdresa.Visible = false;
            LblIbanOdosielatela.Visible = false;
            LblOdosielatel.Visible = false;
            LblPrijemca.Text = "Vkladateľ";
            LblPrijemcaMeno.Text = "Vkladateľ";

        }

        /// <summary>
        /// Skryjem info o príjemcovi - ked napríklad je výber do banky
        /// </summary>
        private void SkryjemInfoOPrijemcovi()
        {
            CmbPrijimatel.Visible = false;
            CmbPrijimatelAdresa.Visible = false;
            CmbPrijimatelIBAN.Visible = false;
            LblPrijemcaMeno.Visible = false;
            LblPrijemcaAdresa.Visible = false;
            LblIbanPrijemca.Visible = false;
            LblPrijemca.Visible = false;
            LblOdosielatel.Text = "Príjemca";
            LblOdosielatelMeno.Text = "Príjemca";
        }

        /// <summary>
        /// Do zoznamu prijímateľov vložím zoznam klientov
        /// </summary>
        private void VlozDoZoznamuPrijimatelovZoznamKlientov()
        {
            Prijimatel = viewModel.NacitajzTabulkyKlientov();
            CmbPrijimatel.DataSource = Prijimatel;
            CmbPrijimatel.DisplayMember = "Klient";
            CmbPrijimatelAdresa.DataSource = Prijimatel;
            CmbPrijimatelAdresa.DisplayMember = "Adresa";
            CmbPrijimatelIBAN.DataSource = Prijimatel;
            CmbPrijimatelIBAN.DisplayMember = "UcetIBAN";
        }

        //Začiatok formulára
        public FrmTransaction(int IdKlienta, int menu)
        {
            InitializeComponent();

            //uložím si klienta
            Klient = IdKlienta;

            //uložím si premennú pre menu - aby som vedel kedy mam pozerať stav účtu
            TypTransakcie = menu;

            //vyčistím text upozornenia
            lblUpozornenie.Text = "";

            //Pohrám sa s formulárom podľa potreby
            switch (menu)
            {
                //vklad na ucet
                case 1:
                    {
                        ZapisemKlientaAkoPrijimatela(IdKlienta);
                        SkryjemInfoOOdosielatelovi();
                        this.Text = "Vklad na účet";
                        break;
                    }
                //vyber z uctu
                case 2:
                    {
                        ZapisemKlientaAkoOdosielatela(IdKlienta);
                        SkryjemInfoOPrijemcovi();
                        this.Text = "Výber peňazí z banky";
                        break;
                    }
                //Prevod z uctu
                case 3:
                    {
                        ZapisemKlientaAkoOdosielatela(IdKlienta);
                        VlozDoZoznamuPrijimatelovZoznamKlientov();
                        this.Text = "Medziúčtový prevod";
                        break;
                    }
                default:
                    break;
            }
        }

        //akcia na tlačidlo uskutočni platbu
        private void BtnUskutocnitPlatbu_Click(object sender, EventArgs e)
        {
            //vyčistím text upozornenia
            lblUpozornenie.Text = "";

            //načítam si info o klientovi
            ModelKlient ucastnik = viewModel.NacitajKlientaPodlaID(Klient);

            //overím či zadal sumu
            if (NtbSuma.Text == "")
            {
                lblUpozornenie.Text = "Suma nesmie byť prázdna";
            }

            //overim, či ma dostatok peňazí na účte
            else if (ucastnik.StavNaUcte - decimal.Parse(NtbSuma.Text) < ucastnik.Precerpanie *-1  && TypTransakcie != 1)
            {
                lblUpozornenie.Text = "Nedostatok peňazí na účte";
            }

            //Zapíšem platbu
            else
            {
                //Použijem premenné z textboxov následne do transakcie
                transakcia.Suma = decimal.Parse(NtbSuma.Text);
                transakcia.VariabilnySymbol = NtbVS.Text;
                transakcia.KonstatnySymbol = NtbKS.Text;
                transakcia.SpecifickySymbol = NtbSS.Text;
                transakcia.Sprava = TxbSprava.Text;
                
                //Zapíšem obrat na účte odosielateľa - Ak combo odosielatel alebo prijímatel nie je prázdne, použijem hodnotu z komba ako ID účtu pre prevody
                if (CmbOdosielatel.SelectedIndex != -1)
                {
                    transakcia.OdosielatelUcetID = (int)Odosielatel.Rows[CmbOdosielatel.SelectedIndex]["UcetID"];
                }

                //Zapíšem obrat na účte príjemcu - Ak combo odosielatel alebo prijímatel nie je prázdne, použijem hodnotu z komba ako ID účtu pre prevody
                if (CmbPrijimatel.SelectedIndex != -1)
                {
                    transakcia.PrijimatelUcetID = (int)Prijimatel.Rows[CmbPrijimatel.SelectedIndex]["UcetID"];
                }

                //Zapíš transakciu
                viewModel.ZapisTransakciu(transakcia);

                //zatvor formular
                this.Close();
            }
        }

        private void NtbSuma_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
