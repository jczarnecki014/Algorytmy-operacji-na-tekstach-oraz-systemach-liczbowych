using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythims
{
    public class Palindrom:IAlgorythims
    {
        private string TextT { get;set;}

        public Palindrom ()
        {
            UserInput();
            Run();
        }

        public void Run()
        {
            string text = TextT.ToUpper();
            int indexStart = 0;
            int indexEnd = (text.Length-1);

           /* if(isPalindrom(text))
            {
                Console.WriteLine(text);
            }*/
            
           
                while(indexStart < text.Length-1)
                 {
                    if(text[indexStart] == text[indexEnd])
                    {
                        string tempString = sub(text,indexStart,indexEnd);
                        if(isPalindrom(tempString))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(tempString);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    indexEnd--;
                     if(indexEnd == indexStart)
                     {
                         indexStart++;
                         indexEnd = (text.Length-1);
                     }
                }
            }
                
        
        public bool isPalindrom(string str)
        {
            bool condition = true;
            int endIndex = str.Length-1;
            for(int i=0; i<str.Length; i++)
            {
                if(str[i] != str[endIndex-i])
                {
                    condition = false;
                    break;
                }
            }
            return condition;
        }
        public string sub(string str,int indexStart,int indexStop)
        {
            int index = indexStart;
            string temp = "";
            while(index<=indexStop)
            {
                temp += str[index];
                index++;
            }
            return temp;
        }

        public void UserInput()
        {
            Console.Write("Type text: ");
            string text = Console.ReadLine();
            if(text.Length > 1)
            {
                TextT = text;
            }
            else
            {
                throw new ArgumentException("Sorry but palindrom need minimum two chars to can exist");
            }
            
        }
    }
}

