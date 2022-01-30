using ModelLIB;
using ModelLIB.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AngelModel
{
    public class cCharacteristic
    {
        private int _value;  //Текущее значение характеристики...
        private int _shift; //Изменение характеристики...
        private int _max;  //Максимальное значение характеристики, "ПОТОЛОК"...
        private int _min; //Минимальное значение характеристики...

        public int ID { set; get; }
        public string Code { set; get; }
        public bool HasMax   { set; get; } = false;  // Контролировать Value по максимуму?
        public bool HasScore { set; get; } = false; // Рассчитывать Score для характеристики?
        public virtual int Value
        {
            set
            {
                if (HasMax && value > Max) { _value = Max;  }
                else if (value < Min)      { _value = Min;  }
                else                       { _value = value;}
                EventInit();
            }
            get
            {
                int _changes = 0;
                if(Changes.Count > 0)
                {
                    _changes = ((Changes is null) ? 0 : Changes.Where(x => x.IDCharacter == ID).Sum(x => x.Value));
                }
                return _value + _changes;
            }
        }
        public int Max
        {
            set
            {
                _max = value;
                if (Value > Max) Value = Max;
                EventInit();
            }
            get
            {
                int _changes = 0;
                if (Changes.Count > 0)
                {
                    _changes = ((Changes is null) ? 0 : Changes.Where(x => x.IDCharacter == ID).Sum(x => x.Max));
                }
                return _max + _changes;
            }
        }
        public int Min { set { _min = value; } get { return _min; } }
        public int Shift
        {
            set
            {
                _shift = value;
                EventInit();
            }
            get
            {
                return _shift;
            }
        }
        public int Level { get { return (int)((Math.Sqrt(1 + 8 * _value) - 1) / 2); } }
        public int Score { get { return (HasScore) ? cSchool.GetScoreByPoints(_value) : 0; } }
        public List<cChangeCharacteristic> Changes;

        public event EventHandler<eValueEventArgs> onValueChanged;
        eValueEventArgs e = new eValueEventArgs() { ID = -1, Value = 0, Max = 0, Shift = 0, Score = 0 };

        public void ShiftValue(int _shift)
        {
            this._shift = _shift;
            Value += _shift;
        }
        public void ShiftMax(int _shift)
        {
            this._shift = _shift;
            Max += _shift;
        }
        public void ShiftValue()
        {
            Value += _shift;
        }
        public void ShiftMax()
        {
            Max += _shift;
        }
        public void EventInit()
        {
            e.ID    = ID;
            e.Value = Value;
            e.Shift = Shift;
            e.Max   = Max;
            if (HasScore) e.Score = Score;
            if (onValueChanged != null) onValueChanged(this, e);
        }


        public cCharacteristic()
        {
            Changes = new List<cChangeCharacteristic>();
            HasMax = false;
            Min = 0;
        }
    }
}