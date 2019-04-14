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

namespace TransformerBank
{

    
    
    public partial class FrmMain : Form
    {
        FrmMainViewModel ViewModel = new FrmMainViewModel();

        ModelBankomat klient = new ModelBankomat();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrihlasit_Click(object sender, EventArgs e)
        {
             klient = ViewModel.NacitajKlienta(int.Parse(NtbKodKarty.Text), int.Parse(NtbPIN.Text));
            if (klient == null)
            {
                label3.Text = "Zadal si nespravne";
            }
            else
            {
                label3.Text = $"{klient.KlientMeno}";
            }
        }
    }
}
