using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLIB.Interfases
{
    public interface iAngel
    {
        Guid ID { get; set; }               //ID
        string Name { get; set; }          //Имя
        int Sex { get; set; }             //Пол
        cPractice Practice { get; set; } //Стаж 

        List<iCharacteristic> Character { get; set; }
        iCharacteristic _Force { get; set; } //СИЛА
        iCharacteristic _Physique { get; set; } //СЛОЖЕНИЕ
        iCharacteristic _Agility { get; set; } //ЛОВКОСТЬ
        iCharacteristic _Wisdom { get; set; } //УМ
        iCharacteristic _Magic { get; set; } //МАГИЯ
        iCharacteristic _Luck { get; set; } //УДАЧА
        iCharacteristic _Battle { get; set; } //Боевые пункты
        iCharacteristic _Bonus { get; set; } //Свободные штришки
        iCharacteristic _Life { get; set; } //Жизненные Силы
        iCharacteristic _Risk { get; set; } //Очки Риска
        iCharacteristic _Science { get; set; } //Единицы Наук
        iCharacteristic _Spirit { get; set; } //Спирит-Силы

        void SetStartValues(int days, int value); //Установка начальных значений
        void EngadeInActivity(int activity);     //Провести день ТРЕНИРОВКА/ВРЕМЯ/ОТДЫХ
        void SetShift(int _shift);              //Установка начальных значений
        string GetPracticeString();            //Получить строковые коды стажа
    }
}
