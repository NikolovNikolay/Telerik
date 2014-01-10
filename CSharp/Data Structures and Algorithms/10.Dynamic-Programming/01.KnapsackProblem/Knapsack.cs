
namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Knapsack
    {
        public int BearableWeight { get; set; }
        private int currentWeight = 0;
        private IList<Product> content;

        public Knapsack(int weight)
        {
            this.BearableWeight = weight;
            this.content = new List<Product>();
        }
    }
}
