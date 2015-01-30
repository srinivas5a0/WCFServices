using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWindowsSetup
{
    public partial class HelloService : ServiceBase
    {
        ServiceHost host; 
        public HelloService()
        {
            InitializeComponent();
            ServiceHost host = new ServiceHost(typeof(HelloSeervice.HelloService));
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(HelloSeervice.HelloService));
            host.Open();
                
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
