using ListGenericToDoUygulama.Database;
using ListGenericToDoUygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericToDoUygulama.BusinessService
{
    public class todoServis
    {
        public int todoKontrol()
        {
            return sanalDatabase.todoTablo.Count;
        }
        public List<Entities.todo> kayitListe()
        {
            return sanalDatabase.todoTablo;
        }

        public int yeniKayit(todo data)
        {
            try
            {
                sanalDatabase.todoTablo.Add(data);
                return 1;

            }
            catch(Exception ex)
            {
                return 0; 
            }
        }
    }
}
