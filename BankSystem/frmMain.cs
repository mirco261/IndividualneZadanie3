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
    public partial class frmMain : Form
    {

        FrmMainViewModel klient = new FrmMainViewModel();
        /// <summary>
        /// Používam ju na prenos vyhľadaného id podľa vyhľadávača
        /// </summary>
        public int id { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void CmdFindClient_Click(object sender, EventArgs e)
        {
            string hladaj = txbHladajKlienta.Text;

            //ošetrím, aby užívateľ zadal výraz, ktorý existuje
            if (klient.HladajKlienta(hladaj) > 0)
            {
                lblInfoOUzivatelovi.Text = "";
                id = klient.HladajKlienta(hladaj);
            }
            else
            {
                lblInfoOUzivatelovi.Text = "Zadaný klient neexistuje";
            }
            using (FrmClientManagement newForm = new FrmClientManagement(id))
            {
                newForm.ShowDialog();

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
