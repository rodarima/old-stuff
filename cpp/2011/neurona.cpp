/*-------------------------------------------------------------------------
PCPTRON.CPP
---------------------------------------------------------------------------
Programa    : Ilustra el funcionamiento de una red neuronal del tipo
              Perceptron de Rosenblatt.
Sintaxis    : PCPTRON.
Prototipo en:
Notas       : Se ha prescindido de las dos unidades del primer nivel puesto
              que únicamente dejan pasar el vector presentado en la entrada.
              El programa permite observar cómo se realiza el aprendizaje
              de una función lógica OR (o bien una AND).
Devuelve    : No devuelve nada.
Portabilidad: El programa ha sido compilado con Turbo C++ v3.0.
Ver también :
---------------------------------------------------------------------------
Autor       : Alfredo Catalina Gallego.
Fecha       : 19 de diciembre de 1994.
Revisiones  : 19 de diciembre de 1994.
---------------------------------------------------------------------------*/

#include <windows.h>
#include <conio.h>
#include <stdio.h>
#include <malloc.h>
//#include <iostream>

#define NO_HAY_CAMBIO 0
#define HAY_CAMBIO 1

//using namespace std;

class neurona{
  float *wij;
  float xj;
  float sj;
  float h;
  int nro;
  int cambio;
  float *ents;

 public:
  neurona(int NumEnt, float Umbral);
 ~neurona(void);
  float activacion(float *si);
  float salida(void);
  void aprendizaje(float *si, float b);
  int mira_cambio(void);
};

neurona::neurona(int NumEnt, float Umbral)
{
 int n;

 xj = 0;
 sj = 0;
 h = Umbral;
 nro = NumEnt;
 *wij = (float)sizeof(float) * nro;
 for(n = 0; n < nro; n++) wij[n] = 0;
 wij[0] = 0;
 wij[1] = 0;
}

neurona::~neurona(void)
{
 free(wij);
}

float neurona::activacion(float *si)
{
 int n;

 xj = 0;
 for(n = 0; n < nro; n++) xj = xj + (si[n] * wij[n]);
 return xj;
}

float neurona::salida(void)
{
 if (xj > h)
  sj = 1;
 else
  sj = 0;
 return sj;
}

void neurona::aprendizaje(float *si, float b)
{
 float error;
 int n;
 activacion(si);
 salida();
 error = b - sj;
 if (error != 0) {
  h = h - error;
  for(n = 0; n < nro; n++) wij[n] = wij[n] + error * si[n];
  if (!cambio) *ents = (float ) (sizeof(float) * nro);
  cambio = HAY_CAMBIO;
  memcpy(ents, si, sizeof(float) * nro);
 } else {
  if (!memcmp(ents, si, sizeof(float) * nro)) {
   cambio = NO_HAY_CAMBIO;
   free(ents);
  }
 }

 return;
}

int neurona::mira_cambio(void)
{
 return cambio;
}

int main(void)
{
 float entradas[8] = {0, 0,   0, 1,   1, 0,   1, 1};
 float salidas[4] = {     0,      1,       1,       1};
 int n;
 neurona n1(2, 1);




 /* En este bucle se realiza el aprendizaje */
 do {
  for(n = 1; n <= 4; n++) {
   n1.aprendizaje(&entradas[(n - 1) * 2], salidas[n - 1]);
  }
 } while (n1.mira_cambio());

 /* En  este bucle se comprueba lo aprendido */
 printf("Entradas  Salidas \n");
  for(n = 1; n <= 4; n++) {
  n1.activacion(&entradas[(n - 1) * 2]);
  printf("  ");
  printf("%c",entradas[(n - 1) * 2]);
  printf("  ");
  printf("%c",entradas[(n - 1) * 2 + 1] );
  printf("         ");
  printf("%c",n1.salida() );
  printf("\n");
 }

 return 0;
}