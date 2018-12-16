using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodificacionCesar
{
    class procEncriptado
    {
        private Alfabeto alfabeto = new Alfabeto();

   public procEncriptado()
        { }

      public  char retornarCaracter(char caracter, int desplazamiento)
        {
            if (retornarPosicion(caracter) != -1)
                return retorCaracterXDesplaz(retornarPosicion(caracter), desplazamiento);
            return caracter;
        }

      public  char retorCaracterXDesplaz(int posicionactual, int desplazamiento)
        {
            return alfabeto.retornarCaracter((posicionactual +
                desplazamiento) % alfabeto.retornarTamanio());

        }

      public  int retornarPosicion(char caracter)
        {
            for (int incre = 0; incre < alfabeto.retornarTamanio(); incre++)
            {
                if (alfabeto.retornarCaracter(incre) == caracter)
                    return incre;
            }
            return -1;
        }
    }
}
