using StarBuzz.Component;

namespace StarBuzz.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            //description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roat";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
