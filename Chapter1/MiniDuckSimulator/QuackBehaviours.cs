namespace MiniDuckSimulator.Behaviours
{
    public interface QuackBehaviour
    {
        void Quack();
    }

    public class QuackQuack : QuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack! Quack!");
        }
    }

    public class MuteQuack : QuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Silence");
        }
    }
}
