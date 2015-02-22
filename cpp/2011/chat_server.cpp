//COMPILAR CON:               g++ chat_server.cpp -o chat_server.exe -lws2_32

#include <winsock.h> //Incluir en las opcione de proyectos, opciones de link, la libreria wsock32.lib
#include <stdio.h>
#include <stdlib.h>
#define PORT 3550 /* El puerto que será abierto */
#define BACKLOG 100 /* El número de conexiones permitidas */
//Si estamos en un entorno linux, no definimos estas funciones

void iniciarRed();//En windows utilizada para inicializar los sockets
void finalizarRed();//En windows utilizada para liberar los sockets


//Funciones auxiliares de red


void iniciarRed()//Inicializacion de la libreria de windows
{

WSADATA info;
if (WSAStartup(MAKEWORD(2,0), &info) != 0)
{
printf ("Fue imposible inicializar Winsock\n");
exit(-1);
}
}


void finalizarRed()
{
WSACleanup();//Cerramos la libreria de forma correcta

}

main()
{
iniciarRed();
system("cls");
   int fd, fd2; /* los ficheros descriptores */

   struct sockaddr_in server;
   /* para la información de la dirección del servidor */

   struct sockaddr_in client;
   /* para la información de la dirección del cliente */

   int sin_size;

   /* A continuación la llamada a socket() */
   if ((fd=socket(AF_INET, SOCK_STREAM, 0)) == -1 ) { 
      printf("error en socket()\n");
      exit(-1);
   }

   server.sin_family = AF_INET;         

   server.sin_port = htons(PORT);
   /* ¿Recuerdas a htons() de la sección "Conversiones"? =) */

   server.sin_addr.s_addr = INADDR_ANY;
   /* INADDR_ANY coloca nuestra dirección IP automáticamente */

   memset(&(server.sin_zero),'\0',8);
   /* escribimos ceros en el reto de la estructura */


   /* A continuación la llamada a bind() */
   if(bind(fd,(struct sockaddr*)&server,
           sizeof(struct sockaddr))==-1) {
      printf("error en bind() \n");
      exit(-1);
   }     
	
   if(listen(fd,BACKLOG) == -1) {  /* llamada a listen() */
      printf("error en listen()\n");
      exit(-1);
   }
char nmbre[100][20] = {""};
int i = 0;
while(1)
{

sin_size=sizeof(struct sockaddr_in);
      /* A continuación la llamada a accept() */
      if ((fd2 = accept(fd,(struct sockaddr *)&client, &sin_size))==-1)
      {
         printf("error en accept()\n");
         exit(-1);
      }

	 char m[145]=" ";
     recv(fd2,m,140,0);
	 if(m!=0){
	 printf ("\a%s\n",m);
	 }
	 
   }
   closesocket(fd2);
   finalizarRed();
}
