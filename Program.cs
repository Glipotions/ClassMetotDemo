using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri1 = new Musteri();
			Musteri musteri2 = new Musteri();

			musteri1.musteriId = 1;
			musteri1.ad = "Hamza";
			musteri1.soyadi = "Kavak";
			musteri1.yas = 22;

			musteri2.musteriId = 2;
			musteri2.ad = "Cafer";
			musteri2.soyadi = "Kavak";
			musteri2.yas = 18;

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.MusteriEkle(musteri1);
			musteriManager.MusteriEkle(musteri2);
			musteriManager.MusteriSil(musteri2);
			musteriManager.MusteriListele(musteri1);

		}
	}
}
