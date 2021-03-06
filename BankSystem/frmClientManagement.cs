﻿using System;
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
    public partial class FrmClientManagement : Form
    {

        FrmClientManagementViewModel klientConnection = new FrmClientManagementViewModel();

        ModelKlient klient = new ModelKlient();

        public int IdKlienta { get; set; }

        Random CisloKarty = new Random();

        /// <summary>
        /// Načíta nové horné info o klientovi
        /// </summary>
        private void NacitajNoveInfoOKlientoviDoHornehoMenu()
        {
            klient = klientConnection.NacitajKlientaPodlaID(IdKlienta);
            lblIBAN.Text = klient.IBAN;
            lblMailovaAdresa.Text = klient.Mail;
            lblMenoPriezvisko.Text = klient.Meno + " " + klient.Priezvisko;
            lblTelefonneCislo.Text = klient.Telefon;
            lblAdresa.Text = klient.Ulica + ", " + klient.Mesto;
            lblPovolenePrecerpanie.Text = klient.Precerpanie.ToString() + " EUR";
            lblStavNaUcte.Text = klient.StavNaUcte.ToString() + " EUR";
            lblObcianskyPreukaz.Text = klient.OP;
            LblDatumZalozenia.Text = klient.DatumZalozenia.ToShortDateString();
        }

        /// <summary>
        /// Načíta zoznam platobných kariet do pravého gridu
        /// </summary>
        private void NacitajZoznamPlatobnychKariet()
        {
            DgwZoznamPlatobnychKariet.AutoGenerateColumns = true;
            DgwZoznamPlatobnychKariet.DataSource = klientConnection.NacitajPlatobneKarty(IdKlienta);
            DgwZoznamPlatobnychKariet.DataMember = "Karty";
            DgwZoznamPlatobnychKariet.Columns[0].Visible = false;
            DgwZoznamPlatobnychKariet.Columns[1].Visible = false;
            DgwZoznamPlatobnychKariet.Columns[3].Visible = false;
            BtnZmenZablokovanieKarty.Visible = true;
        }

        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        public FrmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public FrmClientManagement(int clientId)
        {
            InitializeComponent();

            //prevezmem ID klienta z predchádzajúceho okna
            IdKlienta = clientId;

            //načítam horné info o klientovi
            NacitajNoveInfoOKlientoviDoHornehoMenu();

            //zistím, či klient má platobné karty
            if (klientConnection.ZistiCiMaKlientPlatobneKarty(clientId) > 0)
            {
                //načítam datagridview o platobných kartách klienta
                NacitajZoznamPlatobnychKariet();
            }
            else BtnZmenZablokovanieKarty.Visible = false;

            //Zistím, či je aktívny, ak nie je, upravím všetko toto dole
            if (klient.Aktivny == false)
            {
                cmdAllTransactions.Enabled = false;
                cmdCloseAccount.Enabled = false;
                cmdDeposit.Enabled = false;
                cmdNewTransaction.Enabled = false;
                cmdUpdate.Enabled = false;
                cmdWithdrawal.Enabled = false;
                BtnPridajKartu.Enabled = false;
                BtnZmenZablokovanieKarty.Enabled = false;
                lblDeaktivovanyUcet.Visible = true;
            }
            else
            {
                cmdAllTransactions.Enabled = true;
                cmdCloseAccount.Enabled = true;
                cmdDeposit.Enabled = true;
                cmdNewTransaction.Enabled = true;
                cmdUpdate.Enabled = true;
                cmdWithdrawal.Enabled = true;
                BtnPridajKartu.Enabled = true;
                BtnZmenZablokovanieKarty.Enabled = true;
                lblDeaktivovanyUcet.Visible = false;
            }
        }



        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(IdKlienta))
            {
                newForm.ShowDialog();
            }
            //načítam nové horné info o klientovi
            NacitajNoveInfoOKlientoviDoHornehoMenu();
        }



        private void CmdDeposit_Click(object sender, EventArgs e)
        {
            //Menu 1 = Vklad
            int menu = 1;
            using (FrmTransaction newForm = new FrmTransaction(IdKlienta, menu))
            {
                newForm.ShowDialog();
                //načítam nové horné info o klientovi
                NacitajNoveInfoOKlientoviDoHornehoMenu();
            }
        }

        private void CmdWithdrawal_Click(object sender, EventArgs e)
        {
            //Menu 2 = Výber
            int menu = 2;
            using (FrmTransaction newForm = new FrmTransaction(IdKlienta, menu))
            {
                newForm.ShowDialog();
                //načítam nové horné info o klientovi
                NacitajNoveInfoOKlientoviDoHornehoMenu();
            }
        }

        private void CmdNewTransaction_Click(object sender, EventArgs e)
        {
            //Menu 3 = Prevod
            int menu = 3;
            using (FrmTransaction newForm = new FrmTransaction(IdKlienta, menu))
            {
                newForm.ShowDialog();
                //načítam nové horné info o klientovi
                NacitajNoveInfoOKlientoviDoHornehoMenu();
            }
        }

        private void CmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (FrmTransactions newForm = new FrmTransactions(IdKlienta))
            {
                newForm.ShowDialog();
                //načítam nové horné info o klientovi
                NacitajNoveInfoOKlientoviDoHornehoMenu();
            }
        }



        private void CmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Naozaj chcete zneaktívniť účet klienta?\nTáto operácia sa nedá vrátiť späť!", "Dôležité upozornenie!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //dám príkaz aby sa mu zneaktívnil účet

                klientConnection.ZatvorUcetKlientovi(IdKlienta);

                DialogResult = DialogResult.OK;



            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnZmenZablokovanieKarty_Click(object sender, EventArgs e)
        {
            
            int idKarty = Convert.ToInt32(DgwZoznamPlatobnychKariet.CurrentRow.Cells[1].Value);
            bool stav = Convert.ToBoolean(DgwZoznamPlatobnychKariet.CurrentRow.Cells[5].Value);
            int indexKliknutehoRiadka = DgwZoznamPlatobnychKariet.CurrentRow.Index;

            klientConnection.ZmenZablokovanieKarty(idKarty, stav);

            //načítam datagridview o platobných kartách klienta
            NacitajZoznamPlatobnychKariet();

            //Zmením názov na tlačidle
             stav = Convert.ToBoolean(DgwZoznamPlatobnychKariet.CurrentRow.Cells[5].Value);
            BtnZmenZablokovanieKarty.Text = stav == true ?  "Odblokuj kartu" : "Zablokuj kartu";
            
        }

        private void DgwZoznamPlatobnychKariet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            bool stav = Convert.ToBoolean(DgwZoznamPlatobnychKariet.CurrentRow.Cells[5].Value);

            BtnZmenZablokovanieKarty.Text = stav == true ? "Odblokuj kartu" : "Zablokuj kartu";
        }

        private void BtnPridajKartu_Click(object sender, EventArgs e)
        {
            int RndCislo;

            do
            {
                //vygenerujem si random číslo karty
                RndCislo = CisloKarty.Next(100, 9999);

                //a generujem ich dovtedy, kym nenajdem prázdne
            } while (klientConnection.ZistiCiExistujeCisloKarty(RndCislo) != 0);

            //zapíšem kartu
            klientConnection.PridajKartu(RndCislo, IdKlienta);

            //resetnem dgw s kartami
            NacitajZoznamPlatobnychKariet();

            //vyberiem datagrid, aby si mohol stlačiť tlačidlo aktivuj/deaktivuj
            DgwZoznamPlatobnychKariet.Select();

            //zaktivujem tlačidlo pre úpravu karty
            BtnZmenZablokovanieKarty.Visible = true;


        }
    }
}
