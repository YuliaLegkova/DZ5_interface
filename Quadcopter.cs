using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_5___8
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public string GetInfo()
        {
            return "Quadcopter information.";
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
    }
}
