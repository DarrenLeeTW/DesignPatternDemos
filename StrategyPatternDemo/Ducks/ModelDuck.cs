using StrategyPattern.Behaviors;
using System;

namespace StrategyPattern.Ducks
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
   
}
