#include <stdio.h>
#include <windows.h>
#include <iostream> 
using namespace std;

int download_file(char url[], char to_file[]){
	HMODULE hUrlMon = LoadLibrary("UrlMon.dll");
	typedef HRESULT (__stdcall *URLDownloadToFile_ptr)(LPUNKNOWN pCaller, LPCTSTR szURL, LPCTSTR szFileName, DWORD dwReserved, LPBINDSTATUSCALLBACK lpfnCB);
	URLDownloadToFile_ptr URLDownloadToFile_fn = (URLDownloadToFile_ptr)GetProcAddress(hUrlMon, "URLDownloadToFileA"); 
	printf("\n[+] Descargando \t\t%s \n", url); 
	if(HRESULT hr = !URLDownloadToFile_fn(NULL, url, to_file, 0, NULL)){
	printf("[+] Archivo guardado en: \t%s \n", to_file); 	
	return 0;		
	}else{
	printf("[-] Error al intentar descargar el archivo. Asegurate de que has escrito \"http://\" al principio");
	}
	return -1;
}

int main(int argc, char* argv[]) { 

	if (argc==3){

		download_file(argv[1], argv[2]);	
	}else {
	printf("\n[+] Downloader  C++\n");
	printf("[?] Modo de uso: %s <Url> <Archivo>\n", argv[0]);
	
	}

}