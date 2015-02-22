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

void red(){SetConsoleTextAttribute(hConsole, FOREGROUND_RED | FOREGROUND_INTENSITY);	}
void green(){SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);	}
void blue(){SetConsoleTextAttribute(hConsole, FOREGROUND_BLUE | FOREGROUND_INTENSITY);	}
void reset(){SetConsoleTextAttribute(hConsole, saved_colors);	}


int main()
{
  //hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
  //saved_colors = GetConsoleTextAttribute(hConsole);

  blue();
  cout << "This text should be blue" << endl;
  reset();
  
  return 0;
}
