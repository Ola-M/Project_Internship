using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.BazaDanych
{
    public class Dostawca
    {
        public Guid dostawcaId { get; set; }
        public String nazwaFirmy { get; set; }
        public String kontakt { get; set; }
    }
}
