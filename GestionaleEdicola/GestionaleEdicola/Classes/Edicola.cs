using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleEdicola.Classes
{
    internal class Edicola
    {
        public string? Nome { get; set; }

        public string? Indirizzo { get; set; }

        public List<Pubblicazione> magazzino { get; set; } = new List<Pubblicazione>();

        public Edicola(string? nome, string? indirizzo)
        {
            Nome = nome;    
            Indirizzo = indirizzo;
        }

        public void aggiungi(Pubblicazione pub)
        {
            pub.Contatore++;
            magazzino.Add(pub);
        }
        public void rimuovi(Pubblicazione pub)
        {
            pub.Contatore--;
            if (pub.Contatore <= 0)
            {
                magazzino.Remove(pub);
            }
            magazzino.Remove(pub);
        }
        public void vendi(Pubblicazione pub, int quantita)
        {
            for (int i = 0; i < quantita; i++)
            {
                rimuovi(pub);
            }
        }

        public void stampaElenco()
        {
            foreach (Pubblicazione pub in magazzino)
            {
                pub.stampaDettaglio();
            }
        }
    }
}
