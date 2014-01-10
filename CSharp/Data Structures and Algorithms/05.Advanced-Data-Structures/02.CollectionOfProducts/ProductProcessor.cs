
namespace CollectionOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class ProductProcessor
    {
        private OrderedBag<Product> bag;

        public ProductProcessor()
        {
            this.bag = new OrderedBag<Product>();
        }

        public void Add(Product product)
        {
            this.bag.Add(product);
        }

        public IEnumerable<Product> GetProductsInRange(double start, double end)
        {
            var result = this.bag.Range(new Product("start", start),true,new Product("end",end),true).Take(20);
            return result;
        }
    }
}
