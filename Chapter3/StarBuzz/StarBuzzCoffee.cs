using System;
using StarBuzz.Beverages;
using StarBuzz.CondimentDecorators;
using StarBuzz.Component;

namespace StarBuzz
{
    public class StarBuzz
    {
        public static void Main()
        {
            Beverage beverage1 = new Espresso();
            System.Console.WriteLine(beverage1.GetDescription() + ", $" + beverage1.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            System.Console.WriteLine(beverage2.GetDescription() + ", $" + beverage2.Cost());

        }
    }
}