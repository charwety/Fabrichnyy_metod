using System;

namespace fabrichnyy_metod
{
    abstract class Transport
    {
        public abstract void Drive();
    }

    class Car : Transport
    {
        public override void Drive()
        {
            Console.WriteLine("Вы выбрали автомобиль. Водитель управляет автомобилем.");
        }
    }

    class Bicycle : Transport
    {
        public override void Drive()
        {
            Console.WriteLine("Вы выбрали велосипед. Водитель едет на велосипеде.");
        }
    }

    abstract class TransportCreator
    {
        public abstract Transport CreateTransport();
    }

    class CarCreator : TransportCreator
    {
        public override Transport CreateTransport()
        {
            return new Car();
        }
    }

    class BicycleCreator : TransportCreator
    {
        public override Transport CreateTransport()
        {
            return new Bicycle();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип транспортного средства:");
            Console.WriteLine("1: Автомобиль");
            Console.WriteLine("2: Велосипед");
            Console.Write("Введите номер (1 или 2): ");

            string input = Console.ReadLine();
            TransportCreator creator = null;

            switch (input)
            {
                case "1":
                    creator = new CarCreator();
                    break;
                case "2":
                    creator = new BicycleCreator();
                    break;
                default:
                    Console.WriteLine("Некорректный ответ");
                    return;
            }

            Transport transport = creator.CreateTransport();
            transport.Drive();

            Console.ReadLine();
        }
    }
}
