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
            /*
             *  Database  |  Uygulama
             *  MSSQL         C#
             *  
             *  
             *  tblMusteri
             *  id int
             *  musteriNumara uniqueidentityfy (Guid)
             *  isim nvarchar(50) (nvarchar : C# ta string 'e karşılık geliyor.)
             *  soyisim nvarchar(50) 
             *  dogumTarihi Datetime 
             *  
             *  UnitOfWorks => Generic Class  |  Generic Interface
             *  
             */

            genericRepository<Musteri> repositoryMusteri = new genericRepository<Musteri>();

            List<Musteri> musterilerim = repositoryMusteri.Getir();

            repositoryMusteri.yeniKayitEkle(null);

            genericRepository<Urun> repositoryUrun = new genericRepository<Urun>();
            repositoryUrun.Getir();
            repositoryUrun.yeniKayitEkle(null);

            

            Console.ReadLine();
        }
    }
}
