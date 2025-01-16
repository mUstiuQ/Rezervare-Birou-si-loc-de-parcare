namespace proiect_poo
{
    public static class Menu
    {
        public static void ParcarePublicaActions(ParcarePublica parcare, HartaLocuri hartaLocuri, Angajat angajat)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Parcare Publica ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Rezerva loc");
                Console.WriteLine("3. Afiseaza harta locuri");
                Console.WriteLine("4. Inapoi");
                Console.Write("Alegeti o optiune (1-4): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        // Afișează locurile disponibile pentru parcare
                        parcare.AfiseazaLocuri();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        // Permite utilizatorului să rezerve un loc
                        Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                        var idLoc = int.Parse(Console.ReadLine());
                        parcare.RezervaLocCuTaxa(idLoc, angajat, hartaLocuri);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Afișează harta locurilor
                        parcare.AfiseazaHartaLocuri(hartaLocuri);
                        break;
                    case "4":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void CoworkingSpaceActions(CoworkingSpace coworking, HartaLocuri hartaLocuri, Angajat angajat)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Coworking Space ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Rezerva loc");
                Console.WriteLine("3. Afiseaza harta locuri");
                Console.WriteLine("4. Inapoi");
                Console.Write("Alegeti o optiune (1-4): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        // Afișează locurile disponibile în Coworking Space
                        coworking.AfiseazaLocuri();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        // Permite utilizatorului să rezerve un loc în Coworking Space
                        Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                        var idLoc = int.Parse(Console.ReadLine());
                        coworking.RezervaLocCoworking(idLoc, angajat);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Afișează harta locurilor
                        coworking.AfiseazaHartaLocuri(hartaLocuri);
                        break;
                    case "4":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AngajatActions(SistemRezervare sistem, Angajat angajat)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== Meniu {angajat.Nume} ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Rezerva loc");
                Console.WriteLine("3. Vizualizeaza rezervarile tale");
                Console.WriteLine("4. Inapoi");
                Console.Write("Alegeti o optiune (1-4): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        // Afișează locurile disponibile în sistem
                        sistem.AfiseazaLocuri();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        // Permite angajatului să rezerve un loc
                        RezervaLoc(sistem, angajat);
                        break;
                    case "3":
                        // Afișează rezervările angajatului
                        angajat.AfiseazaRezervari();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "4":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Permite rezervarea unui loc de către angajat
        private static void RezervaLoc(SistemRezervare sistem, Angajat angajat)
        {
            Console.Write("Introduceti ID-ul locului pe care doriti să-l rezervati: ");
            var idLoc = int.Parse(Console.ReadLine());

            if (sistem.RezervaLoc(idLoc, angajat))
            {
                // Dacă rezervarea a avut succes
                Console.WriteLine($"Locul {idLoc} a fost rezervat cu succes de catre {angajat.Nume}.");
            }
            else
            {
                // Dacă locul nu este disponibil
                Console.WriteLine($"Locul {idLoc} nu este disponibil sau nu exista.");
            }

            Console.WriteLine("Apasati orice tasta pentru a continua...");
            Console.ReadKey();
        }

        public static void ManagerActions(Manager manager)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== Meniu {manager.Nume} ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Vizualizeaza rezervarile echipei");
                Console.WriteLine("3. Modificare rezervare");
                Console.WriteLine("4. Stergere rezervare");
                Console.WriteLine("5. Inapoi");
                Console.Write("Alegeti o optiune (1-5): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        // Afișează locurile echipei managerului
                        manager.VizualizeazaRezervariEchipa();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        // Afișează rezervările echipei
                        manager.VizualizeazaRezervariEchipa();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Permite modificarea unei rezervări
                        ModificaRezervare(manager);
                        break;
                    case "4":
                        // Permite ștergerea unei rezervări
                        StergeRezervare(manager);
                        break;
                    case "5":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Modificare rezervare de către manager
        private static void ModificaRezervare(Manager manager)
        {
            Console.Write("Introduceti ID-ul locului de rezervare pe care doriti să-l modificati: ");
            var idLoc = int.Parse(Console.ReadLine());
            Console.Write("Introduceti noua locatie a locului: ");
            var locatieNoua = Console.ReadLine();
            Console.Write("Este locul rezervat? (da/nu): ");
            var rezervat = Console.ReadLine().ToLower() == "da";

            manager.ModificaRezervareEchipa(idLoc, rezervat, locatieNoua);
            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }

        // Ștergere rezervare de către manager
        private static void StergeRezervare(Manager manager)
        {
            Console.Write("Introduceti ID-ul locului de rezervare pe care doriti să-l stergeti: ");
            var idLoc = int.Parse(Console.ReadLine());
            manager.StergeRezervareEchipa(idLoc);
            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }

        public static void AdministratorActions(Administrator administrator, SistemRezervare sistem)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Administrator ===");
                Console.WriteLine("1. Vizualizeaza toate locuri");
                Console.WriteLine("2. Modifica loc");
                Console.WriteLine("3. Inapoi");
                Console.Write("Alegeti o optiune (1-3): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        // Permite administratorului să vizualizeze toate locurile
                        administrator.VizualizeazaToateLocurile(sistem);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        // Permite administratorului să modifice un loc
                        ModificaLoc(administrator, sistem);
                        break;
                    case "3":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Modificare loc de către administrator
        private static void ModificaLoc(Administrator administrator, SistemRezervare sistem)
        {
            Console.Write("Introduceti ID-ul locului pe care doriti să-l modificati: ");
            var idLoc = int.Parse(Console.ReadLine());

            var loc = sistem.Locuri.FirstOrDefault(l => l.Id == idLoc);
            if (loc != null)
            {
                Console.Write("Introduceti noua locatie a locului: ");
                var locatieNoua = Console.ReadLine();
                Console.Write("Este locul rezervat? (da/nu): ");
                var rezervat = Console.ReadLine().ToLower() == "da";

                administrator.EditareLoc(sistem, idLoc, locatieNoua, rezervat);
            }
            else
            {
                Console.WriteLine("Locul nu a fost gasit!");
            }

            Console.WriteLine("Apasati orice tasta pentru a continua...");
            Console.ReadKey();
        }
    }
}