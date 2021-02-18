using System;
using StrategyPattern.Behaviors;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck MallardDuck = new MallardDuck();
            MallardDuck.PerformQuack();
            MallardDuck.PerformFly();

            Duck RedHeadDuck = new RedheadDuck();
            RedHeadDuck.PerformQuack();
            RedHeadDuck.PerformFly();

            Duck DecoyDuck = new DecoyDuck();
            DecoyDuck.PerformQuack();
            DecoyDuck.PerformFly();

            Duck RubberDuck = new RubberDuck();
            RubberDuck.PerformQuack();
            RubberDuck.PerformFly();
           
            Duck ModelDuck = new ModelDuck();
            ModelDuck.PerformFly();
            ModelDuck.SetFlyBehavior(new FlyRocketPowerd());
            ModelDuck.PerformFly();

            Console.ReadLine();
        }
    }
}
