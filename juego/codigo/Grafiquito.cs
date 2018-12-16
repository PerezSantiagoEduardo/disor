
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Juego_de_la_vida
{
    public partial class Grafiquito : UserControl
    {
        #region individuos
        private int maxX;
        private int maxY;
        private Espacio espacio = new Espacio();
        private Rectangle region;
        private Bitmap mapa;
        private long cant = 0;
        private Stopwatch stp = new Stopwatch();
        private Font font = new Font("Times New Roman", 9);
        #endregion

        #region Propiedades
        private Color backColor = Color.Black;
        public override Color BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }
        private Color foreColor = Color.Red;
        public override Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        public string OverlayInfo { get; set; }
        public bool ShowFps { get; set; }
        #endregion

        #region Constructor
        public Grafiquito(int maxX, int maxY)
        {
            Resize += GrafiquitoV2_Resize;
            Paint += GrafiquitoV2_Paint;
         
            InitializeComponent();
            
            this.maxX = maxX;
            this.maxY = maxY;
            this.ShowFps = false;
            this.OverlayInfo = null;
            mapa = new Bitmap(maxX, maxY, PixelFormat.Format24bppRgb);
            ClearBmp();
        } 
        #endregion

        #region Public Methods
  
        /// <param name="x">Componente x</param>
        /// <param name="y">Componente y</param>
        /// <param name="Estado">Estado actual (0:muerta, 1:viva)</param>
        /// <remarks></remarks>      /// <summary>
        /// Dibuja en el bitmap en la posición dada
        /// </summary>
        public void PlotBmp(int x, int y, byte Estado)
        {
            lock (mapa)
            {
                mapa.SetPixel(x, y, Estado > 0 ? ForeColor : BackColor);
            }
        } 
        #endregion

        #region Private Methods
        private void ClearBmp()
        {
            espacio.LockBitmap(mapa);
            for (int i = 0; i <= mapa.Width - 1; i++)
            {
                for (int j = 0; j <= mapa.Height - 1; j++)
                {
                    espacio.SetPixel(i, j, Color.Black);
                }
            }
            espacio.UnlockBitmap(mapa);
        }

        private void GrafiquitoV2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!stp.IsRunning || cant > 10000)
            {
                stp.Start();
                cant = 0;
            }
            cant += 1;
            lock (mapa)
            {
                region = new Rectangle(0, 0, maxX - 1, maxY - 1);
                Rectangle rect = this.ClientRectangle;
                g.DrawImage(mapa, rect, region, GraphicsUnit.Pixel);
                if (this.ShowFps)
                {
                    string info = string.Format("{0} fps", (1000 * cant / stp.ElapsedMilliseconds));
                    SizeF size = g.MeasureString(info, font);
                    g.DrawString(info, font, Brushes.LightBlue, this.Width - size.Width, this.Height - size.Height);
                }
                if (!string.IsNullOrEmpty(this.OverlayInfo))
                {
                    g.DrawString(this.OverlayInfo, font, Brushes.LightBlue, 0, 0);
                }
            }
        }

        private void GrafiquitoV2_Resize(object sender, System.EventArgs e)
        {
            this.Invalidate();
        }
        #endregion

        private void Grafiquito_Load(object sender, EventArgs e)
        {

        }
    }
}
