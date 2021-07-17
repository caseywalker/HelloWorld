using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

      Console.WriteLine("Please type your name, and then press enter:");
      var name = Console.ReadLine();

      Console.WriteLine("Please choose a greeting");
      foreach (var arg in args)
      {
        Console.WriteLine(arg);
      }

      var greetingChosen = Console.ReadLine();

      switch (greetingChosen)
      {
        case "Southern":
          Console.WriteLine($"Howdy {name}");
          break;
        case "British":
          Console.WriteLine($"'Ello Govnuh {name}");
          break;
        case "Pirate":
          Console.WriteLine($"Yarrrr {name}");
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

      Random dino = new Random();
      var randomDino = dino.Next(animals.Length);
      var selectedDino = animals[randomDino];

      Console.WriteLine("Please enter your favorite color:");
      var favoriteColor = Console.ReadLine();
      Console.WriteLine($"Would you like to have a {favoriteColor} {selectedDino}?");
    }
  }
}
