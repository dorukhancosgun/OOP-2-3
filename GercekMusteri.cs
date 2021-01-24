using OOB2;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual Customer
    class GercekMusteri:Musteri
    {
       
        public string TcNo { get; set; } //sayisal islem yapmayacaksak (toplama cikarma falan gibi) metinsel olarak planlamak daha mantikli 

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
