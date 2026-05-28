using RPG.RoundPerRound.Domain.Entities;

namespace RPG.RoundPerRound.Domain.Skills;

public class Thunder : ISkill
{
  public Thunder() : base("Thunder", 3) { }

  public override void SpecialSkill(Character source, Character target)
  {
    int damage = 30;
    target.TakeDamage(damage, armorIgnore: 0.5);
  }
}
