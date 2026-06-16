using System;

namespace Module3.Exercise11
{
    class BaseClass
    {
        public int PublicField = 1;
        private int PrivateField = 2;
        protected int ProtectedField = 3;

        public void Show() => Console.WriteLine($"public={PublicField}, protected={ProtectedField}");
    }

    class Derived : BaseClass
    {
        public void Demo() { Console.WriteLine($"Access protected from derived: {ProtectedField}"); }
    }

    class Other
    {
        public void TryAccess()
        {
            var b = new BaseClass();
            Console.WriteLine(b.PublicField);
            // cannot access b.PrivateField or b.ProtectedField here
        }
    }

    class Program { static void Main(){ new Derived().Demo(); new BaseClass().Show(); } }
}
