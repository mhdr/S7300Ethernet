using System;
using S7.Net;

namespace Ethernet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Plc plc = new Plc(CpuType.S7300, "127.0.0.1", 0, 2);
            plc.Open();

            if (plc.IsConnected)
            {
                Console.WriteLine("Connected");
            }
            
            object result = plc.Read("DB1.DBW6");
            object result2 = plc.Read("DB1.DBD2");
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}