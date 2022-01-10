using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YıkıcıMetot
{
    class Ogrenci
    {
        public Ogrenci()//yapıcı metot
        {
            Console.WriteLine("Yapıcı metot aktif!!");
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Numarasi { get; set; }
        public double Ortalama { get; set; }

        ~Ogrenci()//yıkıcı metot
        {
            Console.WriteLine("Yıkıcı metot aktif ve nesne kaldırıldı!");
            Console.ReadKey();

        }
    }
}
