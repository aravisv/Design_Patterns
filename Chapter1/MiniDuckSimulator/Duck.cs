using MiniDuckSimulator.Behaviours;

namespace MiniDuckSimulator
{
    public abstract class Duck
    {
        public FlyBehaviour? flyBehaviour;
        public QuackBehaviour? quackBehaviour;

        public Duck()
        {
        }

        public void setFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void setQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour?.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour?.Quack();
        }
    }
}