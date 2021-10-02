
using System;
using System.IO;

namespace licznik_punktow_do_tysiaca_consola
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("naciśnij enter aby rozpocząć");
      Klasy.TryParseCS tryParseCS = new();
      for (int i = 1; i < 1000; i++)
      {
        Console.WriteLine("Podaj {0} wynik (liczba a, liczba b).", i);
        Klasy.Licznik licznik = new();
        Console.WriteLine("jeszcze raz podaj {0} wynik (liczba a, liczba b).", i);
        bool tryParseTrue = tryParseCS.Parsujaca() == true;
        if (licznik.tablica.Length != 2)
        {
          Console.WriteLine("Musisz podać 2 liczby, (liczba a, liczba b)");
          i--;
        }
        else
        {
          if (tryParseTrue)
          {
            licznik.Saver();
            licznik.podlicza1i3i5linie();
            licznik.podlicza2i4i6linie();
          }
          else
          {
            Console.WriteLine("nie możesz podawać znaków innych niż liczby oraz przecinek (,)");
            Console.WriteLine("naciśnij enter aby kontynuować");
            i--;
          }
        }
      }

      Console.ReadLine();
    }


  }
}

