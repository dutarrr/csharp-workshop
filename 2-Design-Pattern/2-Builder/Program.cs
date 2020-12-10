using System;
using System.Collections;

namespace _2_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    abstract class CarBuilder
    {
        protected Car Car;
        public abstract void BuildModel();
        public abstract void BuildColor();
        public abstract void BuildEngine();

    }
    class MercedesBuilder : CarBuilder
    {
        public MercedesBuilder()
        {
            Car = new Car("Mercedes");
        }

        public override void BuildModel()
        {
            Car.Model = "C";
        }

        public override void BuildColor()
        {
            Car.Color = "Blue";
        }

        public override void BuildEngine()
        {
            Car.Engine = "2.0";
        }
    }


    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Year { get; set; }

        public Car(string Model, string Color, string Engine, string Year)
        {
            (Model, Color, Engine, Year) = (Model, Color, Engine, Year);
        }

         public Car(string Brand)
        {
            (Brand) = (Brand);
        }

        public void Show()
        {
            System.Console.WriteLine($"Model : {Model}");
            System.Console.WriteLine($"Color : {Color}");
            System.Console.WriteLine($"Engine : {Engine}");
            System.Console.WriteLine($"Year : {Year}");
        }

    }
}
