using System;
using Sharp7;

namespace Ethernet1
{
    class Program
    {
        static void Main(string[] args)
        {
            S7Client client = new S7Client();
            int result = client.ConnectTo("192.168.0.3", 0, 2);

            if (result != 0)
            {
                Console.WriteLine(client.ErrorText(result));
            }
            else
            {
                byte[] dbBuffer = new byte[12];
                result = client.DBRead(1, 0, 12, dbBuffer);
                var var1 = S7.GetIntAt(dbBuffer, 0);
                var var2 = S7.GetRealAt(dbBuffer, 2);
                var var4 = S7.GetDWordAt(dbBuffer, 8);
                Console.WriteLine(var1);
                Console.WriteLine(var2);
                Console.WriteLine(var4);
            }
        }
    }
}