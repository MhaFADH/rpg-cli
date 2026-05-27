
using RPG.RoundPerRound.Infrastructure.Console;

namespace RPG.RoundPerRound.Cli;



public class EntryPoint
{
  enum HeroClasses
  {
    Warrior = 1,
    Mage = 2,
    Archer = 3
  }

  public static void Main(string[] args)
  {
    int MIN_NAME_LENGTH = 3;

    string userName = ConsoleInput.ReadStringInput("Enter your username : ", MIN_NAME_LENGTH);

    int classChoice = ConsoleInput.ReadChoiceFromMenu("Choose your class : ", Enum.GetNames<HeroClasses>());

  }
}
