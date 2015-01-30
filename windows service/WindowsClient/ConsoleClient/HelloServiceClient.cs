using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.IO;
using HelloSeervice;
namespace ConsoleClient
{
    public class HelloServiceClient : ClientBase<IHelloService>, IHelloService, IDisposable
    {
        public HelloServiceClient()
            : base("HelloSeervice.HelloService")
        {
        }

        public string GetMessage(string Name)
        {
           return base.Channel.GetMessage(Name);
        }
    }
}
