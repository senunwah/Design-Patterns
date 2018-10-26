using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    interface IScheduleServerInterface
    {
        void startBooting();
        void readSystemConfigFile();
        void init();
        void initializeContext();
        void initializeListeners();
        void createSystemObjects();
        void releaseProcesses();
        void destroy();
        void destroySystemObjects();
        void destroyListeners();
        void destroyContext();
        void shutDown();
    }
}
