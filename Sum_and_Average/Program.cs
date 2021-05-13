using System;

namespace Sum_and_Average
{
    class Program
    {
        /*read 10 numbers from keyboard and find their sum and average. */
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine()); 

            int[] n = new int[num];
            int sum = 0;
            int i = 0;
            //Store data in array
            while(i< num)
            {
                Console.WriteLine("Enter data: ");
                int a = Convert.ToInt32(Console.ReadLine());
                n[i] = a;
                i++;
            }
            //Sum of data
            for ( i = 0; i< num; i++)
            {
                 sum = sum + n[i];
            }
            Console.WriteLine("Sum of numbers are {0} ", Convert.ToInt32(sum));
            //average of data
            int avg = sum / num;
            Console.WriteLine("Average  of numbers is {0} ", Convert.ToInt32(avg));
        }
    }
}
