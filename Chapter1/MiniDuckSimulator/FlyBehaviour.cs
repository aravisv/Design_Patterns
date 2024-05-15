namespace MiniDuckSimulator.Behaviours
{
    public interface FlyBehaviour
    {
        void Fly();
    }

    public class FlyWithWings : FlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("I am flying with wings");
        }
    }

    public class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("I can't fly");
        }
    }

    public class FlyRocketPowered : FlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying with rocket power");
        }
    }
}