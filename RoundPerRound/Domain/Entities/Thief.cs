using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Domain.Skills;

namespace RPG.RoundPerRound.Domain.Entities;

public class Thief(string name) : Hero(HeroClass.Thief, name, maxHp: 90, baseAttack: 14, armor: 7, specialSkill: new CriticalHit())
{
}
