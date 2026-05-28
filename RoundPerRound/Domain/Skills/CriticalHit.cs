using RPG.RoundPerRound.Domain.Entities;

namespace RPG.RoundPerRound.Domain.Skills;

public class CriticalHit : ISkill
{
  public CriticalHit() : base("Critical Hit", 2) { }

  public override void SpecialSkill(Character source, Character target)
  {
    Random random = new();
    bool isCriticalHit = random.NextDouble() <= 0.3;
    int damage = isCriticalHit ? source.BaseAttack * 2 : source.BaseAttack;
    target.TakeDamage(damage);
  }
}
