#include <stdio.h>
#include <windows.h>
#include <iostream> 
#include <string>
#include "colores.h"


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
	printf("Descargando: %s ", nurl); 
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
	printf("\n[+] Downloader  C++\n");
	printf("[?] Modo de uso: %s URL ARCHIVO\n", argv);
	return 0;
}

int main(int argc, char* argv[]) { 

	if (argc==3){

		download_file(argv[1], argv[2]);	
	}else {
	InfoScreen(argv[0]);
	}

}