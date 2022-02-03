using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleGlaze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter Pills:");
            string pillsNeeded = Console.ReadLine();
            int bottleOrder = int.Parse(pillsNeeded);

            Console.WriteLine("Update Price Per Bottle:");
            string priceOfBottle = Console.ReadLine();
            double bottlePrice = double.Parse(priceOfBottle);

            int howManyBottles = (bottleOrder + 99) / 100;

            double priceTotal;
            priceTotal = bottlePrice * howManyBottles;

            Console.WriteLine($"The number of bottles needed is {howManyBottles} at a price of ${bottlePrice} per bottle");
            Console.WriteLine($"This brings the total to ${priceTotal}");*/



            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter a width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter a height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            glassArea = 2*(width*height);
            woodLength =  (((width + height)*3.25)*2);

            Console.WriteLine($"You will need {glassArea} square meters for double glaze and {woodLength} feet of wood to go around the double glaze window");
            Console.ReadLine();
        }
    }
}
