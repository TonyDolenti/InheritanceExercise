using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal 
    {
        public Bird()
        {

        }

        public bool CanFly { get; set; }
        public string Color { get; set; }
        public string PredatorOrScavenger { get; set; }
        public int LengthInInches { get; set; }
    }
}
