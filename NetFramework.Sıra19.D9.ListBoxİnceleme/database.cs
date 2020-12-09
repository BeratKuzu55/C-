using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.Sıra19.D9.ListBoxİnceleme
{
    public class database
    {
        public static List<ürün> ürünTablo = new List<ürün>() {
            new ürün(){ id = 1,urunAdı="bin muhteşem güneş",stokAdet=10,urunKategori="roman",
                açıklama =@"Bin Muhteşem Güneş, ilk romanı Uçurtma Avcısı’yla
tüm dünyada inanılmaz bir başarı yakalayan Hosseini’nin ikinci romanı. 
Yazar bu romanında da yine doğduğu toprakları anlatıyor. 
Bu kez iki kadının kesişen yaşamları ve dostlukları üzerinden…
"
                ,yazar="khalid housseni",ürünResim=@"C:\Users\berat\Desktop\pdf ler\binmuhteşemGüneş.jpg"},
            new ürün(){id=2,urunAdı="körlük",stokAdet=10,urunKategori="roman",yazar="jose saramago",
                açıklama =@"'Körlük', 1998 yılı 'Nobel Edebiyat Ödülü' sahibi 
                            Portekizli yazar Jose Saramago'nun son yıllarda
                            yazdığı en etkileyici kitap. Araba kullanmakta olan bir adam,
                            yeşil ışığın yanmasını beklerken ansızın körleşiyor.
                            Körlüğü, başvurduğu doktora da bulaşır.",ürünResim=@"C:\Users\berat\Desktop\körlük.jpg" }

        };
    }
}
