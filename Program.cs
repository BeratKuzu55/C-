using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Kelime_Oyunu_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> kelime_listesi = new List<string>();
           /* kelime_listesi.Add("love");
            kelime_listesi.Add("justice");
            kelime_listesi.Add("car");
            kelime_listesi.Add("machine");
            kelime_listesi.Add("enjoy");
            kelime_listesi.Add("advanture");
            kelime_listesi.Add("contact");*/

            string dosya_yolu = @"C:\Users\berat\source\repos\Kelime Oyunu\Kelime Oyunu 2\kelime oyunu 2 word list.txt";
            string word_list = File.ReadAllText(dosya_yolu);
           // Console.WriteLine(word_list);//enter = \r\n !!!

            int toplam_harf_sayısı = word_list.Length;
            string okunan_kelime = string.Empty;
            for (int i = 0; i < toplam_harf_sayısı; i++)
            {

                if (word_list[i] != '\r' && word_list[i] != '\n')
                {
                    okunan_kelime += word_list[i];
                }
                else if (word_list[i] == '\r')
                {
                    kelime_listesi.Add(okunan_kelime);
                    okunan_kelime = string.Empty;
                }                  
                else if (word_list[i] == '\n')
                    ;
               

            }


            Console.WriteLine("kelime oyunu 2 ye hoşgeldiniz ");
            tekrar:
            Console.WriteLine("devam etmek için 1 e basınız : \nçıkmak için farklı bir tuşa basınız :  ");
            string kullanıcı_seçim = Console.ReadLine();

            if (kullanıcı_seçim == "1")
            {
                
                Console.Clear();
                int toplam_puan = 0;
                for (int i=0; i<kelime_listesi.Count;i++)
                {
                    Console.Clear();
                    string kelime;
                    kelime = kelime_listesi[i];
                    int yıldız_sayısı = kelime_listesi[i].Length;

                    for (int j =0; j<yıldız_sayısı;j++)
                    {
                        Console.Write("*");
                    }

                    int tahmin_hakkı = yıldız_sayısı + 3;
                    int k;
                    int a = 0;
                    int puan = 0;
                    char eski_tahmin = ' ';
                    char[] kelime2 = new char[yıldız_sayısı];
                    for ( k = 0; k < tahmin_hakkı; k++)
                    {
                        Console.WriteLine("\nharf tahmini yapınız : ");
                        char tahmin = char.Parse(Console.ReadLine());
                        


                        for (int j = 0; j < yıldız_sayısı; j++)
                        {
                            
                           if (eski_tahmin == tahmin)
                            {
                                Console.WriteLine("Bu harf daha önce girildi :");
                                break;
                            }
                            
                            int[] dizi = new int[yıldız_sayısı];
                            if (kelime[j] == tahmin)
                            {
                                kelime2[j] = tahmin;
                                a++;// örneğin love için 4 kere "e" harfini girsek de bu kod çalışır hatalı puan a sebep olur 
                               
                               // Console.Write(kelime2);
                            }
                            else
                            {
                                //kelime2[j] = '*';
                                //Console.Write(kelime2);
                            }
                            
                        }
                        eski_tahmin = tahmin;
                        Console.WriteLine(kelime2);
                        if (a == yıldız_sayısı)
                            break;
                    }

                    if (a == yıldız_sayısı)
                    {
                        puan = yıldız_sayısı;
                        Console.WriteLine("Tebrikler kelimeyi buldunuz !!! ve {0} puan kazandınız",puan);
                        toplam_puan += puan;
                        Console.ReadLine();

                    }

                    if (k == tahmin_hakkı)
                    {
                        Console.WriteLine("oyun bitti : ");
                       
                        break;
                    }
                   

                }

                Console.WriteLine("toplam skor : {0}", toplam_puan);
                Console.WriteLine("tekrar oynamak istiyorsanız 2 ye tıklayınız : ");
                string kullanıcı_seçim2 = Console.ReadLine();
                if (kullanıcı_seçim2 == "2")
                {
                    goto tekrar;
                }
                else Console.WriteLine("iyi günler dileriz : ");
            }
            else
                Console.WriteLine("iyi günler dileriz : ");

           

            Console.WriteLine(kelime_listesi[1]);
            Console.ReadLine();




                
        }
    }
}
