using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            long TCKimlikNo = player.PlayerNationalityId;
            string Ad = player.PlayerFirstName.ToUpper();
            string Soyad = player.PlayerLastName.ToUpper();
            int DogumYili = player.PlayerDateOfBirth.Year;


            return true;
            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
               // TCKimlikNo, Ad, Soyad, DogumYili))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
