using System;
using System.Drawing;

namespace Farmacia_VitaCare
{
    class NodoArbol
    {
        public NodoArbol izquierdo { get; set; }
        public NodoArbol derecho { get; set; }

        public int cantidad;    
        public int nivel { get; set; }

        // Geometria del nodo
        int coordenadax = 130, coordenaday = 30;
        int coordenadaxder, coordenadayder;
        int elipse = 35;

        public NodoArbol()
        {
            cantidad = 0;
            izquierdo = null;
            derecho = null;
        }

        public NodoArbol(int cant, NodoArbol izq, NodoArbol der)
        {
            cantidad = cant;
            izquierdo = izq;
            derecho = der;
        }

        // Ubicar el nodo
        public void UbicacionNodo(int x, int y, int dx, int dy)
        {
            coordenadaxder = x;  
            coordenadayder = y;     

            int nextDx = Math.Max(30, dx / 2);
            int nextY = y + dy;

            if (izquierdo != null)
                izquierdo.UbicacionNodo(x - dx, nextY, nextDx, dy);

            if (derecho != null)
                derecho.UbicacionNodo(x + dx, nextY, nextDx, dy);
        }


        // Conexiones
        public void DibujarConexiones(Graphics g, Pen lapiz)
        {
            if (izquierdo != null)
            {
                g.DrawLine(lapiz, coordenadaxder, coordenadayder, izquierdo.coordenadaxder, izquierdo.coordenadayder);
                izquierdo.DibujarConexiones(g, lapiz);
            }
            if (derecho != null)
            {
                g.DrawLine(lapiz, coordenadaxder, coordenadayder, derecho.coordenadaxder, derecho.coordenadayder);
                derecho.DibujarConexiones(g, lapiz);
            }
        }

        // Nodos
        public void DibujarNodos(Graphics g, Font fuente, Brush color, Brush colorFuente, Pen lapiz, Brush borde)
        {
            Rectangle temp = new Rectangle(
                Convert.ToInt32(coordenadaxder - elipse / 2),
                Convert.ToInt32(coordenadayder - elipse / 2),
                elipse, elipse);

            g.FillEllipse(color, temp);
            g.DrawEllipse(Pens.Black, temp); 

            var formato = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(cantidad.ToString(), fuente, colorFuente, coordenadaxder, coordenadayder, formato);

            if (izquierdo != null) izquierdo.DibujarNodos(g, fuente, color, colorFuente, lapiz, borde);
            if (derecho != null) derecho.DibujarNodos(g, fuente, color, colorFuente, lapiz, borde);
        }
    }
}
