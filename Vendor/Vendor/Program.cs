using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toshiba;

namespace Vendor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tv obj = new Tv();
            obj.Display();
            LG.WashingMachine machine = new LG.WashingMachine();
            machine.Display();
            Toshiba.WashingMachine tmachine= new Toshiba.WashingMachine();
            tmachine.Display();
            Console.ReadKey();
        }
    }

   
}
