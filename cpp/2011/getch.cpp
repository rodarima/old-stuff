#include <windows.h>
#include <conio.h>
#include <stdio.h>

int main(){
char cTecla = getch();
	printf("la tecla \"%c\" corresponde en decimal a %d", cTecla,(int)cTecla);
}