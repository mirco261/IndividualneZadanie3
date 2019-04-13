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

        //vytvorím si novú datatable
        DataTable Prijimatel = new DataTable();
        DataTable Odosielatel = new DataTable();

        public FrmTransaction()
        {
            InitializeComponent();


            //vytvorím si objekt pre klientov, aby som ich vedel vkladať do comboboxov
            //ModelKlientTransakcia klient = new ModelKlientTransakcia();




            //natiahnem si do klienta všetkých klientov z dtb
            Prijimatel =  viewModel.NacitajzTabulkyKlientov();
            Odosielatel = viewModel.NacitajzTabulkyKlientov();

            //vyplním políčka odosielateľa
            CmbOdosielatel.DataSource = Odosielatel;
            CmbOdosielatel.DisplayMember = "Klient";
            CmbOdosielatelAdresa.DataSource = Odosielatel;
            CmbOdosielatelAdresa.DisplayMember = "Adresa";
            CmbOdosielatelIBAN.DataSource = Odosielatel;
            CmbOdosielatelIBAN.DisplayMember = "UcetIBAN";

            //vyplním políčka prijímateľa
            CmbPrijimatel.DataSource = Prijimatel;
            CmbPrijimatel.DisplayMember = "Klient";
            CmbPrijimatelAdresa.DataSource = Prijimatel;
            CmbPrijimatelAdresa.DisplayMember = "Adresa";
            CmbPrijimatelIBAN.DataSource = Prijimatel;
            CmbPrijimatelIBAN.DisplayMember = "UcetIBAN";

            ////testovanie
            //lblUcetOdosielatela.Text = Odosielatel.Rows[0]["UcetID"].ToString();
            //lblUcetPrijimatela.Text = Prijimatel.Rows[0]["UcetID"].ToString();

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void CmbOdosielatel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbPrijimatel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //testovanie
            lblUcetOdosielatela.Text = Odosielatel.Rows[CmbOdosielatel.SelectedIndex]["UcetID"].ToString();
            lblUcetPrijimatela.Text = Prijimatel.Rows[CmbPrijimatel.SelectedIndex]["UcetID"].ToString();
        }
    }
}
