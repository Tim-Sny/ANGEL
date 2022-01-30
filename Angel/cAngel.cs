using ModelLIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AngelModel
{
    public class cAngel
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Sex { get; set; }
        public cPractice Practice { get; set; }

        public event EventHandler<eValueEventArgs> onValueChanged;

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

        public List<cThing> Things;
        public List<cChangeCharacteristic> Changes;

        public void AddThings(cThing _thing)
        {
            Things.Add(_thing);
            foreach (cChangeCharacteristic _change in _thing.Changes)
                if ((from c in Changes where c.ID == _change.ID select c).Count() == 0)
                {
                    Changes.Add(_change);
                    Character[_change.IDCharacter].EventInit();
                }

        }
        public void RemoveThings(cThing _thing)
        {
            foreach (cChangeCharacteristic _change in _thing.Changes)
            {
                var ch = (from c in Changes where c.ID == _change.ID select c).First();
                Changes.Remove(ch);
                Character[_change.IDCharacter].EventInit();
            }
            Things.Remove(_thing);

        }
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
            cSchool.ProcessDependencies(this);
        }
        public void EngadeInActivity(int activity) //Провести день ТРЕНИРОВКА/ВРЕМЯ/ОТДЫХ
        {
            int[] _Points = cSchool.EngadeInActivity(activity, this); // Рассчитали массив штришков... 
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
                    res += ((n == 0) ? "" : ":") + cSchool.Activity[Practice.Day[n].Activity].Code; 
            }

            return res;
        }
        public string GetThingString() //Получить строковые коды Вещей-Бонусов
        {
            string res = "";

            //foreach(cThing th in Things)
            for (int n = 0; n < Practice.Day.Count; n++)
            {
                res += ((n == 0) ? "" : ":") + Things[n].Code;
            }

            return res;
        }
        public cAngel()
        {
            Things = new List<cThing>();
            Changes = new List<cChangeCharacteristic>();

            _Battle.HasMax  = 
            _Bonus.HasMax   = 
            _Life.HasMax    = 
            _Risk.HasMax    =
            _Science.HasMax =
            _Spirit.HasMax  = true;

            _Force.HasScore    =
            _Physique.HasScore =
            _Agility.HasScore  =
            _Wisdom.HasScore   =
            _Magic.HasScore    = true;

            Practice = new cPractice();
            Practice.DaysOfActivity = 7;

            AddToCharacterList(_Force   ,  0);   
            AddToCharacterList(_Physique,  1);
            AddToCharacterList(_Agility ,  2); 
            AddToCharacterList(_Wisdom  ,  3);  
            AddToCharacterList(_Magic   ,  4);   
            AddToCharacterList(_Luck    ,  5);    
            AddToCharacterList(_Battle  ,  6);  
            AddToCharacterList(_Bonus   ,  7);   
            AddToCharacterList(_Life    ,  8);    
            AddToCharacterList(_Risk    ,  9);    
            AddToCharacterList(_Science , 10);
            AddToCharacterList(_Spirit  , 11); 
        }
        private void AddToCharacterList(cCharacteristic c, int id)
        {
            Character.Add(c);
            c.ID = id;
            c.Code = nameof(c);
            c.onValueChanged += _onValueChanged;
            c.Changes = this.Changes;
        }
        private void _onValueChanged(object sender, eValueEventArgs e)
        {
            e.ID = ((cCharacteristic)sender).ID;
            onValueChanged(this, e);
        }
    }
}


