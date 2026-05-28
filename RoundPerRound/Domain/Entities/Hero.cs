using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Domain.Entities;

public abstract class Hero(HeroClass heroClass, string name, int maxHp, int baseAttack, int armor, ISkill specialSkill) : Character(maxHp, baseAttack, armor, specialSkill)
{
  public string Name { get; } = name;
  public int RemainingHealing { get; protected set; } = 2;
  public HeroClass Class { get; } = heroClass;
  public const int MinNameLength = 3;


  public void Heal(bool survivedWave = false)
  {
    if (RemainingHealing <= 0 && !survivedWave)
    {
      throw new InvalidOperationException("Heal called while none remaining, the heal option should not be available");
    }
    int healAmount = (int)Math.Round(MaxHp * (survivedWave ? 0.20 : 0.25));
    CurrentHp = Math.Min(CurrentHp + healAmount, MaxHp);
    RemainingHealing--;
  }
}
