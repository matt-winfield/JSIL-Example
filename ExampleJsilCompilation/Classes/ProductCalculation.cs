using ExampleJsilCompilation.Interfaces;

namespace ExampleJsilCompilation.Classes
{
    class ProductCalculation : ICalculation
    {
        public int Calculate(params int[] values)
        {
            int total = 0;
            foreach(var value in values)
            {
                total *= value;
            }
            return total;
        }
    }
}
