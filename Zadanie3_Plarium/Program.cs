using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_Plarium
{
   
    class Program
    {
        static void taskA1(string s)
        {
            Console.Write("Введите слово которое надо выделить: ");
            string slovo = Console.ReadLine();
            while (s.Contains(slovo))
            {
              string word = s.Substring(0, s.IndexOf(slovo));
              Console.Write(word);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(slovo);
                Console.ResetColor();
                s = s.Remove(0, word.Length + slovo.Length);
            }
            Console.WriteLine("\n");
        }

        static void taskA2(string s)
        {
            string[] end = { "ать","ять","ешь","ют" };
            bool test = true;
            string[] splite = s.Split(new char[] { ' ', ',', '.', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach(string str in splite)
            {
                test = true;
              foreach(string send in end)
                if (str.EndsWith(send))
                {
                        test = false;

                } 
                
               if(test) result.Append(str+" ");
            }
            Console.WriteLine(result);
        }

        static void taskA3(string s)
        {

        }
   
        static void Main(string[] args)
        {  
            Console.Write("Введите текст строки: ");
            string text = Console.ReadLine();
            taskA1(text);
            taskA2(text);
             System.Console.ReadKey(true);
        }
    }
}
