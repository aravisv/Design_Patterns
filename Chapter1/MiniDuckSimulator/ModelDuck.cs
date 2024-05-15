using MiniDuckSimulator.Behaviours;

namespace MiniDuckSimulator
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new QuackQuack();
        }
        public override void Display()
        {
            System.Console.WriteLine("I am a rocket model duck");
        }
    }
}