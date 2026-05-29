namespace RPG.RoundPerRound.Domain.Entities;

public class Wave(int number, IReadOnlyList<Enemy> enemies)
{
  public int Number { get; } = number;
  public IReadOnlyList<Enemy> Enemies { get; } = enemies;

  public IEnumerable<Enemy> AliveEnemies => Enemies.Where(e => e.IsAlive());

  public bool IsCleared()
  {
    return !AliveEnemies.Any();
  }
}
