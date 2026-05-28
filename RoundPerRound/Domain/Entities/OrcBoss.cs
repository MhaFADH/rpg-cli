using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Domain.Skills;

namespace RPG.RoundPerRound.Domain.Entities;

public class OrcBoss() : Enemy(EnemyClass.OrcBoss, maxHp: 150, baseAttack: 20, armor: 15, specialSkill: new HeavyAttack())
{
}
