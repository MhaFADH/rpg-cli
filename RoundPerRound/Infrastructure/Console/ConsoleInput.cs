namespace RPG.RoundPerRound.Infrastructure.Console;

using System;

public static class ConsoleInput
{

  public static string ReadStringInput(string prompt, int minLength = 0)
  {
    while (true)
    {
      Console.WriteLine(prompt);
      string? input = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(input) || input.Length < minLength)
      {
        Console.Clear();
        Console.WriteLine($"Input must be at least {minLength} characters long.\n");
        continue;
      }

      Console.Clear();
      return input;
    }
  }


  public static int ReadChoiceFromMenu(string prompt, string[] choices)
  {
    while (true)
    {
      int maxLenght = choices.Length;
      Console.WriteLine(prompt + "\n");
      for (int i = 0; i < maxLenght; i++)
      {
        Console.WriteLine($"{i + 1}. {choices[i]}");
      }

      string? input = Console.ReadLine();

      if (!int.TryParse(input, out int choice) || choice < 1 || choice > maxLenght)
      {
        Console.Clear();
        Console.WriteLine($"Input must be a number between 1 and {maxLenght}.\n");
        continue;
      }

      Console.Clear();
      return choice;
    }
  }
}
