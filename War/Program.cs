using System;
using System.Collections.Generic;

namespace War
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "War Battle";
        }
    }

    class Coliseum
    {
        
    }
    
    class Platoon //возод
    {
    }
    
    #region Warrior

    abstract class Warrior :IAttacer, IDamageble, IVisitable
    {
        private readonly Damage _damage;
        private readonly Health _health;

        public Warrior(Damage damage, Health health)
        {
            _damage = damage;
            _health = health;
        }

        public void Accept(IVisiter visiter)
        {
            _damage.Accept(visiter);
            _health.Accept(visiter);
           
        }

        public void Attack(IDamageble target)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(IDamage damade)
        {
            throw new NotImplementedException();
        }
    }

    class Swordsman :  Warrior
    {
        public Swordsman(Damage damage, Health health) : base(damage, health)
        {
        }
    }

    class Murderer :  Warrior
    {
        public Murderer(Damage damage, Health health) : base(damage, health)
        {
        }
    }

    class Archer :  Warrior
    {
        public Archer(Damage damage, Health health) : base(damage, health)
        {
        }
    }

    class MedicineMan
    {
    }

    #endregion
    
    #region Creators

    class PlatoonCreator
    {
    }

    class WarriorCreator
    {
    }

    #endregion

    #region InterFace

    interface IVisitable
    {
        void Accept(IVisiter visiter);
    }

    interface IVisiter
    {
        void Visit(IDamage damage);
        void Visit(Health health);
    }

    interface IAttacer
    {
        void Attack(IDamageble target);
    }

    interface IDamage
    {
        float Physical { get; }
    }

    interface IDamageble
    {
        void TakeDamage(IDamage damade);
    }

    class Damage : IDamage, IVisitable
    {
        public Damage(float phsical, float magic)
        {
            Physical = phsical;
            Magic = magic;
        }

        public float Physical { get; }
        public float Magic { get; }

        public void Accept(IVisiter visiter)
        {
            visiter.Visit(this);
        }
    }

    class Points
    {
        private float _value;

        public Points(float min, float max)
        {
            Min = min;
            Max = max;
            Value = max;
        }

        public event Action Changet;

        public float Min { get; }
        public float Max { get; }

        public float Value
        {
            get => _value;
            set
            {
                float _oldValue = _value;
                _value = Math.Clamp(value, Min, Max);
                Changet?.Invoke();
            }
        }
    }

    class Health : IVisitable
    {
        private readonly Points _points;

        public Health(float max)
        {
            Min = 0;
            _points = new Points(Min, max);
        }

        public event Action Changed
        {
            add => _points.Changet += value;
            remove => _points.Changet -= value;
        }

        public event Action Died;

        public float Max => _points.Max;
        public float Min { get; }

        public float Value
        {
            get => _points.Value;
            set
            {
                _points.Value = value;

                if (_points.Value == 0)
                {
                    Died?.Invoke();
                }
            }
        }

        public void Accept(IVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
    
    #endregion
    
}