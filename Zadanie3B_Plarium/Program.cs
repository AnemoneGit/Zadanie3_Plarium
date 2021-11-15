using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3B_Plarium
{
    class Program
    {
        /*3. Четырехугольники. В сущностях (типах) хранятся координаты вершин выпуклых четырехугольников на плоскости.
Вывести координаты вершин параллелограммов.
Вывести координаты вершин трапеций.
*/

        public class Ygolnik //класс в котором хранятся координаты и методы для фигуры
        {

            private List<Tuple<double, double>> cords = new List<Tuple<double, double>>();//лист кортежей в котором будут храниться координаты фигуры

            public Ygolnik()//конструктор в котором пользователь введет координаты
            {
                for(int i =0; i < 4; i++)
                {
                    double inputx, inputy;
                    Console.WriteLine($"Введите координату х точки №{i+1}");
                    while (!double.TryParse(Console.ReadLine(), out inputx)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
                {
                    Console.WriteLine($"Ошибка ввода! Введите число");
                }
                    Console.WriteLine($"Введите координату y точки №{i+1}");
                    while (!double.TryParse(Console.ReadLine(), out inputy)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
                    {
                        Console.WriteLine($"Ошибка ввода! Введите число");
                    }
                    //cords.Add(new Coords(inputx, inputy));
                    cords.Add(Tuple.Create(inputx, inputy));
                }
                
            }

     
            public void GetParalelogram()//метод для определения является ли четырехугольник паралелограммом
            {
                //диагонали AC и BD четырёхугольника ABCD обозначим, как l и m, они являются векторами
                 double l = Math.Sqrt((cords[2].Item1 - cords[0].Item1) * (cords[2].Item1 - cords[0].Item1) + (cords[2].Item2 - cords[0].Item2) * (cords[2].Item2 - cords[0].Item2));
                 double m = Math.Sqrt((cords[3].Item1 - cords[1].Item1) * (cords[3].Item1 - cords[1].Item1) + (cords[3].Item2 - cords[1].Item2) * (cords[3].Item2 - cords[1].Item2));
                if (((cords[2].Item1 - cords[1].Item1) * (cords[3].Item2 - cords[0].Item2) == (cords[3].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[1].Item2)) || ((cords[1].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[3].Item2) == (cords[2].Item1 - cords[3].Item1) * (cords[1].Item2 - cords[0].Item2)))
                {
                    if (((cords[1].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[3].Item2) == (cords[2].Item1 - cords[3].Item1) * (cords[1].Item2 - cords[0].Item2)) && ((cords[2].Item1 - cords[1].Item1) * (cords[3].Item2 - cords[0].Item2) == (cords[3].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[1].Item2)))
                        if (l == m)
                            Console.WriteLine($"фигура с координатами:A=({cords[0].Item1},{cords[0].Item2}) B=({cords[1].Item1},{cords[1].Item2}) C=({cords[2].Item1},{cords[2].Item2}) D=({cords[3].Item1},{cords[3].Item2}) является Прямоугольником");
                        else
                        {
                            Console.WriteLine($"фигура с координатами:A=({cords[0].Item1},{cords[0].Item2}) B=({cords[1].Item1},{cords[1].Item2}) C=({cords[2].Item1},{cords[2].Item2}) D=({cords[3].Item1},{cords[3].Item2}) является Параллелограммом");
                        }
               
                }
           
            }
            public void GetTrapesion()//метод для определения является ли четырехугольник трапецией
            {

                if (((cords[2].Item1 - cords[1].Item1) * (cords[3].Item2 - cords[0].Item2) == (cords[3].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[1].Item2)) || ((cords[1].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[3].Item2) == (cords[2].Item1 - cords[3].Item1) * (cords[1].Item2 - cords[0].Item2)))
                {
                    if (((cords[1].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[3].Item2) != (cords[2].Item1 - cords[3].Item1) * (cords[1].Item2 - cords[0].Item2)) && ((cords[2].Item1 - cords[1].Item1) * (cords[3].Item2 - cords[0].Item2) == (cords[3].Item1 - cords[0].Item1) * (cords[2].Item2 - cords[1].Item2)))
                       
                   
                    {
                        Console.WriteLine($"фигура с координатами:A=({cords[0].Item1},{cords[0].Item2}) B=({cords[1].Item1},{cords[1].Item2}) C=({cords[2].Item1},{cords[2].Item2}) D=({cords[3].Item1},{cords[3].Item2}) является Трапецией");
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            Ygolnik u = new Ygolnik();//создаем фигуру
            u.GetParalelogram();//проверяем на паралелограмм
            u.GetParalelogram();//проверяем на трапецию
            System.Console.ReadKey(true);
        }
    }
}
