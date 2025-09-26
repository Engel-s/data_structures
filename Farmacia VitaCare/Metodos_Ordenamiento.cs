using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Farmacia_VitaCare.FormCompraVitaCare;

namespace Farmacia_VitaCare
{
    internal class Metodos_Ordenamiento
    {
        //Metodo de burbuja
        public void ordenarBurbuja(FormCompraVitaCare.Compras[] compras)
        {
            for (int i = 0; i < compras.Length - 1; i++)
            {
                for (int j = 0; j < compras.Length - 1 - i; j++)
                {
                    if (compras[j].subtotal > compras[j + 1].subtotal)
                    {
                        // esto intercambia los elementos
                        FormCompraVitaCare.Compras temp = compras[j];
                        compras[j] = compras[j + 1];
                        compras[j + 1] = temp;
                    }
                }
            }
        }

        // Metodo mergesort
        private FormCompraVitaCare.Compras[] Merge(FormCompraVitaCare.Compras[] left, FormCompraVitaCare.Compras[] right)
        {
            FormCompraVitaCare.Compras[] resultado = new FormCompraVitaCare.Compras[left.Length + right.Length];
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i].subtotal <= right[j].subtotal)
                {
                    resultado[k++] = left[i++];
                }
                else
                {
                    resultado[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                resultado[k++] = left[i++];
            }
            while (j < right.Length)
            {
                resultado[k++] = right[j++];
            }
            return resultado;
        }

        public FormCompraVitaCare.Compras[] MergeSort(FormCompraVitaCare.Compras[] array)
        {
            if (array.Length <= 1)
                return array;

            int medio = array.Length / 2;

            FormCompraVitaCare.Compras[] left = new FormCompraVitaCare.Compras[medio];
            FormCompraVitaCare.Compras[] right = new FormCompraVitaCare.Compras[array.Length - medio];
            Array.Copy(array, 0, left, 0, medio);
            Array.Copy(array, medio, right, 0, array.Length - medio);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        //metodo de quicksort
        public void QuickSort(FormCompraVitaCare.Compras[] compras, int izquierda, int derecha)
        {
            int i = izquierda, j = derecha;
            decimal pivote = compras[(izquierda + derecha) / 2].subtotal;
            while (i <= j)
            {
                while (compras[i].subtotal < pivote) i++;
                while (j >= 0 && compras[j].subtotal > pivote) j--;
                if (i <= j)
                {
                    // Aqui se intercambian los elementos 
                    FormCompraVitaCare.Compras temp = compras[i];
                    compras[i] = compras[j];
                    compras[j] = temp;
                    i++;
                    j--;
                }
            }
            if (izquierda < j) QuickSort(compras, izquierda, j);
            if (i < derecha) QuickSort(compras, i, derecha);
        }
    }
}
