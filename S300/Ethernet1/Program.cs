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
        }
    }
}