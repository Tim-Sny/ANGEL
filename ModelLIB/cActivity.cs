using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLIB
{
    public class cActivity
    {
        public string Name;               //Название характеристики (Массив названий)...
        public string TypeName;           //Тип (Тренировка, Время, Отдых)...
        public int Type;                  //Тип (0, 1, 2)...
        public int[] WeekDayEnable;       //Доступность по дням недели...
        public int[][][] Growth;          //Изменение характеристики [ID Характеристики][Уровень/День недели][Изменение]...
        public int Max;                   //Максимальное количество использования данной активности...
        public int Tag;                   //ТЭГ...
        public string Descr;              //Описание...
        public string Code;               //Буквенный код...

        public float GetGrowthAvg(int c, int d)
        {
            return (float)(cFunc.IntArraySum(Growth[c][d])) / Growth[c][d].Length;
        }
        public float GetGrowthAvgSum(int c, int d)
        {
            float sum = 0;
            for (int n = 0; n <= d; n++)
            {
                if (!(c == 6 && n == 0)) //В случае рассчёта для БП не учитывать поле выбора (ComboBox) в столбце первого дня... 
                {
                    sum = sum + GetGrowthAvg(c, n);
                }
            }
            return sum;
        }
        public int GetGrowthMin(int c, int d)
        {
            int min = Growth[c][d][0];
            for (int n = 0; n < Growth[c][d].Length; n++)
            {
                min = (Growth[c][d][n] < min) ? Growth[c][d][n] : min;
            }
            return min;
        }
        public int GetGrowthMinSum(int c, int d)
        {
            int sum = 0;
            for (int n = 0; n <= d; n++)
            {
                sum = sum + GetGrowthMin(c, n);
            }
            return sum;
        }
        public int GetGrowthMax(int c, int d)
        {
            int max = Growth[c][d][0];
            for (int n = 0; n < Growth[c][d].Length; n++)
            {
                max = (Growth[c][d][n] > max) ? Growth[c][d][n] : max;
            }
            return max;
        }
        public int GetGrowthMaxSum(int c, int d)
        {
            int sum = 0;
            for (int n = 0; n <= d; n++)
            {
                sum = sum + GetGrowthMax(c, n);
            }
            return sum;
        }
        public int GetGrowthRND(int c, int d)
        {
            Random rand = new Random();
            int n = rand.Next(0, Growth[c][d].Length);

            return Growth[c][d][n];
        }
        public bool IsActiveByWeekDay(int d)
        {
            bool res;

            res = (WeekDayEnable[d] == 1);

            return res;
        }
        public bool IsActive(int d, int exp)
        {
            bool res;

            res = (WeekDayEnable[d] == 1 && exp < Max);

            return res;
        }

        public cActivity()
        {
            Name = "Наименование";
            Type = 0;
            WeekDayEnable = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

            //Growth = new int[cSchool.NumCharacter][][];
            //for (int i = 0; i < Growth.Length; i++)
            //{
            //    Growth[i] = new int[cSchool.NumDay][];
            //    for (int j = 0; j < Growth[i].Length; j++)
            //    {
            //        Growth[i][j] = new int[] { 0 };
            //    }
            //}
        }
    }
}
