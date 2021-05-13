using System;

namespace Check_Alphabet
{
    /* Enter an alphabet and show that it is an alphabet */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet A-Z or a-z");
            char ch = Convert.ToChar(Console.ReadLine());

            bool result;
            result = Char.IsLetter(ch);

            if(result)
            {
                Console.WriteLine("{0} is an alphabet", ch);
            }
            else
            {
                Console.WriteLine("{0} is not an alphabet", ch);
            }

        }
    }
}
