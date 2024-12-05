using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salva_Patria.AnnuelAA
{
    public class ProductoFisico : ProductoPrincipal
    {
        
        public double peso { get; set; }

        public override void CalcularPrecio()
        {
            double precioPeso = 1200;
            double costoEnvio = peso * precioPeso;

            Console.WriteLine($"su producto: {nomProducto}, cuesta: {precio}, pesa: {peso}Kgs y con un costo de envio por peso de: {precioPeso}, tiene un valor total {costoEnvio}");

        }

    }
}
