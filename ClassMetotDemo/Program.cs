using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri sınıfı ile yeni bir müşteri oluşturup değer veriyoruz.
            Musteri musteri = new Musteri();
            musteri.Adi = "Kerim";
            musteri.Soyadi = "Dinçer";
            musteri.Telefon = 05414445565;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Emre";
            musteri2.Soyadi = "Dinçer";
            musteri2.Telefon = 05414444788;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Serdar";
            musteri3.Soyadi = "Çelik";
            musteri3.Telefon = 05414444335;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Doğuş";
            musteri4.Soyadi = "Özçelik";
            musteri4.Telefon = 05414444455;

            Musteri musteri5 = new Musteri();
            musteri5.Adi = "Talha";
            musteri5.Soyadi = "Dumanoğlu";
            musteri5.Telefon = 05418544330;

            Musteri musteri6 = new Musteri();
            musteri6.Adi = "Koray";
            musteri6.Soyadi = "Dardan";
            musteri6.Telefon = 05414364331;

            Musteri musteri7 = new Musteri();
            musteri7.Adi = "Sezgin";
            musteri7.Soyadi = "Günaydın";
            musteri7.Telefon = 05414488732;

            Musteri musteri8 = new Musteri();
            musteri8.Adi = "Hacı";
            musteri8.Soyadi = "Tunç";
            musteri8.Telefon = 05414444444;

            Musteri musteri9 = new Musteri();
            musteri9.Adi = "Ekrem";
            musteri9.Soyadi = "Dinçer";
            musteri9.Telefon = 05414444986;
            
            //Müşteri Manager sınıfı ile müşterimanager oluşturuyoruz.
            MusteriManager musteriManager = new MusteriManager();

            //Müşterileri ekleme işlemini yapıyoruz.
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);
            musteriManager.Ekle(musteri6);
            musteriManager.Ekle(musteri7);
            musteriManager.Ekle(musteri8);
            musteriManager.Ekle(musteri9);

            //Tüm müşterileri listeliyoruz. 9 adet
            musteriManager.Listele();
            
            //1 adet müşteri siliyporuz.
            musteriManager.Sil(musteri2);

            //Tekrar tüm müşterileri listeliyoruz. 8 adet
            musteriManager.Listele();

            //3 adet müşteri siliyoruz.
            musteriManager.Sil(musteri4);
            musteriManager.Sil(musteri6);
            musteriManager.Sil(musteri8);

            //Tekrar müşterileri listeliyoruz. 3 adet
            musteriManager.Listele();

        }
    }
}
