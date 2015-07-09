using Common.Logging;
using Queaso.Northwind.Contract;
using Queaso.Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queaso.Northwind.Service
{
    public class CustomerService : ICustomerService 
    {
        private ILog _log = LogManager.GetLogger<CustomerService>();

        public IEnumerable<Customer> GetList()
        {
            _log.Info(l => l("Start method GetList"));
            return new List<Customer>() { new Customer() { CustomerID = "ALFKI", CompanyName = "Alfred K" }, new Customer(){ CustomerID = "QUESYS", CompanyName = "Queaso Systems" }};

        }

        public string WhoIAm(string domainName)
        {
            _log.Info(l => l("Start method WhoIAm"));

            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                return Thread.CurrentPrincipal.Identity.Name;
            }
            return string.Format(@"{0}\{1}", "DAN001", "Haeckr");
        }


        public string IsThisAnException()
        {
            throw new DivideByZeroException("Dit is een exception!");
        }
    }
}
