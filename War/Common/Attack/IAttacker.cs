using War.Common.Damage;

namespace War.Common.Attack;

public interface IAttacker
{
    void Attack(IDamageble damageble);
}