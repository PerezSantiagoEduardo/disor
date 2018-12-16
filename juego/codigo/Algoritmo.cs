
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Juego_de_la_vida
{
    public struct Algoritmo
    {
        #region individuos
        //Lista de los valores que indican cuando una célula sigue viva (cantidad de vecinos vivos)
        private List<byte> SigueVivaSi;
        //Lista de los valores que indican cuando una célula nace (cantidad de vecinos vivos)
        private List<byte> NaceSi;
        #endregion

        #region Constructor
        //Simbolo: "nnn/nnn"
        public Algoritmo(string Simbolo)
        {
            string[] ns = Simbolo.Split('/');
            if (ns.Length != 2)
            {
                throw new ArgumentException("Formato erróneo");
            }
            List<byte> indivi_vivios_Si = new List<byte>();
            foreach (char c in ns[0])
            {
                indivi_vivios_Si.Add(Convert.ToByte(Char.GetNumericValue(c)));
            }
            List<byte> Conway_NaceSi = new List<byte>();
            foreach (char c in ns[1])
            {
                Conway_NaceSi.Add(Convert.ToByte(Char.GetNumericValue(c)));
            }
            SigueVivaSi = indivi_vivios_Si;
            NaceSi = Conway_NaceSi;
        }

        public Algoritmo(List<byte> VivaSi, List<byte> NaceSi)
        {
            this.SigueVivaSi = VivaSi;
            this.NaceSi = NaceSi;
        }
        #endregion

        #region Propiedades
        public string Simbolo
        {
            get
            {
                string s = "";
                foreach (byte i in SigueVivaSi)
                {
                    s += i.ToString();
                }
                s += "/";
                foreach (byte i in NaceSi)
                {
                    s += i.ToString();
                }
                return s;
            }
        }
        #endregion

        #region Public metodos
        public bool EvualuarProximoEstado(byte iEstadoActual, byte iVecinosVivos, byte iVecinosFertiles)
        {
            //Está muerta, ver si puede nacer
            if (iEstadoActual == 0 && NaceSi.Contains(iVecinosFertiles))
            {
                return true;
            }
            //Está viva, ver si puede seguir viva
            if (iEstadoActual > 0 && SigueVivaSi.Contains(iVecinosVivos))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

