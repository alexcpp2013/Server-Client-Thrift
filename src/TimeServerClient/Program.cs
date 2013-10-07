using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;
using TimeServer.Thrift;

namespace TimeServerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TTransport transport = new TSocket("localhost", 1337);
            TProtocol proto = new TBinaryProtocol(transport);
            TimeService.Client client = new TimeService.Client(proto);

            transport.Open();
            TimeInfoStruct result = client.GetTime();

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
