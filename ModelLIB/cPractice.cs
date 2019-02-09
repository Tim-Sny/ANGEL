using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLIB
{
    public class cPractice
    {
        public List<cDayOfActivity> Day;
        //public Control DaysLeftControl;
        //public Control DaysTotalControl;

        public event EventHandler<eDayOfActivityEventArgs> OnDayChanged;
        eDayOfActivityEventArgs e = new eDayOfActivityEventArgs();

        public cDayOfActivity this[int index] // Индексатор...
        {
            get { return Day[index]; }
            set
            {
                if (index >= Day.Count)
                    Day.Add(value);
                else
                    Day[index] = value;

                e.DaysLeft = DaysLeft;
                e.DaysTotal = DaysOfActivity;

                OnDayChanged(this, e);
                //if (DaysLeftControl is Control) ((Control)DaysLeftControl).Text = DaysLeft.ToString();
            }
        }

        public int DaysOfActivity //Всего дней для активности/обучения
        {
            get { return Day.Capacity; }
            set
            {
                Day.Clear();
                Day.Capacity = value;

                e.DaysLeft = DaysLeft;
                e.DaysTotal = DaysOfActivity;

                if(OnDayChanged != null) OnDayChanged(this, e);
                //if (DaysTotalControl is Control) ((Control)DaysTotalControl).Text = value.ToString();
                //if (DaysLeftControl is Control) ((Control)DaysLeftControl).Text = DaysLeft.ToString();
            }
        }
        public int DayCurrent
        {
            get { return Day.Count; }
        }
        public int DaysLeft
        {
            get { return Day.Capacity - Day.Count; }
        }
        public int OfActivityTotal(int a) //Общий стаж
        {
            return (from p in Day where p.Activity == a select p).Count();
        }
        public int OfActivityContinuous(int a) //Непрерывный стаж
        {
            int res = 0;

            if (DayCurrent > 0)
                for (int i = DayCurrent - 1; i > -1; i--)
                    if (Day[i].Activity == a)
                        res += 1;
                    else
                        break;

            return res;
        }
        public cPractice()
        {
            Day = new List<cDayOfActivity>();
        }
    }
}
