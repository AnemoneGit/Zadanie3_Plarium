using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*7. Погода. В сущностях (типах) хранится информация о погоде в различных регионах.
Для погоды необходимо хранить:
— регион;
— дату;
— температуру;
— осадки.
Для регионов необходимо хранить:
— название;
— площадь;
— тип жителей.
Для типов жителей необходимо хранить:
— название;
— язык общения.
Вывести сведения о погоде в заданном регионе.
Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке.
Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной.
*/
namespace Zadanie3C_Plarium
{
    class Program
    {
        static void Main(string[] args)
        {
            //листы в которых храниться информацыя о необходимых классах
            List<People> peoples = new List<People>();
            List<Region> regions = new List<Region>();
            List<Pogoda> pogodas = new List<Pogoda>();
            //чтоб не задавать каждый раз в ручную
            #region Начальные значения 
            peoples.Add(new People("Евреи", "иврит"));
            peoples.Add(new People("Англичане", "английский"));

            regions.Add(new Region("Британия", 7000, peoples[1]));
            regions.Add(new Region("Израиль", 10000, peoples[0]));
            regions.Add(new Region("Шотландия", 4000, peoples[1]));

            pogodas.Add(new Pogoda(regions[0], new DateTime(2021, 10, 15, 00, 00, 00), 3, "Дождь"));
            pogodas.Add(new Pogoda(regions[0], new DateTime(2021, 10, 13, 00, 00, 00), -3, "Снег"));
            pogodas.Add(new Pogoda(regions[0], new DateTime(2021, 10, 3, 00, 00, 00), 13, "Солнце"));

            pogodas.Add(new Pogoda(regions[1], new DateTime(2021, 10, 12, 00, 00, 00), -6, "Снег"));
            pogodas.Add(new Pogoda(regions[1], new DateTime(2021, 10, 13, 00, 00, 00), -3, "Снег"));
            pogodas.Add(new Pogoda(regions[1], new DateTime(2021, 10, 7, 00, 00, 00), 13, "Дождь")); 
            
            pogodas.Add(new Pogoda(regions[2], new DateTime(2021, 10, 14, 00, 00, 00), 3, "Дождь"));
            pogodas.Add(new Pogoda(regions[2], new DateTime(2021, 10, 13, 00, 00, 00), 13, "Снег"));
            pogodas.Add(new Pogoda(regions[2], new DateTime(2021, 10, 15, 00, 00, 00), 13, "Солнце"));
            #endregion
            Pogoda p = new Pogoda(regions[0], new DateTime(2021, 10, 15, 00, 00, 00), 3, "Дождь");
            p.GetPogoda(pogodas, regions[0]);//1 задание
            System.Console.ReadKey(true);
            p.GetData(pogodas, regions[1],"Снег",0);//2 задание
            System.Console.ReadKey(true);
            p.GetPogoda(pogodas, "английский");//3 задание
            System.Console.ReadKey(true);
            p.GetTemp(pogodas,6000,regions);//4 задание
            System.Console.ReadKey(true);

        }
    }
}
