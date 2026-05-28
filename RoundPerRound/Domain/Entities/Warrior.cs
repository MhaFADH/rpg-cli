using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Domain.Skills;

namespace RPG.RoundPerRound.Domain.Entities;

public class Warrior(string name) : Hero(HeroClass.Warrior, name, maxHp: 120, baseAttack: 18, specialSkill: new HeavyAttack())
{
}
