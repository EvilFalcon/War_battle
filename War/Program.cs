using War.Domain.Model.Army;
using War.Domain.Model.Hero.Builder;
using War.Domain.Model.Hero.Factory;
using War.Domain.Model.Weapon.Factory;

namespace War
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "War Battle";

            WeaponFactory weaponFactory = new WeaponFactory();
            HeroFactory heroFactory = new HeroFactory();
            HeroBuilder heroBuilder = new HeroBuilder(heroFactory,weaponFactory);
            
            
            var hero =heroBuilder.BildSwordsman();
            var army = new Army();
            
        }
    }
    
}