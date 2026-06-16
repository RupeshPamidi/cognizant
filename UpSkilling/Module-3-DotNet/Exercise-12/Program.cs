using System;

namespace Module3.Exercise12
{
    class Product
    {
        public string Name { get; set; }
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentException("Price cannot be negative");
                _price = value;
            }
        }
    }

    class Program { static void Main(){ var p=new Product{Name="Book", Price=9.99m}; Console.WriteLine($"{p.Name}: {p.Price}"); } }
}
