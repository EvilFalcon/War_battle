namespace War.Common.Factory;

public interface IFactory <out T>
{
     T Create();
}