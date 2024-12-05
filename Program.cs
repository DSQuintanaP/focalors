using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salva_Patria.AnnuelAA;

namespace Salva_Patria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoFisico productoFisico = new ProductoFisico();
            PRoductoDigital pRoductoDigital = new PRoductoDigital();

            productoFisico.nomProducto = "Sancocho";
            productoFisico.precio = 1399.95;
            productoFisico.peso = 10.45;

            productoFisico.CalcularPrecio();

            pRoductoDigital.nomProducto = "Un juegazo";
            pRoductoDigital.precio = 289.95;
            pRoductoDigital.descargaURL = "juegoscienporcienoriginales.com.co";

            pRoductoDigital.CalcularPrecio();

        }
    }
}
