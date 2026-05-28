using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Domain.Entities;

public class Enemy(EnemyClass enemyClass, int maxHp, int baseAttack, int armor, ISkill specialSkill)
    : Character(maxHp, baseAttack, armor, specialSkill)
{
  public EnemyClass Class { get; } = enemyClass;
}
