using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodificacionCesar
{
    class EncripInversa
    {
       public  EncripInversa() { }
       public String encriptarInversa(String  texto)
        {
           String transp = "";
            for (int itera = 0; itera < texto.Length; itera++)
            {
                transp = texto[itera] + transp;
            }
            return transp;
        }
    }
}
