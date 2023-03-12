using War.Common.Attack;
using War.Common.Damage;

namespace War.Domain.Model.Army;

public class Army:IAttackComponent
{
    private readonly List<IAttacker> _components = new List<IAttacker>();
    
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
    
}

