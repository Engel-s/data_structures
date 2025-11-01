using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Farmacia_VitaCare
{
    class Arbol
    {
        public NodoArbol raiz;

        Graphics nodo;
        Font font;

        int coordenadax = 740;
        int coordenaday = 45;

        bool encontrado = false;

        public Arbol(Graphics nodo, Font font)
        {
            this.nodo = nodo;
            this.font = font;
        }

        //Insertar datos
        public bool Insertar(double total)
        {
            NodoArbol temp = new NodoArbol();

            temp.total = total;
            temp.izquierdo = null;
            temp.derecho = null;

            if (raiz == null)
            {
                raiz = temp;
                temp.nivel = 1;
                return true;
            }
            else
            {
                NodoArbol anterior = null, ant;
                ant = raiz;

                while (ant != null)
                {
                    anterior = ant;
                    if (total < ant.total)
                    {
                        ant = ant.izquierdo;
                    }
                    else
                    {
                        ant = ant.derecho;
                    }
                }
                if (total < anterior.total)
                {
                    temp.nivel++;
                    anterior.izquierdo = temp;
                    return true;
                }
                else if (total > anterior.total)
                {
                    temp.nivel++;
                    anterior.derecho = temp;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Actualizar arbol
        public void ActualizarArbol(PaintEventArgs e, Color c)
        {
            e.Graphics.Clear(c);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nodo = e.Graphics;
            DibujarArbol(nodo, font, Brushes.White, Brushes.Black, Pens.White, Brushes.Black);
        }

        public bool Eliminar(double total)
        {
            raiz = EliminarNodo(raiz, total);
            return encontrado;
        }

        public NodoArbol EliminarNodo(NodoArbol Raiz, double total)
        {
            if (Raiz == null)
            {
                MessageBox.Show("Nodo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
            }
            else if (total < Raiz.total)
            {
                NodoArbol left = EliminarNodo(Raiz.izquierdo, total);
                Raiz.izquierdo = left;
            }
            else if (total > Raiz.total)
            {
                NodoArbol right = EliminarNodo(Raiz.derecho, total);
                Raiz.derecho = right;
            }
            else
            {
                NodoArbol aux = Raiz;

                if (aux.derecho == null)
                {
                    Raiz = aux.izquierdo;
                }
                else if (aux.izquierdo == null)
                {
                    Raiz = aux.derecho;
                }
                else
                {
                    aux = Reemplazar(aux);
                }
                aux = null;
                encontrado = true;
            }
            return Raiz;
        }

        //Cambiar nodo al eliminar
        protected NodoArbol Reemplazar(NodoArbol aux)
        {
            NodoArbol temp = aux;
            NodoArbol temp2 = aux.izquierdo;

            while (temp2.derecho != null)
            {
                temp = temp2;
                temp2 = temp2.derecho;
            }
            aux.total = temp2.total;

            if (temp == aux)
            {
                temp.izquierdo = temp2.izquierdo;
            }
            else
            {
                temp.derecho = temp2.izquierdo;
            }
            return temp2;
        }

        //Dibujar el arbol
        public void DibujarArbol(Graphics g, Font fuente, Brush colorRelleno, Brush colorfuente, Pen lapiz, Brush borde)
        {
            if (raiz == null)
            {
                return;
            }

            raiz.UbicacionNodo(coordenadax, coordenaday);
            raiz.DibujarConexiones(g, lapiz);
            raiz.DibujarNodos(g, fuente, colorRelleno, colorfuente, lapiz, borde);
        }

        //Recorrido inorden
        public void InOrden(ListBox list, Label lbl)
        {
            InOrden(raiz, list, lbl);
        }
        public void InOrden(NodoArbol temp, ListBox list, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido InOrden";
                InOrden(temp.izquierdo, list, lbl);
                list.Items.Add(temp.total.ToString());
                InOrden(temp.derecho, list, lbl);
            }
        }

        //Recorridos posOrden
        public void PosOrden(ListBox list, Label lbl)
        {
            list.Items.Clear();
            PosOrden(raiz, list, lbl);
        }
        public void PosOrden(NodoArbol temp, ListBox list, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido PosOrden";
                PosOrden(temp.izquierdo, list, lbl);
                PosOrden(temp.derecho, list, lbl);
                list.Items.Add(temp.total.ToString());
            }
        }

        public void PreOrden(ListBox list, Label lbl)
        {
            list.Items.Clear();
            PreOrden(raiz, list, lbl);
        }
        public void PreOrden(NodoArbol temp, ListBox list, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido PreOrden";
                list.Items.Add(temp.total.ToString());
                PreOrden(temp.izquierdo, list, lbl);
                PreOrden(temp.derecho, list, lbl);
            }
        }
    }
}
