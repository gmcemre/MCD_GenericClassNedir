using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.TcKimlikNumarasi = "12254401254";
            M1.musteriNumara = "MS123";
            M1.isim = "Emre";
            M1.soyisim = "Gemici";
            M1.DogumTarih = DateTime.Parse("22.10.1993");

            MusteriGeneric<int> MusteriGeneric1 = new MusteriGeneric<int>(); //T olanlar int olarak atanmış oldu..
            MusteriGeneric1.id = 1;
            MusteriGeneric1.musteriNumarasiAl();
            Console.WriteLine(MusteriGeneric1.isim);

            MusteriGeneric<Guid> MusteriGeneric2 = new MusteriGeneric<Guid>();
            MusteriGeneric2.musteriNumarasiAl();
            Console.ReadLine();
        }
    }
}
