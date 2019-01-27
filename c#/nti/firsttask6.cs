using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämningsövning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name, please! ");//väljer bara write så att man kas skriva namn på samma rad.

            string strNam; //Första bokstäver i variabels nam visar variabels typ.srting input är text.
            strNam = Console.ReadLine();// Kunde deklarera och tildela värde på ett ock samma rad.För övnings skull, gör dett inte nu.
            Console.Write("Write your last name,please! ");
            string strLnam;// variabel typ string - input är text.
            strLnam = Console.ReadLine();
            Console.WriteLine("Hello, " + strNam + " " + strLnam + "! Welcome to my first programm!");
            Console.Write("Please, write your age!");
            string strAge;
            strAge = Console.ReadLine();//strAge ska konverteras till intAge så att den blir readable och man kan uttgöra mattematiska beräknigar
            int intAge;// variabels namn visar des typ
            intAge = Convert.ToInt32(strAge);// konvertering 
            Console.WriteLine("Your age are approximately  "/*det finns flera dagar */ + intAge * 352 + /*matematiska berekning*/ " " + " days!");
            Console.WriteLine("Thank you! See you again soon!");// det är viktigt att vara trevligt!:)

            Console.ReadLine();
        }
    }
}