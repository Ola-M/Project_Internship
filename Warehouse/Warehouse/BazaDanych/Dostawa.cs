using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.BazaDanych
{
    public class Dostawa
    {
        public Guid dostawaId { get; set; }
        public DateTime dataDostawy { get; set; }
        public DateTime dataWystawienia { get; set; }
        public String numerDostawy { get; set; }
        public virtual Dostawca Dostawca { get; set; }
        public Guid dostawcaId { get; set; }
        public bool otwarte { get; set; }
    }
}
