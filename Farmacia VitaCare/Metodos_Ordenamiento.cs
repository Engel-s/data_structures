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


        //METODOS PARA MEZCLA DIRECTA EXTERNA
        private static void GuardarRegistro(FormCompraVitaCare.Compras c, string archivo)
        {
            using (var streamWriter = new StreamWriter(archivo, false, Encoding.UTF8))
            {
                streamWriter.WriteLine($"{c.codigo}|{c.producto}|{c.cantidad}|{c.precio}|{c.subtotal}");
            }
        }

        private static FormCompraVitaCare.Compras LeerRegistro(string linea)
        {
            var _partes = linea.Split('|');
            return new FormCompraVitaCare.Compras
            {
                codigo = _partes[0],
                producto = _partes[1],
                cantidad = int.Parse(_partes[2]),
                precio = decimal.Parse(_partes[3]),
                subtotal = decimal.Parse(_partes[4])
            };
        }

        private static void MezclarArchivos(string i, string a, string destinoarchivo)
        {
            using (var streamReader1 = new StreamReader(i))
            using (var streamReader2 = new StreamReader(a))
            using (var streamW = new StreamWriter(destinoarchivo, false, Encoding.UTF8))
            {
                string l1 = streamReader1.ReadLine();
                string l2 = streamReader2.ReadLine();

                while (l1 != null && l2 != null)
                {
                    var lR1 = LeerRegistro(l1);
                    var lR2 = LeerRegistro(l2);

                    if (lR1.subtotal <= lR2.subtotal)
                    {
                        streamW.WriteLine(l1);
                        l1 = streamReader1.ReadLine();
                    }
                    else
                    {
                        streamW.WriteLine(l2);
                        l2 = streamReader2.ReadLine();
                    }
                }

                while (l1 != null) { streamW.WriteLine(l1); l1 = streamReader1.ReadLine(); }
                while (l2 != null) { streamW.WriteLine(l2); l2 = streamReader2.ReadLine(); }
            }
        }



        public static void Mezcla_Directa_Externa(FormCompraVitaCare.Compras[] compras, int contador, string archivo_final)
        {
            //crear archivos temporales de un registro
            string tempDir = Path.Combine(Path.GetTempPath(), "mezcla_temp");
            Directory.CreateDirectory(tempDir);
            string[] archivos_temporales = new string[contador];

            for (int i = 0; i < contador; i++)
            {
                archivos_temporales[i] = Path.Combine(tempDir, $"temp{i}.txt");
                GuardarRegistro(compras[i], archivos_temporales[i]);
            }

            // Mezclar archivos de 2 en 2 hasta obtener archivo final
            while (archivos_temporales.Length > 1)
            {
                int n = archivos_temporales.Length;
                string[] nuevosArchivos = new string[(n + 1) / 2];

                for (int i = 0; i < n; i += 2)
                {
                    if (i + 1 < n)
                    {
                        string fusionado = Path.Combine(tempDir, $"fusion{i / 2}.txt");
                        MezclarArchivos(archivos_temporales[i], archivos_temporales[i + 1], fusionado);
                        nuevosArchivos[i / 2] = fusionado;
                    }
                    else
                    {
                        nuevosArchivos[i / 2] = archivos_temporales[i];
                    }
                }

                archivos_temporales = nuevosArchivos;
            }

            // Aqui se lee el archivo final y rellenar arreglo
            int index = 0;
            using (var sr = new StreamReader(archivos_temporales[0]))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    compras[index++] = LeerRegistro(linea);
                }
            }

            //guardar archivo
            File.Copy(archivos_temporales[0], archivo_final, true);

            //limpiar temporales
            Directory.Delete(tempDir, true);
        }

    }
}
