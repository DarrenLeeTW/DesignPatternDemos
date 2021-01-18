using System;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.ReadLine();
        }
    }
}
