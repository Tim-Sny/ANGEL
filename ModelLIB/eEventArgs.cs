using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLIB
{
    public class eValueEventArgs : EventArgs
    {
        public int ID    { get; set; }
        public int Value { get; set; }
        public int Shift { get; set; }
        public int Score { get; set; }
        public int Max   { get; set; }
    }

    public class eDayOfActivityEventArgs : EventArgs
    {
        public int DaysTotal { get; set; }
        public int DaysLeft  { get; set; }
    }
}
