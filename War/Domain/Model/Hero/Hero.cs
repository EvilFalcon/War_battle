
using War.Common.Damage;

using War.Domain.Model.Weapon;
using War.Domain.Point;

namespace War.Domain.Model.Hero;

public class Hero : IHero
{
    private  HealthPoint _healthPoint;
    private readonly int _armor;
    private readonly List<IWeapon> _weapons = new List<IWeapon>();

    public Hero(int health,int armor)
    {
        _healthPoint = new HealthPoint(health);
        _armor = armor;
    }
    public event Action? Daed
    {
        add => _healthPoint.Died += value;
        remove => _healthPoint.Died -= value;
    }

    public void TakeDamage(int damage) => _healthPoint.TakeDamage(damage);

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

    public void Heal(int points) => _healthPoint.Heal(points);
}