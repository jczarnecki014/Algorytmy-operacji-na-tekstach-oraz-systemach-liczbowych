using Algorythims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class Menu
    {
        public static List<string> options = new List<string>(){"Algorytm znajdywania Palindromów ",
                                                                "Algorytm Boyera-Moore’a",
                                                                "Algorytm zamiany liczby dziesiętnej na dowolny system",
                                                                "Algorytm zamiany z dowolnego systemu na system dziesiętny" };
        public static void ShowMenu()
        {
            header.showHeader("Algorytmy operacji na tekstach oraz systemach liczbowych");
            for(int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"[{i}] {options[i]}");
            }
            Console.Write("Option: ");
        }
        public static IAlgorythims Execute(ConsoleKeyInfo option)
        {
            Console.Clear();
            switch(option.KeyChar)
            {
                case '0':
                    header.showHeader("FIND PALINDROM");
                    return new Palindrom();
                break;

                case '1':
                    header.showHeader("Algorythim Boyera-Moore’a");
                    return new BoyerAndMoore();
                break;

                case '2':
                    header.showHeader("(Dec2Any)");
                    return new DecToAnyConversion();
                break;

                case '3':
                    header.showHeader("(Any2Dec)");
                    return new XSystemToDec();
                break;

                default:
                    throw new Exception("Sorry... but function with this index is not implemented");
            }
        }
    }
    
