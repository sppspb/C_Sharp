using System;

namespace C_Sharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            Console.WriteLine("Sum is: " + sum3);

            int sub1 = 200 - 50;        // 50 (100 + 50)
            int sub2 = sub1 - 50;      // 150 (150 + 250)
            int sub3 = sub2 - sum2;

            Console.WriteLine("subtrcation is: " + sub3);

            int a, b, c,d,e, mul, div, mod, inc_pre, dec_pre, inc_post, dec_post,max,min,ab,ro;
            double sq;

            

            a = 20;
            b = 40;
            c = 11;
            d = 25;

            e = (a > b) ? a : b;
            Console.WriteLine("? oprator : " + e);
            max = Math.Max(a, b);
            Console.WriteLine("Max number is: " + max);
            min = Math.Min(a, b);
            Console.WriteLine("Min number is: " + min);
            sq = Math.Sqrt(d);
            Console.WriteLine("Squareroot  number is: " + sq);

            mul = a * b;
            div = a / b;
            mod = a % b;
            inc_pre = ++a;

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False


            inc_post = c++;
            dec_pre = --b;
            dec_post = d--;

            Console.WriteLine("Multiplication is: " + mul);
            Console.WriteLine("Division is: " +div);
            Console.WriteLine("Modulous is: " +mod);
            Console.WriteLine("Pre Increment is: " + inc_pre);
            Console.WriteLine("Post Increment is: " + inc_post);
            Console.WriteLine("Pre Decrement is: " + dec_pre);
            Console.WriteLine("Post Decrement is: " + dec_post);



        }
    }
}
