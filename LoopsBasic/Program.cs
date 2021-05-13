using System;

namespace LoopsBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // check number is odd or even
            Console.WriteLine("Please Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine("{0} is Even Number", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd Number", num);
            }
            Console.ReadKey();

            

            //Print odd and even number
            for(int i =0; i<20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} is Even Number",i);
                }
                else
                {
                    Console.WriteLine("{0} is Odd Number", i);
                }
               

            }
            Console.ReadKey();

            //Print Even number

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} is Even Number", i);
                }
               


            }
            Console.ReadKey();

            //Print Odd Number
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0)
               
                {
                    Console.WriteLine("{0} is Odd Number", i);
                }


            }
            Console.ReadKey();
        }
    }
}
