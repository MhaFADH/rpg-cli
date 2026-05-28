using RPG.RoundPerRound.Domain.Entities;
using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Application.Factories;

public class HeroFactory
{

  public static readonly Dictionary<HeroClass, Func<string, Hero>> HeroRegistry = new() {
    { HeroClass.Warrior, name => new Warrior(name) },
    { HeroClass.Mage, name => new Mage(name) },
    { HeroClass.Thief, name => new Thief(name) }
  };

  public static Hero Create(string name, HeroClass heroClass)
  {
    if (HeroRegistry.TryGetValue(heroClass, out Func<string, Hero>? heroConstructor))
    {
      return heroConstructor(name);
    }
    throw new ArgumentException($"Unsupported hero class: {heroClass}");
  }
}
