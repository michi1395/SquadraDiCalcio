using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraDiCalcio
{
    class Menù
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto  nella sezione SQUADRA DI CALCIO!");
            Console.WriteLine(new String('-', 95));
            int scelta = 0;
                do
                {
                    Console.WriteLine("Premi 1 per Aggiungere un nuovo Calciatore alla squadra");
                    Console.WriteLine("Premi 2 per Vendere un tuo Calciatore");
                    Console.WriteLine("Premi 3 per Gestire la Squadra TITOLARE");
                    Console.WriteLine("Premi 4 per Stampare le statistiche della Squadra TITOLARE");
                    Console.WriteLine("Premi 0 per Uscire");



                    bool isInt = true;

                    do
                    {
                        isInt = int.TryParse(Console.ReadLine(), out scelta);
                        if (!isInt)
                        {
                            Console.WriteLine("La scelta è sbagliata... Riprova");
                        }
                    } while (!isInt);
                    switch (scelta)
                    {
                        case 1:
                            Console.Clear();
                            SquadraManager.AggiungiCalciatore();
                            break;
                        case 2:
                            Console.Clear();
                            SquadraManager.VendiCalciatore();
                        break;
                        case 3:
                            Console.Clear();
                            SquadraManager.GestisciSquadra();
                        break;
                        case 4:
                            Console.Clear();
                            SquadraManager.StampaSquadra();
                        break;
                        case 0:
                            Console.Clear();
                        Console.WriteLine("------ Grazie per aver usufruito del SERVIZIO!! -----");
                            break;
                        default:
                            Console.WriteLine("La scelta è sbagliata... Riprova");
                            break;

                    }
                } while (scelta != 0);
        }
    }
}
