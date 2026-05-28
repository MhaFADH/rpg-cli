using RPG.RoundPerRound.Domain.Entities;

namespace RPG.RoundPerRound.Domain.Skills;

public class SneakAttack() : ISkill("Sneak Attack", defaultCoolDown: 2)
{
  public override void SpecialSkill(Character source, Character target)
  {
    target.TakeDamage(source.BaseAttack, armorIgnore: 0.5);
  }
}
