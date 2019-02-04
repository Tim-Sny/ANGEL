using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angel.Models
{
    class cFunc
    {
        public static string[] WeekDay = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        public static string ArrToStr(int[] Arr)//Массив в строку
        {
            string Str = "";

            for (int n = 0; n < Arr.Length; n++)
            {
                Str = Str + ((n == 0) ? "" : "; ") + Sign(Arr[n]);
            }
            return Str;
        }
        public static int IntArraySum(int[] a) //Сумма массива целых значений
        {
            int S = 0;
            for (int n = 0; n < a.Length; n++) S = S + a[n];
            return S;
        }
        public static string Sign(int n)    //Добавить знак + к целому положительному числу
        {
            return ((n > 0) ? "+" : "") + n.ToString();
        }
        public static string Sign(double n) //Добавить знак + к дробному положительному числу
        {
            return ((n > 0) ? "+" : "") + n.ToString();
        }
        public static string Sign(string n) //Добавить знак + к дробному положительному числу
        {
            return ((int.Parse(n) > 0) ? "+" : "") + n;
        }
        public static int LevelToPoints(int l)        //Перевести уровень в штришки
        {
            return (l * (l + 1)) / 2;
        }
        public static int LevelToPoints(int l, int p) //Перевести уровень в штришки
        {
            return (l * (l + 1)) / 2 + p;
        }
        public static int[] PointsToLevel(int p) //Перевести штришки в уровень
        {
            int[] Result = new int[2];
            Result[0] = (int)((Math.Sqrt(1 + 8 * p) - 1) / 2);
            Result[1] = p - (Result[0] * (Result[0] + 1)) / 2; 
            return Result;
        }
        public static string ToRoman(int number) //Римские числа
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M"  + ToRoman(number - 1000);
            if (number >=  900) return "CM" + ToRoman(number -  900); 
            if (number >=  500) return "D"  + ToRoman(number -  500);
            if (number >=  400) return "CD" + ToRoman(number -  400);
            if (number >=  100) return "C"  + ToRoman(number -  100);
            if (number >=   90) return "XC" + ToRoman(number -   90);
            if (number >=   50) return "L"  + ToRoman(number -   50);
            if (number >=   40) return "XL" + ToRoman(number -   40);
            if (number >=   10) return "X"  + ToRoman(number -   10);
            if (number >=    9) return "IX" + ToRoman(number -    9);
            if (number >=    5) return "V"  + ToRoman(number -    5);
            if (number >=    4) return "IV" + ToRoman(number -    4);
            if (number >=    1) return "I"  + ToRoman(number -    1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}
