using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Domain.Skills;

namespace RPG.RoundPerRound.Domain.Entities;

public class GoblinArcher() : Enemy(EnemyClass.GoblinArcher, maxHp: 35, baseAttack: 8, armor: 0, specialSkill: new PiercingShot())
{
}
