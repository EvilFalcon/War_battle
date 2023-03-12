using War.Common.Attack;
using War.Common.Damage;
using War.Domain.Model.Army;
using War.Domain.Model.Weapon;

namespace War.Domain.Model.Hero;

public class Hero : IHero
{
    private readonly List<IWeapon> _weapons = new List<IWeapon>();
    
    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public void Attack(IDamageble damageble)
    {
        foreach (IWeapon weapon in _weapons)
        {
            weapon.Attack(damageble);
        }
    }

    public void Add(IWeapon component)
    {
        if (_weapons.Contains(component) == false)
        {
            _weapons.Add(component);
        }
    }

    private int CalculateDamage()
    {
        int damage = 0;

        foreach (IWeapon weapon in _weapons)
        {
            weapon.
        }
    }

}