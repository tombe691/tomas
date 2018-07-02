#include <windows.h>
#include <shellapi.h>


LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
void AddMenus(HWND);

#define IDM_FILE_NEW 1
#define IDM_FILE_OPEN 2
#define IDM_FILE_QUIT 3
#define ID_EDIT 4
#define ID_BUTTON 5
#define ID_BUTTON2 6

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance,
		   LPSTR lpCmdLine, int nCmdShow) {
                     
  MSG  msg;    
  WNDCLASSW wc = {0};
  wc.lpszClassName = L"Simple menu";
  wc.hInstance     = hInstance;
  wc.hbrBackground = GetSysColorBrush(COLOR_3DFACE);
  wc.lpfnWndProc   = WndProc;
  wc.hCursor       = LoadCursor(0, IDC_ARROW);

  RegisterClassW(&wc);
  CreateWindowW(wc.lpszClassName, L"Simple menu",
		WS_OVERLAPPEDWINDOW | WS_VISIBLE,
		100, 100, 350, 250, 0, 0, hInstance, 0);

  while (GetMessage(&msg, NULL, 0, 0)) {
    
    TranslateMessage(&msg);
    DispatchMessage(&msg);
  }

  return (int) msg.wParam;
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, 
			 WPARAM wParam, LPARAM lParam) {
  static HWND hwndEdit;
  HWND hwndButton;
  HWND hwndButton2;
  switch(msg) {

  case WM_CREATE:
      
    AddMenus(hwnd);
    hwndEdit = CreateWindowW(L"Edit", NULL, 
			     WS_CHILD | WS_VISIBLE | WS_BORDER,
			     50, 50, 150, 20, hwnd, (HMENU) ID_EDIT,
			     NULL, NULL);
    hwndButton = CreateWindowW(L"button", L"Set title",
			       WS_VISIBLE | WS_CHILD, 50, 100, 80, 25,
			       hwnd, (HMENU) ID_BUTTON, NULL, NULL);
    hwndButton2 = CreateWindowW(L"button", L"Set title",
				WS_VISIBLE | WS_CHILD, 150, 100, 80, 25,
				hwnd, (HMENU) ID_BUTTON2, NULL, NULL);
    break;
    
    
  case WM_COMMAND:
      
    switch(LOWORD(wParam)) {
          
    case IDM_FILE_NEW:
      ShellExecute(NULL, NULL, "calc.exe", NULL, NULL, SW_SHOWNORMAL);
      break;
    case IDM_FILE_OPEN:
              
      ShellExecute(NULL, NULL, "C:\\temp\\tomas\\skolan\\myfile.txt", NULL, NULL, SW_SHOWNORMAL);
      MessageBeep(MB_ICONINFORMATION);
      break;
                  
    case IDM_FILE_QUIT:
              
      SendMessage(hwnd, WM_CLOSE, 0, 0);
      break;

      //    case ID_BUTTON:
      if (HIWORD(wParam) == BN_CLICKED) {

	int len = GetWindowTextLengthW(hwndEdit) + 1;
	wchar_t text[len];

	GetWindowTextW(hwndEdit, text, len);
	SetWindowTextW(hwnd, text);

	MessageBoxW(NULL, L"Fraga 1 a tal = 2, tal2 = tal * 2 2*2=4 \n2 *4 = 8 moduldivision med 3 pa 8 ger 2 i rest\neftersom 2 * 3 = 6", L"Hello", MB_OK);
      }
      //      break;
      
    case WM_DESTROY:
      
      PostQuitMessage(0);
      break;
    }
  }

  return DefWindowProcW(hwnd, msg, wParam, lParam);
}

void AddMenus(HWND hwnd) {

  HMENU hMenubar;
  HMENU hMenu;

  hMenubar = CreateMenu();
  hMenu = CreateMenu();

  AppendMenuW(hMenu, MF_STRING, IDM_FILE_NEW, L"&New");
  AppendMenuW(hMenu, MF_STRING, IDM_FILE_OPEN, L"&Open");
  AppendMenuW(hMenu, MF_SEPARATOR, 0, NULL);
  AppendMenuW(hMenu, MF_STRING, IDM_FILE_QUIT, L"&Quit");

  AppendMenuW(hMenubar, MF_POPUP, (UINT_PTR) hMenu, L"&File");
  SetMenu(hwnd, hMenubar);
}
