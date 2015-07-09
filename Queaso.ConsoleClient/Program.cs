using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Queaso.Northwind.Contract;
using System.Net.NetworkInformation;
using System.Net;
using Common.Logging;
using System.IO;
using Queaso.ConsoleClient.Proxies;
using System.Threading;

namespace Queaso.ConsoleClient
{
    class Program
    {
        private static ILog _log;

        static void Main(string[] args)
        {
            _log = LogManager.GetLogger("Queaso.ConsoleClient.Main");
            try
            {
                _log.Info(l => l("Start client application..."));

                _log.Info(l => l("Exercise 1 - Work with ChannelFactory & Channel"));

                Exercise1();

                _log.Info(l => l("Exercise 2 - Work with Client Proxies"));
                
                Exercise2();

                _log.Info(l => l("Behaviours"));

                var customerProxy = new CustomerProxy();
                customerProxy.IsThisAnException();

                Thread.Sleep(50);

                
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                throw ex;
            }
        
        }

        /// <summary>
        /// Works with ChannelFactory
        /// </summary>
        static void Exercise1()
        {
            var channelFactory = new ChannelFactory<ICustomerService>("*");
            var channel = channelFactory.CreateChannel(new EndpointAddress("http://localhost:57920/CustomerService.svc"));

            // Test connection
            var list = channel.GetList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            // Authentication
            var account = channel.WhoIAm("SDWorx");
        }

        /// <summary>
        ///  Works with Proxies
        /// </summary>
        static void Exercise2()
        {
            var customerProxy = new CustomerProxy();
            var list = customerProxy.GetList();

            foreach (var item in list)
            {
                _log.Debug(l => l(item.CustomerID + " " + item.CompanyName));
            }

            var output = customerProxy.WhoIAm("sd");

        }


        public static bool TestWCFHost()
        {
            try
            {
                Ping pingCommand = new Ping();
                var pingReply = pingCommand.Send("localhost");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public static void TestHTTPCommunication()
        {
            WebRequest request = WebRequest.Create("http://localhost:57920/CustomerService.svc");
            WebResponse response = request.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd(); // do something fun...

                //_log.Debug(l => l(result));
            }
        }
    }
}
