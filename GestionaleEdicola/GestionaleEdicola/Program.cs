using GestionaleEdicola.Classes;

namespace GestionaleEdicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giornale giorUno = new Giornale("Messaggero", 1.20d, "QWER1234");
            Giornale giorDue = new Giornale("Corrieredellasera", 1.80d, "QWER5678");
            Rivista rivUno = new Rivista("Quattroruote", "Automobili", 4.99d, "ITUI1234");
            Rivista rivDue = new Rivista("Spaziogames", "Videogiochi", 2.99d, "TRYU5678");

            Edicola edi = new Edicola("Mille idee", "Via Ormelli 15");

            edi.aggiungi(giorUno);
            edi.aggiungi(giorUno);
            edi.aggiungi(giorUno);
            edi.aggiungi(giorDue);
            edi.aggiungi(giorDue);
            edi.aggiungi(giorDue);
            edi.aggiungi(giorDue);
            edi.aggiungi(rivUno);
            edi.aggiungi(rivUno);
            edi.aggiungi(rivDue);

            edi.rimuovi(rivUno);


            bool continua = true;

            while (continua)
            {
                Console.WriteLine("Seleziona un'operazione:");
                Console.WriteLine("1. Aggiungi pubblicazione");
                Console.WriteLine("2. Rimuovi pubblicazione");
                Console.WriteLine("3. Visualizza elenco pubblicazioni");
                Console.WriteLine("4. Esci");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.WriteLine("Seleziona il tipo di pubblicazione (1. Giornale, 2. Rivista):");
                        string tipoPubblicazione = Console.ReadLine();
                        Console.WriteLine("Inserisci il titolo:");
                        string titolo = Console.ReadLine();
                        Console.WriteLine("Inserisci il prezzo:");
                        double prezzo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserisci il codice:");
                        string codice = Console.ReadLine();
                        if (tipoPubblicazione == "1")
                        {
                            Giornale nuovoGiornale = new Giornale(titolo, prezzo, codice);
                            edi.aggiungi(nuovoGiornale);
                        }
                        else if (tipoPubblicazione == "2")
                        {
                            Console.WriteLine("Inserisci la categoria della rivista:");
                            string categoriaRivista = Console.ReadLine();
                            Rivista nuovaRivista = new Rivista(titolo, categoriaRivista, prezzo, codice);
                            edi.aggiungi(nuovaRivista);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Inserisci il codice della pubblicazione da rimuovere:");
                        string codicePubblicazione = Console.ReadLine();
                        Pubblicazione pubblicazioneDaRimuovere = edi.magazzino.Find(pub => pub.Codice == codicePubblicazione);
                        if (pubblicazioneDaRimuovere != null)
                        {
                            edi.rimuovi(pubblicazioneDaRimuovere);
                        }
                        else
                        {
                            Console.WriteLine("Pubblicazione non trovata.");
                        }
                        break;
                    case "3":
                        edi.stampaElenco();
                        break;
                    case "4":
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;

                }

            }
        }
    }
}
