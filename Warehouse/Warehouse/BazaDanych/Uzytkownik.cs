using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
   public class Uzytkownik
    {
        public Guid uzytkownikId { get; set; }
        public String imie { get; set; }
        public String nazwisko { get; set; }
        public String haslo { get; set; }
        public String login { get; set; }
        public uprawnieniaUzytkownika Uprawnienia { get; set; }

    }

    public enum uprawnieniaUzytkownika
    {
        Magazynier,
        Logistyk
    }
}
