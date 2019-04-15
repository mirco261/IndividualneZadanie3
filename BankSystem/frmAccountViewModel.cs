using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using BankSystem.Properties;
using Controls;
using Data.Models;


namespace BankSystem
{
    class FrmAccountViewModel
    {
        RepoKlient NovyKlient = new RepoKlient();


        /// <summary>
        /// prenášam informácie o klientovi a zapisujem nového
        /// </summary>
        public void ZapisKlientaDoDb(ModelKlient klient)
        {
            NovyKlient.ZapisKlientaDoDb(klient);
        }

        /// <summary>
        /// prenášam informácie o klientovi a upravujem jeho existujúce údaje
        /// </summary>
        public void UpravKlientaDoDb(ModelKlient klient)
        {
            NovyKlient.UpravKlientaDoDb(klient);
        }

        //inicializujem si generator
        Generator generator = new Generator();

        /// <summary>
        /// Vytvorí mi random IBAN
        /// </summary>
        /// <returns></returns>
        public string VratIBAN()
        {
            string iban;
            Random randomIBAN = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append("SK");
            for (int i = 0; i < 4; i++)
            {
                iban = randomIBAN.Next(100000, 999999).ToString();
                sb.Append(iban);
            }
            return sb.ToString();
        }

        /// <summary>
        /// vytvorí náhodného klienta a vráti ho ako objekt klient
        /// </summary>
        /// <returns></returns>
        public ModelKlient VratRandomKlienta()
        {
            ModelKlient klient = new ModelKlient();
            string randomKlient = generator.GetRandomPerson();
            string[] line = randomKlient.Split(';');
            klient.Priezvisko = line[0];
            klient.Meno = line[1];
            klient.OP = line[3];
            klient.Telefon = line[4];
            klient.Telefon = line[4];
            klient.Mail = line[5];
            string randomAdress = generator.GetRandomAddress();
            string[] address = randomAdress.Split(';');
            klient.Ulica = address[0];
            klient.Mesto = address[2];

            return klient;
        }

        /// <summary>
        /// Načítam klieta, keď zadám jeho ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>vráti mi dataset, kde je iba 1 klient</returns>
        public ModelKlient NacitajKlientaPodlaID(int id)
        {
            return NovyKlient.NacitajKlientaPodlaID(id);
        }



    }
}
