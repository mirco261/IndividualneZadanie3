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
        /// <param name="meno"></param>
        /// <param name="priezvisko"></param>
        /// <param name="adresa"></param>
        /// <param name="mesto"></param>
        /// <param name="cisloOP"></param>
        /// <param name="telefon"></param>
        /// <param name="mail"></param>
        /// <param name="iban"></param>
        /// <param name="precerpanie"></param>
        public void ZapisKlientaDoDb(string meno, string priezvisko, string adresa, string mesto, string cisloOP, string telefon, string mail, string iban, int precerpanie, DateTime datum)
        {
            NovyKlient.ZapisKlientaDoDb(meno, priezvisko, adresa, mesto, cisloOP, telefon, mail, iban, precerpanie, datum);
        }

        /// <summary>
        /// prenášam informácie o klientovi a upravujem jeho existujúce údaje
        /// </summary>
        /// <param name="meno"></param>
        /// <param name="priezvisko"></param>
        /// <param name="adresa"></param>
        /// <param name="mesto"></param>
        /// <param name="cisloOP"></param>
        /// <param name="telefon"></param>
        /// <param name="mail"></param>
        /// <param name="iban"></param>
        /// <param name="precerpanie"></param>
        public void UpravKlientaDoDb(int ID, string meno, string priezvisko, string adresa, string mesto, string cisloOP, string telefon, string mail, string iban, int precerpanie)
        {
            NovyKlient.UpravKlientaDoDb(ID, meno, priezvisko, adresa, mesto, cisloOP, telefon, mail, iban, precerpanie);
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
