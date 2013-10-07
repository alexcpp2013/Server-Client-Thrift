using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TimeServerCore;
using TimeServer.Thrift;

namespace TimeServer
{
    class TimeServiceImplementation : TimeService.Iface
    {
        public TimeServer.Thrift.TimeInfoStruct GetTime()
        {
            return new TimeInfoStruct() { Time = DateTime.Now.ToString() };
        }
    }
}
