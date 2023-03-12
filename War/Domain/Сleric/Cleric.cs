using War.Common.Damage;
using War.Domain.Model.Hero;
using War.Domain.Model.Weapon;

namespace War.Domain.Сleric;

public class Cleric:IHero,ICleric
{
    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public void Attack(IDamageble damageble)
    {
        throw new NotImplementedException();
    }

    public void Add(IWeapon weapon)
    {
        throw new NotImplementedException();
    }

    public void Heal(IHealable healable)
    {
        throw new NotImplementedException();
    }

}