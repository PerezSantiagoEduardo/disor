
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Text;

namespace Juego_de_la_vida
{
    public partial class MainForm : Form
    {
        #region individuos
        private JuegoVida juegov;
        private Grafiquito graf;
        private int GridSize = 100;
        private double OcupacionInicial = .5;
        private int EdadMaxima = 500;
        private string Algoritmo = "23/3";
        private Thread proceso; 
        #endregion

        #region Constructor
        public MainForm()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            this.Shown += Form1_Shown;
            this.FormClosing += Form1_FormClosing;
            Inicializar();
        } 
        #endregion

        #region Private Metodos
        private void Inicializar()
        {
            this.Controls.Remove(graf);
            juegov = new JuegoVida(GridSize, GridSize, Algoritmo, EdadMaxima, this.OcupacionInicial);
            juegov.FireUpdate += juego_V_AgreAr;
            graf = new Grafiquito(GridSize, GridSize);
            graf.Dock = DockStyle.Fill;
            this.Controls.Add(graf);
        }

        private void Comenzar()
        {
            AbortWorker();
            proceso= new Thread(juegov.Jugar);
            proceso.Priority = ThreadPriority.AboveNormal;
            proceso.Start();
        }

        private void AbortWorker()
        {
            if (proceso != null && proceso.IsAlive)
            {
                proceso.Abort();
                proceso.Join();
            }
        }

     
        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            AbortWorker();
        }

        private void Form1_Shown(object sender, System.EventArgs e)
        {
            Comenzar();
        }

        private void juego_V_AgreAr(object sender, FireUpdateEventArgs e)
        {
            foreach (Point nace in e.Nacidos)
            {
                graf.PlotBmp(nace.X, nace.Y, 1);
            }
            foreach (Point muere in e.Muertos)
            {
                graf.PlotBmp(muere.X, muere.Y, 0);
            }
            graf.Invalidate();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}