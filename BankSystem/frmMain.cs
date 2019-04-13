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

        FrmMainViewModel klient = new FrmMainViewModel();
        /// <summary>
        /// Používam ju na prenos vyhľadaného id podľa vyhľadávača
        /// </summary>
        public int Id { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void CmdFindClient_Click(object sender, EventArgs e)
        {
            //naplním si do premenej text z vyhľadávania
            string hladaj = txbHladajKlienta.Text;

            //vynechám medzery
            hladaj.Replace(" ", "");

            //ošetrím aby užívateľ zadal aspoň 3 znaky
            if (hladaj.Length<3)
            {
                lblInfoOUzivatelovi.Text = "Zadaj aspoň tri znaky vyhľadávaného výrazu";
            }

            //ošetrím, aby užívateľ zadal výraz, ktorý existuje
            else if (klient.HladajKlienta(hladaj) > 0)
            {
                lblInfoOUzivatelovi.Text = "";
                Id = klient.HladajKlienta(hladaj);
                using (FrmClientManagement newForm = new FrmClientManagement(Id))
                {
                    newForm.ShowDialog();
                }
            }
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
            }
        }

        private void CmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (FrmAccounts newForm = new FrmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void CmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }

        private void TxbHladajKlienta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
