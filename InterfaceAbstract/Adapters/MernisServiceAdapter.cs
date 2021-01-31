using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System.Threading.Tasks;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
