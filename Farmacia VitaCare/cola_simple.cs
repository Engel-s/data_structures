using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_VitaCare
{
    class cola_simple
    {
        public int Frente, Final, Max;
        public int[] ColaC;

        public cola_simple() { }
        public cola_simple(int maximo)
        {
            Frente = 0;
            Final = 0;
            Max = maximo;
            ColaC = new int[Max];
        }

        public bool ColaVacia()
        {
            if (Final == 0)
                return true;
            else
                return false;
        }

        public bool ColaLlena()
        {
            return Final == Max;
        }

        public void insertar(int i)
        {
            if (ColaLlena())
            {
                MessageBox.Show("La cola está llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Final = Final + 1;
            ColaC[Final - 1] = i;
            if (Frente == 0) Frente = 1;
        }

        public void ELiminar()
        {
            if (Frente == 0)
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (Frente == Final)
            {
                Frente = 0; Final = 0;
            }
            else
            {
                Frente = Frente + 1;

            }
        }
    }
}
