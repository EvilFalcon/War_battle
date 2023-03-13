namespace War.Domain.Сleric.Factory;

public class ClericFactory
{
    public Cleric Create(int health,int armor, int healPoint) => 
        new Cleric(health,armor, healPoint);
}