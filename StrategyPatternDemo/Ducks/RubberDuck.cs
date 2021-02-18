using System;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}