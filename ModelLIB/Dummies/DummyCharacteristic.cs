using ModelLIB.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLIB.Dummies
{
    class cDummyCharacteristic : iCharacteristic
    {
        public int ID { set; get; } = 0;
        public string Code { set; get; } = "DUMMY";
        public bool HasMax { set; get; } = false;  // Контролировать Value по максимуму?
        public bool HasScore { set; get; } = false; // Рассчитывать Score для характеристики?
        public virtual int Value { set; get; } = 0;
        public int Max { set; get; } = 0;
        public int Min { set; get; } = 0;
        public int Shift { set; get; } = 0;
        public int Bonus { set; get; } = 0; // Бонус к характеристике. Постоянная добавка в динамической характеристике...
        public int Level { set; get; } = 0;
        public int Score { set; get; } = 0;

        public event EventHandler<eValueEventArgs> onValueChanged;
//        eValueEventArgs e = new eValueEventArgs() { ID = -1, Value = 0, Max = 0, Shift = 0, Score = 0 };

        public void ShiftValue(int _shift)
        {
        }
        public void ShiftMax(int _shift)
        {
        }
        public void ShiftBonus(int _shift)
        {
        }
        public void ShiftValue()
        {
        }
        public void ShiftMax()
        {
        }
        public void ShiftBonus()
        {
        }
    }

    
}
