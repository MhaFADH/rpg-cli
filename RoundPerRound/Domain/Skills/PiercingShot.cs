using RPG.RoundPerRound.Domain.Entities;

namespace RPG.RoundPerRound.Domain.Skills;

public class PiercingShot() : ISkill("Piercing Shot", defaultCoolDown: 2)
{
  public override void SpecialSkill(Character source, Character target)
  {
    target.TakeDamage(source.BaseAttack, armorIgnore: 1.0);
  }
}
