using MiniDuckSimulator.Behaviours;

namespace MiniDuckSimulator
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.setFlyBehaviour(new FlyNoWay());
            modelDuck.PerformFly();
            modelDuck.setQuackBehaviour(new QuackQuack());
            modelDuck.PerformQuack();
            modelDuck.setFlyBehaviour(new FlyRocketPowered());
            modelDuck.PerformFly();

        }
    }
}