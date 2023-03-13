using War.Common.Damage;
using War.Domain.Model.Hero;

namespace War.Domain.Сleric;

public class Cleric:Hero,ICleric
{
    private readonly int _healPoints;


    public Cleric(int health,int armor,int healPoints) : base(health,armor) => _healPoints = healPoints;

    public void Heal(IHealable target) => target.Heal(_healPoints);
}