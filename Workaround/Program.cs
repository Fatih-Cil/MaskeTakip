// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;
using System.Runtime.CompilerServices;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas1 = new Vatandas();
            SelamVer("fatih");
            SelamVer("mehmet");
            SelamVer();
            int sonuc = Topla(4,3);
            Console.WriteLine("Toplam:"+sonuc);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Fatih";
            ogrenciler[1] = "Mehmet";
            ogrenciler[2] = "Ali";
            //ogrenciler[3]="Veli";

            
            ogrenciler=new string[4];
            ogrenciler[3] = "Ahmet";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1= new Person();
            person1.NationalIdentity = 111;
            person1.FirstName = "FATİH";
            person1.LastName = "ÇİL";
            person1.DateOfBirthYear = 1900;

            Person person2 = new Person {NationalIdentity=1,FirstName = "JOE",LastName="BIDEN",DateOfBirthYear=1942};



            Person person3 = new Person();
            person3 = null;

            foreach (string sehir in sehirler1)
            { 
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler=new List<string> { "Konya","Niğde","Trabzon"};
            yeniSehirler.Add("Kastamonu");
            foreach (string sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);

            }

            //TC vatandaşı personel
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            //Yabancı uyruklu vatandaşlar için (verilmeyecek)
            PttManager pttManager2 = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person2);

            //Null bir değer gönderiyorum.
            PttManager pttManager3 = new PttManager(new PersonManager());
            pttManager.GiveMask(person3);
        }


        static void SelamVer(string ad="?")
        {
            Console.WriteLine("Merhaba "+ad);
        }

        static int Topla(int x=0,int y=0)
        {
            int sonuc = x + y;
            return sonuc;
        }

        static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100000;
            int sayi = 100;
            bool girisYaptimi = false;

            string ad = "Fatih";
            string soyad = "Çil";
            int dogumYili = 1979;
            long tcNo = 12345678901;

            Console.WriteLine(mesaj);
            Console.WriteLine(sayi);
        }

    }

    public class Vatandas
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

}

