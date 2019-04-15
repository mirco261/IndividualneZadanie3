using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class FrmMain : Form
    {
        //načíta štatistiky do bočného meu
        private void NacitajStatistiky()
        {
            //štatistika top10 klientov
            DgwTOP10.AutoGenerateColumns = true;
            DgwTOP10.DataSource = klient.Top10klientov();
            DgwTOP10.DataMember = "Top10";

            //štatistika zakladná 
            NtbSumaNaUctoch.Text = klient.PocetPenaziNaUctoch().ToString();
            NtbPocetAktivnychUctov.Text = klient.PocetUctov().ToString();

            //štatistika top mestá
            DgvTopMesta.AutoGenerateColumns = true;
            DgvTopMesta.DataSource = klient.TopMestaKlienti();
            DgvTopMesta.DataMember = "Mesta";

            //štatistika počet  založených účtov podľa mesiacov
            DgwPocetUctov.AutoGenerateColumns = true;
            DgwPocetUctov.DataSource = klient.PocetZalozenychUctovPoMesiacoch();
            DgwPocetUctov.DataMember = "Top6";
        }

        /// <summary>
        /// Vytvorím viewModel
        /// </summary>
        FrmMainViewModel klient = new FrmMainViewModel();

        /// <summary>
        /// Používam ju na prenos vyhľadaného id podľa vyhľadávača
        /// </summary>
        public int Id { get; set; }


        public FrmMain()
        {
            InitializeComponent();
            NacitajStatistiky();
        }

        private void CmdFindClient_Click(object sender, EventArgs e)
        {
            //naplním si do premenej text z vyhľadávania
            string hladaj = txbHladajKlienta.Text;

            //vynechám medzery
            hladaj.Replace(" ", "");

            //ošetrím aby užívateľ zadal aspoň 3 znaky
            if (hladaj.Length < 3)
            {
                lblInfoOUzivatelovi.Text = "Zadaj aspoň tri znaky vyhľadávaného výrazu";
            }

            //ošetrím, aby užívateľ zadal výraz, ktorý existuje
            else if (klient.HladajKlienta(hladaj) > 0)
            {
                lblInfoOUzivatelovi.Text = "";
                Id = klient.HladajKlienta(hladaj);

                //otvor nový formulár
                using (FrmClientManagement newForm = new FrmClientManagement(Id))
                {
                    newForm.ShowDialog();
                    NacitajStatistiky();
                }
            }

            //ošetrím, ak užívateľa nenájdem, informujem o tom užívateľa
            else
            {
                lblInfoOUzivatelovi.Text = "Zadaný klient neexistuje";
            }
        }

        private void CmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {
                newForm.ShowDialog();
                NacitajStatistiky();
            }
        }

        private void CmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (FrmAccounts newForm = new FrmAccounts())
            {
                newForm.ShowDialog();
                NacitajStatistiky();
            }
        }

        private void CmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (FrmTransactions newForm = new FrmTransactions())
            {
                newForm.ShowDialog();
                NacitajStatistiky();
            }
        }
    }
}
