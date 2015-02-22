//COMPILAR CON:               g++ chat_client.cpp -o chat_client.exe -lws2_32

#include <winsock2.h>
#include <stdio.h>

#define PORT 3550
#define IP "192.168.1.77"

using namespace std;

void Red()
{
WSADATA info;

if (WSAStartup(MAKEWORD(2,0), &info) !=0)
{
printf("Fue imposible inicializar winsock 2.0\n");
exit(1);
}
}

int main(int argc, char *argv[])
{
char nombre[100];
Red();
struct sockaddr_in red;

if (argv[1] == 0)
{
printf("Introduzca un nombre\n");
scanf("%s",nombre);

}else{
strcpy(nombre,argv[1]);
//nombre = argv[1];
}
int fd = 0;


red.sin_family = AF_INET;
red.sin_port = htons(PORT);
red.sin_addr.s_addr = inet_addr(IP);


int i=0;

printf("Conectado a: %s\n", IP);

printf("Nombre(max 15): %s\n", nombre );
char bv[100];
strcpy(bv,nombre);
strcat(bv," se ha conectado");
if ((fd=socket(AF_INET,SOCK_STREAM,IPPROTO_TCP))==INVALID_SOCKET)
    {
        printf("Socket failed.Error:%d\n",WSAGetLastError());
        exit(1);
        return 0;
    }
if(connect(fd,(struct sockaddr*)&red,sizeof(red))==SOCKET_ERROR)
 {
 printf("Socket failed.Error:%d\n",WSAGetLastError());
 exit(1);
  return 0;
 }
send(fd,bv,sizeof(bv),0);
closesocket(fd);
//char* caca;
//gets(caca);
while(1)
{

char sn[2048] = " ";
printf("%s> ",nombre);
//scanf("%[^\n]",sn);
gets(sn);
//if(strcmp(sn,"\n"))continue;
char message[140]=" ";
strcpy(message,nombre);
strcat(message,"> ");
strcat(message,sn);

if ((fd=socket(AF_INET,SOCK_STREAM,IPPROTO_TCP))==INVALID_SOCKET)
    {
        printf("Socket failed.Error:%d\n",WSAGetLastError());
        exit(1);
        return 0;
    }
if(connect(fd,(struct sockaddr*)&red,sizeof(red))==SOCKET_ERROR)
 {
 printf("Socket failed.Error:%d\n",WSAGetLastError());
 exit(1);
  return 0;
 }
send(fd,message,sizeof(message),0);
closesocket(fd);
}
}
