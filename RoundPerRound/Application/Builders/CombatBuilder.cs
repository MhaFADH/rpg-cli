using RPG.RoundPerRound.Application.Factories;
using RPG.RoundPerRound.Domain.Entities;
using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Application.Builders;

public class CombatBuilder
{
  private readonly List<Wave> waves = [];

  public CombatBuilder Wave(params EnemyClass[] enemies)
  {
    if (enemies.Length == 0)
      throw new InvalidOperationException("Wave must have at least one enemy.");

    List<Enemy> enemyInstances = [.. enemies.Select(EnemyFactory.Create)];
    Wave wave = new(waves.Count + 1, enemyInstances);

    waves.Add(wave);

    return this;
  }

  public IReadOnlyList<Wave> Build()
  {
    if (waves.Count == 0)
      throw new InvalidOperationException("Combat must have at least one wave.");
    return waves;
  }
}
