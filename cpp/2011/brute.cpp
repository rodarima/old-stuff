#include <stdio.h>
#include <time.h>
#include <string>
#include <windows.h>

char word[12];int leng;

int comp(char* pass){
	int c = strcmp(word,pass);
	if(c==0){
		printf("> %s", pass);
		exit(0);
		return 0;
	}
	return 1;
}
int posicion=0;
void bruteforce(char* pwd){
	printf("%s",pwd);
	char pass[leng];int i;
	for(i=0;i<leng;i++)
	pass[i]='a';
	pass[i]='\0';
	printf("%s\n", pass);
	
	while(true){
		
		for(i='a'; i<='z';i++){
			pass[leng-1]=i;
			comp(pass);
			//printf("(%s|%s)\n", word, pass);
		}
		printf("(%s|%s) ", word, pass);
		posicion++;
		printf("\t %d ->", posicion);
		if(pass[leng-posicion-1]!='z'){
			pass[leng-posicion-1]++;
			posicion=0;
		}
		else
		{
			pass[leng-posicion-2]++;
			for(i=0; i<posicion;i++){
				pass[leng-i-2]='a';
			}
		}
		printf("%d\n", posicion);
		
	}

}

int main(){
	system("cls");
	printf("BruteForce *****\n");
	printf("> ");
	scanf("%10s",word);
	leng = strlen(word);
	printf(".Longitud %d ", leng);
	bruteforce(word);
	
}