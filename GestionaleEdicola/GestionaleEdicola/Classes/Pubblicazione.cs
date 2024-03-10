using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleEdicola.Classes
{
    public abstract class Pubblicazione
    {
        public string? Codice { get; set; }

        public double Prezzo { get; set; }

        public int Contatore { get; set; }


        public abstract void stampaDettaglio();


    }
}
