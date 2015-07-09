using Queaso.Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Queaso.Northwind.Contract
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        IEnumerable<Customer> GetList();

        [OperationContract]
        string WhoIAm(string domainName);

        [OperationContract()]
        string IsThisAnException();
    }
}
