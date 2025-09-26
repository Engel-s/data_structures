using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_VitaCare
{
    internal class Recursividad
    {
        //Recursividad lineal no final, con esto vamos a calcular el total de la compra
        public decimal CalcularTotal(FormCompraVitaCare.Compras[] compras, int indice)//el indice es el parametro para recorrer el arreglo
        {
            if (indice >= compras.Length)
                return 0;//si el indice es mayor o igual al tamano del arreglo se va a retornar cero

            return compras[indice].subtotal + CalcularTotal(compras, indice + 1);
        }
    }
}
