using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelModel
{
    public class cThing
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public List<cShiftCharacteristic> Shift { set; get; } = new List<cShiftCharacteristic>();
    }

    public class cShiftCharacteristic
    {
        public int ID;
        public int Value;
        public int Max; 
    }
}
    