using War.Common.Attack;
using War.Common.Damage;

namespace War.Domain.Model.Weapon;

public class Weapons : IWeapon 
{
    private readonly int _damage;

    public Weapons(int damage) => _damage = damage;


    public void Attack(IDamageble damageble) => damageble.TakeDamage(_damage);
}