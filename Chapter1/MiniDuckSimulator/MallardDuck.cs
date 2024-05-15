using MiniDuckSimulator.Behaviours;

namespace MiniDuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new QuackQuack();
        }
        public override void Display()
        {
            System.Console.WriteLine("I am a Mallard duck");
        }
    }
}
