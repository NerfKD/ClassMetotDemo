using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //sınıfa özel bir list oluşturuyoruz. List Müşteri sınıfı türünde oluşturuluyor.
        private List<Musteri> musteriler = new List<Musteri>();
        //Id'yi sirali arttıramak için siralama değişkeni oluşturuyoruz.
        int siralama = 1;

        public void Ekle(Musteri musteri) 
        {
            //gelen müşterinin id sini atıyoruz.
            musteri.Id = siralama;
            //musteriler olarak belirlediğimiz liste add ile müşteriyi ekliyoruz.
            musteriler.Add(musteri);
            //ad soyad belirterek eklendiğini yazdırıyoruz.
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adlı müşteri sisteme eklendi.");
            //bir sonraki müşteri başka id alsın sira ilerlesin diye siralama değişkenini 1 arttırıyoruz.
            siralama++;
            //görsel olarak çizgi ekliyoruz.
            Console.WriteLine("-------------------------------------------------");
            
        }

        public void Listele()
        {
            //musteriler olarak tanımladığımız listeyi foreach ile sıra sıra dönerek ekrana tüm müşterileri yazdırıyoruz.
            foreach (Musteri must in musteriler)
            {
                Console.WriteLine("ID: " + must.Id);
                Console.WriteLine("Adı: " + must.Adi + " - " + " Soyadi: " + must.Soyadi);
                Console.WriteLine("Telefon: " + must.Telefon);
                Console.WriteLine("-------------------------------------------------");
            }
            
        }

        public void Sil(Musteri musteri)
        {
            //eklenen tüm müşterileri musteriler adlı listte tuttuğumuz için listden ilgili müşteri kaydını remove ile siliyoruz.
            musteriler.Remove(musteri);

            //müşteri ID sini belirterek silme işlemini ekrana yazıyoruz.
            Console.WriteLine(musteri.Id + " Id'li müşteri silinmiştir.");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
