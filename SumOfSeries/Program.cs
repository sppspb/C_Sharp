using System;

namespace SumOfSeries
{
    class Program
    { /* Sum of n natural numbers */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} Natural numbers are: " ,Convert.ToString(n)); 
            //Print n number 
            for (int i =1; n-i>=0; i++)
            {
                Console.WriteLine(Convert.ToString(i));
            }

            // Sum n numbers
            int sum = n*(n + 1)/2;
            Console.WriteLine("Sum of {0} natural numbers is {1} ", Convert.ToString(n), Convert.ToString(sum));
        }
    }
}
