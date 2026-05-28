namespace RPG.RoundPerRound.Domain.Entities;

public abstract class ISkill(string name, int defaultCoolDown)
{
  public string Name { get; } = name;
  public int CoolDown { get; private set; } = defaultCoolDown;
  public int DefaultCoolDown { get; } = defaultCoolDown;

  public void Use(Character source, Character target)
  {
    if (CoolDown > 0)
      throw new InvalidOperationException("Special skill is on cooldown, the option to use it should not be available");
    SpecialSkill(source, target);
    ResetCoolDown();
  }

  public abstract void SpecialSkill(Character source, Character target);

  public void ReduceCoolDown()
  {
    if (CoolDown != 0)
      CoolDown--;
  }

  public void ResetCoolDown()
  {
    CoolDown = DefaultCoolDown;
  }

  public bool IsAvailable()
  {
    return CoolDown == 0;
  }
}
