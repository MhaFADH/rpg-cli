using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Domain.Skills;

namespace RPG.RoundPerRound.Domain.Entities;

public class Goblin() : Enemy(EnemyClass.Goblin, maxHp: 40, baseAttack: 6, armor: 5, specialSkill: new SneakAttack())
{
}
