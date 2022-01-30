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
        public List<cChangeCharacteristic> Changes { set; get; } = new List<cChangeCharacteristic>();
    }

    public class cChangeCharacteristic
    {
        public Guid ID;
        public int IDCharacter;
        public int Value;
        public int Max; 
    }
}
    