#include<windows.h>
#include<sstream>
#include<string>
using namespace std;
 
/*  Declare Windows procedure  */
LRESULT CALLBACK WindowProcedure (HWND, UINT, WPARAM, LPARAM);
 
/*  Make the class name into a global variable  */
char szClassName[ ] = "calculator";
 
int WINAPI WinMain (HINSTANCE hThisInstance,
                    HINSTANCE hPrevInstance,
                    LPSTR lpszArgument,
                    int nFunsterStil)
 
{
    HWND hwnd;               /* This is the handle for our window */
    MSG messages;            /* Here messages to the application are saved */
    WNDCLASSEX wincl;        /* Data structure for the windowclass */
 
    /* The Window structure */
    wincl.hInstance = hThisInstance;
    wincl.lpszClassName = szClassName;
    wincl.lpfnWndProc = WindowProcedure;      /* This function is called by windows */
    wincl.style = CS_DBLCLKS;                 /* Catch double-clicks */
    wincl.cbSize = sizeof (WNDCLASSEX);
 
    /* Use default icon and mouse-pointer */
    wincl.hIcon = LoadIcon (NULL, IDI_APPLICATION);
    wincl.hIconSm = LoadIcon (NULL, IDI_APPLICATION);
    wincl.hCursor = LoadCursor (NULL, IDC_ARROW);
    wincl.lpszMenuName = NULL;                 /* No menu */
    wincl.cbClsExtra = 0;                      /* No extra bytes after the window class */
    wincl.cbWndExtra = 0;                      /* structure or the window instance */
    /* Use Windows's default color as the background of the window */
    wincl.hbrBackground = (HBRUSH)(COLOR_BACKGROUND);
 
    /* Register the window class, and if it fails quit the program */
    if (!RegisterClassEx (&wincl))
        return 0;
 
    /* The class is registered, let's create the program*/
    hwnd = CreateWindowEx (
           0,                   /* Extended possibilites for variation */
           szClassName,         /* Classname */
           "calculator",       /* Title Text */
           WS_OVERLAPPEDWINDOW, /* default window */
           CW_USEDEFAULT,       /* Windows decides the position */
           CW_USEDEFAULT,       /* where the window ends up on the screen */
           257,                 /* The programs width */
           282,                 /* and height in pixels */
           HWND_DESKTOP,        /* The window is a child-window to desktop */
           NULL,                /* No menu */
           hThisInstance,       /* Program Instance handler */
           NULL                 /* No Window Creation data */
           );
 
    /* Make the window visible on the screen */
    ShowWindow (hwnd, nFunsterStil);
 
    /* Run the message loop. It will run until GetMessage() returns 0 */
    while (GetMessage (&messages, NULL, 0, 0))
    {
        /* Translate virtual-key messages into character messages */
        TranslateMessage(&messages);
        /* Send message to WindowProcedure */
        DispatchMessage(&messages);
    }
 
    /* The program return-value is 0 - The value that PostQuitMessage() gave */
    return messages.wParam;
}
 
 
class Calculator
{
 public:
        
        //Constructor
        Calculator();
        //WinProc Functions
        void command(WPARAM, LPARAM);        
        void create(HWND);
        int  destroy();
        //Other
        void perform_previous_op(); 
  
 private:  
              
        char   prev_op;
        double dSubtotal, 
               dTotal;
        string strSubtotal;               
        bool   bDecimal, 
               bClear;         
        HWND   hNumbers[10], 
               hOperators[4], 
               hDecimal, 
               hClear, 
               hDisplay, 
               hEquals;     
         
};
 
enum keypad
{
     ID_Button_0,
     ID_Button_1, ID_Button_2, ID_Button_3,
     ID_Button_4, ID_Button_5, ID_Button_6,
     ID_Button_7, ID_Button_8, ID_Button_9, 
     ID_Decimal,  ID_Button_EQU,     
     ID_Button_ADD,   ID_Button_SUB, 
     ID_Button_MULT,  ID_Button_DIV,
     ID_Button_CLEAR, ID_Static 
};
 
/*  This function is called by the Windows function DispatchMessage()  */
 
LRESULT CALLBACK WindowProcedure (HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{   
    
   static Calculator MyCalc;
                
    switch (message)                  /* handle the messages */
    {        
        case WM_CREATE:   MyCalc.create(hwnd);               break;   
        case WM_COMMAND:  MyCalc.command(wParam, lParam);    break;
        case WM_DESTROY:  MyCalc.destroy();                  break;        
             
        default:                      /* for messages that we don't deal with */
            return DefWindowProc (hwnd, message, wParam, lParam);
    }
 
    return 0;
}
 
 
 
 
/////////////////////////////////////////
///////// Function Definitions //////////
/////////////////////////////////////////
 
Calculator::Calculator()
{
    dTotal = 0.0;
    dSubtotal = 0.0;  
    bDecimal = false;
    bClear = false;
    prev_op = 0;
}
 
void Calculator::create(HWND hwnd)
{
 
   int index = 1;
   TCHAR *numbers[]   = {"1","2","3","4","5","6","7","8","9"};
    
   for(int y=150; y>49; y-=50)
   for(int x=0;  x<101; x+=50)    
   {                 
      hNumbers[index] = CreateWindow("BUTTON", numbers[index-1], 
                            WS_CHILD|WS_VISIBLE|BS_PUSHBUTTON,
                            x, y, 50, 50, hwnd, (HMENU)index,
                            (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL);  
                            index++;                    
   }
    
   index = 0;
   TCHAR *operators[] = {"+","-","*","/"};
    
   int x  = 150, y = 0;
   int ID = ID_Button_ADD;      
    
   for(int i=0; i<4; i++)
   {
      hOperators[i]   = CreateWindow("BUTTON", operators[i], 
                            WS_CHILD|WS_VISIBLE|BS_PUSHBUTTON,
                            x, y+=50, 50, 50, hwnd, (HMENU)ID++,
                            (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL);
   }     
 
    
   hNumbers[0]   = CreateWindow("BUTTON", "0", WS_CHILD|WS_VISIBLE|BS_PUSHBUTTON,
                           0, 200, 100, 50, hwnd, (HMENU)ID_Button_0,
                           (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL); 
                           
   hDecimal      = CreateWindow("BUTTON", ".", WS_CHILD|WS_VISIBLE|BS_PUSHBUTTON,
                           100, 200, 50, 50, hwnd, (HMENU)ID_Decimal,
                           (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL);
                           
   hClear        = CreateWindow("BUTTON", "Clear", WS_CHILD|WS_VISIBLE|BS_PUSHBUTTON,
                           200, 50, 50, 100, hwnd, (HMENU)ID_Button_CLEAR,
                           (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL);  
                           
   hDisplay      = CreateWindow("STATIC", NULL , WS_CHILD|WS_VISIBLE|WS_BORDER|ES_RIGHT,
                           5, 10, 188, 20, hwnd, (HMENU)ID_Static, 
                           (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL);
    
   hEquals       = CreateWindow("BUTTON", "=", WS_CHILD|WS_VISIBLE|BS_PUSHBUTTON,
                           200, 150, 50, 100, hwnd, (HMENU)ID_Button_EQU,
                           (HINSTANCE)GetWindowLong(hwnd, GWL_HINSTANCE), NULL);  
}
 
 
void Calculator::command(WPARAM wParam, LPARAM lParam)
{   
     
    WORD msg = LOWORD(wParam);
    TCHAR *numbers[]   = {"0","1","2","3","4","5","6","7","8","9","."};
      
     if(HIWORD(wParam) == BN_CLICKED)
     {     
        //Numbers 1 thru 9
        if(msg >= ID_Button_1 && msg <= ID_Button_9)
        {    
             if(bClear)
             {
                strSubtotal.clear();
                SetWindowText(hDisplay, strSubtotal.c_str());
                bClear = false;
             }
                            
             strSubtotal += numbers[msg];
             SetWindowText(hDisplay, strSubtotal.c_str());      
        }
         
        //Number 0 (special case to eliminate leading zeros)
        else if(msg == ID_Button_0 && strSubtotal.size() && !bClear)
        {                           
             strSubtotal += "0";
             SetWindowText(hDisplay, strSubtotal.c_str());
        }
         
        //Decimal (special case to eliminate multiple decimals)
        else if(msg == ID_Decimal && !bDecimal)
        {
             if(bClear)
             {
                strSubtotal.clear();
                SetWindowText(hDisplay, strSubtotal.c_str());
                bClear = false;
             }
              
             bDecimal = true;
             strSubtotal += ".";
             SetWindowText(hDisplay, strSubtotal.c_str());
        } 
         
        //Operators +, -, *, /
        else if(msg >= ID_Button_ADD && msg <= ID_Button_DIV)
        {
             bClear = true;
             bDecimal = false;
              
             if(prev_op)
                                      
                perform_previous_op();
                  
             else
             {   
                istringstream atod(strSubtotal);
                atod >> dTotal; 
             }                       
                  
             switch(msg)
             {
                case ID_Button_ADD:  prev_op = '+';   break;
                case ID_Button_SUB:  prev_op = '-';   break;
                case ID_Button_MULT: prev_op = '*';   break;
                case ID_Button_DIV:  prev_op = '/';   break;
             }
                            
             SetWindowText(hDisplay, strSubtotal.c_str());
        }
         
        //Equals
        else if(msg == ID_Button_EQU)
        {
             if(prev_op)
              
                perform_previous_op();
 
             bClear = true;             
             SetWindowText(hDisplay, strSubtotal.c_str());
        }             
         
        //Clear
        else if(msg == ID_Button_CLEAR)
        {
             prev_op   = 0;
             dSubtotal = 0.0;
             dTotal    = 0.0;
             bClear    = false;
             bDecimal  = false;            
             strSubtotal.clear();
             SetWindowText(hDisplay, strSubtotal.c_str());
        }     
         
    }
}    
           
 
void Calculator::perform_previous_op()
{    
   istringstream atod(strSubtotal);
   atod >> dSubtotal;
    
   switch(prev_op)
   {
      case '+':  dTotal += dSubtotal;   break;
      case '-':  dTotal -= dSubtotal;   break;
      case '*':  dTotal *= dSubtotal;   break;
      case '/':  dTotal /= dSubtotal;   break;   
   }
    
   ostringstream dtoa;
   dtoa << dTotal;
   strSubtotal = dtoa.str();     
}
                            
   
int Calculator::destroy() 
{
     PostQuitMessage(0);
     return 0;
}
