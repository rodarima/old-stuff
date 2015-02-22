#include <stdio.h>
#include <windows.h>
#include <conio.h>

int main(){
while(1){
    char ping=system("ping -t -n 1 209.85.229.99");
   
    printf("%d",ping);
    char ErrPing = sscanf("ping","%d");
    char aa = printf("%d",ErrPing);
if (aa == "0") {printf("no hubo error");
}else{
      printf("error");}
    getch();
}
}
