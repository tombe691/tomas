#include <windows.h>

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, 
                    LPSTR pCmdLine, int CmdShow) {
                    
    MessageBoxW(NULL, L"Hello World", L"Hello", MB_OK);

    return 0;
}
