using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angel
{
    class cSimpleCharacteristic
    {
        private int _value;  //Текущее значение характеристики...
        private int _shift; //Изменение характеристики...
        private int _max;  //Максимальное значение характеристики, "ПОТОЛОК"...
        private int _min; //Минимальное значение характеристики...

        public virtual int Value
        {
            set
            {
                if      (value > Max) { _value = Max; }
                else if (value < Min) { _value = Min; }
                else                  { _value = value; }
            }
            get { return _value; }
        }
        public int Max
        {
            set
            {
                _max = value;
                if (Value > _max) Value = _max;
            }
            get { return _max; }
        }
        public int Min { set { _min = value; } get { return _min; } }
        public int Shift
        {
            set
            {
                _shift = value;
            }
            get
            {
                return _shift;
            }
        }

        //public event EventHandler<eValueEventArgs> onValueChanged;
        //eValueEventArgs e = new eValueEventArgs() { ID = -1, Value = 0, Max = 0, Shift = 0, Score = 0 };

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
    }
}
