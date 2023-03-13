using War.Data.Config;
using War.Domain.Model.Army.Builder;
using War.Domain.Model.Army.Factory;
using War.Domain.Model.BattleField;
using War.Domain.Model.Hero.Builder;
using War.Domain.Model.Hero.Factory;
using War.Domain.Model.Weapon.Factory;
using War.Domain.Сleric.Factory;

namespace War
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "War Battle";

            WeaponConfig weaponConfig = new WeaponConfig();
            HeroConfig heroConfig = new HeroConfig();
            ArmyConfig armyConfig = new ArmyConfig();
            
            ClericFactory clericFactory = new ClericFactory();
            WeaponFactory weaponFactory = new WeaponFactory(weaponConfig);
            HeroFactory heroFactory = new HeroFactory();

            ArmyFactory armyFactory = new ArmyFactory();

            HeroBuilder heroBuilder = new HeroBuilder(heroConfig,heroFactory, clericFactory, weaponFactory);
            ArmyBuilder armyBuilder = new ArmyBuilder(armyConfig,armyFactory, heroBuilder);
            BattleFiled battleFiled = new BattleFiled(armyBuilder);

            battleFiled.StartBattle();
            Console.ReadKey();
        }
    }
}