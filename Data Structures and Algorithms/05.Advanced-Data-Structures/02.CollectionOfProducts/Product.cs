
namespace CollectionOfProducts
{
    using System;
    using System.Linq;

    public class Product : IComparable<Product>
    {
        public string  Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price) return 1;
            else if (this.Price < other.Price) return -1;
            else return 0;
        }
    }
}
