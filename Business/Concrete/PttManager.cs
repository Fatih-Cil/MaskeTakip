using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _service;

        public PttManager(IApplicantService service)
        {
            _service = service;
        }

        public void GiveMask(Person person)
        {
            if (person == null)
            {
                Console.WriteLine("Personel bilgisi gelmediği için işlem yapılamadı.");
                
            }else if (_service.CheckPerson(person)) {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }

        }
    }
}
