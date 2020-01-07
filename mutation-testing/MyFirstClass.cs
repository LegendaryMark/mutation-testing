using System;

namespace mutation_testing
{
    public class MyFirstClass
    {
        public int MultiplyEvenNumberBySix(int number)
        {
            if (number % 2 != 0)
                throw new ArgumentException("number can only be an even number");

            var output = $"{number / 2}{number}";

            return int.Parse(output);
        }
    }
}
