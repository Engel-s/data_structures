using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_VitaCare
{
    internal class PIla
    {
        public class Pila<T>
        {
            private T[] elementos;
            private int tope;
            private int max;

            public Pila (int size)
            {
                max = size;
                elementos = new T[max];
                tope = 0;
            }

            //Pila vacia
            public bool PilaVacia()
            {
                return tope == 0;
            }

            //Pila llena
            public bool PilaLlena()
            {
                return tope == max;
            }
           
            public void Pone(T elemento)
            {
                if (PilaLlena())
                {
                    throw new InvalidOperationException("Desbordamiento: La pila está llena.");
                }
                elementos[tope] = elemento;
                tope++;
            }
          
            public T Quita()
            {
                if (PilaVacia())
                {
                    throw new InvalidOperationException("Subdesbordamiento: La pila está vacía.");
                }
                tope--;
                return elementos[tope];
            }

            
            public int Tope => tope;
            public int Max => max;
            public T[] Elementos => elementos;

        }
    }
}
