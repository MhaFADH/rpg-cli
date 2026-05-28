using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Domain.Entities;

public abstract class Hero(HeroClass heroClass, string name, int maxHp, int baseAttack, ISkill specialSkill) : Character(name, maxHp, baseAttack, 0)
{
  public int MaxHp { get; } = maxHp;
  public int RemainingHealing { get; protected set; } = 2;
  private ISkill SpecialSkill { get; } = specialSkill;
  public HeroClass Class { get; } = heroClass;

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

  public void UseSpecialSkill(Character target)
  {
    SpecialSkill.Use(this, target);
  }
}
