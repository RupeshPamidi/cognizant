using System;

namespace Module3.Exercise10
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car() { Make = "Unknown"; Model = "Unknown"; Year = 0; }
        public Car(string make, string model, int year) { Make = make; Model = model; Year = year; }
        public override string ToString() => $"{Year} {Make} {Model}";
    }

    class Program
    {
        static void Main()
        {
            var c1 = new Car();
            var c2 = new Car("Toyota","Camry",2020);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
