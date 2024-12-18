using System;

namespace ClassLibrary
{
    public class Vehicle
    { 

    public string Brand { get; set; }
    public double Mileage { get; set; }
    public double Power { get; set; }
    public int Cylinders { get; set; }

    public Vehicle()
    {
        Brand = "Unknown";
        Mileage = 0.0;
        Power = 0.0;
        Cylinders = 0;
    }

    public Vehicle(string brand, double mileage, double power, int cylinders)
    {
        Brand = brand;
        Mileage = mileage;
        Power = power;
        Cylinders = cylinders;
    }

    public Vehicle(Vehicle other)
    {
        Brand = other.Brand;
        Mileage = other.Mileage;
        Power = other.Power;
        Cylinders = other.Cylinders;
    }

    public void ChangePower(double newPower)
    {
        Power = newPower;
    }

    public void ChangeMileage(double newMileage)
    {
        Mileage = newMileage;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Пробіг: {Mileage} км, Потужність: {Power} к.с., Кількість циліндрів: {Cylinders}");
    }
    }
}
