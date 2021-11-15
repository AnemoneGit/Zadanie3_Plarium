using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3C_Plarium
{
    class Pogoda//класс погоды(основной класс)
    {
       public Region reg;//регион по которому будет информация о погоде
       public DateTime date;//дата
        public decimal temp;//температура
        public string osad;//осадки

        public Pogoda(Region region, DateTime Date, decimal T, string Osad)
        {
        reg=region;
        date=Date;
        temp=T;
        osad=Osad;
        }

        public void GetPogoda(List<Pogoda> vezers, Region region)//Вывести сведения о погоде в заданном регионе
        {
            foreach (Pogoda pogoda in vezers)
                if (pogoda.reg.Nazva == region.Nazva)
            {
                Console.WriteLine($"В регионе {pogoda.reg.Nazva} {pogoda.date} числа, температура {pogoda.temp + "°C"} , осадки:{pogoda.osad}");
            }
            
        }

        public void GetData(List<Pogoda> vezers, Region region, string osadki, decimal zTemp)//Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
        {
            foreach (Pogoda pogoda in vezers)
                if (pogoda.reg.Nazva==region.Nazva && pogoda.osad ==osadki && zTemp> pogoda.temp)
                Console.WriteLine($" {pogoda.date} числа в регионе {pogoda.reg.Nazva}, температура {pogoda.temp + "°C"} была меньше заданной {zTemp + "°C"}, и были заданные осадки:{pogoda.osad}");
        }

        public void GetPogoda(List<Pogoda> vezers, string Lang)//Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке
        {
            
            foreach (Pogoda pogoda in vezers)
            {
                if (Lang == pogoda.reg.people.Langue && pogoda.date.AddDays(7)>=DateTime.Today)
                {
                    Console.WriteLine($"В регионе {pogoda.reg.Nazva} люди говорят на языке {Lang} {pogoda.date} числа, температура {pogoda.temp + "°C"}, осадки:{pogoda.osad}");
                }
            }
        }

        public void GetTemp(List<Pogoda> vezers, int Zplochad, List<Region> regions)//Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной
        {
            decimal srTemp=0;
            foreach (Region region in regions) {
                if (region.Plochad > Zplochad)
                    foreach (Pogoda pogoda in vezers)
                        if (pogoda.reg.Nazva == region.Nazva && pogoda.date.AddDays(7) >= DateTime.Today)
                            srTemp += pogoda.temp;

               Console.WriteLine($"В регионе {region.Nazva} средняя температура {srTemp+ "°C"}");
                srTemp = 0;
                }
             
        }

        public override string ToString()//переопределенный метод ToString
        {
            return $"Регион:\n{reg}\nДата:\n{date}\nТемпература: {temp+ "°C"}\nОсодки: {osad}\n";
        }
    }
}
