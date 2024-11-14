
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;


namespace linq2xml
{
    //jednostavna klasa customer
    public class Klijent_class
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EmailAdresa { get; set; }
    }

    // gllavni program

    public class Tester
    {
        static void Main()
        {
            List<Klijent_class> ListaKlijenata = CreateCustomerList();

            var dokumentXmlKlijenti = new XDocument();
            var rootElem = new XElement("lista_klijenata");
            dokumentXmlKlijenti.Add(rootElem);
            foreach (Klijent_class customer in ListaKlijenata)
            {
                /*  kreirenja elemenata
                //Pravi novi element koji predstavlja svojstvo Ime
                var customerElem = new XElement("Klijent");

                //Dodaje element koji predstavlja svojstvo Ime za element customer
                var ImeElem = new XElement("Ime", customer.Ime);
                customerElem.Add(ImeElem);

                //Dodaje element koji predstavlja svojstvo Prezime za element customer
                var PrezimeElem = new XElement("Prezime", customer.Prezime);
                customerElem.Add(PrezimeElem);

                //Dodaje element koji predstavlja svojstvo EmailAdresa za element customer
                var EmailAdresa = new XElement("EmailAdress", customer.EmailAdresa);
                customerElem.Add(EmailAdresa);

                //Dodaje element customer u XML dokument
                rootElem.Add(customerElem);
                */

                // kreiranje elemenata i atributa
                /*
                //Pravi novi element koji predstavlja svojstvo Customer
                var customerElem = new XElement("Customer");

                //Dodaje element koji predstavlja svojstvo FirstName za element customer
                var firstNameAttr = new XAttribute("FirstName", customer.Ime);
                customerElem.Add(firstNameAttr);

                //Dodaje element koji predstavlja svojstvo LastName za element customer
                var lastNameAttr = new XAttribute("LastName", customer.Prezime);
                customerElem.Add(lastNameAttr);

                //Dodaje element koji predstavlja svojstvo EmailAddress za element customer
                var emailAddress = new XElement("EmailAdress", customer.EmailAdresa);
                customerElem.Add(emailAddress);

                //Dodaje element customer u XML dokument
                rootElem.Add(customerElem);
                */
                
                var customerElem = new XElement("Customer",
                    new XAttribute("FirstName", customer.Ime),
                    new XAttribute("LastName", customer.Prezime),
                    new XElement("EmailAddress", customer.EmailAdresa)
                    );
                rootElem.Add(customerElem);
                


               
            }
            Console.WriteLine(dokumentXmlKlijenti.ToString());
            Console.Read();
        }

        // Stvara popis klijenata s podacima
        private static List<Klijent_class> CreateCustomerList()
        {
            List<Klijent_class> ListaKlijenata = new List<Klijent_class>
            {
                new Klijent_class
                {
                    Ime = "Ivan",
                    Prezime = "Horvatin",
                    EmailAdresa = "ivan.horvatin@email.com"
                },
                new Klijent_class
                {
                    Ime = "Marko",
                    Prezime = "Ivić",
                    EmailAdresa = "marko.ivic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Josip",
                    Prezime = "Bralić",
                    EmailAdresa = "josip.bralic@email.com"
                },
                new Klijent_class
                {
                    Ime = "John",
                    Prezime = "Horvatin",
                    EmailAdresa = "john.horvatin@email.com"
                },
                new Klijent_class
                {
                    Ime = "Mladen",
                    Prezime = "Marković",
                    EmailAdresa = "marko.markovic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Josip",
                    Prezime = "Kukuljan",
                    EmailAdresa = "josip.kukuljan@email.com"
                },
                new Klijent_class
                {
                    Ime = "Ivan",
                    Prezime = "Crnković",
                    EmailAdresa = "ivan.crnkovic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Joško",
                    Prezime = "Karlautić",
                    EmailAdresa = "josko.karlautic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Anatolij",
                    Prezime = "Uremović",
                    EmailAdresa = "anatolij.uremovic@email.com"
                },
            };
            return ListaKlijenata;
        }
    }
}
