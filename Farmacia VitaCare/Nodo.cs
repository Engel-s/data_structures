using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_VitaCare
{
    public class Nodo
    {
        public Nodo next { get; set; } 
        public string codigo { get; set; } 
        public string producto { get; set; }
        public decimal precio { get; set; }
        public decimal subtotal { get; set; }
        public int cantidad { get; set; } 

        public Nodo() { }

        public Nodo(string cod, string prod, int cant, decimal pre, decimal sub)
        {
            codigo = cod;
            producto = prod;
            precio = pre;
            cantidad = cant;
            subtotal = sub;
        }

    }
}
