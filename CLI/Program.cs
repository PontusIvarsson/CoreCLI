using Handlers.Base;
using Handlers.Scen1;
using Handlers.Scen2;
using System;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            Scen1Handler handler = new Scen1Handler();
            Scen1Command command = new Scen1Command();
            Scen2Command command2 = new Scen2Command();
            
            Console.WriteLine(handler.Handle2(command2).Scen1Value);

            Console.ReadKey();
        }
    }
}
