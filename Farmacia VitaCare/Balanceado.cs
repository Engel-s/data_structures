using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Farmacia_VitaCare
{
    public class Balanceado
    {
        public double valor;
        public Balanceado NodoIzquierdo;
        public Balanceado NodoDerecho;
        public Balanceado NodoPadre;
        public int altura;
        private DibujaBalanceado arbol;

        public DibujaBalanceado Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        public Balanceado(double valorNuevo, Balanceado izquierdo, Balanceado derecho, Balanceado padre)
        {
            valor = valorNuevo;
            NodoIzquierdo = izquierdo;
            NodoDerecho = derecho;
            NodoPadre = padre;
            altura = 0;
        }

        //Funcion para insertar un nuevo valor en el arbol balanceado
        public Balanceado Insertar(double valorNuevo, Balanceado Raiz)
        {
            if (Raiz == null)
            {
                Raiz = new Balanceado(valorNuevo, null, null, null);
            }
            else if (valorNuevo < Raiz.valor)
            {
                Raiz.NodoIzquierdo = Insertar(valorNuevo, Raiz.NodoIzquierdo);
            }
            else if (valorNuevo > Raiz.valor)
            {
                Raiz.NodoDerecho = Insertar(valorNuevo, Raiz.NodoDerecho);
            }
            else
            {
                MessageBox.Show("Valor existente en el árbol balanceado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Alturas(Raiz.NodoIzquierdo) - Alturas(Raiz.NodoDerecho) == 2)
            {
                if (valorNuevo < Raiz.NodoIzquierdo.valor)
                {
                    MessageBox.Show("Rotación simple izquierda (inserción)");
                    Raiz = RotacionIzquierdaSimple(Raiz);
                }
                else
                {
                    MessageBox.Show("Rotación compuesta izquierda (inserción)");
                    Raiz = RotacionIzquierdaDoble(Raiz);
                }
            }
            if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) == 2)
            {
                if (valorNuevo > Raiz.NodoDerecho.valor)
                {
                    MessageBox.Show("Rotación simple derecha (inserción)");
                    Raiz = RotacionDerechaSimple(Raiz);
                }
                else
                {
                    MessageBox.Show("Rotación compuesta derecha (inserción)");
                    Raiz = RotacionDerechaDoble(Raiz);
                }
            }

            Raiz.altura = max(Alturas(Raiz.NodoIzquierdo), Alturas(Raiz.NodoDerecho)) + 1;
            return Raiz;
        }

        // Metodo para obtener que rama es mayor
        private static int max(int lhs, int rhs)
        {
            return lhs > rhs ? lhs : rhs;
        }

        //Metodo para obtener la altura
        private static int Alturas(Balanceado Raiz)
        {
            if (Raiz == null)
            {
                return -1;
            }
            else
            {
                return Raiz.altura;
            }
        }

        Balanceado nodoE, nodoP;

        //Método para eliminar un nodo en el arbol
        public Balanceado Eliminar(double valorEliminar, Balanceado raiz)
        {
            if (raiz == null) return null;

            if (valorEliminar < raiz.valor)
            {
                raiz.NodoIzquierdo = Eliminar(valorEliminar, raiz.NodoIzquierdo);
            }
            else if (valorEliminar > raiz.valor)
            {
                raiz.NodoDerecho = Eliminar(valorEliminar, raiz.NodoDerecho);
            }
            else
            {
                // Nodo encontrado
                if (raiz.NodoIzquierdo == null || raiz.NodoDerecho == null)
                {
                    raiz = (raiz.NodoIzquierdo != null) ? raiz.NodoIzquierdo : raiz.NodoDerecho;
                }
                else
                {
                    var sucesor = Minimo(raiz.NodoDerecho);
                    raiz.valor = sucesor.valor;
                    raiz.NodoDerecho = Eliminar(sucesor.valor, raiz.NodoDerecho);
                }
            }

            if (raiz == null) return null;

            // Recalcular altura
            raiz.altura = max(Alturas(raiz.NodoIzquierdo), Alturas(raiz.NodoDerecho)) + 1;

            // Balancear
            int balance = Alturas(raiz.NodoIzquierdo) - Alturas(raiz.NodoDerecho);

            // Caso IZQ pesado
            if (balance > 1)
            {
                if (Alturas(raiz.NodoIzquierdo?.NodoIzquierdo) >= Alturas(raiz.NodoIzquierdo?.NodoDerecho))
                {
                    MessageBox.Show("Rotación simple izquierda (eliminación)");
                    return RotacionIzquierdaSimple(raiz);
                }
                else
                {
                    MessageBox.Show("Rotación compuesta izquierda (eliminación)");
                    raiz.NodoIzquierdo = RotacionDerechaSimple(raiz.NodoIzquierdo);
                    return RotacionIzquierdaSimple(raiz);
                }
            }

            // DER pesado
            if (balance < -1)
            {
                if (Alturas(raiz.NodoDerecho?.NodoDerecho) >= Alturas(raiz.NodoDerecho?.NodoIzquierdo))
                {
                    MessageBox.Show("Rotación simple derecha (eliminación)");
                    return RotacionDerechaSimple(raiz);
                }
                else
                {
                    MessageBox.Show("Rotación compuesta derecha (eliminación)");
                    raiz.NodoDerecho = RotacionIzquierdaSimple(raiz.NodoDerecho);
                    return RotacionDerechaSimple(raiz);
                }
            }

            return raiz;
        }

        private static Balanceado Minimo(Balanceado n)
        {
            while (n?.NodoIzquierdo != null) n = n.NodoIzquierdo;
            return n;
        }


        //seccion de funciones de rotaciones
        //Rotación izquierda simple
        private static Balanceado RotacionIzquierdaSimple(Balanceado k2)
        {
            Balanceado k1 = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1.NodoDerecho;
            k1.NodoDerecho = k2;
            k2.altura = max(Alturas(k2.NodoIzquierdo), Alturas(k2.NodoDerecho)) + 1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), k2.altura) + 1;
            return k1;
        }

        //Rotación derecha simple
        private static Balanceado RotacionDerechaSimple(Balanceado k1)
        {
            Balanceado k2 = k1.NodoDerecho;
            k1.NodoDerecho = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), Alturas(k1.NodoDerecho)) + 1;
            k2.altura = max(Alturas(k2.NodoDerecho), k1.altura) + 1;
            return k2;
        }

        //Doble rotación izquierda
        private static Balanceado RotacionIzquierdaDoble(Balanceado k3)
        {
            Balanceado aux;
            k3.NodoIzquierdo = RotacionDerechaSimple(k3.NodoIzquierdo);
            aux = RotacionIzquierdaSimple(k3);
            return aux;
        }

        //Doble rotación derecha
        private static Balanceado RotacionDerechaDoble(Balanceado k1)
        {
            Balanceado aux;
            k1.NodoDerecho = RotacionIzquierdaSimple(k1.NodoDerecho);
            aux = RotacionDerechaSimple(k1);
            return aux;
        }

        //Funciones para dibujar el árbol
        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;

        //Encuentra la pocision en donde debe crearse el nodo
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = Convert.ToInt32(ymin + Radio / 2);

            //Obtiene la posicion del sub árbol izquierdo
            if (NodoIzquierdo != null)
            {
                NodoIzquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((NodoIzquierdo != null) && (NodoDerecho != null))
            {
                xmin += DistanciaH;
            }
            if (NodoDerecho != null)
            {
                NodoDerecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (NodoIzquierdo != null)
            {
                if (NodoDerecho != null)
                {
                    //Centro entre los nodos
                    CoordenadaX = (int)((NodoIzquierdo.CoordenadaX + NodoDerecho.CoordenadaX) / 2);
                }
                else
                {
                    //No hay nodo derecho centrar el nodo izquierdo
                    aux1 = NodoIzquierdo.CoordenadaX;
                    NodoIzquierdo.CoordenadaX = CoordenadaX - 40;
                    CoordenadaX = aux1;
                }
            }
            else if (NodoDerecho != null)
            {
                aux2 = NodoDerecho.CoordenadaX;
                //no hay nodo izquierdo, centrar al nodo derecho
                NodoDerecho.CoordenadaX = CoordenadaX + 40;
                CoordenadaX = aux2;
            }
            else
            {
                // Nodo hoja
                CoordenadaX = (xmin + Radio / 2);
                xmin += Radio;
            }
        }

        //Dibuja Las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (NodoIzquierdo != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, NodoIzquierdo.CoordenadaX,
                    NodoIzquierdo.CoordenadaY);
                NodoIzquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (NodoDerecho != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, NodoDerecho.CoordenadaX,
                    NodoDerecho.CoordenadaY);
                NodoDerecho.DibujarRamas(grafo, Lapiz);
            }
        }

        //Dibuja el nodo en la posición especificada
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, int dato, Brush encuentro)
        {
            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle(
                (int)(CoordenadaX - Radio / 2),
                (int)(CoordenadaY - Radio / 2),
                Radio, Radio);
            if (valor == dato)
            {
                grafo.FillEllipse(encuentro, rect);
            }
            else
            {
                grafo.FillEllipse(encuentro, rect);
                grafo.FillEllipse(Relleno, rect);
            }
            grafo.DrawEllipse(Lapiz, rect);

            //Dibuja el valor del nodo
            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(valor.ToString(), fuente, Brushes.Black, CoordenadaX, CoordenadaY, formato);

            if (NodoIzquierdo != null)
            {
                NodoIzquierdo.DibujarNodo(grafo, fuente, Brushes.Aqua, RellenoFuente, Lapiz, dato, encuentro);
            }
            if (NodoDerecho != null)
            {
                NodoDerecho.DibujarNodo(grafo, fuente, Brushes.LightBlue, RellenoFuente, Lapiz, dato, encuentro);
            }
        }
    }

}