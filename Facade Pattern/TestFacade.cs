using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class TestFacade
    {
        static void Main(string[] args)
        {

            ScheduleServer scheduleServer = new ScheduleServer();
            ScheduleServerFacade facadeServer = new ScheduleServerFacade(scheduleServer);
            facadeServer.StartServer();
            Console.WriteLine("Start working......");
            Console.WriteLine("After work done.........");
            facadeServer.StopServer();

            Console.Read();

        }
    }
}
