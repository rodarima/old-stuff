#include <stdio.h>
#include <windows.h>
#include <iostream> 
#include <string>

using namespace std;

char nurl[100];
int download_file(char url[], char to_file[]){
	//    https://
	if(url == "") return -1;
	if(url[6]!= '/' ){
		
		strcpy(nurl, "http://");
		printf("%s\n",nurl);
		strcat(nurl,url);
		printf("%s",nurl);
		//printf("%s",nurl);
		//printf("%c",nurl[6]);
	}else{
	strcpy(nurl, url);
	}
	HMODULE hUrlMon = LoadLibrary("UrlMon.dll");
	typedef HRESULT (__stdcall *URLDownloadToFile_ptr)(LPUNKNOWN pCaller, LPCTSTR szURL, LPCTSTR szFileName, DWORD dwReserved, LPBINDSTATUSCALLBACK lpfnCB);
	URLDownloadToFile_ptr URLDownloadToFile_fn = (URLDownloadToFile_ptr)GetProcAddress(hUrlMon, "URLDownloadToFileA"); 
	printf("\n[+] Descargando: %s \n", nurl); 
	if(HRESULT hr = !URLDownloadToFile_fn(NULL, nurl, to_file, 0, NULL)){
	printf("[+] Archivo guardado en: \t%s \n", to_file); 	
	return 0;		
	}else{
	printf("[-] Error al intentar descargar el archivo.");
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