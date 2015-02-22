#include <iostream>
#include <windows.h>   // WinApi header

using namespace std;    // std::cout, std::cin

WORD GetConsoleTextAttribute (HANDLE hCon)
{
  CONSOLE_SCREEN_BUFFER_INFO con_info;
  GetConsoleScreenBufferInfo(hCon, &con_info);
  return con_info.wAttributes;
}
HANDLE hConsole= GetStdHandle(STD_OUTPUT_HANDLE);
const int saved_colors = GetConsoleTextAttribute(hConsole);


void color_red(){SetConsoleTextAttribute(hConsole, FOREGROUND_RED | FOREGROUND_INTENSITY);	}
void color_green(){SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);	}
void color_blue(){SetConsoleTextAttribute(hConsole, FOREGROUND_BLUE | FOREGROUND_INTENSITY);	}
void color_yellow(){SetConsoleTextAttribute(hConsole, 0x0E );	}
void color_reset(){SetConsoleTextAttribute(hConsole, saved_colors);	}



