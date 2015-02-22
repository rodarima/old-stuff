// Sockets_Options.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <winsock2.h>
#include <ws2tcpip.h>
#include <stdio.h>
#pragma comment(lib, "ws2_32")
#define DEFAULT_PORT "27015"

struct addrinfo *result = NULL,
                *ptr = NULL,
                hints;


int t_main() {
   
  WSADATA wsaData;
  int iResult;

// Initialize Winsock
iResult = WSAStartup(MAKEWORD(2,2), &wsaData);
if (iResult != 0) {
    printf("WSAStartup failed: %d\n", iResult);
    return 1;
}
printf ("WSAStartup conseguido \n");
//Sleep(100000);
   //return 0;


ZeroMemory( &hints, sizeof(hints) );
hints.ai_family = AF_INET;
hints.ai_socktype = SOCK_STREAM;
hints.ai_protocol = IPPROTO_TCP;
hints.ai_flags = AI_PASSIVE;

// Resolve the local address and port to be used by the server
iResult = getaddrinfo(NULL, DEFAULT_PORT, &hints, &result);
if ( iResult != 0 ) {
    printf("getaddrinfo failed: %d\n", iResult);
    WSACleanup();
   
    return 1;
}



printf ("getaddrinfo conseguido \n");
SOCKET ListenSocket = INVALID_SOCKET;
ListenSocket = socket(result->ai_family, result->ai_socktype, result->ai_protocol);
if (ListenSocket == INVALID_SOCKET) {
    printf("Error at socket(): %ld\n", WSAGetLastError());
    freeaddrinfo(result);
    WSACleanup();
    return 1;
}
printf ("parece ser que el socket se ha creado correctamente \n");
SOCKET ClientSocket;
ClientSocket = INVALID_SOCKET;

// Accept a client socket
ClientSocket = accept(ListenSocket, NULL, NULL);
if (ClientSocket == INVALID_SOCKET) {
    printf("accept failed: %d\n", WSAGetLastError());
    closesocket(ListenSocket);
    WSACleanup();
   Sleep(10000);
    return 1;
}
printf ("Accept correct \n");



Sleep(10000);
return 0;
}
/*
int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}

*/