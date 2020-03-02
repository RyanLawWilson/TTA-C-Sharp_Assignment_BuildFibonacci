using System;
using System.Collections.Generic;
using System.Text;

namespace BuildFibonacci
{
    public class Fibonacci
    {
        public Fibonacci()
        {

        }

        // Creates 20 fibonacci numbers based on the parameters.
        public void printSequence(int first, int second)
        {
            List<int> sequence = new List<int>() { first, second };

            Console.WriteLine("\nFirst integer: {0} | Second integer: {1}", first, second);

            for (int i = 1; i < 21; i++)
            {
                int newValue = sequence[i] + sequence[i - 1];
                Console.Write("{0,-8}  ", newValue);
                sequence.Add(newValue);
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
