using System;

namespace Angel
{
    public class cCharacteristic
    {
        private int _MIN; //Минимальное значение характеристики...
        private int _NOW; //Текущее значение характеристики...
        private int _MAX; //"Потолок", максимальное значение характеристики..

        public int MIN
        {
            set { _MIN = value; }
            get { return _MIN; }
        }

        public int NOW
        {
            set
            {
                if (value > _MAX)
                {
                    _NOW = _MAX;
                }
                else if (value < _MIN)
                {
                    _NOW = _MIN;
                }
                else
                {
                    _NOW = value;
                }
                //_NOW = (value > _MAX) ? _MAX : value;
                //_NOW = (value < _MIN) ? _MIN : value;
            }
            get { return _NOW; }
        }
        public int MAX
        {
            set { _MAX = value; }
            get { return _MAX; }
        }

        public cCharacteristic()
        {
        }

    }
}