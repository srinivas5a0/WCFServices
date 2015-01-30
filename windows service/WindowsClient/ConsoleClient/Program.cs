using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloServiceClient client = new HelloServiceClient();
            string ipaddress = client.Endpoint.Address.Uri.Host;
            int port = client.Endpoint.Address.Uri.Port;
            client.Open();
            Console.WriteLine(client.GetMessage(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
