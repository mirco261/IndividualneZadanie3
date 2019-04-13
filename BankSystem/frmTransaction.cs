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

        //Začiatok formulára
        public FrmTransaction(int IdKlienta, int menu)
        {
            InitializeComponent();

            //Pohrám sa s formulárom podľa potreby
            switch (menu)
            {
                //vklad na ucet
                case 1:
                    {
                        ZapisemKlientaAkoPrijimatela(IdKlienta);
                        SkryjemInfoOOdosielatelovi();
                        break;
                    }
                //vyber z uctu
                case 2:
                    {
                        ZapisemKlientaAkoOdosielatela(IdKlienta);
                        SkryjemInfoOPrijemcovi();
                        break;
                    }
                //Prevod z uctu
                case 3:
                    {
                        ZapisemKlientaAkoOdosielatela(IdKlienta);
                        

                        //Do zoznamu prijímateľov vložím zoznam klientov
                        Prijimatel = viewModel.NacitajzTabulkyKlientov();
                        CmbPrijimatel.DataSource = Prijimatel;
                        CmbPrijimatel.DisplayMember = "Klient";
                        CmbPrijimatelAdresa.DataSource = Prijimatel;
                        CmbPrijimatelAdresa.DisplayMember = "Adresa";
                        CmbPrijimatelIBAN.DataSource = Prijimatel;
                        CmbPrijimatelIBAN.DisplayMember = "UcetIBAN";
                        break;
                    }
                default:
                    break;
            }
        }
        
        //akcia na tlačidlo uskutočni platbu
        private void BtnUskutocnitPlatbu_Click(object sender, EventArgs e)
        {
            //Ak combo odosielatel alebo prijímatel nie je prázdne, použijem hodnotu z komba ako ID účtu pre prevody
            if (CmbOdosielatel.SelectedIndex != -1)
            {
                transakcia.OdosielatelUcetID = (int)Odosielatel.Rows[CmbOdosielatel.SelectedIndex]["UcetID"];
            }
            
            //Ak combo odosielatel alebo prijímatel nie je prázdne, použijem hodnotu z komba ako ID účtu pre prevody
            if (CmbPrijimatel.SelectedIndex != -1)
            {
                transakcia.PrijimatelUcetID = (int)Prijimatel.Rows[CmbPrijimatel.SelectedIndex]["UcetID"];
            }

            //Použijem premenné z textboxov následne do transakcie
            transakcia.Suma = decimal.Parse(NtbSuma.Text);
            transakcia.VariabilnySymbol = TxbVariabilnySymbol.Text;
            transakcia.KonstatnySymbol = TxbKonstatnySymbol.Text;
            transakcia.SpecifickySymbol = TxbSpecifickySymbol.Text;
            transakcia.Sprava = TxbSprava.Text;

            //Zapíš transakciu
            viewModel.ZapisTransakciu(transakcia);

            //zatvor formular
            this.Close();

        }

        private void CmbOdosielatel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
