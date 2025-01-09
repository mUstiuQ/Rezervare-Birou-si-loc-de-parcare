public class HartaLocuri
{
    private char[,] hartaLocuri;

    public HartaLocuri(int nrLocuri, int numarLocuriPeLinie)
    {
        hartaLocuri = new char[nrLocuri / numarLocuriPeLinie, numarLocuriPeLinie];
        for (int i = 0; i < hartaLocuri.GetLength(0); i++)
        {
            for (int j = 0; j < hartaLocuri.GetLength(1); j++)
            {
                hartaLocuri[i, j] = 'O'; // Loc liber
            }
        }
    }

    public int GetNrColoane()
    {
        return hartaLocuri.GetLength(1);
    }

    public void RezervaLoc(int linie, int coloana)
    {
        hartaLocuri[linie, coloana] = 'X'; // Loc rezervat
    }

    public void AfiseazaHarta()
    {
        for (int i = 0; i < hartaLocuri.GetLength(0); i++)
        {
            for (int j = 0; j < hartaLocuri.GetLength(1); j++)
            {
                Console.Write(hartaLocuri[i, j] + " ");
            }

            Console.WriteLine();
        }
        Console.WriteLine("Apasa orice tasta pentru a continua...");
        Console.ReadKey();
    }
}