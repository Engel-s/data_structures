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
            if((Frente == 1 && Final == Max) || (Final +1 == Frente))
                return true;
            else
                return false;
        }

        public void insertar (int i)
        {
            if(ColaLlena() == false)
            {
                if (Final == Max)
                {
                    Final = 1;
                }
                else
                {
                    Final++;
                }

                ColaC[Final - 1] = i;
                if (Frente == 0)
                    Frente = 1;
            }
            else
            {
                MessageBox.Show("La cola está llena.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public void ELiminar()
        {
            if(ColaVacia() == false)
            {
                if (Frente == Final)
                {
                    Frente = 0;
                    Final = 0;
                }
                else if (Frente == Max)
                    Frente = 1;
                else
                    Frente++;
            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
