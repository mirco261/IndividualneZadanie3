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
    public partial class frmTransactions : Form
    {
        FrmTransactionsViewModel viewModel = new FrmTransactionsViewModel();

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();
            DgvTransakcie.AutoGenerateColumns = true;
            DgvTransakcie.DataSource = viewModel.NacitajTransakcie();
            DgvTransakcie.DataMember = "Transakcie";
            DgvTransakcie.Columns[0].Visible = false;
            DgvTransakcie.Columns[3].Visible = false;
            DgvTransakcie.Columns[4].Visible = false;
            DgvTransakcie.Columns[10].Visible = false;
            DgvTransakcie.Columns[11].Visible = false;


        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(int clientId)
        {
            InitializeComponent();

            DgvTransakcie.AutoGenerateColumns = true;
            DgvTransakcie.DataSource = viewModel.NacitajTransakcie(clientId);
            DgvTransakcie.DataMember = "Transakcie";
            DgvTransakcie.Columns[0].Visible = false;
            DgvTransakcie.Columns[3].Visible = false;
            DgvTransakcie.Columns[4].Visible = false;
            DgvTransakcie.Columns[10].Visible = false;
            DgvTransakcie.Columns[11].Visible = false;
        }
    }
}
