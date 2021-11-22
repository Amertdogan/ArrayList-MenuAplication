using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NetworkAkademi_N041_ArrayListOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList degerlerListesi = new ArrayList();
            bool sonuc = true;
            do
            {
                Console.WriteLine("Yapacagınız işlemi seçiniz.\n");
                Console.WriteLine("  Menü\n 1-Deger ekleme \n 2-Deger Listele \n 3-Deger Ara \n 4-Deger Düzenle \n 5-Deger Sil \n 6-Uygulamadan Çıkış ");
                int secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Deger giriniz:");
                    string girilenDeger = Console.ReadLine();
                    degerlerListesi.Add(girilenDeger);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Deger eklendi.");
                        break;

                case 2:
                        for (int i = 0; i < degerlerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. deger= {1}",i,degerlerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;

                case 3:
                    Console.WriteLine("Aramak istediginiz elemanı yazınız.");
                    string arananEleman = Console.ReadLine();                   
                    if (degerlerListesi.Contains(arananEleman))
                    {
                        Console.WriteLine($"Aranan eleman listede var.\n İndex numarası:{degerlerListesi.IndexOf(arananEleman)}");
                    }
                    else
                    {
                        Console.WriteLine("Aranan eleman listede yok.");
                        Console.WriteLine("Bu degeri listeye ekleyelim mi? Evet/Hayır");
                            string secim3 = Console.ReadLine();
                            if (secim3.ToLower()=="evet")
                            {
                                degerlerListesi.Add(arananEleman);
                            }
                            else if (secim3.ToLower() == "hayır")
                            {
                                Console.WriteLine("Aranan deger eklenmeden devam ediyorsunuz.");
                                Console.ReadLine();
                            }
                    }
                        break;
                case 4:
                        Console.WriteLine("Güncellemek istediginiz degeri giriniz.");
                        string kullaniciDüzenlenedekDeger = Console.ReadLine();
                        Console.WriteLine("{0} degerini hangi deger ile degistirmek istiyotunuz? ");
                        string kullaniciYeniDeger = Console.ReadLine();
                        if (degerlerListesi.Contains(kullaniciDüzenlenedekDeger))
                        {
                            int kullaniciHedefIndexDegeri = degerlerListesi.IndexOf(kullaniciDüzenlenedekDeger);
                            degerlerListesi[kullaniciHedefIndexDegeri] = kullaniciYeniDeger;
                            Console.WriteLine("Degeriniz güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Aradiginiz deger liste içerisinde bulunamadı.");
                        }
                        System.Threading.Thread.Sleep(200);
                        break;
                case 5:
                        Console.WriteLine("Silme istediginiz elemanı giriniz:");
                        string SilmekİstenenEleman = Console.ReadLine();
                        degerlerListesi.Remove(SilmekİstenenEleman);
                        break;

                case 6:
                         sonuc = false;
                        break;
            }
            } while (sonuc);




            Console.ReadLine();
        }
    }
}
