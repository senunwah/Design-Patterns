using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class ScheduleServerFacade
    {
        private ScheduleServer scheduleServer;
    
        public ScheduleServerFacade(ScheduleServer scheduleServer)
            {
                this.scheduleServer = scheduleServer;
            }

        public void StartServer()
        {
            scheduleServer.startBooting();
            scheduleServer.readSystemConfigFile();
            scheduleServer.init();
            scheduleServer.initializeContext();
            scheduleServer.initializeListeners();
            scheduleServer.createSystemObjects();
        }

        public void StopServer()
        {
            scheduleServer.releaseProcesses();
            scheduleServer.destroy();
            scheduleServer.destroySystemObjects();
            scheduleServer.destroyListeners();
            scheduleServer.destroyContext();
            scheduleServer.shutDown();
        }
    }
}
