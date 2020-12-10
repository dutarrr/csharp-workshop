using System;
using System.Collections;

namespace _2_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            var mercedesBuilder = new MercedesBuilder();
            shop.Build(mercedesBuilder);
            mercedesBuilder.GetCar().Show();

            var bmvBuilder = new BmvBuilder();
            shop.Build(bmvBuilder);
            bmvBuilder.GetCar().Show();

            Console.ReadKey();
        }
    }

    class Shop
    {
        public void Build(CarBuilder builder)
        {
            builder.BuildModel();
            builder.BuildEngine();
            builder.BuildColor();
        }
    }


    abstract class CarBuilder
    {
        protected Car Car { get; set; }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void BuildModel();
        public abstract void BuildColor();
        public abstract void BuildEngine();

    }
    class MercedesBuilder : CarBuilder
    {
        public MercedesBuilder()
        {
            Car = new Car();
            Car.Brand = "Mercedes";
            Car.Year = "2020";
        }

        public override void BuildModel() => Car.Model = "C";

        public override void BuildColor() => Car.Color = "Blue";

        public override void BuildEngine() => Car.Engine = "2.0";
    }
    class BmvBuilder : CarBuilder
    {
        public BmvBuilder()
        {
            Car = new Car();
            Car.Brand = "BMV";
            Car.Year = "2019";
        }

        public override void BuildModel() => Car.Model = "3";

        public override void BuildColor() => Car.Color = "Black";

        public override void BuildEngine() => Car.Engine = "1.8";
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Year { get; set; }

        public void Show()
        {
            System.Console.WriteLine($"Brand : {Brand}");
            System.Console.WriteLine($"Model : {Model}");
            System.Console.WriteLine($"Color : {Color}");
            System.Console.WriteLine($"Engine : {Engine}");
            System.Console.WriteLine($"Year : {Year}");
        }

    }
}
