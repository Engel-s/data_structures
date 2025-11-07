using System;
using System.Drawing;
using System.Windows.Forms;

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

        // Insertar usando cantidad
        public bool Insertar(int cantidad)
        {
            var temp = new NodoArbol { cantidad = cantidad };

            if (raiz == null)
            {
                raiz = temp;
                temp.nivel = 1;
                return true;
            }

            NodoArbol anterior = null;
            NodoArbol ant = raiz;

            while (ant != null)
            {
                anterior = ant;
                if (cantidad < ant.cantidad) ant = ant.izquierdo;
                else ant = ant.derecho;
            }

            temp.nivel = (anterior?.nivel ?? 0) + 1;

            if (cantidad < anterior.cantidad) anterior.izquierdo = temp;
            else anterior.derecho = temp;

            return true;
        }

        // Refrescar arbol
        public void ActualizarArbol(PaintEventArgs e, Color fondo)
        {
            e.Graphics.Clear(fondo);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            coordenadax = Math.Max(20, e.ClipRectangle.Width / 2);
            coordenaday = 25;

            nodo = e.Graphics;
            DibujarArbol(nodo, font, Brushes.White, Brushes.Black, Pens.Black, Brushes.LightSkyBlue);
        }

        // Eliminar por cantidad
        public bool Eliminar(int cantidad)
        {
            raiz = EliminarNodo(raiz, cantidad);
            return encontrado;
        }

        private NodoArbol EliminarNodo(NodoArbol Raiz, int cantidad)
        {
            if (Raiz == null)
            {
                MessageBox.Show("Nodo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encontrado = false;
                return null;
            }

            if (cantidad < Raiz.cantidad)
            {
                Raiz.izquierdo = EliminarNodo(Raiz.izquierdo, cantidad);
            }
            else if (cantidad > Raiz.cantidad)
            {
                Raiz.derecho = EliminarNodo(Raiz.derecho, cantidad);
            }
            else
            {
                // Encontrado
                NodoArbol aux = Raiz;
                if (aux.derecho == null) Raiz = aux.izquierdo;
                else if (aux.izquierdo == null) Raiz = aux.derecho;
                else aux = Reemplazar(aux);

                aux = null;
                encontrado = true;
            }
            return Raiz;
        }

        // Predecesor inorden
        protected NodoArbol Reemplazar(NodoArbol aux)
        {
            NodoArbol temp = aux;
            NodoArbol temp2 = aux.izquierdo;

            while (temp2.derecho != null)
            {
                temp = temp2;
                temp2 = temp2.derecho;
            }
            aux.cantidad = temp2.cantidad;

            if (temp == aux) temp.izquierdo = temp2.izquierdo;
            else temp.derecho = temp2.izquierdo;

            return temp2;
        }

        public void DibujarArbol(Graphics g, Font fuente, Brush colorRelleno, Brush colorfuente, Pen lapiz, Brush borde)
        {
            if (raiz == null) return;

         
            int w = (int)g.VisibleClipBounds.Width;
            int xCenter = Math.Max(20, w / 2);
            int dx = Math.Max(60, w / 4);   
            int dy = 60;                 

            raiz.UbicacionNodo(xCenter, 80, dx, dy);
            raiz.DibujarConexiones(g, Pens.Black);
            raiz.DibujarNodos(g, fuente, colorRelleno, colorfuente, Pens.Black, borde);
        }

        // Recorridos
        public void InOrden(ListBox list, Label lbl = null) { list.Items.Clear(); InOrden(raiz, list, lbl); }
        private void InOrden(NodoArbol t, ListBox list, Label lbl)
        {
            if (t == null) return;
            lbl?.SetTextThreadSafe("Recorrido InOrden");
            InOrden(t.izquierdo, list, lbl);
            list.Items.Add(t.cantidad.ToString());
            InOrden(t.derecho, list, lbl);
        }

        public void PosOrden(ListBox list, Label lbl = null) { list.Items.Clear(); PosOrden(raiz, list, lbl); }
        private void PosOrden(NodoArbol t, ListBox list, Label lbl)
        {
            if (t == null) return;
            lbl?.SetTextThreadSafe("Recorrido PosOrden");
            PosOrden(t.izquierdo, list, lbl);
            PosOrden(t.derecho, list, lbl);
            list.Items.Add(t.cantidad.ToString());
        }

        public void PreOrden(ListBox list, Label lbl = null) { list.Items.Clear(); PreOrden(raiz, list, lbl); }
        private void PreOrden(NodoArbol t, ListBox list, Label lbl)
        {
            if (t == null) return;
            lbl?.SetTextThreadSafe("Recorrido PreOrden");
            list.Items.Add(t.cantidad.ToString());
            PreOrden(t.izquierdo, list, lbl);
            PreOrden(t.derecho, list, lbl);
        }
    }

    // Helper para actualizar label
    static class ControlExt
    {
        public static void SetTextThreadSafe(this Control c, string text)
        {
            if (c == null) return;
            if (c.InvokeRequired) c.Invoke(new Action(() => c.Text = text));
            else c.Text = text;
        }
    }
}
