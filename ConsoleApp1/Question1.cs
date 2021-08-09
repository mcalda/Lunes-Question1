using System;
using System.Linq;

namespace Question1
{
  class Class1
  {
    static void Main(string[] args)
    {
      bool exitFlag = false;
      while (!exitFlag)
      {
        string input;
        Console.WriteLine("2 - 1'den 100'e kadar yaz\n3 - 100'den 1'e kadar yaz\n4 - 1'den verilen sayıya kadar topla" +
          "\n5 - 1'den verilen sayıya kadar topla\n6 - 1'den verilen sayıya kadar topla\n7 - Cikis");

        input = Console.ReadLine();
        Console.Clear();
        switch (input)
        {
          case "2":
            PrintFrom1To100();
            break;
          case "3":
            PrintFrom100To1();
            break;
          case "4":
            CalcSumMethod("4");
            break;
          case "5":
            CalcSumMethod("5");
            break;
          case "6":
            CalcSumMethod("6");
            break;
          case "7":
            exitFlag = true;
            break;
          default:
            break;
        }
      }
    }

   

    private static void PrintFrom1To100()
    {
      for (int i = 1; i < 101; i++)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("\n\n");
    }

    private static void PrintFrom100To1()
    {
      for (int i = 100; i > 0; i--)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("\n\n");
    }

    private static void CalcSumMethod(string version)
    {
      Console.WriteLine("\n1'den kaca kadar toplanacagini belirtiniz: ");
      string inputString = Console.ReadLine();
      int value;
      if (int.TryParse(inputString, out value))
      {      
        int result = SumMethodHelper(version, value);
        Console.WriteLine("\n1'den " + value + "'e kadar olan sayilarin toplami: " + result + "\n");
      }
      else
      {
        Console.WriteLine("\nLutfen gecerli bir sayi giriniz!");
        CalcSumMethod(version);
      }
    }

    
    private static int SumMethodHelper(string version, int value)
    {
      int result = 0;
      if (version.Equals("4"))
      {
        for (int i = 1; i <= value; i++)
        {
          result += i;
        }
      }

      else if (version.Equals("5"))
      {
        if (value > 0)
        {
          result = value * (value + 1) / 2;
        }
      }

      else if (version.Equals("6"))
      {
        result = Enumerable.Range(1, value).Sum();
      }

      return result;
    }
  }
}
