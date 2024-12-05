using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salva_Patria.AnnuelAA
{
    public class PRoductoDigital : ProductoPrincipal
    {
        public string descargaURL {  get; set; }

        public override void CalcularPrecio()
        {
            Console.WriteLine($"su producto: {nomProducto} tiene un valor por copia digital de: {precio}, puede descargarlo desde este link: {descargaURL}");
        }
    }
}
