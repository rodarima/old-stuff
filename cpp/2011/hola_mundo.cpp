#include <stdio.h>
#include <windows.h>
#include <iostream> 
using namespace std;

int download_file(char url[], char to_file[]){
	HMODULE hUrlMon = LoadLibrary("UrlMon.dll");
	typedef HRESULT (__stdcall *URLDownloadToFile_ptr)(LPUNKNOWN pCaller, LPCTSTR szURL, LPCTSTR szFileName, DWORD dwReserved, LPBINDSTATUSCALLBACK lpfnCB);
	URLDownloadToFile_ptr URLDownloadToFile_fn = (URLDownloadToFile_ptr)GetProcAddress(hUrlMon, "URLDownloadToFileA"); 
	if(HRESULT hr = URLDownloadToFile_fn(NULL, url, to_file, 0, NULL)){
	return 0;
	}
}

int main(int argc, char* argv[]) { 

	char url[] = "http://ak1.images.tuenti.net/i74/15-416.536547372/0.1.290-429/full/mbWqN4SWKigk6_6Pk10/7R5p01T3jiU.jpg";
	char local[] = "C:\\c++\\Readme.txt";
	cout << "argc = " << argc << endl; 
   for(int i = 0; i < argc; i++) 
      cout << "argv[" << i << "] = " << argv[i] << endl; 


	
   
	if (download_file(url, local)==0){
		printf("Fichero descargado! \n\n"); 
		return 0;
	}
	
	printf("error \n\n"); 
	

}