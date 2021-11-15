using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_Plarium
{
    /*
 Вариант А 
 Создать консольное приложение, используя тип string (StringBuilder).
 Программа принимает строку. 
 По нажатию произвольной клавиши поочередно выделяет в тексте заданное слово (заданное слово вводится с клавиатуры); 
 Ищет в ней глаголы и возвращает в консоль строку без глаголов.
 Для выполнения задания создать массив строк и проинициализировать его несколькими окончаниями, которые есть у глаголов, например, “ать”, “ять” и т.д. Слово из входной строки соответствует глаголу, если оно содержит одно из этих окончаний.
 Найти во входной строке слова с одинаковым основанием (совпадающие части двух и более слов, 3 буквы и более) и разбить эти слова на 3 части
 – префикс, то что стоит до основания слева,
 – основа, то что совпадает с частью другого слова,
 – окончание.
 Обратите внимание, что некоторые из этих 1,3 частей могут отсутствовать.
 */
    class Program
    {
        #region Методы для выполнения задания
        static void taskA1(string s) // По нажатию произвольной клавиши поочередно выделяет в тексте заданное слово (заданное слово вводится с клавиатуры)
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

        static void taskA2(string s) // метод ищет в строке глаголы и возвращает в консоль строку без глаголов.
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

        static void taskA3(string s) //Метод найходит во входной строке слова с одинаковым основанием (совпадающие части двух и более слов, 3 буквы и более) и разбить эти слова на 3 части
        {
            
            string text;int j = 0;
            bool bol = true;
            string[] splite = s.Split(new char[] { ' ', ',', '.', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string str in splite)
            {
                
                for (int i=0; i < str.Length-4; i++)
                {
                   text = str.Substring(i,i+3);
                    bol = false;
                    for(int t = 0; t < splite.Length; t++)
                    {
                        if (t != j)
                        {
                            if (splite[t].Contains(text))
                            {
                                Console.Write(splite[t].Insert(splite[t].IndexOf(text),"-").Insert(splite[t].IndexOf(text)+4, "-")+" ");
                                bol = true;
                            }
                        }
                    }
                    if(bol) Console.Write(splite[j].Insert(splite[j].IndexOf(text), "-").Insert(splite[j].IndexOf(text) + 4, "-") + "\n");
                }
                j++;
            }

        }
        #endregion


        static void Main(string[] args)
        {
            bool Flag = true;
            Console.WriteLine($"Управляющие команды: \n" +
             $"1-Задание 1\n" +
             $"2-Задание 2\n" +
             $"3-Задание 3\n" +
             $"0-Выход\n");
            while (Flag)
            {
            Console.Write("Введите текст строки: ");
            string swflag = Console.ReadLine();
                switch (swflag)
                {
                    case "1"://задание 1
                        {
                            try
                            {
                                Console.Write("Введите текст строки: ");
                                string text = Console.ReadLine();
                                taskA1(text);//вызов метода
                            }
                            catch
                            {
                                Console.Write("возникла ошибка");

                            }

                            break;
                        }
                    case "2"://задание 2
                        {
                            try
                            {
                                Console.Write("Введите текст строки: ");
                                string text = Console.ReadLine();
                                taskA2(text);//вызов метода
                            }
                            catch
                            {
                                Console.Write("возникла ошибка");

                            }

                            break;
                        }
                    case "3"://зажание 3
                        {
                            try
                            {
                                Console.Write("Введите текст строки: ");
                                string text = Console.ReadLine();
                                taskA3(text);//вызов метода
                            }
                            catch
                            {
                                Console.Write("возникла ошибка");

                            }

                            break;
                        }
                    case "0"://завершение программы
                        {

                            Console.WriteLine($"Программа завершена");
                            break;
                        }
                    default://неизвестное значение
                        {
                            Console.WriteLine($"такого значения не предусмотрено");
                            break;
                        }
                }
            }
                    System.Console.ReadKey(true);
        }
    }
}
