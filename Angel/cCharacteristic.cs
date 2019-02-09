using ModelLIB;
using ModelLIB.Interfases;
using System;
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
                //_shift = value - _value;

                if (HasMax && value > Max) { _value = Max;  }
                else if (value < Min)      { _value = Min;  }
                else                       { _value = value;}

                e.Value = _value;
                e.Shift = _shift;
                if(HasScore)
                    e.Score = cSchool.GetScoreByPoints(_value);
                e.Max   = _max;
                if(onValueChanged != null) onValueChanged(this, e);

                //if (ValueControl is PointsLabel) ((PointsLabel)ValueControl).Points = _value;
                //if (ValueControl is PointsLabel) ((PointsLabel)ValueControl).Shift = _shift;
                //if (ValueControl is Label) ((Label)ValueControl).Text = _value.ToString();
                //if (ScoreControl is Label) ((Label)ScoreControl).Text = cFunc.Sign(fMain.oSchool.GetScoreByPoints(_value));

            }
            get { return _value; }
        }
        public int Max
        {
            set
            {
                _max = value;

                e.Max = _max + Bonus;
                if (Value > _max) Value = _max;
                if (onValueChanged != null) onValueChanged(this, e);
                //if (MaxControl is PointsLabel) ((PointsLabel)MaxControl).Points = _max + Bonus;
                //if (MaxControl is Label) ((Label)MaxControl).Text = (_max + Bonus).ToString();
            }
            get { return _max + Bonus; }
        }
        public int Min { set { _min = value; } get { return _min; } }
        public int Shift
        {
            set
            {
                _shift = value;
                e.Shift = _shift;
                if (onValueChanged != null) onValueChanged(this, e);
                //if (ValueControl is PointsLabel) ((PointsLabel)ValueControl).Shift = _shift;
            }
            get
            {
                return _shift;
            }
        }
        public int Bonus // Бонус к характеристике. Постоянная добавка в динамической характеристике...
        {
            get;
            set;
        } 
        public int Level { get { return (int)((Math.Sqrt(1 + 8 * _value) - 1) / 2); } }
        public int Score { get { return (HasScore) ? cSchool.GetScoreByPoints(_value) : 0; } }

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
        public void ShiftBonus(int _shift)
        {
            this._shift = _shift;
            Bonus += _shift;
        }
        public void ShiftValue()
        {
            Value += _shift;
        }
        public void ShiftMax()
        {
            Max += _shift;
        }
        public void ShiftBonus()
        {
            Bonus += _shift;
        }

        public cCharacteristic()
        {
            HasMax = false;
            Bonus = 0;
            Min = 0;
        }
    }
}