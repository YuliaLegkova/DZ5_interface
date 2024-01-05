using System;
using System.Collections.Generic;
using System.Threading;
namespace ДЗ_5___8
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();
            Console.WriteLine(quadcopter.GetInfo());
            Console.WriteLine($"Components: {string.Join(", ", quadcopter.GetComponents())}");
            if (quadcopter is IFlyingRobot iFly)
            Console.WriteLine($"Robot Type: {iFly.GetRobotType()}");
            IChargeable chargeableRobot = quadcopter;
            chargeableRobot.Charge();
        }
    }
}


