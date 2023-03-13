using War.Data.Config;
using War.Domain.Model.Hero.Factory;
using War.Domain.Model.Weapon;
using War.Domain.Model.Weapon.Factory;
using War.Domain.Сleric;
using War.Domain.Сleric.Factory;

namespace War.Domain.Model.Hero.Builder;

public class HeroBuilder
{
     private readonly HeroConfig _heroConfig;
     private readonly HeroFactory _heroFactory;
     private readonly ClericFactory _clericFactory;
     private readonly WeaponFactory _weaponFactory;
     
     public HeroBuilder(HeroConfig heroConfig,
          HeroFactory heroFactory,
          ClericFactory clericFactory,
          WeaponFactory weaponFactory
    )
     {
          _heroConfig = heroConfig;
          _heroFactory = heroFactory;
          _clericFactory = clericFactory;
          _weaponFactory = weaponFactory;
     }

     public Hero BildSwordsman()
     {
          Hero hero = _heroFactory.Create(_heroConfig.HealthHero,_heroConfig.ArmorHero);
          IWeapon weapon = _weaponFactory.CreateTwoHandSword();
          hero.Add(weapon);
          return hero;
     }

     public Cleric BildCleric()
     {
          Cleric cleric = _clericFactory.Create(_heroConfig.HealthCleric,_heroConfig.ArmorCleric, _heroConfig.HealPoint);
          IWeapon mace = _weaponFactory.CreateMace();
          cleric.Add(mace);
          return cleric;
     }

     public Hero Archer()
     {
          Hero archer = _heroFactory.Create(_heroConfig.HealthArcher, _heroConfig.ArmorArcher);
          IWeapon bow = _weaponFactory.CreateCombatBow();
          archer.Add(bow);
          return archer;

     }
}