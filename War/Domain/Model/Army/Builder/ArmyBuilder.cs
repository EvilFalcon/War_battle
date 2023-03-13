using War.Data.Config;
using War.Domain.Model.Army.Factory;
using War.Domain.Model.Hero;
using War.Domain.Model.Hero.Builder;


namespace War.Domain.Model.Army.Builder;

public class ArmyBuilder
{
    private readonly ArmyConfig _config;
    private readonly ArmyFactory _armyFactory;
    private readonly HeroBuilder _heroBuilder;

    public ArmyBuilder(ArmyConfig config,ArmyFactory armyFactory, HeroBuilder heroBuilder)
    {
        _config = config;
        _armyFactory = armyFactory;
        _heroBuilder = heroBuilder;
    }

    public Army Build(string name)
    {
        Army army = _armyFactory.Create(name);

        AddHeroes(army, CreateHero(_heroBuilder.BildSwordsman,_config.SwordsmanCount));
        AddHeroes(army,CreateHero(_heroBuilder.Archer,_config.ArcherCount));
        AddHeroes(army, CreateHero(_heroBuilder.BildCleric,_config.ClericCount));

        return army;
    }

    private void AddHeroes(Army army, IHero[] heroes)
    {
        foreach (IHero hero in heroes)
        {
            army.Add(hero);
        }
    }

    private IHero[] CreateHero(Func<IHero> creator, int count)
    {
        List<IHero> heroes = new List<IHero>();

        for (int i = 0; i < count; i++)
        {
            heroes.Add(creator.Invoke());
        }

        return heroes.ToArray();
    }
}