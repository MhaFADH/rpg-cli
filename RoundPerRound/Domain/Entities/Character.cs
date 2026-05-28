namespace RPG.RoundPerRound.Domain.Entities;

public abstract class Character(int maxHp, int baseAttack, int armor, ISkill specialSkill)
{
  public int CurrentHp { get; protected set; } = maxHp;
  public int BaseAttack { get; } = baseAttack;
  public int MaxHp { get; } = maxHp;
  private ISkill SpecialSkill { get; } = specialSkill;
  public int Armor { get; } = armor;

  public void Attack(Character target)
  {
    target.TakeDamage(BaseAttack);
  }

  public bool IsAlive()
  {
    return CurrentHp > 0;
  }

  public void TakeDamage(int damage, double armorIgnore = 0)
  {
    int effectiveArmor = (int)Math.Round(Armor * (1 - armorIgnore));
    // got issues here, 100.0 mandatory because otherwise it will do integer division and multiplier will always be 0
    double multiplier = 100.0 / (100 + effectiveArmor);
    CurrentHp -= (int)Math.Round(damage * multiplier);
  }

  public void UseSpecialSkill(Character target)
  {
    SpecialSkill.Use(this, target);
  }

  public bool CanUseSpecialSkill()
  {
    return SpecialSkill.IsAvailable();
  }
}
