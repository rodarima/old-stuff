#include <stdio.h>

int main() {
	
      long Num, divisor=2; 
      printf("Numero: ");
      scanf("%ld",&Num);
      
while(divisor<Num)
{  
while( Num % divisor != 0){divisor=divisor+1;}

	if(Num== divisor){                            
	 printf("%ld es PRIMO\n",Num);    
	}
	else
	{
	printf("%ld no es primo. Multiplo de %ld \n",Num,divisor);  
	break;
	}
}
      
    return 0;
     }
