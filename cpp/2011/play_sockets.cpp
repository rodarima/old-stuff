
#include <windows.h>

#include <winsock.h>

#include <stdio.h>



#define NETWORK_ERROR -1

#define NETWORK_OK     0



void ReportError(int, const char *);





int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpCmd, int nShow)

{

	WORD sockVersion;

	WSADATA wsaData;

	int nret;



	sockVersion = MAKEWORD(1, 1);





	// Initialize Winsock as before

	WSAStartup(sockVersion, &wsaData);





	// Store information about the server

	LPHOSTENT hostEntry;



	hostEntry = gethostbyname("www.yahoo.com");	// Specifying the server by its name;

							// another option: gethostbyaddr()



	if (!hostEntry)

	{

		nret = WSAGetLastError();

		ReportError(nret, "gethostbyname()");	// Report the error as before



		WSACleanup();

		return NETWORK_ERROR;

	}





	// Create the socket

	SOCKET theSocket;



	theSocket = socket(AF_INET,			// Go over TCP/IP

			   SOCK_STREAM,			// This is a stream-oriented socket

			   IPPROTO_TCP);		// Use TCP rather than UDP



	if (theSocket == INVALID_SOCKET)

	{

		nret = WSAGetLastError();

		ReportError(nret, "socket()");



		WSACleanup();

		return NETWORK_ERROR;

	}





	// Fill a SOCKADDR_IN struct with address information

	SOCKADDR_IN serverInfo;



	serverInfo.sin_family = AF_INET;



	// At this point, we've successfully retrieved vital information about the server,

	// including its hostname, aliases, and IP addresses.  Wait; how could a single

	// computer have multiple addresses, and exactly what is the following line doing?

	// See the explanation below.



	serverInfo.sin_addr = *((LPIN_ADDR)*hostEntry->h_addr_list);



	serverInfo.sin_port = htons(80);		// Change to network-byte order and

							// insert into port field





	// Connect to the server

	nret = connect(theSocket,

		       (LPSOCKADDR)&serverInfo,

		       sizeof(struct sockaddr));



	if (nret == SOCKET_ERROR)

	{

		nret = WSAGetLastError();

		ReportError(nret, "connect()");



		WSACleanup();

		return NETWORK_ERROR;

	}





	// Successfully connected!





	// Send/receive, then cleanup:

	closesocket(theSocket);

	WSACleanup();

}





void ReportError(int errorCode, const char *whichFunc)

{

   char errorMsg[92];					// Declare a buffer to hold

							// the generated error message

   

   ZeroMemory(errorMsg, 92);				// Automatically NULL-terminate the string



   // The following line copies the phrase, whichFunc string, and integer errorCode into the buffer

   sprintf(errorMsg, "Call to %s returned error %d!", (char *)whichFunc, errorCode);



   MessageBox(NULL, errorMsg, "socketIndication", MB_OK);

}
