using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySpell
{
    public class spellClass
    {
        public string spell(DateTime date)
        {
            string dayNow = "", monthNow = "", yearNow = "";
            string[] daySecondWord = { "", "первое", "второе", "третье ", "четвертое", "пятое", "шестое", 
                                 "седьмое", "восьмое", "девятое" };
            string[] dayFirstWord = { "", "", "двадцать", "тридцать" };
            string[] day11_19 = { "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцатое", "шестнадцатое", 
                                 "семнадцатое", "восемнадцатое", "девятнадцатое"};
            string[] day10_20_30 = { "десятое", "двадцатое", "тридцатое", "сороковое", "пятидесятое", "шестидесятое", "семидесятое", "восьмидесятое", "девяностое" };

            string[] month = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", 
                                 "августа", "сентября", "октября", "ноября", "декабря" };

            string[] yearY = { "одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] yearY1000_2000 = { "", "", "двух", "трёх", "четырёх", "пяти", "шести", "семи", "восеми", "девяти" };
            string[] yearE = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] yearE100_200 = { "", "сотого", "двухсотого", "трехсотого", "четырехсотого", "пятисотого", "шестисотого", "семисотого", "восьмисотого", "девятисотого" };
            string[] yearA = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

            if (date.Day % 10 == 0)
                dayNow = day10_20_30[date.Day / 10 - 1];
            else if (date.Day / 10 != 1)
                dayNow = dayFirstWord[date.Day / 10] + " " + daySecondWord[date.Day % 10];
            else
                dayNow = day11_19[date.Day % 10 - 1];

            monthNow = month[date.Month - 1];

            int y = date.Year / 1000,
                e = date.Year / 100 % 10,
                a = date.Year % 100 / 10,
                r = date.Year % 10;
            if (y > 0)
                if (e == 0 && a == 0 && r == 0)
                {
                    yearNow += yearY1000_2000[y] + "тысячного года";
                    return dayNow.Replace("  ", " ").Trim() + " " + monthNow.Replace("  ", " ").Trim() + " " + yearNow.Replace("  ", " ").Trim();
                }
                else
                    yearNow = yearY[y - 1] + " тысяч";

            if (y == 1)
                yearNow += "а ";
            else if (y == 2 || y == 3 || y == 4)
                yearNow += "и ";

            if (a != 0 || r != 0)
                yearNow += yearE[e] + " ";
            else
            {
                yearNow += yearE100_200[e] + " года";
                return dayNow.Replace("  ", " ").Trim() + " " + monthNow.Replace("  ", " ").Trim() + " " + yearNow.Replace("  ", " ").Trim();
            }

            if (a != 0 && r == 0)
                yearNow += day10_20_30[a - 1].Substring(0, day10_20_30[a - 1].Length - 1) + "го" + " года";
            else if (a != 1)
                yearNow += yearA[a] + " ";
            else
            {
                yearNow += day11_19[r - 1].Substring(0, day11_19[r - 1].Length - 1) + "го года";
                return dayNow.Replace("  ", " ").Trim() + " " + monthNow.Replace("  ", " ").Trim() + " " + yearNow.Replace("  ", " ").Trim();
            }

            if (r > 0)
                yearNow += daySecondWord[r].Substring(0, daySecondWord[r].Length - 1) + "го года";

            dayNow = dayNow.Replace("  ", " ").Trim();
            monthNow = monthNow.Replace("  ", " ").Trim();
            yearNow = yearNow.Replace("  ", " ").Trim();

            return dayNow.Replace("  ", " ").Trim() + " " + monthNow.Replace("  ", " ").Trim() + " " + yearNow.Replace("  ", " ").Trim();
        }
    }
}
