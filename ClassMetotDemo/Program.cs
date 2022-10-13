using ClassMetotDemo;

Musteri musteri1 = new Musteri ();
musteri1.Adi = "Ekrem";
musteri1.Soyadi = "Gün";

Musteri musteri2 = new Musteri();
musteri2.Adi = "Kazım";
musteri2.Soyadi = "Çelik";

Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
foreach (var musteri in musteriler)
{
    Console.WriteLine(musteri.Adi);
    Console.WriteLine(musteri.Soyadi);
    Console.WriteLine("--------listeleme--------");
}

MusteriManager musteriManager = new MusteriManager ();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
Console.WriteLine(musteriManager);
Console.WriteLine("-----ekleme------");

musteriManager.Sil(musteri1);
Console.WriteLine(musteriManager);
Console.WriteLine("-------silme------");


