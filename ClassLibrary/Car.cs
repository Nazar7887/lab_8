using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        public int Passengers { get; set; } // Кількість пасажирів

        // Конструктор за замовчуванням
        public Car() : base()
        {
            Passengers = 0;
        }

        // Конструктор з параметрами
        public Car(string brand, double mileage, double power, int cylinders, int passengers) : base(brand, mileage, power, cylinders)
        {
            Passengers = passengers;
        }

        // Конструктор копіювання
        public Car(Car other) : base(other)
        {
            Passengers = other.Passengers;
        }

        public void ChangePassengers(int newPassengers)
        {
            Passengers = newPassengers;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість пасажирів: {Passengers}");
        }

        public static bool operator >(Car c1, Car c2)
        {
            return c1.Passengers > c2.Passengers;
        }

        public static bool operator <(Car c1, Car c2)
        {
            return c1.Passengers < c2.Passengers;
        }
    }
}
