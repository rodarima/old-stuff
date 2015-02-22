#include <windows.h>
#include <conio.h>
#include <stdio.h>

int gotoxy(int x, int y) {
COORD coord;
coord.X = x;
coord.Y = y;
SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
} 

int main(){
	gotoxy(15,2);
	printf("hola cabezota");
}