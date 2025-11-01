using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;

namespace Farmacia_VitaCare
{
    class NodoArbol
    {

        public NodoArbol izquierdo { get; set; }
        public NodoArbol derecho { get; set; }

        public double total;

        int coordenadax = 130,
            coordenaday = 30,
            coordenadaxder,
            coordenadayder,
            elipse = 35;

        public int nivel { get; set; }

        public NodoArbol()
        {
            total = 0;
            izquierdo = null;
            derecho = null;
        }

        public NodoArbol(double dato, NodoArbol izquierdo, NodoArbol derecho, NodoArbol raiz)
        {
            total = dato;
            this.izquierdo = izquierdo;
            this.derecho = derecho;
        }

        //Ubicar el nodo en la zona correspondiente
        public void UbicacionNodo(int posX, int posY)
        {
            int auxiliar1,
                auxiliar2;

            coordenadayder = Convert.ToInt32(posY + elipse / 2);

            if (izquierdo != null)
            {
                izquierdo.UbicacionNodo(posX, posY + elipse + coordenaday);
            }

            if ((izquierdo != null) && (derecho != null))
            {
                posX += coordenadax;
            }

            if (derecho != null)
            {
                derecho.UbicacionNodo(posX, posY + elipse + coordenaday);
            }

            if (izquierdo != null && derecho != null)
            {
                coordenadaxder = Convert.ToInt32(izquierdo.coordenadaxder + derecho.coordenadaxder / 2);
            }
            else
                if (izquierdo != null)
            {
                auxiliar1 = izquierdo.coordenadaxder;
                izquierdo.coordenadaxder = coordenadaxder - 80;
                coordenadaxder = auxiliar1;
            }
            else
                if (derecho != null)
            {
                auxiliar2 = derecho.coordenadaxder;
                derecho.coordenadaxder = coordenadaxder + 80;
                coordenadaxder = auxiliar2;
            }
            else
            {
                coordenadaxder = Convert.ToInt32(posX + elipse / 2);
                posX += elipse;
            }
        }

        //Dibujar las conexiones entre nodos
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
        //Dibujar los nodos
        public void DibujarNodos(Graphics g, Font fuente, Brush color, Brush colorFuente, Pen lapiz, Brush B)
        {
            Rectangle temp = new Rectangle(Convert.ToInt32(coordenadaxder - elipse /2), Convert.ToInt32(coordenadayder - elipse / 2), elipse, elipse);

            g.FillEllipse(B, temp);
            g.FillEllipse(color, temp);
            g.DrawEllipse(lapiz, temp);
            g.FillEllipse(color, temp);
            g.DrawEllipse(lapiz, temp);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            g.DrawString(total.ToString(), fuente, colorFuente, coordenadaxder, coordenadayder, formato);
            if (izquierdo != null)
            {
                izquierdo.DibujarNodos(g, fuente, color, colorFuente, lapiz, B);
            }
            if (derecho != null)
            {
                derecho.DibujarNodos(g, fuente, color, colorFuente, lapiz, B);
            }
        }
    }
}
