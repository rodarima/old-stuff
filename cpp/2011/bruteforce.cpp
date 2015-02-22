#include <stdio.h>
#include <string.h>
#include <time.h>
#include <windows.h>


int gotoxy(int x, int y) {
COORD coord;
coord.X = x;
coord.Y = y;
SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
} 
void wherexy(int& x, int& y){ 
	CONSOLE_SCREEN_BUFFER_INFO screenBufferInfo;
	HANDLE hStd = GetStdHandle(STD_OUTPUT_HANDLE); 
	if (!GetConsoleScreenBufferInfo(hStd, &screenBufferInfo)) 
		printf("GetConsoleScreenBufferInfo (%d)\n", GetLastError()); 
	x = screenBufferInfo.dwCursorPosition.X; 
	y = screenBufferInfo.dwCursorPosition.Y;
}


int main(){

	char word[100];
	scanf("%100s",&word);
	srand((unsigned)time(0)); 
	int leng = strlen(word);
	char test[leng];
	printf("\nCadena:%s Longitud de la cadena = %d\n",word,leng);
	CONSOLE_SCREEN_BUFFER_INFO screenBufferInfo;
	HANDLE hStd = GetStdHandle(STD_OUTPUT_HANDLE); 
	if (!GetConsoleScreenBufferInfo(hStd, &screenBufferInfo)) 
		printf("GetConsoleScreenBufferInfo (%d)\n", GetLastError()); 
	int x = screenBufferInfo.dwCursorPosition.X; 
	int y = screenBufferInfo.dwCursorPosition.Y;
	int step=0, mill =0;
	double it=0;
	while(strcmp(word,test)!=0){
		step++; it++;
		for(int i=0; i<leng; i++){
			int letter = (rand() % 25)+97;
			test[i]=letter;
		}
		test[leng]='\0';
		if(step ==1000000){
			mill+=1;
			step=0;
			gotoxy(x,y);
			printf("%s - %s, %d millones", word, test,mill);
		}
		
	}
	printf("\nEncontrado (%s - %s) en %.0f repeticiones", word, test, it);
}