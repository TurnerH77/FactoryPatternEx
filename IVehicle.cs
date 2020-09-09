using System;
using FactoryPatternEx;

public interface IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new car!");
    }
}
