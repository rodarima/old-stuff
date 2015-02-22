//#include <stdio.h>
#include <iostream>
#include <stdio.h>
#include <windows.h>
 
 using namespace std;
int main() {


      long Num, divisor=2; 
	        
      printf("Numero: ");
      scanf("%ld",&Num);
      
while(divisor<Num)
{  
while( Num % divisor != 0)
          
		  divisor=divisor+1;
          if(Num== divisor)                                
           printf("%ld es PRIMO",Num);    
           else
      printf("%ld no es primo. Multiplo de %ld",Num,divisor);  

     char q = getchar();
     break;
      }
      
 	 char q = getchar();
    return 0;
     }
