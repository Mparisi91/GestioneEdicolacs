using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleEdicola.Classes
{
    internal class Rivista : Pubblicazione
    {
        public string? Titolo { get; set; }

        public string? Categoria { get; set; }

        public Rivista(string? titolo, string? categoria, double prezzo, string? codice)
        {
            Titolo = titolo;
            Categoria = categoria;
            Prezzo = prezzo;
            Codice = codice;
        }

        public override void stampaDettaglio()
        {
            Console.WriteLine($"[RIVISTA]{Titolo} {Categoria} {Prezzo} {Codice} Quantità: {Contatore}");   
        }

    }
}
