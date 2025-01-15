// Clasa HartaLocuri gestionează reprezentarea grafică a locurilor într-un spațiu de coworking.
// Utilizează o matrice bidimensională de caractere pentru a reprezenta starea locurilor:
// 'O' - loc liber, 'X' - loc rezervat.
public class HartaLocuri
{
    private char[,] hartaLocuri; // Matrice care reprezintă locurile.
    
    public HartaLocuri(int nrLocuri, int numarLocuriPeLinie)
    {
        // Creează matricea hărții pe baza numărului de locuri și numărului de locuri pe linie.
        hartaLocuri = new char[nrLocuri / numarLocuriPeLinie, numarLocuriPeLinie];

        // Inițializează fiecare loc din matrice ca liber ('O').
        for (int i = 0; i < hartaLocuri.GetLength(0); i++)
        {
            for (int j = 0; j < hartaLocuri.GetLength(1); j++)
            {
                hartaLocuri[i, j] = 'O'; 
            }
        }
    }

    // Metoda returnează numărul de coloane din matricea hărții.
    // Este utilă pentru a calcula poziția unui loc pe hartă.
    public int GetNrColoane()
    {
        return hartaLocuri.GetLength(1);
    }

    // Metoda marchează un loc specific (linie și coloană) ca rezervat ('X').
    public void RezervaLoc(int linie, int coloana)
    {
        hartaLocuri[linie, coloana] = 'X';
    }

    // Metoda afișează harta locurilor în consolă.
    // Locurile libere sunt marcate cu 'O', iar cele rezervate cu 'X'.
    public void AfiseazaHarta()
    {
        for (int i = 0; i < hartaLocuri.GetLength(0); i++) // Iterează prin liniile hărții.
        {
            for (int j = 0; j < hartaLocuri.GetLength(1); j++) // Iterează prin coloanele hărții.
            {
                Console.Write(hartaLocuri[i, j] + " "); // Afișează starea locului.
            }
            Console.WriteLine(); // Trecere la următoarea linie.
        }

        Console.WriteLine("Apasa orice tasta pentru a continua...");
        Console.ReadKey(); 
    }
}
