using War.Common.Attack;
using War.Common.Damage;
using War.Domain.Model.Army;
using War.Domain.Model.Weapon;

namespace War.Domain.Model.Hero;

public interface IHero: IDamageble,IAttacker
{
 void Add(IWeapon weapon);
}