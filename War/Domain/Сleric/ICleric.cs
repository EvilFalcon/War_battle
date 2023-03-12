using War.Common.Damage;

namespace War.Domain.Сleric;

public interface ICleric
{
    void Heal(IHealable healable);
}