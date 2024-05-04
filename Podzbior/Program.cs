using System;

class Program
{
    static void Main()
    {
        int[] tablica = new int[20];
        Random rand = new Random();
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = rand.Next(-99, 100); 
        }

        int najwiekszaSuma = int.MinValue; 
        int indeksPoczatku = 0; 
        int indeksKonca = 0; 

        for (int i = 0; i < tablica.Length; i++)
            {
            int sumaCzesciowa = 0; 

            for (int j = i; j < tablica.Length; j++)
            {
                sumaCzesciowa += tablica[j]; 

                if (sumaCzesciowa > najwiekszaSuma)
                {
                    najwiekszaSuma = sumaCzesciowa; 
                    indeksPoczatku = i; 
                    indeksKonca = j; 
                }
            }
        }

        Console.WriteLine("Tablica liczb:");
        foreach (var liczba in tablica)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine("\n\nNajwiększa suma: " + najwiekszaSuma);
        Console.WriteLine("Indeks początku: " + indeksPoczatku);
        Console.WriteLine("Indeks końca: " + indeksKonca);
    }
}
