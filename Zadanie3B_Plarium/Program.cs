using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3B_Plarium
{
    class Program
    {

       
            public struct Coords
            {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double X { get;  }
            public double Y { get;  }
            public void info() 
            {
                Console.WriteLine($"x: {X} and y: {Y}");


            }
        }

        public class Ygolnik {
           private List<Coords> cords = new List<Coords>();
            public Ygolnik()
            {
                for(int i =0; i < 4; i++)
                {
                    double inputx, inputy;
                    Console.WriteLine($"Введите координату х точки №{i+1}");
                    while (!double.TryParse(Console.ReadLine(), out inputx)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
                {
                    Console.WriteLine($"Ошибка ввода! Введите число");
                }
                    Console.WriteLine($"Введите координату х точки №{i+1}");
                    while (!double.TryParse(Console.ReadLine(), out inputy)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
                    {
                        Console.WriteLine($"Ошибка ввода! Введите число");
                    }
                    cords.Add(new Coords(inputx, inputy));
                }
                
            }

            public void GetInfo()
            {
                
                cords[0].info();
                cords[1].info();
                cords[2].info();
                cords[3].info();
            }
            public void GetParalelogram()
            {
                //диагонали AC и BD четырёхугольника ABCD обозначим, как l и m, они являются векторами
                 double l = Math.Sqrt((cords[2].X - cords[0].X) * (cords[2].X - cords[0].X) + (cords[2].Y - cords[0].Y) * (cords[2].Y - cords[0].Y));
                 double m = Math.Sqrt((cords[3].X - cords[1].X) * (cords[3].X - cords[1].X) + (cords[3].Y - cords[1].Y) * (cords[3].Y - cords[1].Y));
                if (((cords[2].X - cords[1].X) * (cords[3].Y - cords[0].Y) == (cords[3].X - cords[0].X) * (cords[2].Y - cords[1].Y)) || ((cords[1].X - cords[0].X) * (cords[2].Y - cords[3].Y) == (cords[2].X - cords[3].X) * (cords[1].Y - cords[0].Y)))
                {
                    if (((cords[1].X - cords[0].X) * (cords[2].Y - cords[3].Y) == (cords[2].X - cords[3].X) * (cords[1].Y - cords[0].Y)) && ((cords[2].X - cords[1].X) * (cords[3].Y - cords[0].Y) == (cords[3].X - cords[0].X) * (cords[2].Y - cords[1].Y)))
                        if (l == m)
                            Console.WriteLine($"фигура с координатами:A=({cords[0].X},{cords[0].Y}) B=({cords[1].X},{cords[1].Y}) C=({cords[2].X},{cords[2].Y}) D=({cords[3].X},{cords[3].Y}) является Прямоугольником");
                        else
                        {
                            Console.WriteLine($"фигура с координатами:A=({cords[0].X},{cords[0].Y}) B=({cords[1].X},{cords[1].Y}) C=({cords[2].X},{cords[2].Y}) D=({cords[3].X},{cords[3].Y}) является Параллелограммом");
                        }
               
                }
           
            }
            public void GetTrapesion()
            {

                if (((cords[2].X - cords[1].X) * (cords[3].Y - cords[0].Y) == (cords[3].X - cords[0].X) * (cords[2].Y - cords[1].Y)) || ((cords[1].X - cords[0].X) * (cords[2].Y - cords[3].Y) == (cords[2].X - cords[3].X) * (cords[1].Y - cords[0].Y)))
                {
                    if (((cords[1].X - cords[0].X) * (cords[2].Y - cords[3].Y) != (cords[2].X - cords[3].X) * (cords[1].Y - cords[0].Y)) && ((cords[2].X - cords[1].X) * (cords[3].Y - cords[0].Y) == (cords[3].X - cords[0].X) * (cords[2].Y - cords[1].Y)))
                       
                   
                    {
                        Console.WriteLine($"фигура с координатами:A=({cords[0].X},{cords[0].Y}) B=({cords[1].X},{cords[1].Y}) C=({cords[2].X},{cords[2].Y}) D=({cords[3].X},{cords[3].Y}) является Трапецией");
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            Ygolnik u = new Ygolnik();
            u.GetParalelogram();
            System.Console.ReadKey(true);
        }
    }
}
