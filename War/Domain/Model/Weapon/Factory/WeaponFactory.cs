using War.Data.Config;

namespace War.Domain.Model.Weapon.Factory;

public class WeaponFactory
{
    private readonly WeaponConfig _weaponConfig;

    public WeaponFactory(WeaponConfig weaponConfig)
    {
        _weaponConfig = weaponConfig;
    }

    public IWeapon CreateTwoHandSword() => new Weapons(_weaponConfig.TwoHendSwordDamage);

    public IWeapon CreateMace() => new Weapons(_weaponConfig.MaceDamage);

    public IWeapon CreateCombatBow() => new Weapons(_weaponConfig.CombatBowDamage);
}