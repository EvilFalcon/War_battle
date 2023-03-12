using War.Common.Attack;

namespace War.Domain.Model.Army;

public interface IAttackComponent:IAttacker
{
    void Add(IAttacker component);
}