using StrategyPattern.Behaviors;
using System;

namespace StrategyPattern.Ducks
{
    public class DecoyDuck :Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
