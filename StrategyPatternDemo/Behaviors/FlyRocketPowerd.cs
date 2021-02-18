using System;

namespace StrategyPattern.Behaviors
{
    public class FlyRocketPowerd: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
