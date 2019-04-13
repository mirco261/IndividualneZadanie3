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
    public partial class FrmClientManagement : Form
    {

        FrmClientManagementViewModel klientConnection = new FrmClientManagementViewModel();

        ModelKlient klient = new ModelKlient();

        public int IdKlienta { get; set; }

        Random CisloKarty = new Random();



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
            klient =  klientConnection.NacitajKlientaPodlaID(clientId);
            lblIBAN.Text = klient.IBAN;
            lblMailovaAdresa.Text = klient.Mail;
            lblMenoPriezvisko.Text = klient.Meno + " " + klient.Priezvisko;
            lblTelefonneCislo.Text = klient.Telefon;
            lblAdresa.Text = klient.Ulica + ", " + klient.Mesto;
            lblPovolenePrecerpanie.Text = klient.Precerpanie.ToString() + " EUR";
            lblStavNaUcte.Text = klient.StavNaUcte.ToString() + " EUR";
            lblObcianskyPreukaz.Text = klient.OP;

            //zistím, či klient má platobné karty
            if (klientConnection.ZistiCiMaKlientPlatobneKarty(clientId) > 0)
            {
                //načítam datagridview o platobných kartách klienta
                DgwZoznamPlatobnychKariet.AutoGenerateColumns = true;
                DgwZoznamPlatobnychKariet.DataSource = klientConnection.NacitajPlatobneKarty(IdKlienta);
                DgwZoznamPlatobnychKariet.DataMember = "Karty";
                DgwZoznamPlatobnychKariet.Columns[0].Visible = false;
                DgwZoznamPlatobnychKariet.Columns[1].Visible = false;
                DgwZoznamPlatobnychKariet.Columns[3].Visible = false;

            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(IdKlienta))
            {
                newForm.ShowDialog();
            }

            //načítam nové horné info o klientovi
            klient = klientConnection.NacitajKlientaPodlaID(IdKlienta);
            lblIBAN.Text = klient.IBAN;
            lblMailovaAdresa.Text = klient.Mail;
            lblMenoPriezvisko.Text = klient.Meno + " " + klient.Priezvisko;
            lblTelefonneCislo.Text = klient.Telefon;
            lblAdresa.Text = klient.Ulica + ", " + klient.Mesto;
            lblPovolenePrecerpanie.Text = klient.Precerpanie.ToString() + " EUR";
            lblStavNaUcte.Text = klient.StavNaUcte.ToString() + " EUR";
            lblObcianskyPreukaz.Text = klient.OP;
        }

        private void CmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void CmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void CmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void CmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void CmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
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

            klientConnection.ZmenZablokovanieKarty(idKarty, stav);

            //načítam datagridview o platobných kartách klienta
            DgwZoznamPlatobnychKariet.AutoGenerateColumns = true;
            DgwZoznamPlatobnychKariet.DataSource = klientConnection.NacitajPlatobneKarty(IdKlienta);
            DgwZoznamPlatobnychKariet.DataMember = "Karty";
            DgwZoznamPlatobnychKariet.Columns[0].Visible = false;
            DgwZoznamPlatobnychKariet.Columns[1].Visible = false;
            DgwZoznamPlatobnychKariet.Columns[3].Visible = false;
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
            //načítam datagridview o platobných kartách klienta
            DgwZoznamPlatobnychKariet.AutoGenerateColumns = true;
            DgwZoznamPlatobnychKariet.DataSource = klientConnection.NacitajPlatobneKarty(IdKlienta);
            DgwZoznamPlatobnychKariet.DataMember = "Karty";
            DgwZoznamPlatobnychKariet.Columns[0].Visible = false;
            DgwZoznamPlatobnychKariet.Columns[1].Visible = false;
            DgwZoznamPlatobnychKariet.Columns[3].Visible = false;

        }
    }
}
