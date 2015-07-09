using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Queaso.Northwind.Contract;
using System.Data;
using Common.Logging;

namespace Queaso.IBAN.Client.Proxies
{
    public class IBANSoapProxy : ClientBase<IIBANSoap>, IIBANSoap
    {
        private readonly ILog _log = LogManager.GetLogger<IBANSoapProxy>();

        public IBANSoapProxy()
            : base()
        {

        }

        public IBANSoapProxy(string endpointName)
            : base(endpointName)
        {

        }

        public DataTable GetCountryList()
        {
            _log.Debug(l => l("Start method GetCountryList"));

            return this.Channel.GetCountryList();
        }


        public string GetBankName(string bban)
        {
            _log.Debug(l => l("Start method GetBankName"));

            return this.Channel.GetBankName(bban);
        }

        public bool CheckBBAN(string bban)
        {
            return this.Channel.CheckBBAN(bban);
        }
    }
}
