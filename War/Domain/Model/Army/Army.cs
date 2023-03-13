using War.Common.Attack;
using War.Common.Damage;

namespace War.Domain.Model.Army;

public class Army:IAttackComponent,IDamageble
{
    private readonly string _name;
    private readonly List<IAttacker> _components = new List<IAttacker>();

    public Army(string name)
    {
        _name = name;
    }
    
    public void Attack(IDamageble damageble)
    {
        foreach (IAttacker attackComponent in _components)
        {
            attackComponent.Attack(damageble);
        }
    }

    public void Add(IAttacker component)
    {
        if (_components.Contains(component) == false)
        {
            _components.Add(component);
        }
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"армия  {_name} получила урон {damage} ");
    }
}

