#include <windows.h>
#include <stdlib.h>
#include <malloc.h>
#include <memory.h>
#include <tchar.h>
#include <stdio.h>

#define			BUTTON_IDENTIFIER	1

HINSTANCE		ghInstance = NULL ;
ATOM			RegisterWindowClass(HINSTANCE hInstance, char *pszWindowClassName) ;
BOOL			InitInstance(HINSTANCE, int, char *pszWindowClassName) ;
LRESULT CALLBACK	WndProc(HWND, UINT, WPARAM, LPARAM) ;

int APIENTRY _tWinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPTSTR    lpCmdLine,
                     int       nCmdShow)
{
	//Step 1: Register a Window Class..
	char *pszWindowClassName = "Button Event Class" ;
	if(RegisterWindowClass(hInstance, pszWindowClassName) == 0)
	{
		char szMessage[1024] ;
		sprintf(szMessage, "Last Error = %d", GetLastError()) ;
		OutputDebugString(szMessage) ;
		return -1 ;
	}

	ghInstance = hInstance ;

	//Step 2: Create a Main Window..
	if (!InitInstance(hInstance, nCmdShow, pszWindowClassName))
	{
		return -1 ;
	}

	//Step 3: Loop through the message
	MSG msg ;
	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
}

ATOM RegisterWindowClass(HINSTANCE hInstance, char *pszWindowClassName)
{
	WNDCLASSEX objWndClassEx ;

	memset(&objWndClassEx, 0, sizeof(objWndClassEx)) ;

	objWndClassEx.cbSize		= sizeof(WNDCLASSEX) ;
	objWndClassEx.style			= CS_HREDRAW | CS_VREDRAW ;
	objWndClassEx.lpfnWndProc	= WndProc ;
	objWndClassEx.hInstance		= hInstance ;
	objWndClassEx.hIcon			= LoadIcon(hInstance, MAKEINTRESOURCE(IDI_APPLICATION)) ;
	objWndClassEx.hCursor		= LoadCursor(NULL, IDC_ARROW) ;
	objWndClassEx.hbrBackground	= (HBRUSH)(COLOR_WINDOW+1) ;
	objWndClassEx.lpszClassName	= pszWindowClassName ;

	return RegisterClassEx(&objWndClassEx);
}

BOOL InitInstance(HINSTANCE hInstance, int nCmdShow, char *pszWindowClassName)
{
	int nWidth	= 200 ;
	int nHeight	= 200 ;

	int nScreenX = GetSystemMetrics(SM_CXSCREEN) ;
	int nScreenY = GetSystemMetrics(SM_CYSCREEN) ;

	int x = (nScreenX / 2) - (nWidth / 2) ;
	int y = (nScreenY / 2) - (nHeight / 2) ;

	//Create main Window
	HWND hWnd = CreateWindowEx(NULL, pszWindowClassName, "Button Event Example", WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX, x, y, nWidth, nHeight, NULL, NULL, hInstance, NULL) ;

	if (NULL == hWnd)
	{
		char szMessage[1024] ;
		sprintf(szMessage, "Last Error = %d", GetLastError()) ;
		OutputDebugString(szMessage) ;
		return FALSE ;
	}

	//Display window that we just created.
	ShowWindow(hWnd, nCmdShow) ;
	UpdateWindow(hWnd) ;

	return TRUE ;
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_CREATE:
		{
			//Step 4: Create Button control
			int nWidth	= 70 ;
			int nHeight	= 30 ;
			RECT rect ;
			GetClientRect(hWnd, &rect) ;
			HWND hButtonWnd = CreateWindowEx(NULL, "BUTTON", "Click Me!", WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,
								(rect.right - rect.left - nWidth) / 2, 
								(rect.bottom - rect.top - nHeight) / 2,
								nWidth, nHeight, hWnd, (HMENU) BUTTON_IDENTIFIER, ghInstance, NULL) ;
		}
		break ;

	case WM_COMMAND:
		{
			switch(LOWORD(wParam))
			{
			case BUTTON_IDENTIFIER:
				{
					//Step 5: User click on the button
					if (HIWORD(wParam) == BN_CLICKED)
					{
						UINT nButton	= (UINT) LOWORD(wParam) ;
						HWND hButtonWnd = (HWND) lParam ;

						char szMessage[1024] ;
						sprintf(szMessage, "Hello World from Click Me. Button ID is = %d", nButton) ;
						MessageBox(hWnd, szMessage, "Click Me", MB_OK) ;
					}
				}
				break ;
			}
		}
		break ;

	case WM_CLOSE:
		DestroyWindow(hWnd) ;
		break ;

	case WM_DESTROY:
		PostQuitMessage(0);
		break;

	default:
		return DefWindowProc(hWnd, message, wParam, lParam) ;
	}

	return 0 ;
}
