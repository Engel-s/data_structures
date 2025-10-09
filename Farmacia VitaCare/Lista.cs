using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_VitaCare
{
    public class Lista
    {
        public Nodo primero, ultimo, anterior, T;
        int bandera;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        #region Inserciones
        public void InsertarInicio(string cod, string prod, int cant, decimal precio, decimal subtotal, DataGridView dgv )
        {
            Nodo q = new Nodo();

            q.codigo = cod;
            q.producto = prod;
            q.cantidad = cant;
            q.precio = precio;
            q.subtotal = subtotal;

            q.next = primero;
            primero = q;

            MessageBox.Show($"Producto agregado correctamente, los datos del producto con el código {cod} al inicio", "Listo",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void InsertarFinal(string cod, string prod, int cant, decimal precio, decimal subtotal, DataGridView dgv)
        {
            Nodo q = new Nodo();
            T = primero;

            q.codigo = cod;
            q.producto = prod;
            q.cantidad = cant;
            q.precio = precio;
            q.subtotal = subtotal;

            if (primero == null)
            {
                q.next = primero;
                primero = q;
                ultimo = q;
            }
            else
            {
                while (T.next != null)
                {
                    T = T.next;
                }
                q.next = null;
                T.next = q;
            }
            MessageBox.Show($"Se ha ingresado correctamente el producto con el código {cod} al final", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void InsertarAntesX(string cod, string prod, int cant, decimal precio, decimal subtotal, string x)
        {
            Nodo q = primero;
            bandera = 1;
            Nodo T = new Nodo();

            while (q.codigo != x && bandera == 1)
            {
                if (q.next != null)
                {
                    T = q;
                    q = q.next;
                }
                else
                {
                    bandera = 0;
                }
            }
            if (bandera == 1)
            {
                Nodo k = new Nodo(cod, prod, cant, precio, subtotal);

                if (primero == q)
                {
                    k.next = primero;
                    primero = k;
                }
                else
                {
                    T.next = k;
                    k.next = q;
                }
                MessageBox.Show($"Nodo insertado correctamente antes de {x}");
            }
            else
            {
                MessageBox.Show($"El nodo con código {x} no existe");
            }
        }

        public void InsertarDespuesX(string cod, string prod, int cant, decimal precio, decimal subtotal, string x)
        {
            Nodo q = primero;
            bandera = 1;

            while (q.codigo != x && bandera == 1)
            {
                if (q.next != null)
                {
                    q = q.next;
                }
                else
                {
                    bandera = 0;
                }
            }
            if (bandera == 1)
            {
                Nodo T = new Nodo(cod, prod, cant, precio, subtotal);

                T.next = q.next;
                q.next = T;
                MessageBox.Show($"Nodo insertado correctamente después de {x}");
            }
            else
            {
                MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eliminaciones
        public void EliminarInicio()
        {
            if (primero != null)
            {
                Nodo q = primero;
                MessageBox.Show($"Ha salido el nodo con código {primero.codigo}");
                primero = q.next;
                q = null;
            }
            else
            {
                MessageBox.Show("La lista está vacía", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void EliminarFinal()
        {
            Nodo q = primero;

            if (primero == null)
            {
                MessageBox.Show("La lista está vacía", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (primero.next == null)
                {
                    primero = null;
                }
                else
                {
                    while (q.next != null)
                    {
                        T = q;
                        q = q.next;
                    }
                    MessageBox.Show($"Se ha eliminado el nodo con código {q.codigo}");
                    T.next = null;
                }
            }
        }
        public void EliminarX(string x)
        {
            Nodo q = primero;
            bandera = 1;

            while (q.codigo != x && bandera == 1)
            {
                if (q.next != null)
                {
                    T = q;
                    q = q.next;
                }
                else
                {
                    bandera = 0;
                }
            }
            if (bandera == 1)
            {
                if (primero == q)
                {
                    primero = q.next;
                }
                else
                {
                    T.next = q.next;
                }
                MessageBox.Show($"Ha salido el nodo con código {x}");
            }
            else
            {
                MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            q = null;
        }
        public void EliminarAntesX(string x)
        {
            if (primero.codigo == x)
            {
                MessageBox.Show($"No existe un nodo que preceda a {x}");
            }
            else
            {
                Nodo q = primero;
                bandera = 1;
                T = primero;

                while (q.codigo != x && bandera == 1)
                {
                    if (q.next != null)
                    {
                        anterior = T;
                        T = q;
                        q = q.next;
                    }
                    else
                    {
                        bandera = 0;
                    }
                }
                if (bandera == 1)
                {
                    if (primero.next == q)
                    {
                        primero = q;
                    }
                    else
                    {
                        anterior.next = q;
                    }
                    anterior = null;
                    MessageBox.Show($"Ha salido el nodo que precede a {x}");
                }
                else
                {
                    MessageBox.Show("El nodo dado como referencia no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void EliminarDespuesX(string x)
        {
            if (primero.codigo == x && primero.next == null)
            {
                MessageBox.Show("Solo hay un nodo, no hay ninguno posterior a él");
            }
            else
            {
                Nodo q = primero;
                bandera = 1;

                while (q.codigo != x && bandera == 1)
                {
                    if (q.next != null)
                    {
                        q = q.next;
                        anterior = q;
                        T = anterior.next;
                    }
                    else
                    {
                        bandera = 0;
                    }
                }
                if (bandera == 1)
                {
                    if (primero.codigo == x)
                    {
                        T = q.next;
                        primero.next = T.next;
                    }
                    else
                    {
                        if (T == null)
                        {
                            MessageBox.Show("No puedes establecer el último nodo como referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            anterior.next = T.next;
                        }
                        T = null;
                        MessageBox.Show($"Se ha eliminado el nodo que se encuentra posterior a {x}");
                    }
                }
                else
                {
                    MessageBox.Show("El nodo no se encuentra en la lista");
                }
            }
        }
        #endregion

        #region Buscar
        public void BusquedaDesordenada(string x)
        {
            Nodo q = primero;

            while (q != null && q.codigo != x)
            {
                q = q.next;
            }
            if (q == null)
            {
                MessageBox.Show("El elemento no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"El producto se encuentra en la lista, su información es la siguiente " +
                    $"\nCódigo: {q.codigo} \nNombre: {q.producto}\nPrecio: {q.precio}\nCantidad: {q.cantidad}\nSubtotal: {q.subtotal}", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void BusquedaOrdenada(string x)
        {
            Nodo q = primero;

            while ((q != null) && (q.codigo != x))
            {
                q = q.next;
            }
            if ((q == null) || (q.codigo != x))
            {
                MessageBox.Show($"El elemento {x} no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"El producto se encuentra en la lista, su información es la siguiente " +
                    $"\nCódigo: {q.codigo} \nNombre: {q.producto}\nPrecio: {q.precio}\nCantidad: {q.cantidad}\nTotal: {q.subtotal}", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void BusquedaRecursiva(Nodo q, string x)
        {
            if (q != null)
            {
                if (q.codigo == x)
                {
                    MessageBox.Show($"El producto se encuentra en la lista, su información es la siguiente " +
                        $"\nCódigo: {q.codigo} \nNombre: {q.producto}\nPrecio: {q.precio} \nCantidad: {q.cantidad} \nSubtotal: {q.subtotal}", "", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BusquedaRecursiva(q.next, x);
                }
            }
            else
            {
                MessageBox.Show("El elemento no se encuentra en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Recorridos
        public void RecorridoIterativo(DataGridView dgv)
        {
            Nodo q = new Nodo();
            q = primero;

            if (primero != null)
            {
                while (q != null)
                {
                    MessageBox.Show($"Código: {q.codigo} \nNombre: {q.producto}\nPrecio: {q.precio} \nCantidad: {q.cantidad} \nSubtotal: {q.subtotal}");
                    q = q.next;
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacía");
            }
        }
        public void RecorridoRecursivo(Nodo q)
        {
            if (q == null)
            {
                MessageBox.Show("La lista está vacía");
            }
            if (q != null)
            {
                MessageBox.Show($"Código: {q.codigo}  \nNombre: {q.producto} \nPrecio: {q.precio}  \nCantidad:  {q.cantidad}  \nSubtotal:  {q.subtotal}");
                RecorridoRecursivo(q.next);
            }
            else
            {
                MessageBox.Show("Esta es toda la lista");
            }
        }
        #endregion

        #region Mostrar
        public void Mostrar(DataGridView dgv)
        {
            Nodo q = new Nodo();
            q = primero;
            dgv.Rows.Clear();

            if (primero != null)
            {
                while (q != null)
                {
                    dgv.Rows.Add(q.codigo, q.producto, q.cantidad, q.precio ,q.subtotal);
                    q = q.next;
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacía");
            }
        }
        #endregion
    }
}
