namespace StarBuzz.Component
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }

    public abstract class CondimentsDecorator : Beverage
    {
        protected Beverage beverage;
        public override abstract string GetDescription();
    }
}
