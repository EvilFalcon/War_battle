using War.Common.Factory;

namespace War.Domain.Model.Hero.Factory;

public class HeroFactory:IFactory<IHero>
{
    public IHero Create()=> new Hero();
    
}