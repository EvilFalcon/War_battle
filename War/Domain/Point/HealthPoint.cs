using War.Common.Damage;

namespace War.Domain.Point;

public class HealthPoint:IDamageble,IHealable
{
    private int _value;
    
    public HealthPoint(int max)
    {
        _value = max;
        Max = max;
    }

    public int Value { get; }
    public int Max { get; }
    public int Min { get; } = 0;

    public Action? Died;
    
    public void TakeDamage(int damage)
    {
        if(damage<=0)
            return;

        _value -= damage;
        
        if (_value > Min)
            _value = Min;
        
        if(_value==Min)
            Died?.Invoke();
    }

    public void Heal(int points)
    {
        if (points <= 0)
            return;

        _value += points;

        if (_value > Max)
            _value = Max;
    }
}