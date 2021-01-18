using System;

namespace StrategyPattern.Behaviors
{
    class MuteQuack:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
