using RPG.RoundPerRound.Domain.Entities;
using RPG.RoundPerRound.Domain.Enums;

namespace RPG.RoundPerRound.Application.Combat;

public class CombatContext(Hero hero, IReadOnlyList<Wave> waves)
{
  public Hero Hero { get; } = hero;
  public IReadOnlyList<Wave> Waves { get; } = waves;
  public int CurrentWaveIndex { get; private set; } = 0;
  public CombatOutcome Outcome { get; set; } = CombatOutcome.InProgress;

  public Wave CurrentWave => Waves[CurrentWaveIndex];

  public bool IsLastWave()
  {
    return CurrentWaveIndex == Waves.Count - 1;
  }

  public void NextWave()
  {
    CurrentWaveIndex++;
  }
}
