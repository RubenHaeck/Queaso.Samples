using Common.Logging;
using Queaso.Northwind.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Queaso.ConsoleHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = LogManager.GetCurrentClassLogger();

            log.Info(l => l("Start application..."));

            ServiceHost customerServiceHost = new ServiceHost(typeof(CustomerService));
            customerServiceHost.Open();

            Console.WriteLine("Services started. Press [Enter] to exit");
            Console.ReadLine();

            customerServiceHost.Close();

            log.Info(l => l("End application"));
        }
    }
}
