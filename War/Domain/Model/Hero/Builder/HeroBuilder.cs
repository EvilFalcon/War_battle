using War.Domain.Model.Hero.Factory;
using War.Domain.Model.Weapon;
using War.Domain.Model.Weapon.Factory;

namespace War.Domain.Model.Hero.Builder;

public class HeroBuilder
{
     private readonly HeroFactory _heroFactory;
     private readonly WeaponFactory _weaponFactory;
     
     public HeroBuilder(HeroFactory heroFactory,WeaponFactory weaponFactory)
     {
          _heroFactory = heroFactory;
          _weaponFactory = weaponFactory;
     }

     public IHero BildSwordsman()
     {
          IHero hero = _heroFactory.Create();
          IWeapon weapon = _weaponFactory.CreateTwoHandSword();
          hero.Add(weapon);
          return hero;
     }
}