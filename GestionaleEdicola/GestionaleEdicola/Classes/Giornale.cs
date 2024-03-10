using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleEdicola.Classes
{
    internal class Giornale : Pubblicazione
    {
        public string? Redazione { get; set; }


        public Giornale(string? redazione,double prezzo,string? codice) {

            Redazione = redazione;
            Prezzo = prezzo;
            Codice = codice;
             
        }
        public override void stampaDettaglio()
        {
            Console.WriteLine($"[GIORNALE]{Redazione} {Prezzo} {Codice} Quantità: {Contatore}");

        }
    }
}
