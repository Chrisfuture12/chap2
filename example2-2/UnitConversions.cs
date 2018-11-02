using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2_2
{
    class UnitConversion
    {
        static void Main(string[] args)
        {
            double dimesionInches, dimensionFeet, dimensionSqft, dimensionYard;

            String input;
            Console.WriteLine("Enter dimesnion  in inches");
            input = Console.ReadLine();
            dimesionInches = double.Parse(input);
            Console.WriteLine("Dimension  in inches is {0}", dimesionInches);
            Console.ReadLine();

            dimensionFeet = dimesionInches / 12;
            dimensionSqft = dimensionFeet * dimensionFeet;
            dimensionYard = dimensionSqft / 9;

            Console.WriteLine("Dimensions in feet is {0}ft , in sqft is {1:F2}sqft, in yard is {2:F4}sqyards", dimensionFeet, dimensionSqft, dimensionYard);

            Console.ReadLine();
        }
    }
}
