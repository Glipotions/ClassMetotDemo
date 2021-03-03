using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class MusteriManager
	{
		

		public void MusteriEkle(Musteri musteri)
		{

			Console.WriteLine(musteri.ad+" Adlı Müşteri Eklendi!!");
		}
		public void MusteriSil(Musteri musteri)
		{
			Console.WriteLine(musteri.ad + " Adlı Müşteri Silindi!!");
		}

		public void MusteriListele(Musteri musteri)
		{
			Console.WriteLine(musteri.musteriId + " Id'li Müşteri: " + musteri.ad + " " + musteri.soyadi + " yaş:  " + musteri.yas);
		}


	}
}
