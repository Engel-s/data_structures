using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_VitaCare
{
    internal class Colas_circulares
    {
        public int Frente, Final, Max;
        public int[] ColaC;

        public Colas_circulares() { }
        public Colas_circulares(int maximo)
        {
            Frente = -1;  
            Final = -1;   
            Max = maximo;
            ColaC = new int[Max];
        }

        public bool ColaVacia()
        {
            return Frente == -1; 
        }

        public bool ColaLlena()
        {
            return (Frente == 0 && Final == Max - 1) || (Final + 1 == Frente); 
        }

        public void insertar(int i)
        {
            if (!ColaLlena())
            {
                if (Frente == -1) // Si la cola está vacía
                {
                    Frente = 0;
                    Final = 0;
                }
                else if (Final == Max - 1 && Frente != 0) 
                {
                    Final = 0;
                }
                else
                {
                    Final++;
                }

                ColaC[Final] = i; 
            }
            else
            {
                MessageBox.Show("La cola está llena.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public void ELiminar()
        {
            if (!ColaVacia())
            {
                int elemento = ColaC[Frente];

                if (Frente == Final) 
                {
                    Frente = -1;
                    Final = -1;
                }
                else if (Frente == Max - 1) 
                {
                    Frente = 0;
                }
                else
                {
                    Frente++;
                }
            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
