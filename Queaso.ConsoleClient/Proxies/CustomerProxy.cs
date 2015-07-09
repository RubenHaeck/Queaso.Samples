using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Queaso.Northwind.Contract;
using Queaso.Northwind.Model;

namespace Queaso.ConsoleClient.Proxies
{
    public class CustomerProxy : ClientBase<ICustomerService>, ICustomerService
    {
        public IEnumerable<Customer> GetList()
        {
            return this.Channel.GetList();
        }

        public string WhoIAm(string domainName)
        {
            var creditionals = this.ClientCredentials;
            return this.Channel.WhoIAm(domainName);
        }



        public async Task<IEnumerable<Customer>> GetListAsync()
        {
            var taskFactory = new TaskFactory<IEnumerable<Customer>>();
            var task = taskFactory.StartNew(() => GetList());
            return task.Result as IEnumerable<Customer>;
        }


        public string IsThisAnException()
        {
            return this.Channel.IsThisAnException();
        }
    }
}
