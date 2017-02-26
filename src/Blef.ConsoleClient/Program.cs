using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blef.ConsoleClient
{
    class Program
    {
        static ServerConnector _serverConnector;

        static void Main(string[] args)
        {
            _serverConnector = new ServerConnector();

            Console.WriteLine("Press Enter when server has established");
            Console.ReadLine();

            _serverConnector.Register();

            Console.ReadLine();
        }
    }
}
