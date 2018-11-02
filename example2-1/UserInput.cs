using System;

namespace example2
{
    class UserInput
    {
        static void Main()
        {
            double ml;
            string value1;
            Console.WriteLine("Enter the amount in ml: ");
            value1 = Console.ReadLine();
            ml = double.Parse(value1);
            Console.WriteLine("You entered " + ml + " ml");
            Console.ReadKey();
        }
    }
}
