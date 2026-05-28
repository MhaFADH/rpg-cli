using RPG.RoundPerRound.Domain.Entities;

namespace RPG.RoundPerRound.Domain.Skills;

public class HeavyAttack : ISkill
{
  public HeavyAttack() : base("Heavy Attack", 2) { }

  public override void SpecialSkill(Character source, Character target)
  {
    int damage = (int)Math.Round(source.BaseAttack * 1.5);
    target.TakeDamage(damage);
  }
}
