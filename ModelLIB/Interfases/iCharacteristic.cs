using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLIB.Interfases
{
    public interface iCharacteristic
    {
        int ID { set; get; }
        bool HasMax { set; get; }    // Контролировать Value по максимуму?
        bool HasScore { set; get; } // Рассчитывать Score для характеристики?
        int Value { set; get; }    //Текущее значение характеристики...
        int Max { set; get; }     //Максимальное значение характеристики, "ПОТОЛОК"...
        int Min { set; get; }    //Минимальное значение характеристики...
        int Shift { set; get; } //Изменение характеристики...
        int Bonus { set; get; }// Бонус к характеристике. Постоянная добавка в динамической характеристике...
        int Score { get; }
        int Level { get; }

        event EventHandler<eValueEventArgs> onValueChanged;

        void ShiftValue(int _shift);
        void ShiftMax(int _shift);
        void ShiftBonus(int _shift);
        void ShiftValue();
        void ShiftMax();
        void ShiftBonus();
    }
}
