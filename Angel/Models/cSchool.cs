using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Angel.Models;
using System.Linq;

namespace Angel
{

    public class cSchool
    {
        public static int NumberActivity { get { return 12; } }
        public static int NumCharacter   { get { return  7; } }
        public static int NumDay         { get { return  7; } }

        public cActivity[] Activity;
        private int[,] Scores;
        private int[,] RestEdenBonusPoints = new int[7, 2] { { 1, 0 }, { 3, 1 }, { 5, 3 }, { 7, 6 }, { 9, 10 }, { 11, 15 }, { 13, 21 } }; //{ FreePoints, to random ch }
        private List<cDependence> Dependencies; //Характеристика, Уровень (в штришках), Зависимая характеристика, Значение зависимой характеристики...
         

        public List<cSex> Sex = new List<cSex>();
        public List<cCharacterInfo> CharacterInfo = new List<cCharacterInfo>();

        public cSchool()
        {
            Activity = new cActivity[NumberActivity];
            for (int i = 0; i < Activity.Length; i++) { Activity[i] = new cActivity(); }

            CharacterInfo = new List<cCharacterInfo>();
            Dependencies = new List<cDependence>();

            Sex.Add(new cSex() { ID = 0, Name = "Андрогин" });
            Sex.Add(new cSex() { ID = 1, Name = "Мужчина"  });
            Sex.Add(new cSex() { ID = 2, Name = "Женщина"  });
        }
        public int Load()
        {
            DBEntities db = new DBEntities();

            // sActivity + sActivityType =================================
            var ATs = from a in db.sActivity
                      join t in db.sActivityType on a.IDsActivityType equals t.IDsActivityType
                      select new {
                         IDsActivity = a.IDsActivity,
                         Name = a.Name,
                         Descr = a.Descr,
                         IDsActivityType = t.IDsActivityType,
                         Max = t.Max
                    };
            foreach (var AT in ATs)
            {
                Activity[AT.IDsActivity].Name  = AT.Name;
                Activity[AT.IDsActivity].Descr = AT.Descr;
                Activity[AT.IDsActivity].Type  = AT.IDsActivityType;
                Activity[AT.IDsActivity].Max   = AT.Max;
            }

            // xActivityTrain =================================
            foreach (var ACN in db.xActivityCharacterN)
            {
                string[] _Values = ACN.Value.Split(';');
                Activity[ACN.IDsActivity].Growth[ACN.IDsCharacter][ACN.N] = new int[_Values.Length];
                for (int i = 0; i < _Values.Length; i++)
                    Activity[ACN.IDsActivity].Growth[ACN.IDsCharacter][ACN.N][i] = int.Parse(_Values[i]);
            }

            // xActivityDay =================================
            foreach (var AD in db.xActivityDay)
                Activity[AD.IDsActivity].WeekDayEnable[AD.N] = AD.Value;

            // sCharacter =================================
            CharacterInfo = (from CI in db.sCharacter
                             select new cCharacterInfo 
                             {
                                 ID       = CI.IDsCharacter,
                                 Name     = CI.Name,
                                 NameAlt  = CI.NameAlt,
                                 Descr    = CI.Descr
                             } ).ToList();

            // sScore =================================
            Scores = new int[db.sScore.Count(), 3];
            int n = 0;
            foreach (var Score in db.sScore)
            {
                Scores[n, 0] = Score.Points;
                Scores[n, 1] = Score.Score;
                Scores[n, 2] = Score.N;
                n++;
            }

            // xCharacterDependence =================================
            Dependencies = (from CD in db.vCharacterDependence
                       select new cDependence()
                       {
                           chr = CD.chr,
                           dep = CD.dep,
                           sex = CD.sex,
                           beg = CD.beg,
                           end = CD.end.Value,
                           val = CD.val.Value

                       }).ToList();

            return 0;
        }

        public int[] EngadeInActivity(int activity, cAngel angel) //Рассчёт накидок 
        {
            int[] _Points = new int[angel.Character.Count];
            int expCnt = angel.Practice.OfActivityContinuous(activity); //Кол-во дней непрерывного стажа...
            int expTtl = angel.Practice.OfActivityTotal(activity);     //Кол-во дней общего стажа...
            int dayWeek = angel.Practice.DayCurrent % 7;              //День недели...

            //ОСНОВНЫЕ НАКИДКИ Цикл по характеристикам...
            for (int i = 0; i < Activity[activity].Growth.Length; i++) 
            {
                if (i == 6 && Activity[activity].Type == 0) //Если это БП...
                {
                    if(expTtl == 0)
                    {
                        _Points[i] = GetNByPoints(angel.Character[Activity[activity].GetGrowthRND(i, expTtl)].Value);//Открытие потолка БП по характеритике...
                    }
                    else
                        _Points[i] = Activity[activity].GetGrowthRND(i, expTtl);
                }
                else //Если это стандартные характеристики...
                {
                    if (Activity[activity].Type == 0) //Если тип "ТРЕНИРОВКА", то по количеству дней...
                    {
                        _Points[i] = Activity[activity].GetGrowthRND(i, expTtl);
                    }
                    else //Если это "ВРЕМЯ" или "ОТДЫХ", то по дню недели...
                    {
                        _Points[i] = Activity[activity].GetGrowthRND(i, dayWeek);
                    }
                }
            }

            // ОТДЫХ В ЭДЕМЕ...
            if (activity == 10)
            {
                if (expCnt == 0)
                    //Если решили отдохнуть в Эдеме, а вчера тренировались и повысили характеристики на кол-во штришков кратное 3, то получаете за каждые 3 штришка +1 к росту этих характеристик...
                    if (angel.Practice.DayCurrent > 0 && Activity[angel.Practice[angel.Practice.DayCurrent - 1].Activity].Type == 0)
                        for (int c = 0; c < 6; c++)
                            if ((angel.Practice[angel.Practice.DayCurrent - 1].Character[c] % 3) == 0)
                                _Points[c] += angel.Practice[angel.Practice.DayCurrent - 1].Character[c] / 3;
                else 
                    _Points[RND(6)] += RestEdenBonusPoints[expCnt, 1];
                //А ещё штришки, который можете использовать в конце недели, чтобы поднять любую характеристику...
                _Points[7] = RestEdenBonusPoints[expCnt, 0];
            }
            //Если сегодня решили отдохнуть в Эдеме, а завтра тренировка, то сегодняшний отдых уменьшит все завтрашние потери на -2...
            if (angel.Practice.DayCurrent > 0 && Activity[activity].Type == 0 && angel.Practice[angel.Practice.DayCurrent - 1].Activity == 10)
                for (int c = 0; c < 6; c++)
                {
                    if (_Points[c] == -1) _Points[c] += 1;
                    if (_Points[c] <= -2) _Points[c] += 2;
                }

            // ОТДЫХ В МУДРОСТИ НАРУЧИ...
            if (activity == 11)
            {
                //Если сегодня, вы решили отдохнуть в мудрости, а вчера тренировались или проводили время и некоторые характеристики упали, то сегодняшний отдых уменьшит вчерашние потери на -3...
                if (angel.Practice.DayCurrent > 0 && Activity[angel.Practice[angel.Practice.DayCurrent - 1].Activity].Type != 2)
                    for (int c = 0; c < 6; c++)
                    {
                        if (angel.Practice[angel.Practice.DayCurrent - 1].Character[c] == -1) _Points[c] += 1;
                        if (angel.Practice[angel.Practice.DayCurrent - 1].Character[c] == -2) _Points[c] += 2;
                        if (angel.Practice[angel.Practice.DayCurrent - 1].Character[c] <= -3) _Points[c] += 3;
                    }
                //А ещё вы получили +2 штришка, которые можете использовать в конце недели для того, чтобы поднять любую характеристику на выбор...
                _Points[7] = 2;
                //Ещё +1 +1 +1 штришка случайно на три любые из характеристик немедленно. Такой рост на +2 на выбор и +3 случайно вы получаете за каждый день отдыха в мудрости...
                int i, x, y , z;
                i = 0;
                x = y = z = -1;
                while (i++ < 30)
                {
                    x = RND(6);
                    if(x != y)
                        if (y < 0) { _Points[x] += 1; y = x; }
                        else if (x != z)
                            if(z < 0) { _Points[x] += 1; z = x; }
                            else      { _Points[x] += 1; break; }
                }
            }
            //Если сегодня вы решили отдохнуть в мудрости, а завтра проведёте время с пользой и повысите одну из характеристик выше других, то получете ещё шесть штришков на сосдение характеристики...
            if (Activity[activity].Type == 1 && angel.Practice[angel.Practice.DayCurrent - 1].Activity == 11)
                switch (activity)
                {
                    case 1: //если вы повысите силу, собирая камни, то вы повысите и сложение на +6...
                        _Points[1] += 6;
                        break;
                    case 3: //если вы повысите сложение, собирая урожай, то вы повысите и силу на +3, и ловкость на +3...
                        _Points[0] += 3;
                        _Points[2] += 3;
                        break;
                    case 5: //если вы повысите ловкость, ловя и птиц и лисиц, то вы повысите и сложение на +6...
                        _Points[1] += 6;
                        break;
                    case 7: //если вы повысите мудрость, читая и слушая старших, то вы повысите и магию на +6...
                        _Points[4] += 6;
                        break;
                    case 9: //если вы повысите магию, сажать и поливая, то вы повысите и мудрость на +6...
                        _Points[3] += 6;
                        break;
                    default:
                        break;
                }

            for (int c = 0; c < _Points.Length; c++) // И увеличиваем характеристики...
            {

                if (c == 6) //Для БП накидки от Силы и Ловкости в Bonus, в Max - зависимость от сложения...
                    angel.Character[c].ShiftBonus(_Points[c]);
                else
                {
                    if (angel.Character[c].HasMax)
                        angel.Character[c].ShiftMax(_Points[c]);
                    angel.Character[c].ShiftValue(_Points[c]);
                }
                //angel.Character[c].Value = angel.Character[c].Value + _Points[c];

                ProcessDependencies(c, angel);
            }

            angel.Practice.Day.Add(new cDayOfActivity(activity, _Points)); // Добавляем день в опыт...


            return _Points;
        }
        public int ProcessDependencies(int c, cAngel angel)
        {
            var deps = (from d in Dependencies
                        where d.chr == c && angel._Physique.Value >= d.beg && angel._Physique.Value < d.end
                        select new { d.dep, d.val }).ToList();

            foreach (var dep in deps)
            {
                angel.Character[dep.dep].Value =
                angel.Character[dep.dep].Max = dep.val;
            }

            return 0;
        }
        public int ProcessDependencies(cAngel angel)
        {
            for(int c = 0; c < angel.Character.Count; c++)
            {
                var deps = (from d in Dependencies
                            where d.chr == c && angel._Physique.Value >= d.beg && angel._Physique.Value < d.end
                            select new { d.dep, d.val }).ToList();

                foreach (var dep in deps)
                {
                    angel.Character[dep.dep].Value =
                    angel.Character[dep.dep].Max = dep.val;
                }
            }

            return 0;
        }
        public int RND(int r) //Случайное целое [0..r-1]
        {
            Random rand = new Random();
            int n = rand.Next(0, r);
            return n;
        }
        public int GetScoreByPoints(int point) //Рассчитать оценку по штришкам
        {
            int n = 0;
            int res = -3;

            while (point >= Scores[n, 0])
            {
                res = Scores[n, 1];
                n++;
            }

            return res;
        }
        public int GetScoreByPoints(int level, int point) //Рассчитать оценку по уровню и штришкам
        {
            int n = 0;
            int res = -3;
            int points = ((level * (level + 1)) / 2) + point;

            while (points >= Scores[n, 0])
            {
                res = Scores[n, 1];
                n++;
            }

            return res;
        }
        public int GetNByPoints(int point) //Рассчитать N (для БП) по штришкам
        {
            int n = 0;
            int res = 0;

            while (point >= Scores[n, 0])
            {
                res = Scores[n, 2];
                n++;
            }

            return res;
        }
        public int GetNByPoints(int level, int point) //Рассчитать N (для БП) по уровню и штришкам
        {
            int n = 0;
            int res = 0;
            int points = ((level * (level + 1)) / 2) + point;

            while (points >= Scores[n, 0])
            {
                res = Scores[n, 2];
                n++;
            }

            return res;
        }
    }

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

        public float GetGrowthAvg(int c, int d)
        {
            return (float)(cFunc.IntArraySum(Growth[c][d])) / Growth[c][d].Length;
        }
        public float GetGrowthAvgSum(int c, int d)
        {
            float sum = 0;
            for (int n = 0; n <= d; n++)
            {
                if(!(c == 6 && n == 0)) //В случае рассчёта для БП не учитывать поле выбора (ComboBox) в столбце первого дня... 
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

            Growth = new int[cSchool.NumCharacter][][];
            for (int i = 0; i < Growth.Length; i++) {
                Growth[i] = new int[cSchool.NumDay][];
                for (int j = 0; j < Growth[i].Length; j++) {
                    Growth[i][j] = new int[] { 0 };
                }
            }
        }
    }

    public class cSex
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class cCharacterInfo
    {
        public int    ID      { get; set; }
        public string Name    { get; set; }
        public string NameAlt { get; set; }
        public string Descr   { get; set; }
        //public string NameEN { get; set; }
    }

    public class cDependence
    {
        public int chr; //Влияющая арактеристика
        public int dep; //Зависимая характеристика
        public int sex; //Пол 
        public int beg; //Начало диапазона штришков
        public int end; //Конец диапазона штришков
        public int val; //Значение
    }
}

