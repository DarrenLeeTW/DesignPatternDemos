using StrategyPattern.Behaviors;
using System;

namespace StrategyPattern.Ducks
{
    public class RedheadDuck :Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Red head duck");
        }
    }
}
