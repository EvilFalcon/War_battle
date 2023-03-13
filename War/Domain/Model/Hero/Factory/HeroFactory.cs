using War.Common.Factory;

namespace War.Domain.Model.Hero.Factory;

public class HeroFactory
{
    public Hero Create(int health,int armor) => new Hero(health, armor);
}