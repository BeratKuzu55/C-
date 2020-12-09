using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sıra19.D7.ComboBoxİnceleme
{
    public class Ürün
    {


        public int id { get; set; }
        public string urunAdı { get; set; }
        public string ürünResim { get; set; }
        public string urunKategori { get; set; }
        public int stokAdet{ get; set; }
        public string yazar { get; set; }
        public string açıklama { get; set; }


        public override string ToString()
        {
            return urunAdı;
        }




    }
}
