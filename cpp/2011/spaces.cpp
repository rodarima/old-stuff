#include <windows.h>
#include <conio.h>
#include <stdio.h>
#include <time.h>

int gotoxy(int x, int y) {
COORD coord;
coord.X = x;
coord.Y = y;
SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
} 

int main(){
	srand((unsigned)time(0)); 
	for(int i = 0; i<256; i++){
		printf("%d - %c\n",i,i);
	}
	while(true){
	int x, y,c;

  x = rand() % 78;
	  y = rand() % 25;
		c = (rand() % 70) +50;
	gotoxy(x,y);
	printf("%c",c);
	//Sleep(10000);
		}
}


