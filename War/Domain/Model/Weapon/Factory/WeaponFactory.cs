using War.Common.Factory;

namespace War.Domain.Model.Weapon.Factory;

public class WeaponFactory
{
    private readonly int _twoHendSwordDamage = 100;
    
    public IWeapon CreateTwoHandSword()
    {
        return new Weapons(_twoHendSwordDamage);
    }
}