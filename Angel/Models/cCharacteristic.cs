using Angel.Models;
using System;
using System.Windows.Forms;

namespace Angel
{
    public class cCharacteristic
    {
        private int _value;  //Текущее значение характеристики...
        private int _shift; //Изменение характеристики...
        private int _max;  //Максимальное значение характеристики, "ПОТОЛОК"...
        private int _min; //Минимальное значение характеристики...

        public Control MaxControl;
        public Control ValueControl;
        public Control ScoreControl;

        public bool HasMax { set; get; } // Контролировать Value по максимуму?
        public virtual int Value
        {
            set
            {
                //_shift = value - _value;

                if (HasMax && value > Max) { _value = Max;  }
                else if (value < Min)      { _value = Min;  }
                else                       { _value = value;}

                if (ValueControl is PointsLabel) ((PointsLabel)ValueControl).Points = _value;
                if (ValueControl is PointsLabel) ((PointsLabel)ValueControl).Shift = _shift;
                if (ValueControl is Label) ((Label)ValueControl).Text = _value.ToString();
                if (ScoreControl is Label) ((Label)ScoreControl).Text = cFunc.Sign(fMain.oSchool.GetScoreByPoints(_value));

            }
            get { return _value; }
        }
        public int Max
        {
            set
            {
                _max = value;
                if (MaxControl is PointsLabel) ((PointsLabel)MaxControl).Points = _max + Bonus;
                if (MaxControl is Label) ((Label)MaxControl).Text = (_max + Bonus).ToString();
            }
            get { return _max + Bonus; }
        }
        public int Min { set { _min = value; } get { return _min; } }
        public int Shift
        {
            set
            {
                _shift = value;
                if (ValueControl is PointsLabel) ((PointsLabel)ValueControl).Shift = _shift;
            }
            get
            {
                return _shift;
            }
        }
        public int Bonus { set; get; } // Бонус к характеристике. Постоянная добавка в динамической характеристике...
        //public int ID { set; get; }


        public int Level
        { get { return (int)((Math.Sqrt(1 + 8 * _value) - 1) / 2); } }
        public int Score
        { get { return fMain.oSchool.GetScoreByPoints(_value); } }

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