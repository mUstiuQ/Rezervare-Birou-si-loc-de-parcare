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
                parcare.AfiseazaLocuri();
                Console.WriteLine("Apasa orice tasta pentru a continua...");
                Console.ReadKey();
                break;
            case "2":
                Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                var idLoc = int.Parse(Console.ReadLine());
                parcare.RezervaLocCuTaxa(idLoc, angajat);
                Console.WriteLine("Apasa orice tasta pentru a continua...");
                Console.ReadKey();
                break;
            case "3":
                parcare.AfiseazaHartaLocuri(hartaLocuri);
                break;
            case "4":
                return;
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
                coworking.AfiseazaLocuri();
                Console.WriteLine("Apasa orice tasta pentru a continua...");
                Console.ReadKey();
                break;
            case "2":
                Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                var idLoc = int.Parse(Console.ReadLine());
                coworking.RezervaLocCoworking(idLoc, angajat);
                Console.WriteLine("Apasa orice tasta pentru a continua...");
                Console.ReadKey();
                break;
            case "3":
                coworking.AfiseazaHartaLocuri(hartaLocuri);
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                Console.ReadKey();
                break;
        }
    }
}

    // Meniu pentru Angajat
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
                    sistem.AfiseazaLocuri();
                    Console.WriteLine("Apasa orice tasta pentru a continua...");
                    Console.ReadKey();
                    break;
                case "2":
                    RezervaLoc(sistem, angajat);  // Permite rezervarea unui loc
                    break;
                case "3":
                    angajat.AfiseazaRezervari();
                    Console.WriteLine("Apasa orice tasta pentru a continua..."); 
                    Console.ReadKey();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                    Console.ReadKey();
                    break;
            }
        }
    }


    // Rezervare loc pentru angajat
    private static void RezervaLoc(SistemRezervare sistem, Angajat angajat)
    {
        Console.Write("Introduceti ID-ul locului pe care doriti să-l rezervati: ");
        var idLoc = int.Parse(Console.ReadLine());

        if (sistem.RezervaLoc(idLoc, angajat))
        {
            Console.WriteLine($"Locul {idLoc} a fost rezervat cu succes de catre {angajat.Nume}.");
        }
        else
        {
            Console.WriteLine($"Locul {idLoc} nu este disponibil sau nu exista.");
        }

        Console.WriteLine("Apasati orice tasta pentru a continua...");
        Console.ReadKey();
    }

    // Meniu pentru Manager
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
            Console.Write("Alegeti o optiune (1-3): ");
            var alegere = Console.ReadLine();

            switch (alegere)
            {
                case "1":
                    manager.VizualizeazaRezervariEchipa();
                    Console.WriteLine("Apasa orice tasta pentru a continua..."); 
                    Console.ReadKey();
                    break;
                case "2":
                    manager.VizualizeazaRezervariEchipa();
                    Console.WriteLine("Apasa orice tasta pentru a continua..."); 
                    Console.ReadKey();
                    break;
                case "3":
                    ModificaRezervare(manager);
                    return;
                case "4":
                    StergeRezervare(manager);
                    return;
                case "5":
                    return;
                default:
                    Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                    Console.ReadKey();
                    break;
            }
        }
    }

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

    private static void StergeRezervare(Manager manager)
    {
        Console.Write("Introduceti ID-ul locului de rezervare pe care doriti să-l stergeti: ");
        var idLoc = int.Parse(Console.ReadLine()); 
        manager.StergeRezervareEchipa(idLoc); 
        Console.WriteLine("Apasa orice tasta pentru a continua..."); 
        Console.ReadKey();
    }

    // Meniu pentru Administrator
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
                    administrator.VizualizeazaToateLocurile(sistem);
                    Console.WriteLine("Apasa orice tasta pentru a continua..."); 
                    Console.ReadKey();
                    break;
                case "2":
                    ModificaLoc(administrator, sistem);
                    break;
                case "3":
                    return;
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