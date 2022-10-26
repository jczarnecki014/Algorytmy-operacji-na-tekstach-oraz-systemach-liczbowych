using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythims
{
    public class XSystemToDec:IAlgorythims
    {
        private double _sysNumber{ get;set;}
        private string _XSysNumber{ get;set;}
        private int _resoult = 0;

        public XSystemToDec(){
            UserInput();
            Run();
        }
        public void Run()
        {
            int index = 0;
            for(int i = (_XSysNumber.Length-1); i>=0; i--)
            {
                double XSysNumber;
                if(_XSysNumber[index] >= 65) //Program check that Number is a Letter
                {
                    XSysNumber = (_XSysNumber[index] - 65)+10;
                }
                else if(_XSysNumber[index] >= 90) //Letter can not be grather than "Z" ASCI Z = 90
                {
                    throw new Exception("This algoryhims not support more than 36-position systems");
                }
                else
                {
                    XSysNumber = double.Parse(_XSysNumber[index].ToString()); // I need to convert a Char object into string because number in char represent only ASCI value
                }
                if(XSysNumber >= _sysNumber)
                {
                    throw new Exception($"Number {XSysNumber} is not in the range {_sysNumber}-system"); //User can not use letter whitch is out of the range in used system
                }
                _resoult += (int) (Math.Pow(_sysNumber, i)*XSysNumber);
                index++;
            }
            printResoult(_resoult);
        }
        private void printResoult(int resoult){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succes! - All operation have well done");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Conversion from ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(_sysNumber);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" >> ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Decimal System is ok");
            Console.WriteLine();
            Console.Write("Resoult: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(resoult);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void UserInput(){
            Console.Write("Please type the xSystem number: ");
            string XSysNumber = Console.ReadLine();
            Console.Write("\nPlease type used system");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("(egzample: 8 == octal system): ");
            Console.ForegroundColor = ConsoleColor.White;
            int sysNumber = Int32.Parse(Console.ReadLine());

            if(sysNumber > 0 && XSysNumber != "")
            {
                _sysNumber = sysNumber;
                _XSysNumber = XSysNumber.ToUpper();
            }
            else
            {
                throw new ArgumentException("Please type other number greater than 0");
            }
        }
    }
}
