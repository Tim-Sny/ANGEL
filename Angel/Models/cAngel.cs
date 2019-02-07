using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Angel
{
    public class cAngel
    {
        public string Name;
        public int Sex { get; set; }
        public cPractice Practice;
        public Guid ID;

        public List<cCharacteristic> Character = new List<cCharacteristic>();
        public cCharacteristic _Force    = new cCharacteristic(); //СИЛА
        public cCharacteristic _Physique = new cCharacteristic(); //СЛОЖЕНИЕ
        public cCharacteristic _Agility  = new cCharacteristic(); //ЛОВКОСТЬ
        public cCharacteristic _Wisdom   = new cCharacteristic(); //УМ
        public cCharacteristic _Magic    = new cCharacteristic(); //МАГИЯ
        public cCharacteristic _Luck     = new cCharacteristic(); //УДАЧА
        public cCharacteristic _Battle   = new cCharacteristic(); //Боевые пункты
        public cCharacteristic _Bonus    = new cCharacteristic(); //Свободные штришки
        public cCharacteristic _Life     = new cCharacteristic(); //Жизненные Силы
        public cCharacteristic _Risk     = new cCharacteristic(); //Очки Риска
        public cCharacteristic _Science  = new cCharacteristic(); //Единицы Наук
        public cCharacteristic _Spirit   = new cCharacteristic(); //Спирит-Силы


        public void SetStartValues(int days, int value) //Установка начальных значений
        {
            Practice.DaysOfActivity = days;

            foreach (cCharacteristic c in Character)
            {
                if (Character.IndexOf(c) > 5)
                    c.Value = 0;
                else
                    c.Value = value;
            }
            fMain.oSchool.ProcessDependencies(this);
        }
        public void EngadeInActivity(int activity) //Провести день ТРЕНИРОВКА/ВРЕМЯ/ОТДЫХ
        {
            int[] _Points = fMain.oSchool.EngadeInActivity(activity, this); // Рассчитали массив штришков...
        }
        public void SetShift(int _shift) //Установка начальных значений
        {
            Character.ForEach(c => c.Shift = _shift);
        }
        public string GetPracticeString() //Получить строковые коды стажа
        {
            string res = "";

            for (int n = 0; n < Practice.Day.Count; n++)
            {
                if (Practice.Day[n].Activity >= 0)
                    res += ((n == 0) ? "" : ":") + fMain.oSchool.Activity[Practice.Day[n].Activity].Code;
            }

            return res;
        }
        public cAngel()
        {
            _Battle.HasMax  = 
            _Bonus.HasMax   = 
            _Life.HasMax    = 
            _Risk.HasMax    =
            _Science.HasMax =
            _Spirit.HasMax  = true;

            Practice = new cPractice();
            Practice.DaysOfActivity = 7;

            Character.Add(_Force); 
            Character.Add(_Physique); 
            Character.Add(_Agility); 
            Character.Add(_Wisdom); 
            Character.Add(_Magic); 
            Character.Add(_Luck); 
            Character.Add(_Battle);
            Character.Add(_Bonus);
            Character.Add(_Life);
            Character.Add(_Risk);
            Character.Add(_Science);
            Character.Add(_Spirit);
        }
    }

    public class cDayOfActivity
    {
        public int Activity;
        public int[] Character;

        public cDayOfActivity(int a, int[] c)
        {
            Activity = a;
            Character = c;
        }
    }

    public class cPractice
    {
        public List<cDayOfActivity> Day;
        public Control DaysLeftControl;
        public Control DaysTotalControl;

        public cDayOfActivity this[int index] // Индексатор...
        {
            get { return Day[index]; }
            set
            { 
                if (index >= Day.Count)
                    Day.Add(value);
                else
                    Day[index] = value;
                if (DaysLeftControl is Control) ((Control)DaysLeftControl).Text = DaysLeft.ToString();
            }
        }

        public int DaysOfActivity //Всего дней для активности/обучения
        {
            get { return Day.Capacity; }
            set
            {
                Day.Clear();
                Day.Capacity = value;
                if (DaysTotalControl is Control) ((Control)DaysTotalControl).Text = value.ToString();
                if (DaysLeftControl  is Control) ((Control)DaysLeftControl).Text  = DaysLeft.ToString();
            }
        }
        public int DayCurrent
        {
            get { return Day.Count; }
        }
        public int DaysLeft
        {
            get { return Day.Capacity - Day.Count; }
        }
        public int OfActivityTotal(int a) //Общий стаж
        {
            return (from p in Day where p.Activity == a select p).Count();
        }
        public int OfActivityContinuous(int a) //Непрерывный стаж
        {
            int res = 0;

            if (DayCurrent > 0)
                for (int i = DayCurrent - 1; i > -1; i--)
                    if (Day[i].Activity == a)
                        res += 1;
                    else
                        break;

            return res;
        }
        public cPractice() 
        {
            Day = new List<cDayOfActivity>();
        }
   }
}


