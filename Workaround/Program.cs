// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();
            
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

