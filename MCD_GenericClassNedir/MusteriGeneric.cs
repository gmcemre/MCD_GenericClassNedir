﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_GenericClassNedir
{
    public class MusteriGeneric<T>
    {
        public T id { get; set; }
        public T musteriNumara { get; set; }
        public string  TcKimlikNumarasi { get; set; }
        public string  isim { get; set; }
        public string  soyisim { get; set; }
        public DateTime DogumTarih { get; set; }

        public T musteriNumarasiAl()
        {
            return musteriNumara;
        }
    }
}
