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
    public partial class FrmAccounts : Form
    {
        FrmAccountsViewModel ZoznamKlientov = new FrmAccountsViewModel();

        /// <summary>
        /// Property na vyhľadávanie mena
        /// </summary>
        public string Meno { get; set; }

        /// <summary>
        /// Property na vyhľadávanie priezviska
        /// </summary>
        public string Priezvisko { get; set; }

        /// <summary>
        /// Property na vyhľadávanie IBANu
        /// </summary>
        public string IBAN { get; set; }

        //načíta mi zoznam klientov - pregeneruje a prekreslí
        private void NacitajZoznamKlientov()
        {
            dgwZoznamKlientov.AutoGenerateColumns = true;
            dgwZoznamKlientov.DataSource = ZoznamKlientov.NacitajzTabulkyPerson(txbMeno.Text, txbPriezvisko.Text, txbIBAN.Text);
            dgwZoznamKlientov.DataMember = "Klient";
            dgwZoznamKlientov.Columns[0].Visible = false;
        }


        public FrmAccounts()
        {
            InitializeComponent();
            NacitajZoznamKlientov();

            if (dgwZoznamKlientov.Rows.Count == 0)
            {
                cmdManageAccount.Enabled = false;

            }
        }



        private void CmdManageAccount_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwZoznamKlientov.CurrentRow.Cells[0].Value);

            using (FrmClientManagement newForm = new FrmClientManagement(id))
            {
                newForm.ShowDialog();
                //pregeneruj dgw
                NacitajZoznamKlientov();
            }
        }

        private void TxbMeno_TextChanged(object sender, EventArgs e)
        {
            dgwZoznamKlientov.DataSource = ZoznamKlientov.NacitajzTabulkyPerson(txbMeno.Text, txbPriezvisko.Text, txbIBAN.Text);
            dgwZoznamKlientov.DataMember = "Klient";
        }

        private void TxbPriezvisko_TextChanged(object sender, EventArgs e)
        {
            dgwZoznamKlientov.DataSource = ZoznamKlientov.NacitajzTabulkyPerson(txbMeno.Text, txbPriezvisko.Text, txbIBAN.Text);
            dgwZoznamKlientov.DataMember = "Klient";
        }

        private void TxbIBAN_TextChanged(object sender, EventArgs e)
        {
            dgwZoznamKlientov.DataSource = ZoznamKlientov.NacitajzTabulkyPerson(txbMeno.Text, txbPriezvisko.Text, txbIBAN.Text);
            dgwZoznamKlientov.DataMember = "Klient";
        }
    }
}
