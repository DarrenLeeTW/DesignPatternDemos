using System;
using StrategyPattern.Behaviors;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowerd());
            model.PerformFly();

            Console.ReadLine();
        }
    }
}
