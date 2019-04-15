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
    public partial class FrmTransactions : Form
    {
        FrmTransactionsViewModel viewModel = new FrmTransactionsViewModel();

        /// <summary>
        /// Nepotrebné stĺpce budu skryte
        /// </summary>
        private void SkryjemStlpceKtoreNepotrebujem()
        {
            DgvTransakcie.Columns[0].Visible = false;
            DgvTransakcie.Columns[3].Visible = false;
            DgvTransakcie.Columns[4].Visible = false;
            DgvTransakcie.Columns[11].Visible = false;
            DgvTransakcie.Columns[12].Visible = false;
        }

        /// <summary>
        /// Použijem keď chcem zobraziť všetky transakcie
        /// </summary>
        public FrmTransactions()
        {
            InitializeComponent();
            DgvTransakcie.AutoGenerateColumns = true;
            DgvTransakcie.DataSource = viewModel.NacitajTransakcie();
            DgvTransakcie.DataMember = "Transakcie";

            SkryjemStlpceKtoreNepotrebujem();
        }


        /// <summary>
        /// použité, keď chcem zobraziť transakcie iba konkrétneho clienta
        /// </summary>
        /// <param name="clientId">ID Klienta</param>
        public FrmTransactions(int clientId)
        {
            InitializeComponent();
            DgvTransakcie.AutoGenerateColumns = true;
            DgvTransakcie.DataSource = viewModel.NacitajTransakcie(clientId);
            DgvTransakcie.DataMember = "Transakcie";

            SkryjemStlpceKtoreNepotrebujem();
        }
    }
}
