using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager: IApplicantService
    {
        private readonly KPSPublicSoapClient _client;
        public PersonManager()
        {
            _client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        }
        public void ApplyForMask(Person person)
        {


        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            
           
            return _client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
