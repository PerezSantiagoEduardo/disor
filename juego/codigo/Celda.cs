

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Juego_de_la_vida
{
    public struct Celda
    {
        #region Propiedades
        public Point Ubicacion { get; set; }
        public List<Point> Vecinos { get; set; }
        public byte Cantidad { get; set; }
        public bool Viva { get; set; }
        public int Edad { get; set; } 
        #endregion

        #region Constructor
        public Celda(int X, int Y)
            : this()
        {
            this.Ubicacion = new Point(X, Y);
            this.Cantidad = 0;
            this.Vecinos = new List<Point>(8);
            this.Edad = 0;
            this.Viva = false;
        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
