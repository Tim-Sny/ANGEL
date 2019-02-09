using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLIB.Interfaces
{
    public interface iSchool
    {
        int NumberActivity { get;}
        int NumCharacter { get; }
        int NumDay { get; }

        cActivity[] Activity { get; set; }
        int[,] Scores { get; set; }
        int[,] RestEdenBonusPoints { get; set; } //{ FreePoints, to random ch }

        List<cDependence> Dependencies { get; set; } //Характеристика, Уровень (в штришках), Зависимая характеристика, Значение зависимой характеристики...
        List<cSex> Sex { get; set; }
        List<cCharacterInfo> CharacterInfo { get; set; }

        int Load();

        //int[] EngadeInActivity(int activity, cAngel angel); //Рассчёт накидок 
        //int ProcessDependencies(int c, cAngel angel);
        //int ProcessDependencies(cAngel angel);
        int[] EngadeInActivity(int activity, object angel); //Рассчёт накидок 
        int ProcessDependencies(int c, object angel);
        int ProcessDependencies(object angel);
        int RND(int r); //Случайное целое [0..r-1]
        int GetScoreByPoints(int point); //Рассчитать оценку по штришкам
        int GetScoreByPoints(int level, int point); //Рассчитать оценку по уровню и штришкам
        int GetNByPoints(int point); //Рассчитать N (для БП) по штришкам
        int GetNByPoints(int level, int point); //Рассчитать N (для БП) по уровню и штришкам
    }
}
