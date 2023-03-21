using System;

namespace Prakticheskaya_1
{
    class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Имя машины: " + Name);
            Console.WriteLine("Максимальная скорость:" + MaxSpeed + "км/ч");
        }
    }
    class Race
    {
        static void Main()
        {
            Car car1 = new Car("Ferrari", 350);
            Car car2 = new Car("Porsche", 330);
            Car car3 = new Car("Mercedes-AMG", 320);
            Car car4 = new Car("Lamborgini", 360);

            car1.PrintInfo();
            car2.PrintInfo();
            car3.PrintInfo();
            car4.PrintInfo();
        }
    }
}