using System;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using InterfaceAndAbstractDemo.MernisServiceReference;

namespace InterfaceAndAbstractDemo.Adapters
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
