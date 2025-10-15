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
                Final = (Final + 1) % Max;
                ColaC[Final] = i;

                if (Frente == -1) 
                    Frente = 0;
            }
            else
            {
                MessageBox.Show("La cola está llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ELiminar()
        {
            if (!ColaVacia())
            {
                if (Frente == Final)
                {
                    Frente = -1;
                    Final = -1;
                }
                else
                {
                    Frente = (Frente + 1) % Max;
                }
            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
