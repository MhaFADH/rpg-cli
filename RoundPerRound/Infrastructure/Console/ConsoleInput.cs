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
}
