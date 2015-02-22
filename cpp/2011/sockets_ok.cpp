#include <stdio.h>
#include "winsock2.h"

int main() {

// Initialize Winsock.
WSADATA wsaData;
int iResult = WSAStartup( MAKEWORD(2,2), &wsaData );
if ( iResult != NO_ERROR )
printf("Error at WSAStartup()\n");

// Create a socket.
SOCKET m_socket;
m_socket = socket( AF_INET, SOCK_STREAM, IPPROTO_TCP );

if ( m_socket == INVALID_SOCKET ) {
printf( "Error at socket(): %ld\n", WSAGetLastError() );
WSACleanup();
return 0;
}

// Connect to a server.
sockaddr_in clientService;

clientService.sin_family = AF_INET;
clientService.sin_addr.s_addr = inet_addr( "127.0.0.1" );
clientService.sin_port = htons( 27015 );

if ( connect( m_socket, (SOCKADDR*) &clientService,
sizeof(clientService) ) == SOCKET_ERROR) {
printf( "Failed to connect.\n" );
WSACleanup();
return 0;
}

// Send and receive data.
int bytesSent;
int bytesRecv = SOCKET_ERROR;
char sendbuf[32] = "Client: Sending data.";
char recvbuf[32] = "";

bytesSent = send( m_socket, sendbuf, strlen(sendbuf), 0 );
printf( "Bytes Sent: %ld\n", bytesSent );

while( bytesRecv == SOCKET_ERROR ) {
bytesRecv = recv( m_socket, recvbuf, 32, 0 );
if ( bytesRecv == 0 || bytesRecv == WSAECONNRESET ) {
printf( "Connection Closed.\n");
break;
}
if (bytesRecv < 0)
system("pause");
return 0;
printf( "Bytes Recv: %ld\n", bytesRecv );
}
system("pause");
return 0;
}