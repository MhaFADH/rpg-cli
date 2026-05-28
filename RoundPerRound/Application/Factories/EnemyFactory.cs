using RPG.RoundPerRound.Domain.Entities;
using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Application.Factories;

public class EnemyFactory
{
  public static readonly Dictionary<EnemyClass, Func<Enemy>> EnemyRegistry = new()
  {
    { EnemyClass.Goblin, () => new Goblin() },
    { EnemyClass.GoblinArcher, () => new GoblinArcher() },
    { EnemyClass.OrcBoss, () => new OrcBoss() }
  };

  public static Enemy Create(EnemyClass enemyClass)
  {
    if (EnemyRegistry.TryGetValue(enemyClass, out Func<Enemy>? enemyConstructor))
    {
      return enemyConstructor();
    }
    throw new ArgumentException($"Unsupported enemy class: {enemyClass}");
  }
}
