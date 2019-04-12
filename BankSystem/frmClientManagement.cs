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

        frmClientManagementViewModel klientConnection = new frmClientManagementViewModel();

        ModelKlient klient = new ModelKlient();

        public int IdKlienta { get; set; }



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
    }
}
