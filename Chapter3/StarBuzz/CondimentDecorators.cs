using StarBuzz.Component;

namespace StarBuzz.CondimentDecorators
{
    public class Mocha : CondimentsDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }

    public class Soy : CondimentsDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }

    public class SteamedMilk : CondimentsDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", SteamedMilk";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }

    public class Whip : CondimentsDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
