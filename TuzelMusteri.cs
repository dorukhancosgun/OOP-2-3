using OOB2;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate Customer
    //miras - Inheritance metodu
    class TuzelMusteri:Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
