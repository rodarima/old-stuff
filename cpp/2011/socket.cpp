#include <stdio.h>
#include <winsocket.h>
#include <netinet/in.h>

int main(int argc, char *argv[]) {
	    int sockfd, accefd, rsinlen, on = 1;
	    pid_t pid;
	    struct sockaddr_in sin, rsin;
	    unsigned long waittime;

	    if (fork()) exit(0);
 
 		sockfd = socket(PF_INET, SOCK_STREAM, 0);
	    setsockopt(sockfd, SOL_SOCKET, SO_REUSEADDR, &on, sizeof(on));
	    memset(&sin, 0, sizeof(struct sockaddr));
	    rsinlen = sizeof(struct sockaddr);
	    sin.sin_family = AF_INET;
	    sin.sin_port = htons(80);
	    sin.sin_addr.s_addr = INADDR_ANY;
        bind(sockfd, (struct sockaddr *)&sin, sizeof(struct sockaddr));
        listen(sockfd, 256);
        while (1) {
                accefd = accept(sockfd, (struct sockaddr *)&rsin, &rsinlen);
                if (accefd >= 0) {
                        pid = fork();
                        if (pid < 0) {
                                printf("Parent: fork error\n");
                                close(accefd);
                                continue;
                        }
                        if (pid == 0) {
                                close(sockfd);
                                //close(accefd);
		/* in my test, althought I add this line the second time,
			it ran into the same situation */
                                process(accefd);
                                printf("Child return to parent\n");
                                close(accefd);
                                exit(0);
                        } else {
                                waitpid(pid, NULL, 0);
                                printf("Parent exiting\n");
                                close(accefd);
                                exit(0);
                        }
                }
        }
        return 0;
}

int process(int fd) {
        int i;

        printf("Child start\n");
        close(fd);
        printf("fd %d closed\n", fd);

        if (fork() > 0)
                return 0;
        printf("in grandchild, infinite loop\n");
		while (1) ;
}
