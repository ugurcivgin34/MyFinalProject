using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages  //sürekli newlemeyerek ,sabit olduğu için static kullandık.Staticler newlenmez
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";

        //public ler pascal case yani büyük harfle başlar 
    }
}
