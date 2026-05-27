
using RPG.RoundPerRound.Infrastructure.Console;

namespace RPG.RoundPerRound.Cli;



public class EntryPoint
{

  public static void Main(string[] args)
  {
    int MIN_NAME_LENGTH = 3;

    string userName = ConsoleInput.ReadStringInput("Enter your username : ", MIN_NAME_LENGTH);
  }
}
