using metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";
urun1.StokAdedi = 21;

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";
urun2.StokAdedi = 29;

Urun[] urunler = new Urun[] {urun1,urun2};

foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.StokAdedi);
    Console.WriteLine("---------------------");

}

Console.WriteLine("---------metodlar-----------");

SepetManager sepetmanager = new SepetManager();
sepetmanager.Ekle(urun1);
sepetmanager.Ekle(urun2);
Console.WriteLine(sepetmanager);

sepetmanager.Ekle2("Elma","Yeşil Elma",12);



