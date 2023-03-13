using War.Domain.Model.Army.Builder;

namespace War.Domain.Model.BattleField;

public class BattleFiled
{
    private readonly ArmyBuilder _armyBuilder;

    public BattleFiled(ArmyBuilder armyBuilder)
    {
        _armyBuilder = armyBuilder;
    }


    public void StartBattle()
    {
        Army.Army firstArmy = _armyBuilder.Build("первая армия");
        Army.Army secondArmy = _armyBuilder.Build("вторая армия");

        Battle(firstArmy,secondArmy);
    }

    private void Battle(Army.Army firstArmy,Army.Army secontArmy)
    {
        
        firstArmy.Attack(secontArmy);
        secontArmy.Attack(firstArmy);
        
    }
}