using RPG.RoundPerRound.Domain.Enums;
using RPG.RoundPerRound.Domain.Skills;

namespace RPG.RoundPerRound.Domain.Entities;

public class Mage(string name) : Hero(HeroClass.Mage, name, maxHp: 80, baseAttack: 12, specialSkill: new Thunder())
{
}
