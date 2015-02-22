#include <iostream>
#include <windows.h>   // WinApi header

using namespace std;    // std::cout, std::cin

WORD GetConsoleTextAttribute (HANDLE hCon)
{
  CONSOLE_SCREEN_BUFFER_INFO con_info;
  GetConsoleScreenBufferInfo(hCon, &con_info);
  return con_info.wAttributes;
}

int main()
{
  HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
  const int saved_colors = GetConsoleTextAttribute(hConsole);

  SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);
  cout << "This text should be blue" << endl;
  SetConsoleTextAttribute(hConsole, saved_colors);
  
  return 0;
}
