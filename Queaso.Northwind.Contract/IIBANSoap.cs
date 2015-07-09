using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Queaso.Northwind.Contract
{
    [ServiceContract]
    public interface IIBANSoap
    {
        //[OperationContract(Name="getCountryList", Action="")]
        [OperationContract(Name = "getCountryList", Action = "http://tempuri.org/getCountryList")]
        [XmlSerializerFormat(SupportFaults=true)]        
        DataTable GetCountryList();

        //BBANtoBANKNAME
        [OperationContract(Name = "BBANtoBANKNAME", Action = "http://tempuri.org/BBANtoBANKNAME")]
        [XmlSerializerFormat(SupportFaults=true)]
        string GetBankName(string Value);

        [OperationContract(Name = "CheckBBAN", Action = "http://tempuri.org/CheckBBAN")]
        [XmlSerializerFormat(SupportFaults = true)]
        bool CheckBBAN(string Value);

    }
}
