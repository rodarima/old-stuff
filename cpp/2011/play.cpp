#include <stdio.h>
#include <windows.h>
#include <iostream> 
#include <string>
#include "colores.h"
#include <time.h>
 


using namespace std;

char nurl[100];
int download_file(char url[], char to_file[]){
	//    https://
	if(url == "") return -1;
	if(url[6]!= '/' ){
		
		strcpy(nurl, "http://");
		//printf("%s\n",nurl);
		strcat(nurl,url);
		//printf("%s",nurl);
		//printf("%s",nurl);
		//printf("%c",nurl[6]);
	}else{
	strcpy(nurl, url);
	}
	HMODULE hUrlMon = LoadLibrary("UrlMon.dll");
	typedef HRESULT (__stdcall *URLDownloadToFile_ptr)(LPUNKNOWN pCaller, LPCTSTR szURL, LPCTSTR szFileName, DWORD dwReserved, LPBINDSTATUSCALLBACK lpfnCB);
	URLDownloadToFile_ptr URLDownloadToFile_fn = (URLDownloadToFile_ptr)GetProcAddress(hUrlMon, "URLDownloadToFileA"); 
	color_yellow(); printf("\n> "); color_reset();
	printf("Descargando: \"%s\" ", nurl); 
	color_reset();
	if(HRESULT hr = !URLDownloadToFile_fn(NULL, nurl, to_file, 0, NULL)){
	color_green(); printf("\n> "); color_reset();
	printf("Archivo guardado en: %s \n", to_file); 	
	return 0;		
	}else{
	color_red(); printf("\n> "); color_reset();
	printf("Error al intentar descargar el archivo. \n");
	}
	return -1;
}
int InfoScreen(char argv[]){
	color_yellow(); printf("\n> "); color_reset();
	color_green(); printf("Downloader  C++"); color_reset();
	color_yellow(); printf("\n> "); color_reset();
	printf("Modo de uso: %s URL ARCHIVO\n", argv);
	return 0;
}
int page=1;
char str[80];
int cont = 1;
int main(int argc, char* argv[]) { 

	if (argc>=2){
		char* result = "miles de cosasasaas";
while(cont==1){
  strcpy (str,"http://www.goear.com/search/");
		for(int i=1; i<argc ; i++){
			strcat (str,argv[i]); 
			if(i!=argc-1){
			strcat (str,"+"); 
			}
		}
  strcat (str,"/");
		char npage[10];
		sprintf(npage,"%d",page);
  strcat (str,npage);

		if(download_file(str, "g.txt")!=0)return -1;
			
		FILE *f = fopen("g.txt", "r");

if (f==NULL)
{
   perror ("Error al abrir fichero.txt");
   return -1;
}

char cadena[100000]; /* Un array lo suficientemente grande como para guardar la línea más larga del fichero */
cont=0;
while (fgets(cadena, 100000, f) != NULL)
{
	
	char* str1 = cadena;
	char* str2 = "href=\"listen/";
	char* result = strstr( str1, str2 );
	if( result != NULL ) cont=1;
	size_t found;
	printf(result);
	
	
}
fclose(f);
//Sleep(2000);
page++;
}

	}else {
	InfoScreen(argv[0]);
	}

}