using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Lorry : Vehicle
    {
        public double LoadCapacity { get; set; } 

        public Lorry() : base()
        {
            LoadCapacity = 0.0;
        }

        public Lorry(string brand, double mileage, double power, int cylinders, double loadCapacity) : base(brand, mileage, power, cylinders)
        {
            LoadCapacity = loadCapacity;
        }

        public Lorry(Lorry other) : base(other)
        {
            LoadCapacity = other.LoadCapacity;
        }

        public void ChangeLoadCapacity(double newLoadCapacity)
        {
            LoadCapacity = newLoadCapacity;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Вантажопідйомність: {LoadCapacity} кг");
        }

        public static bool operator >(Lorry l1, Lorry l2)
        {
            return l1.LoadCapacity > l2.LoadCapacity;
        }

        public static bool operator <(Lorry l1, Lorry l2)
        {
            return l1.LoadCapacity < l2.LoadCapacity;
        }
    }
}
