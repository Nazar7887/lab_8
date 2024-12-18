using ClassLibrary;
using System;
using System.Collections.Generic;

namespace lr8
{
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            int choice;
            do
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Створити та додати легковий автомобіль");
                Console.WriteLine("2. Створити та додати вантажівку");
                Console.WriteLine("3. Показати всі транспортні засоби");
                Console.WriteLine("4. Порівняти вантажівки");
                Console.WriteLine("5. Порівняти легкові автомобілі");
                Console.WriteLine("6. Вихід");

                Console.Write("Ваш вибір: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        vehicles.Add(new Car("Toyota", 50000, 150, 4, 5));
                        break;
                    case 2:
                        vehicles.Add(new Lorry("Volvo", 100000, 300, 6, 10000));
                        break;
                    case 3:
                        foreach (var vehicle in vehicles)
                        {
                            vehicle.ShowInfo();
                        }
                        break;
                    case 4:
                        if (vehicles[0] is Lorry lorry1 && vehicles[1] is Lorry lorry2)
                        {
                            if (lorry1 > lorry2)
                                Console.WriteLine("Перша вантажівка має більшу вантажопідйомність.");
                            else
                                Console.WriteLine("Друга вантажівка має більшу вантажопідйомність.");
                        }
                        break;
                    case 5:
                        if (vehicles[0] is Car car1 && vehicles[1] is Car car2)
                        {
                            if (car1 > car2)
                                Console.WriteLine("Перше авто має більше пасажирів.");
                            else
                                Console.WriteLine("Друге авто має більше пасажирів.");
                        }
                        break;
                }

            } while (choice != 6);
        }
    }
}
