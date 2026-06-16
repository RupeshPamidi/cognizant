using System;

namespace Module3.Exercise15
{
    abstract class Vehicle { public abstract void Drive(); }
    interface IDrivable { void Start(); }
    class Car : Vehicle, IDrivable { public override void Drive() => Console.WriteLine("Car driving"); public void Start() => Console.WriteLine("Car started"); }

    class Program { static void Main(){ Vehicle v = new Car(); ((IDrivable)v).Start(); v.Drive(); } }
}
