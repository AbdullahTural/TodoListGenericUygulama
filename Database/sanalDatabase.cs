using ListGenericToDoUygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericToDoUygulama.Database
{
    public class sanalDatabase
    {
        public static List<Entities.kullanici> kullaniciTablo;
        public static List<Entities.todo> todoTablo;

        static sanalDatabase()
        {
            kullaniciTablo = new List<Entities.kullanici>();
            kullaniciTablo.Add(new kullanici() { id = Guid.NewGuid() , kullaniciAdi = "test1" , sifre = "1"});

            todoTablo = new List<todo>();
        }
    }
}
