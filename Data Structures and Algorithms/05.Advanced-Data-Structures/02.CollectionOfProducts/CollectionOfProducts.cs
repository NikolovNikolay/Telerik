/*Write a program to read a large collection of products (name + price)
 * and efficiently find the first 20 products in the price range [a…b].
 * Test for 500 000 products and 10 000 price searches.
    Hint: you may use OrderedBag<T> and sub-ranges.
*/

namespace CollectionOfProducts
{
    using System;
    using System.Linq;

    class CollectionOfProducts
    {
        static void Main(string[] args)
        {
            ProductProcessor processor = new ProductProcessor();
            Random generator = new Random();

            char name = '@';
            for (int i = 1; i <= 26; i++)
            {
                processor.Add(new Product(((char)(name + i)).ToString(),generator.Next(1,20)));
            }

            var result = processor.GetProductsInRange(1, 20);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }
    }
}
