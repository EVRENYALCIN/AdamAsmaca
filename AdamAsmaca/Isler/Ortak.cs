using AdamAsmaca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca.Isler
{
    public class Ortak
    {
		private static List<Kullanici> kullanicilar;

		public static List<Kullanici> Kullanicilar
        {
			get {
                if (kullanicilar == null)
                {
                    kullanicilar = new List<Kullanici>();
                    //#if DEBUG
                    //kullanicilar.Add(new Kullanici
                    //{
                    //    KullaniciAdi = "evren",
                    //    Sifre = "1234"
                    //});
                    //#endif
                }
                return kullanicilar;
            }
		}

        public static Kullanici AktifKullanici { get; set; }
    }
}
