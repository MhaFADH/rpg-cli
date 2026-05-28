
using RPG.RoundPerRound.Application.Factories;
using RPG.RoundPerRound.Domain.Entities;
using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Infrastructure.Console;

namespace RPG.RoundPerRound.Cli;

public class EntryPoint
{

  public static void Main(string[] args)
  {
    string userName = ConsoleInput.ReadStringInput("Enter your username : ", Hero.MinNameLength);

    HeroClass classChoice = (HeroClass)ConsoleInput.ReadChoiceFromMenu("Choose your class : ", Enum.GetNames<HeroClass>());

    Hero hero = HeroFactory.Create(userName, classChoice);

    Console.WriteLine($"Welcome, {hero.Name} the {hero.Class}!");
  }
}
