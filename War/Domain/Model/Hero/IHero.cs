using War.Common.Attack;
using War.Common.Damage;
using War.Domain.Model.Army;
using War.Domain.Model.Weapon;

namespace War.Domain.Model.Hero;

public interface IHero: IDamageble,IAttacker,IHealable
{
 event Action? Daed;
 
 void Add(IWeapon weapon);
}