using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythims
{
    public class DecToAnyConversion:IAlgorythims
    {
        private int _sysNumber{ get;set;}
        private int _decNumber{ get;set;}
        private string _resoult = "";

        public DecToAnyConversion(){
            UserInput();
            Run();
        }
        public void Run()
        {
            while(_decNumber > 0)
            {
                if((_decNumber % _sysNumber > 9) && (_decNumber % _sysNumber < 28))
                {
                    _resoult += Convert.ToChar(((_decNumber % _sysNumber) - 9) + 64);
                }
                else
                {
                    _resoult += _decNumber % _sysNumber;
                }
                _decNumber = _decNumber / _sysNumber;
            }
            printResoult(reverse(_resoult));
        }
        private string reverse(string text)
        {
            string tempText = "";
            for(int i = (text.Length-1); i >= 0 ; i--)
            {
                tempText += text[i];
            }
            return tempText;
        }
        private void printResoult(string resoult){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succes! - All operation have well done");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Conversion from [Decimal system]");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" >> ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(_sysNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-system is ok. ");
            Console.WriteLine();
            Console.Write("Resoult: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(resoult);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void UserInput(){
            Console.Write("Please type the decimal number: ");
            int decNumber = Int32.Parse(Console.ReadLine());

            Console.Write("\nPlease type the conversion system number");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(egzample: 8 == octal system): ");
            Console.ForegroundColor = ConsoleColor.White;
            int sysNumber = Int32.Parse(Console.ReadLine());

            if(sysNumber > 0 && decNumber > 0 )
            {
                _sysNumber = sysNumber;
                _decNumber = decNumber;
            }
            else
            {
                throw new ArgumentException("Please type other number greater than 0");
            }
        }
    }
}
