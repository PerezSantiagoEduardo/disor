#include "Alfabeto.h"
namespace Cesar{
	char cifrar(char let,int desplaza = 0,int posicion = 0){
			posicion = alfabeto::obtenerPos(let);
			if(posicion < 0)
				return let;
			posicion = (posicion + desplaza)%alfabeto::size;
			return alfabeto::alfabeto[posicion];
		}

		char descifrar(char let,int desplaza = 0,int index = 0){
			index = alfabeto::obtenerPos(let);
			if(index < 0)
				return let;
			index = (alfabeto::size +index-desplaza)%alfabeto::size;
			return alfabeto::alfabeto[index];
		}
}

/**
			try{	
			 int des = 0;
				 //if(numUpDownDesplaza->Text != "")
					 des = Convert::ToInt16(numUpDownDesplaza->Text);
				 std::string descifrado = "";
				 for(int i = 0; i < textBoxTextCifrado->Text->Length;i++){
					 descifrado = descifrado + Cesar::descifrar(textBoxTextCifrado->Text[i],des);
				 }
				 textBoxTextoPlano->Text =  gcnew String(descifrado.c_str());
			}catch(int e){}
*/