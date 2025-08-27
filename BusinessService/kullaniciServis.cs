using ListGenericToDoUygulama.Database;
using ListGenericToDoUygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericToDoUygulama.BusinessService
{
    public class kullaniciServis
    {
        public kullanici kullaniciKontrol(string kullaniciAdi, string sifre)
        {
            return sanalDatabase.kullaniciTablo.Where(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre).FirstOrDefault();
        }
    }
}
