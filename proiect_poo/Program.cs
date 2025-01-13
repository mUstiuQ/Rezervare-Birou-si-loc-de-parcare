using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using proiect_poo;

namespace proiect_poo
{


    class Program
    {
        static void Main(string[] args)
        {
            // Creare locuri
            var sistemRezervare = new SistemRezervare();
            sistemRezervare.AdaugaLoc(new Loc(1, "Birou", "Birou 1"));
            sistemRezervare.AdaugaLoc(new Loc(2, "Birou", "Birou 2"));
            sistemRezervare.AdaugaLoc(new Loc(3, "Parcare", "Parcare A1"));
            sistemRezervare.AdaugaLoc(new Loc(4, "Parcare", "Parcare A2"));

            // Creare angajați
            var angajat1 = new Angajat("Dragulescu Alex");
            var angajat2 = new Angajat("Dinis Maria");

            // Creare manager și atribuirea echipei
            var manager = new Manager("Fodoka David", new List<Angajat> { angajat1, angajat2 });

            // Creare administrator
            var administrator = new Administrator();

            var hartaParcare = new HartaLocuri(10, 5); // 10 locuri, 5 pe linie
            var hartaCoworking = new HartaLocuri(10, 5);

            var parcarePublica = new ParcarePublica();
            parcarePublica.AdaugaLoc(new Loc(3, "Parcare", "Parcare A1"));
            parcarePublica.AdaugaLoc(new Loc(4, "Parcare", "Parcare A2"));

            var coworkingSpace = new CoworkingSpace();
            coworkingSpace.AdaugaLoc(new Loc(1, "Birou", "Birou 1"));
            coworkingSpace.AdaugaLoc(new Loc(2, "Birou", "Birou 2"));

            // Menținerea unui meniu pentru utilizatori
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=== Meniu Principal ===");
                    Console.WriteLine("1. Angajat");
                    Console.WriteLine("2. Manager");
                    Console.WriteLine("3. Administrator");
                    Console.WriteLine("4. Parcare publica");
                    Console.WriteLine("5. Coworking Space");
                    Console.WriteLine("6. Iesire");
                    Console.Write("Alegeti un rol (1-6): ");
                    var alegere = Console.ReadLine();

                    switch (alegere)
                    {
                        case "1":
                            Menu.AngajatActions(sistemRezervare,
                                angajat1); // aici se poate inlocuii angajat1 cu angajat2 
                            break;
                        case "2":
                            Menu.ManagerActions(manager);
                            break;
                        case "3":
                            Menu.AdministratorActions(administrator, sistemRezervare);
                            break;
                        case "4":
                            Menu.ParcarePublicaActions(new ParcarePublica(), hartaParcare, angajat1);
                            break;
                        case "5":
                            Menu.CoworkingSpaceActions(new CoworkingSpace(), hartaCoworking, angajat2);
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introdu un numar valid.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"A aparut o eroare neasteptata: {ex.Message}");
                }
            }

        }
    }
}