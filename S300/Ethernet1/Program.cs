using System;
using Sharp7;

namespace Ethernet1
{
    class Program
    {
        static void Main(string[] args)
        {
            S7Client client = new S7Client();
            int result = client.ConnectTo("127.0.0.1", 0, 2);

            if (result != 0)
            {
                Console.WriteLine(client.ErrorText(result));
            }
            else
            {
                byte[] dbBuffer = new byte[8];
                result = client.DBRead(1, 0, 8, dbBuffer);
                var var2 = S7.GetRealAt(dbBuffer, 2);
                Console.WriteLine(var2);
            }
        }
    }
}