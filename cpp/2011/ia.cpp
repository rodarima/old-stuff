#include <windows.h>
#include <conio.h>
#include <stdio.h>

int main(){
	float entradas[8] = {0, 0,   0, 1,   1, 0,   1, 1};
	float *si = entradas;
	float  *wij;
	int nro = 0;
	int xj=0;
	*wij = (float)sizeof(float) * nro;
	for(int n = 0; n < nro; n++) wij[n] = 0;
	for(int n = 0; n < nro; n++) xj = xj + (si[n] * wij[n]);
	printf("%d \n",xj);
	printf("%d \n",sizeof(float)*nro);
	printf("%d \n",&wij);
	//getch();
}