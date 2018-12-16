using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodificacionCesar
{
    class procDesencriptar
    {
	
	private Alfabeto alfabeto = new Alfabeto();
    private int desplazamiento = 0;

     public procDesencriptar()
        { }

       public char retornarCaracter(char caracter, int desplazamiento)
        {
            if (retornarPosicion(caracter) != -1)
                return retorCaracterXDesplazInverso(
                    retornarPosicion(caracter), desplazamiento);
            return caracter;
        }

       public char retorCaracterXDesplazInverso(int posicionactual, int desplazamiento)
        {
            return alfabeto.retornarCaracter((posicionactual - desplazamiento +
                alfabeto.retornarTamanio()) % alfabeto.retornarTamanio());
        }

        public int retornarPosicion(char caracter)
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
