#include <iostream>
#include <string>
#include <stdio.h>
#include <windows.h>
#include <time.h>
typedef  unsigned long long bignum; 
using namespace std;
string t = "aver";
string password = "";
int a,b,c,lmax,lmin,lcad,max_min;
bignum ncar;
char key[20];
const char alfa[27] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

//void checkPassword(string password);
void recurse(int width, int position, string baseString);
	
bignum pot(bignum b, int p){
	bignum y=1,w;
      for(w=1;w<=p;w++)
      {
        y*=b;
      }
      return(y);
}
clock_t reloj, reloj2; 
float tiempo; 
int main() {




	printf("BruteForcer [metodo lineal]\n");
	printf("> ");
	char word[100];
	scanf(word);reloj = clock(); 
	int leng = strlen(word);
	t = string(word);
	lcad= sizeof alfa / sizeof(char);
	ncar= pot(lcad,leng);
	printf("Total(%d)", ncar);

    char buf[255];
    
    for(bignum i=0;i<ncar;i++){
	
	cout << " [" << i << "]" << endl;
	recurse(i,0,"");
	reloj2 = clock();
tiempo = ((float)reloj2-(float)reloj)/CLOCKS_PER_SEC; 
printf ("Tiempo transcurrido = %f segundos\n", tiempo); 
	}
	getchar();getchar();	
		
}

void recurse(int width, int position, string baseString) {
	//password="";
if(password!=t){
  for(int i=0;i<lcad;i++) {
    if (position < width-1) {
      recurse(width, position + 1, baseString+alfa[i]);
      //cout << baseString+alfa[i];
    }
    password =  baseString+alfa[i];
    //checkPassword(baseString+alfa[i]);
  }
}
else{cout << "Encontrado [" << password << "]" << endl;
reloj2 = clock();
tiempo = ((float)reloj2-(float)reloj)/CLOCKS_PER_SEC; 
printf ("Tiempo transcurrido = %f segundos\n", tiempo); 
    getchar();
	//return ;
    exit(0);
	}
}
/*
void checkPassword(string password) {
  if (password==t) {
    
    exit(0);
  }
}
*/
