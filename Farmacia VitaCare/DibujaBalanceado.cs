using Farmacia_VitaCare;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Farmacia_VitaCare
{
    public class DibujaBalanceado
    {
        private readonly Panel _panel;
        private readonly Font _font;
        private readonly Brush _rellenoNodo = Brushes.White;
        private readonly Brush _brushEncuentro = Brushes.LightSkyBlue;
        private readonly Pen _pen = Pens.Black;

        // Instancia utilizada para llamar a los métodos de Balanceado
        private readonly Balanceado _ops = new Balanceado(0, null, null, null);

        private Balanceado _raiz;
        internal Balanceado Raiz => _raiz;

        public DibujaBalanceado(Panel panelDestino, Font? font = null)
        {
            _panel = panelDestino ?? throw new ArgumentNullException(nameof(panelDestino));
            _font = font ?? SystemFonts.DefaultFont;

  
            _panel.GetType().GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(_panel, true, null);

            _panel.Paint += Panel_Paint;
            _panel.Resize += (s, e) => _panel.Invalidate();
        }

        private void Panel_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(_panel.BackColor);

            if (_raiz == null) return;

            int yTop = 30;

            int probe = 0;
            _raiz.PosicionNodo(ref probe, yTop);
            int anchoUsado = Math.Max(1, probe);

            int left = Math.Max(10, (_panel.ClientSize.Width - anchoUsado) / 2);

            int xmin = left;
            _raiz.PosicionNodo(ref xmin, yTop);

            xmin = left;
            _raiz.PosicionNodo(ref xmin, yTop);

            _raiz.DibujarRamas(g, Pens.Gray);
            _raiz.DibujarNodo(g, _font, _rellenoNodo, Brushes.Black, _pen, -999999, _brushEncuentro);
        }

        public void Insertar(double valor)
        {
            _raiz = _ops.Insertar(valor, _raiz); 
            _panel.Invalidate();
        }

        public bool Contiene(int valor)
        {
            var n = _raiz;
            while (n != null)
            {
                if (valor < n.valor) n = n.NodoIzquierdo;
                else if (valor > n.valor) n = n.NodoDerecho;
                else return true; // encontrado
            }
            return false;
        }

        
        public bool TryInsert(int valor)
        {
            if (Contiene(valor)) return false;
            _raiz = _ops.Insertar(valor, _raiz);  
            _panel.Invalidate();
            return true;
        }

        public void Eliminar(double valor)
        {
            _raiz = _ops.Eliminar(valor, _raiz);
            _panel.Invalidate();
        }

        // Recorridos sin tocar balanceado
        public void InOrden(ListBox lst) { lst.Items.Clear(); InOrden(_raiz, lst); }
        public void PreOrden(ListBox lst) { lst.Items.Clear(); PreOrden(_raiz, lst); }
        public void PosOrden(ListBox lst) { lst.Items.Clear(); PosOrden(_raiz, lst); }

        private void InOrden(Balanceado n, ListBox lst)
        {
            if (n == null) return;
            InOrden(n.NodoIzquierdo, lst);
            lst.Items.Add(n.valor);
            InOrden(n.NodoDerecho, lst);
        }
        private void PreOrden(Balanceado n, ListBox lst)
        {
            if (n == null) return;
            lst.Items.Add(n.valor);
            PreOrden(n.NodoIzquierdo, lst);
            PreOrden(n.NodoDerecho, lst);
        }
        private void PosOrden(Balanceado n, ListBox lst)
        {
            if (n == null) return;
            PosOrden(n.NodoIzquierdo, lst);
            PosOrden(n.NodoDerecho, lst);
            lst.Items.Add(n.valor);
        }

        public void Redibujar() => _panel.Invalidate();
    }
}
