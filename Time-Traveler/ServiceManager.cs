using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace Time_Traveler
{
    static class ServiceManager
    {

        public static bool isServiceRunning(String SERVICENAME)
        {

            ServiceController sc = new ServiceController(SERVICENAME);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return true;
                default:
                    return false;
            }
        }

    }
}
