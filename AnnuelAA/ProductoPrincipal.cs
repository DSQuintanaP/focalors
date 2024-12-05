using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salva_Patria.AnnuelAA
{
    public class ProductoPrincipal
    {
        public string nomProducto {  get; set; }
        public double precio { get; set; }

        public virtual void CalcularPrecio()
        {

        }
    }
}
