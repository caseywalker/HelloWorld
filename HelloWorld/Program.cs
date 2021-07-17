using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

      Console.WriteLine("Please choose a greeting");
      foreach (var arg in args)
      {
        Console.WriteLine(arg);
      }

      var greetingChosen = Console.ReadLine();

      switch (greetingChosen)
      {
        case "Southern":
          Console.WriteLine("Howdy Y'all");
          break;
        case "British":
          Console.WriteLine("'Ello Govnuh");
          break;
        case "Pirate":
          Console.WriteLine("Yarrrr matey");
          break;
        default:
          Console.WriteLine("No greeting selected");
          break;
      }

      foreach (var animal in animals)
      {
        var vowels = new char[6] { 'a', 'e', 'i', 'o', 'u', 'y' };
        var syl = 0;
        for (var i = 0; i < vowels.Length; i++)
        {
          if (animal.Contains(vowels[i]))
          {
            syl++;
          }
        }
        if (syl > 2 && animal != "Toucan")
        {
          Console.WriteLine(animal);
        }
      }
    }
  }
}
