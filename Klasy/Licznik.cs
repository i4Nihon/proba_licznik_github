using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace licznik_punktow_do_tysiaca_consola.Klasy
{
  public class Licznik
  {
    public string[] tablica;
    public int[] intTab;

    public Licznik()
    {
      tablica = Console.ReadLine().Split(", ");
      intTab = new int[tablica.Length];
    }


    public void CheckDir()
    {
      string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
      if (!Directory.Exists(dirPath))
      {
        Directory.CreateDirectory(dirPath);
      }
    }


    public void Saver()
    {
      foreach (var i in tablica)
      {
        CheckDir();
        string date = $"{DateTime.Now}";
        string[] splitedDate = date.Split(":");
        string filePath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca\zapiska {splitedDate[0] + "; " + splitedDate[1]}.txt";
        string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
        string[] filePathButToSearch = Directory.GetFiles(dirPath, "*.txt");
        File.AppendAllText(filePathButToSearch[^1], i + "\n");
      }
       

    }


    public int podlicza1i3i5linie()
    {
      string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
      string[] filePath = Directory.GetFiles(dirPath, "*.txt");
      int dlugoscFora = (filePath.Length - 1) / 2;
      for (int i = 0; i < dlugoscFora; i += 2)
      {
        string[] tablicaZPliku = File.ReadAllLines(filePath[^1]);
        int dodawanie = int.Parse(tablicaZPliku[i]) + int.Parse(tablicaZPliku[i += 2]);
        Console.WriteLine(dodawanie);
        return dodawanie;
      }
      return -1;
    }
    public int podlicza2i4i6linie()
    {
      string dirPath = @$"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\licznik_pkt_do_tysiaca";
      string[] filePath = Directory.GetFiles(dirPath, "*.txt");
      int dlugoscFora = (filePath.Length - 1) / 2;
      for (int i = 0; i < dlugoscFora; i += 2)
      {
        string[] tablicaZPliku = File.ReadAllLines(filePath[^1]);
        int dodawanie = int.Parse(tablicaZPliku[i]) + int.Parse(tablicaZPliku[i += 2]);
        Console.WriteLine(dodawanie);
        return dodawanie;
      }
      return -1;
    }
  }
}
