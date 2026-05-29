
using RPG.RoundPerRound.Application.Builders;
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

    Console.WriteLine($"name: {hero.Name}\nclass:  {hero.Class}!");

    IReadOnlyList<Wave> waves = new CombatBuilder()
        .Wave(EnemyClass.Goblin)
        .Wave(EnemyClass.Goblin, EnemyClass.GoblinArcher)
        .Wave(EnemyClass.OrcBoss)
        .Build();

    foreach (Wave wave in waves)
    {
      Console.WriteLine($"\n=== Wave {wave.Number} ===");
      foreach (Enemy enemy in wave.Enemies)
      {
        Console.WriteLine($"  - {enemy.GetType().Name} (HP {enemy.CurrentHp}/{enemy.MaxHp}, Armor {enemy.Armor})");
      }
    }
  }
}
