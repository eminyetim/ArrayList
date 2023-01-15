using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
       ArrayList liste = new ArrayList();
        // liste.Add("Ayse");
        // liste.Add(2);
        // liste.Add(true);
        // liste.Add('A');

        //System.Console.WriteLine(liste[1]);

        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }

        //Adrange birden fazla elemanı toplu halde ekleme
        System.Console.WriteLine("***** Add Range *** ");

        //string[] renkler = {"Kirmizi" , "Sari" , "Yeşil"};
        //liste.AddRange(renkler);
        List<int> sayilar = new (){1 , 8 , 3 , 7 , 9 , 92 , 5};
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }
        
        System.Console.WriteLine("**** Sort ****");
        liste.Sort();
        
        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }

        // Binary Search
        System.Console.WriteLine("**** Binary Search ****"); // Binary Search Yaparken liste sıralı olmaliki doğru indeksi bulsun.
        System.Console.WriteLine(liste.BinarySearch(5));
        
        //Reverse
        System.Console.WriteLine("*** Reverse ***");
        liste.Reverse();
        
        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }

        //Clear
        System.Console.WriteLine("**Clear**");
        liste.Clear();
         foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }

    }
}
