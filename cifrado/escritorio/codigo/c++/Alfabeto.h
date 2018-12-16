#include <vector>	
namespace alfabeto{
		char alfabeto [54]= {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z'
				   ,'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z'};
		int size = 54;
		int obtenerPos(char letra,int posicion = 0){
			for(;posicion < size;posicion++)
				if(alfabeto[posicion] == letra)
					return posicion;
			return -1;
		}

		bool existe(char letra, int posicion = 0){
			for(;posicion < size;posicion++)
				if(alfabeto[posicion] == letra)
					return true;
			return false;
		}
	}