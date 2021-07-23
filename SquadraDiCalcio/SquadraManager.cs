using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SquadraDiCalcio.Calciatore;
//using static SquadraDiCalcio.Squadra;



namespace SquadraDiCalcio
{
    class SquadraManager
    {
        static List<Calciatore> calciatori = new List<Calciatore>()
        {
            new Difensore{Nome="Diego Godin",NumeroMaglia=5,DataDiNascita=new DateTime(1986,2,16),NumeroTackle=150,Ruolo=Categoria.Difensore},
            new Difensore{Nome="Luca Ceppitelli",NumeroMaglia=7,DataDiNascita=new DateTime(1989,8,11),NumeroTackle=180,Ruolo=Categoria.Difensore},
            new Difensore{Nome="Alberto Cerri",NumeroMaglia=9,DataDiNascita=new DateTime(1996,4,15),NumeroTackle=80,Ruolo=Categoria.Difensore},
            new Difensore{Nome="Giorgio Altare",NumeroMaglia=11,DataDiNascita=new DateTime(1998,8,9),NumeroTackle=54,Ruolo=Categoria.Difensore},
            new Attaccante{Nome="Giovanni Simeone",NumeroMaglia=34,DataDiNascita=new DateTime(1995,7,5),NumeroGolRealizzati=70,Ruolo=Categoria.Attaccante},
            new Attaccante{Nome="Diego Farias",NumeroMaglia=38,DataDiNascita=new DateTime(1990,5,10),NumeroGolRealizzati=62,Ruolo=Categoria.Attaccante},
            new Portiere{Nome="Alessio Cragno",NumeroMaglia=2,DataDiNascita=new DateTime(1994,6,28),NumeroGolSubiti=201,NumeroRigoriParati=35,Ruolo=Categoria.Portiere},
            new Centrocampista{Nome="Joao Pedro",NumeroMaglia=10,DataDiNascita=new DateTime(1992,3,9),NumeroPassaggiRiusciti=234,NumeroPassaggiTentati=380,Ruolo=Categoria.Centrocampista},
            new Centrocampista{Nome="Christian Oliva",NumeroMaglia=25,DataDiNascita=new DateTime(1996,6,1),NumeroPassaggiRiusciti=45,NumeroPassaggiTentati=80,Ruolo=Categoria.Centrocampista},
            new Centrocampista{Nome="Nahitan Nandez",NumeroMaglia=15,DataDiNascita=new DateTime(1995,12,28),NumeroPassaggiRiusciti=212,NumeroPassaggiTentati=321,Ruolo=Categoria.Centrocampista},
            new Centrocampista{Nome="Marko Rog",NumeroMaglia=31,DataDiNascita=new DateTime(1995,7,19),NumeroPassaggiRiusciti=200,NumeroPassaggiTentati=289,Ruolo=Categoria.Centrocampista},
        };

        static Squadra sq = new Squadra();

        public static Squadra CreaSquadra()
        {
            sq.Nome = "Cagliari Calcio";
            sq.NomeAllenatore = "Leonardo Semplici";
            sq.NomePresidente = "Tommaso Giulini";
            sq.CampionatoDisputato = "Serie A";
            sq.DataDiFondazione = new DateTime(1920, 5, 30);
            sq.Rosa = calciatori;
            return sq;
        }

        public static void AggiungiCalciatore()
        {
        
            Console.WriteLine("Inserisci Ruolo Calciatore:");
            Categoria ruolo = CategoriaCalciatore();
            ControlloRuolo(ruolo, calciatori);

        }

        public static Categoria CategoriaCalciatore()
        {
            Console.WriteLine($"Premi {(int)Categoria.Portiere} per impostare {Categoria.Portiere}");
            Console.WriteLine($"Premi {(int)Categoria.Difensore} per impostare {Categoria.Difensore}");
            Console.WriteLine($"Premi {(int)Categoria.Centrocampista} per impostare {Categoria.Centrocampista}");
            Console.WriteLine($"Premi {(int)Categoria.Attaccante} per impostare {Categoria.Attaccante}");


            Console.WriteLine("------------------------------");
            int tipo = Check();
            return (Categoria)tipo;


        }

        public static void ControlloRuolo(Categoria ruolo, List<Calciatore> calciatori)
        {
            if (ruolo == Categoria.Attaccante)
            {
                Calciatore calciatore = new Attaccante();
                Console.WriteLine("Inserisci Nome del Calciatore:");
                calciatore.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci Numero Maglia:");
                calciatore.NumeroMaglia = Check();

                Console.WriteLine("Inserisci Data di nascita del Calciatore:");
                bool isDate = true;
                DateTime dataInserita;
                do
                {
                    isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);

                } while (!isDate);
                Console.WriteLine("Inserisci n° goal realizzati:");
                ((Attaccante)calciatore).NumeroGolRealizzati = Check();
                calciatori.Add(calciatore);
            }
            else if (ruolo == Categoria.Difensore)
            {
                Calciatore calciatore = new Difensore();
                Console.WriteLine("Inserisci Nome del Calciatore:");
                calciatore.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci Numero Maglia:");
                calciatore.NumeroMaglia = Check();

                Console.WriteLine("Inserisci Data di nascita del Calciatore:");
                bool isDate = true;
                DateTime dataInserita;
                do
                {
                    isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);

                } while (!isDate);


                Console.WriteLine("Inserisci n° Tackle riusciti:");
                ((Difensore)calciatore).NumeroTackle = Check();
                calciatori.Add(calciatore);
            }
            else if (ruolo == Categoria.Portiere)
            {
                Calciatore calciatore = new Portiere();
                Console.WriteLine("Inserisci Nome del Calciatore:");
                calciatore.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci Numero Maglia:");
                calciatore.NumeroMaglia = Check();

                Console.WriteLine("Inserisci Data di nascita del Calciatore:");
                bool isDate = true;
                DateTime dataInserita;
                do
                {
                    isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);

                } while (!isDate);


                Console.WriteLine("Inserisci n° Gol subiti:");
                ((Portiere)calciatore).NumeroGolSubiti = Check();
                Console.WriteLine("Inserisci n° Gol parati:");
                ((Portiere)calciatore).NumeroRigoriParati = Check();
                calciatori.Add(calciatore);
            }
            else if (ruolo == Categoria.Centrocampista)
            {
                Calciatore calciatore = new Centrocampista();
                Console.WriteLine("Inserisci Nome del Calciatore:");
                calciatore.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci Numero Maglia:");
                calciatore.NumeroMaglia = Check();

                Console.WriteLine("Inserisci Data di nascita del Calciatore:");
                bool isDate = true;
                DateTime dataInserita;
                do
                {
                    isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);

                } while (!isDate);


                Console.WriteLine("Inserisci n° Passaggi tentati:");
                ((Centrocampista)calciatore).NumeroPassaggiTentati = Check();
                Console.WriteLine("Inserisci n° Passaggi riusciti:");
                ((Centrocampista)calciatore).NumeroPassaggiRiusciti = Check();
                calciatori.Add(calciatore);
            }

            else
                Console.WriteLine("ERRORE!");

        }
        public static int Check()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.WriteLine("Puoi inserire solo numeri interi positivi! Riprova:");
            }
            return num;
        }

        public static void VendiCalciatore()
        {
            Console.WriteLine("------SELEZIONA IL CALCIATORE DA VENDERERE-----");
            Console.WriteLine("");
            VisualizzaSquadra();
            int num = 0;
            bool isInt = false;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out num);
            } while (!isInt || num < 0 || num > calciatori.Count);

            Calciatore calciatoreDaEliminare = calciatori.ElementAt(num - 1);
            calciatori.Remove(calciatoreDaEliminare);
        }
        public static void GestisciSquadra()
        {
            Console.WriteLine("Inserisci i 4 Difensori");
            List<Calciatore> calciatoriTitolari = new List<Calciatore>();
            int count = 1;
            while (count < 4)
            {
                Calciatore calciatoreSelezionato = new Calciatore();
                calciatoreSelezionato = SelezionaCalciatore(calciatoreSelezionato);
                calciatoriTitolari.Add(calciatoreSelezionato);
                count++;
            }
            Console.WriteLine("Inserisci i 4 Centrocampisti");
            int count1 = 1;
            while (count1 < 4)
            {
                Calciatore calciatoreSelezionato1 = new Calciatore();
                calciatoreSelezionato1 = SelezionaCalciatore(calciatoreSelezionato1);
                calciatoriTitolari.Add(calciatoreSelezionato1);
                count1++;
            }
            Console.WriteLine("Inserisci i 2 Attaccanti");
            int count2 = 1;
            while (count2 < 4)
            {
                Calciatore calciatoreSelezionato2 = new Calciatore();
                calciatoreSelezionato2 = SelezionaCalciatore(calciatoreSelezionato2);
                calciatoriTitolari.Add(calciatoreSelezionato2);
                count2++;
            }
            Console.WriteLine("Inserisci il Portiere");
           
            Calciatore calciatoreSelezionato3 = new Calciatore();
            calciatoreSelezionato3 = SelezionaCalciatore(calciatoreSelezionato3);
            calciatoriTitolari.Add(calciatoreSelezionato3);
            count1++;
            

        }

        public static Calciatore SelezionaCalciatore(Calciatore calciatore)
        {
            Console.WriteLine("------SELEZIONA IL CALCIATORE-----");
            Console.WriteLine("");
            VisualizzaSquadra();
            int num = 0;
            bool isInt = false;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out num);
            } while (!isInt || num < 0 || num > calciatori.Count);

            Calciatore cSelezionato = calciatori.ElementAt(num - 1);
            return cSelezionato;
        }

        public static void VisualizzaSquadra()
        {
            if (calciatori.Count > 0)
            {
                int count = 1;

                foreach (Calciatore calciatore in calciatori)
                {
                    Console.WriteLine($"{count} -- " + calciatore);
                    count++;
                }
                
            }
            else
                Console.WriteLine("Nessun calciatore presente!");
        }

        public static void StampaSquadra()
        {

            Squadra squadra = new Squadra();
            squadra=CreaSquadra();
            Console.WriteLine($"La tua squadra {squadra.Nome} con presidente {squadra.NomePresidente} e allenatore {squadra.NomeAllenatore} ha come giocatori titolari:");
            foreach(Calciatore c in calciatori)
            {
                c.ToStringForTable();
            }
        }
    }
}
